using Dapper;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeOpenXml;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Models.DTO;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class PatientDoctorsForm : Form
    {
        HospitalSystemContext db;
        private User _loggedUser;
        SqlConnection con;

        public PatientDoctorsForm(User loggedUser)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            _loggedUser = loggedUser;

        }

        private void PatientDoctorsForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
            dgv_patientlist.DataSource = db.Patients
            .Join(db.Appointments,
                  patient => patient.PatientId,
                     appointment => appointment.PatientId,
                  (patient, appointment) => new { patient, appointment })
                     .Join(db.MedicalRecords,
                         pa => pa.appointment.medicalRecordId,
                         medicalRecord => medicalRecord.MedicalId,
                         (pa, medicalRecord) => new { pa.patient, pa.appointment, medicalRecord })
                     .Where(result => result.appointment.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId)
                     .Select(result => new
                     {
                         DoctorDetailsId = result.appointment.DoctorDetailsId,
                         PatientId = result.patient.PatientId,
                         FullName = result.patient.FirstName + " " + result.patient.LastName
                     })
                     .Distinct().ToList();
            dgv_patientlist.Columns["DoctorDetailsId"].Visible = false;
            dgv_patientlist.Columns["PatientId"].Visible = false;
            btn_updatemedicalhistory.Hide();
            cb_searchitem.Items.AddRange(new string[] { "Full Name", "Email", "Phone Number" });
            cb_searchitem.SelectedIndex = 0;
            search_bar.Text += search_bar.Text;
        }
        int idOfDoctor;
        int idOfPatient;

        private void dgv_patientlist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }
                var selectedRow = dgv_patientlist.Rows[e.RowIndex];
                if (selectedRow == null ||
                    selectedRow.Cells["DoctorDetailsId"].Value == null ||
                    selectedRow.Cells["PatientId"].Value == null)
                {
                    MessageBox.Show("Please select a valid patient.", "Selection Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                idOfDoctor = Convert.ToInt32(selectedRow.Cells["DoctorDetailsId"].Value);
                idOfPatient = Convert.ToInt32(selectedRow.Cells["PatientId"].Value);
                var patient = con.QueryFirstOrDefault<PatientQRData>(@"
            SELECT P.FirstName, P.LastName, P.DateOfBirth, P.Gender, P.MedicalHistory,
                   M.Diaqnois, M.LabResult, M.Prescription, M.TreatmentDetails
            FROM Appointments A 
            INNER JOIN Patients P ON A.PatientId = P.PatientId
            INNER JOIN MedicalRecords M ON A.medicalRecordId = M.MedicalId
            WHERE A.DoctorDetailsId = @DoctorId AND P.PatientId = @PatientId",
                    new { DoctorId = idOfDoctor, PatientId = idOfPatient });

                if (patient == null)
                {
                    MessageBox.Show("Patient data not found.", "Data Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtNamePatient.Text = $"{patient.FirstName} {patient.LastName}";
                txtDateOfBirth.Text = patient.DateOfBirth?.ToString("yyyy-MM-dd") ?? "N/A";
                txtGender.Text = patient.Gender ?? "N/A";
                txtMerdicalHistory.Text = patient.MedicalHistory ?? "N/A";
                txtDiaqnois.Text = patient.Diaqnois ?? "N/A";
                txtPrescription.Text = patient.Prescription ?? "N/A";
                txtLabResult.Text = patient.LabResult ?? "N/A";
                txtTreatmentDetails.Text = patient.TreatmentDetails ?? "N/A";
                GenerateQRCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerateQRCode()
        {
            try
            {
                if (idOfPatient == 0 || idOfDoctor == 0)
                {
                    MessageBox.Show("No patient selected for QR generation.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var patient = con.QueryFirstOrDefault<PatientQRData>(@"
            SELECT P.FirstName, P.LastName, P.DateOfBirth, P.Gender, P.MedicalHistory,
                   M.Diaqnois, M.LabResult, M.Prescription, M.TreatmentDetails
            FROM Appointments A 
            INNER JOIN Patients P ON A.PatientId = P.PatientId
            INNER JOIN MedicalRecords M ON A.medicalRecordId = M.MedicalId
            WHERE A.DoctorDetailsId = @DoctorId AND P.PatientId = @PatientId",
                    new { DoctorId = idOfDoctor, PatientId = idOfPatient });

                if (patient == null) return;

                string patientData = $"Patient Information\n" +
                                   $"Name: {patient.FirstName} {patient.LastName}\n" +
                                   $"DOB: {patient.DateOfBirth:yyyy-MM-dd}\n" +
                                   $"Gender: {patient.Gender}\n" +
                                   $"Diagnosis: {patient.Diaqnois}\n" +
                                   $"Prescription: {patient.Prescription}\n" +
                                   $"Lab Results: {patient.LabResult}\n" +
                                   $"Treatment: {patient.TreatmentDetails}";

                using (var qrGenerator = new QRCodeGenerator())
                {
                    var qrCodeData = qrGenerator.CreateQrCode(patientData, QRCodeGenerator.ECCLevel.Q);
                    using (var qrCode = new QRCode(qrCodeData))
                    {
                        var qrImage = qrCode.GetGraphic(20);
                        pictureBox.Image = new Bitmap(qrImage);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Tag = patientData;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"QR Generation Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_updatemedicalhistory_Click(object sender, EventArgs e)
        {
            try
            {
                if (idOfPatient == 0)
                {
                    MessageBox.Show("No patient selected. Please select a patient first.",
                                  "Selection Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMerdicalHistory.Text))
                {
                    MessageBox.Show("Medical history cannot be empty.",
                                  "Validation Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }
                var patient = db.Patients.FirstOrDefault(p => p.PatientId == idOfPatient);
                if (patient != null)
                {
                    patient.MedicalHistory = txtMerdicalHistory.Text;
                    db.SaveChanges();

                    MessageBox.Show("Medical history updated successfully!",
                                  "Success",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);

                    if (dgv_patientlist.SelectedRows.Count > 0)
                    {
                        dgv_patientlist_CellDoubleClick(null,
                            new DataGridViewCellEventArgs(0, dgv_patientlist.SelectedRows[0].Index));
                    }
                }
                else
                {
                    MessageBox.Show("Patient not found in database.",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating medical history: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            finally
            {
                btn_updatemedicalhistory.Hide();
                txtMerdicalHistory.ReadOnly = true;
                btnShowQrCode.Visible = true;
            }
        }

        private void txtMerdicalHistory_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamePatient.Text) || idOfPatient == 0)
            {
                MessageBox.Show("Please select a patient first by double-clicking on patient name",
                              "No Patient Selected",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            txtMerdicalHistory.ReadOnly = false;
            btn_updatemedicalhistory.Show();
            pictureBox.Hide();
        }

        private void btn_word_Click(object sender, EventArgs e)
        {
            if (pictureBox.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }
            string patientData = pictureBox.Tag.ToString();
            SaveToWordWithDocX(patientData);
        }
        public void SaveToWordWithDocX(string data)
        {
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PatientReport.docx");
                using (var doc = DocX.Create(filePath))
                {
                    var header = doc.InsertParagraph("Monufia General Hospital")
                        .Font("Arial")
                        .FontSize(16)
                        .Bold();
                    header.Alignment = Alignment.center;
                    doc.InsertParagraph("Patient Medical Report")
                        .Font("Arial")
                        .FontSize(16)
                        .Bold()
                        .Alignment = Alignment.center;
                    doc.InsertParagraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd")}")
                        .Font("Arial")
                        .FontSize(12)
                        .Alignment = Alignment.center;

                    doc.InsertParagraph("---------------------------------------------------")
                        .Font("Arial")
                        .FontSize(12)

                        .Alignment = Alignment.center;

                    string[] lines = data.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string line in lines)
                    {
                        string[] keyValue = line.Split(new[] { ':' }, 2);
                        if (keyValue.Length == 2)
                        {
                            var p = doc.InsertParagraph();
                            p.Append(keyValue[0].Trim() + ": ").Bold();
                            p.Append(keyValue[1].Trim());
                        }
                    }

                    doc.InsertParagraph("---------------------------------------------------")
                        .Font("Arial")
                        .FontSize(12)
                        .Alignment = Alignment.center;
                    doc.InsertParagraph("Doctor's Signature: ___ ")
                        .Font("Arial")
                        .FontSize(12);
                    doc.Save();
                }
                MessageBox.Show($"Report saved successfully: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Word: " + ex.Message);
            }

        }


        public void SaveToExcel(string data)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Patient Data");

                string[] lines = data.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] keyValue = lines[i].Split(new[] { ':' }, 2);
                    worksheet.Cells[i + 1, 1].Value = keyValue[0].Trim();
                    worksheet.Cells[i + 1, 2].Value = keyValue.Length > 1 ? keyValue[1].Trim() : "";
                }

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PatientData.xlsx");
                package.SaveAs(new FileInfo(filePath));

                MessageBox.Show($"Data saved to Excel file: {filePath}");
            }

        }

        private void btn_Qr_Click(object sender, EventArgs e)
        {
            if (pictureTwo.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }

            string patientData = pictureTwo.Tag.ToString();

            SaveToExcel(patientData);
        }

        private void search_bar_TextChanged(object sender, EventArgs e)
        {
            string searchItem = search_bar.Text.Trim();
            string searchCriteria = cb_searchitem.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(searchItem))
            {
                dgv_resultofsearch.DataSource = null;
                return;
            }

            try
            {
                var baseQuery = db.Patients
    .Join(db.Appointments,
        patient => patient.PatientId,
        appointment => appointment.PatientId,
        (patient, appointment) => new { patient, appointment })
    .Join(db.MedicalRecords,
        pa => pa.appointment.medicalRecordId,
        medicalRecord => medicalRecord.MedicalId,
        (pa, medicalRecord) => new { pa.patient, pa.appointment, medicalRecord })
    .Where(result => result.appointment.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId)
    .Select(result => new
    {
        Patient = result.patient,
        MedicalRecord = result.medicalRecord
    });
                switch (searchCriteria)
                {
                    case "Full Name":
                        baseQuery = baseQuery.Where(result =>
                            (result.Patient.FirstName + " " + result.Patient.LastName).Contains(searchItem));
                        break;
                    case "Email":
                        baseQuery = baseQuery.Where(result =>
                            result.Patient.Email.Contains(searchItem));
                        break;
                    case "Phone Number":
                        baseQuery = baseQuery.Where(result =>
                            result.Patient.PhoneNumber.Contains(searchItem));
                        break;
                }


                var result = baseQuery
                    .Select(result => new
                    {
                        result.Patient.PatientId,
                        FullName = result.Patient.FirstName + " " + result.Patient.LastName,
                        result.Patient.Email,
                        result.Patient.PhoneNumber,
                        result.Patient.DateOfBirth,
                        result.Patient.Gender,
                        result.Patient.Address,
                        result.Patient.MedicalHistory
                    })
                    .Distinct()
                    .ToList();

                dgv_resultofsearch.DataSource = result;
                dgv_resultofsearch.Columns["PatientId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void GenerateAndDisplayQRCode(string data)
        {
            try
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);

                Bitmap qrCodeImage = qRCode.GetGraphic(20, System.Drawing.Color.Black, System.Drawing.Color.White, true);
                pictureTwo.Image = qrCodeImage;
                pictureTwo.SizeMode = PictureBoxSizeMode.Zoom;
                pictureTwo.Tag = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}");
            }
        }

        private void btn_ExportWord_Click(object sender, EventArgs e)
        {
            if (pictureTwo.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }
            string patientData = pictureTwo.Tag.ToString();
            SaveToWordWithDocX(patientData);
        }
        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            if (pictureTwo.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }
            string patientData = pictureTwo.Tag.ToString();
            SaveToExcel(patientData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_updatemedicalhistory.Visible = false;
            pictureBox.Visible = true;
        }
        int idOfResarchOfPatient;
        private void dgv_resultofsearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (pictureTwo.Image != null)
            {
                pictureTwo.Image.Dispose();
                pictureTwo.Image = null;
            }

            idOfResarchOfPatient = (int)dgv_resultofsearch.Rows[e.RowIndex].Cells["PatientId"].Value;

            try
            {
                var query = con.Query(@"SELECT P.FirstName, P.LastName, P.DateOfBirth, P.Gender, P.MedicalHistory, 
                                       M.Diaqnois, M.LabResult, M.Prescription, M.TreatmentDetails
                                FROM Appointments A 
                                INNER JOIN Patients P ON A.PatientId = P.PatientId
                                INNER JOIN MedicalRecords M ON A.medicalRecordId = M.MedicalId
                                WHERE A.DoctorDetailsId = @DoctorId 
                                  AND P.PatientId = @patientId",
                                        new { DoctorId = _loggedUser.doctorDetails.DoctorDetailsId, patientId = idOfResarchOfPatient })
                                .ToList();

                if (query == null || !query.Any())
                {
                    MessageBox.Show("No patient data found.");
                    return;
                }

                var patient = query.FirstOrDefault();
                string patientData = $"Patient Info\n" +
                    $"Full Name: {patient.FirstName} {patient.LastName}\n" +
                    $"Date Of Birth: {patient.DateOfBirth?.ToString("yyyy-MM-dd")}\n" +
                    $"Gender: {patient.Gender}\n" +
                    $"Medical History: {patient.MedicalHistory}\n" +
                    $"Diagnosis: {patient.Diaqnois}\n" +
                    $"Prescription: {patient.Prescription}\n" +
                    $"Lab Result: {patient.LabResult}\n" +
                    $"Treatment Details: {patient.TreatmentDetails}\n";

                GenerateAndDisplayQRCode(patientData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public void Reload()
        {
            try
            {
                txtMerdicalHistory.Clear();
                search_bar.Clear();
                txtPrescription.Clear();
                txtDiaqnois.Clear();
                txtTreatmentDetails.Clear();
                txtLabResult.Clear();
                txtGender.Clear();
                txtDateOfBirth.Clear();

                txtNamePatient.Text = "";
                cb_searchitem.SelectedIndex = 0;
                dgv_patientlist.DataSource = db.Patients
                    .Join(db.Appointments,
                        patient => patient.PatientId,
                        appointment => appointment.PatientId,
                        (patient, appointment) => new { patient, appointment })
                    .Join(db.MedicalRecords,
                        pa => pa.appointment.medicalRecordId,
                        medicalRecord => medicalRecord.MedicalId,
                        (pa, medicalRecord) => new { pa.patient, pa.appointment, medicalRecord })
                    .Where(result => result.appointment.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId)
                    .Select(result => new
                    {
                        DoctorDetailsId = result.appointment.DoctorDetailsId,
                        PatientId = result.patient.PatientId,
                        FullName = result.patient.FirstName + " " + result.patient.LastName
                    })
                    .Distinct()
                    .ToList();
                dgv_resultofsearch.DataSource = null;
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }
                if (pictureTwo.Image != null)
                {
                    pictureTwo.Image.Dispose();
                    pictureTwo.Image = null;
                }
                btn_updatemedicalhistory.Hide();
                txtMerdicalHistory.ReadOnly = true;
                btnShowQrCode.Visible = true;
                pictureBox.Visible = true;
                idOfPatient = 0;
                idOfDoctor = 0;
                idOfResarchOfPatient = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reloading form: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
