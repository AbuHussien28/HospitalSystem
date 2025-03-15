using System.Configuration;
using Dapper;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using ProjectHospitalSystem.Models;
using QRCoder;
//using Xceed.Document.NET;
//using Xceed.Words.NET;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class DoctorUser : Form
    {
        HospitalSystemContext db;
        private User _loggedUser;
        SqlConnection con;
        public DoctorUser(User loggedUser)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            _loggedUser = loggedUser;
        }

        private void DoctorUser_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
            loadDataOfHomePage();
            panel_profile.Hide();
            panel_medicalrecord.Hide();
            panel_patient.Hide();
            panel_appointment.Hide();

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_HomePage.Show();
            panel_profile.Hide();
            panel_medicalrecord.Hide();
            panel_patient.Hide();
            panel_appointment.Hide();

            loadDataOfHomePage();
        }

        public void loadDataOfHomePage()
        {
            var query = db.Users.Where(n => n.doctorDetails.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId).Select(n => new { FullName = n.FName + " " + n.LName });
            label36.Text = query.FirstOrDefault().FullName;

            dgv_patientListHome.DataSource = db.Patients.Where(n => n.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId).Select(n => new { n.PatientId, FullName = n.FirstName + " " + n.LastName }).ToList();
            dgv_patientListHome.Columns["PatientId"].Visible = false;

            var dt = new System.Data.DataTable();
            dt.Columns.Add("AppointmentId", typeof(int));
            dt.Columns.Add("Appointment Time", typeof(DateTime));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Note", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));



            var results = con.Query(

                  @"SELECT A.AppointmentId, A.AppointmentDateTime, A.Status, A.Note, P.FirstName, P.LastName 
          FROM Appointments A 
          INNER JOIN Patients P ON A.PatientId = P.PatientId 
          WHERE A.DoctorDetailsId = @doctorId 
            AND CAST(A.AppointmentDateTime AS DATE) = CAST(GETDATE() AS DATE) -- Filter for today's date
            AND A.Status = @status
          ORDER BY A.AppointmentDateTime ASC",

                  new
                  {
                      doctorId = _loggedUser.DoctorDetailsId,
                      status = 0
                  }
              );

                @"SELECT A.AppointmentId, A.AppointmentDateTime,  
                CASE  WHEN A.Status = 0 THEN 'Upcoming'
                        WHEN A.Status = 1 THEN 'Cancel'         
                        WHEN A.Status = 2 THEN 'Done'            
                        ELSE 'Unknown'   
                    END AS Status, A.Note, P.FirstName, P.LastName " +
                "FROM Appointments A " +
                "INNER JOIN Patients P ON A.PatientId = P.PatientId " +
                "WHERE A.DoctorDetailsId = @doctorId " +
                "AND A.AppointmentDateTime > @currentDateTime " +
                "AND A.Status = @status",
                new
                {
                    doctorId = _loggedUser.doctorDetails.DoctorDetailsId,
                    currentDateTime = DateTime.Now,
                    status = AppointmentStatus.Upcoming
                }
            );



            foreach (var row in results)
            {
                string statusName = Enum.GetName(typeof(AppointmentStatus), row.Status) ?? "Unknown";
                dt.Rows.Add(row.AppointmentId, row.AppointmentDateTime, statusName, row.Note, row.FirstName, row.LastName);
            }


            dgv_upcommingAppointmentHomePage.DataSource = dt;
            dgv_upcommingAppointmentHomePage.Columns["AppointmentId"].Visible = false;
        }

        // Start  Profile Form

        private void btn_profile_Click(object sender, EventArgs e)
        {
            panel_HomePage.Hide();
            panel_profile.Show();
            panel_medicalrecord.Hide();
            panel_patient.Hide();
            panel_appointment.Hide();

            var query = con.Query("select U.FName,U.LName,Dr.Specialization,U.Email\r\nfrom Users U Inner Join Doctors Dr\r\non U.UserId = Dr.UserId\r\nwhere Dr.DoctorDetailsId = @DoctorId", new { DoctorId = _loggedUser.doctorDetails.DoctorDetailsId }).ToList();

            txt_firstName.Text = query.FirstOrDefault()?.FName;
            txt_lastName.Text = query.FirstOrDefault()?.LName;
            txt_email.Text = query.FirstOrDefault()?.Email;
            txt_specializtion.Text = query.FirstOrDefault()?.Specialization;

            btn_updateProfile.Hide();


        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            txt_firstName.ReadOnly = false;
            txt_lastName.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_specializtion.ReadOnly = false;
            btn_updateProfile.Show();
            btn_editProfile.Hide();
        }

        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            btn_updateProfile.Enabled = false;
            btn_editProfile.Show();

            txt_firstName.ReadOnly = true;
            txt_lastName.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_specializtion.ReadOnly = true;

            try
            {
                using (var context = new HospitalSystemContext())
                {

                    var doctor = context.Doctors
                        .Include(d => d.User)
                        .FirstOrDefault(d => d.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId);

                    if (doctor == null)
                    {
                        MessageBox.Show("Error: Doctor not found!");
                        return;
                    }

                    var user = doctor.User;

                    if (txt_firstName.Text == user.FName &&
                        txt_lastName.Text == user.LName &&
                        txt_specializtion.Text == doctor.Specialization &&
                        txt_email.Text == user.Email)
                    {
                        MessageBox.Show("Edit at least one field!");
                        return;
                    }

                    using (var transaction = context.Database.BeginTransaction())
                    {
                        bool isUpdated = false;

                        if (txt_email.Text != user.Email || txt_specializtion.Text != doctor.Specialization)
                        {
                            user.Email = txt_email.Text;
                            doctor.Specialization = txt_specializtion.Text;
                            isUpdated = true;
                        }

                        if (txt_firstName.Text != user.FName || txt_lastName.Text != user.LName)
                        {
                            user.FName = txt_firstName.Text;
                            user.LName = txt_lastName.Text;
                            isUpdated = true;
                        }

                        if (isUpdated)
                        {
                            context.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("User and Doctor information updated successfully!");
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("No record was updated. Please check the provided IDs.");
                        }
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database Update Error: {dbEx.InnerException?.Message ?? dbEx.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException invEx)
            {
                MessageBox.Show($"Operation Error: {invEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btn_updateProfile.Enabled = true;
            }
        }

        // End Profile Form

        // Start Medical Record

        //private void btn_medicalrecord_Click(object sender, EventArgs e)
        //{
        //    panel_HomePage.Hide();
        //    panel_profile.Hide();
        //    panel_medicalrecord.Show();
        //    panel_patient.Hide();
        //    panel_appointment.Hide();

        //    try
        //    {
        //        getData();
        //        btn_update.Hide();
        //        btn_delete.Hide();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error during form load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}


        //public void getData()
        //{
        //    try
        //    {
        //        dgv_medicalrecord.DataSource = db.MedicalRecords
        //            .Where(n => n.DoctorDetailsId == _loggedUser.DoctorDetailsId)
        //            .Select(n => new { n.MedicalId, n.DateOfVist, n.Diaqnois, n.Prescription, n.LabResult, n.TreatmentDetails, n.PatientId, n.DoctorDetailsId })
        //            .ToList();

        //        cb_patient.DataSource = db.Patients.Select(n => n).ToList();
        //        cb_patient.ValueMember = "PatientId";
        //        cb_patient.DisplayMember = "FirstName";

        //        txt_dateOfVisit.Text = txt_diaqnois.Text = txt_labResult.Text = txt_prescription.Text = txt_treatment.Text = "";
        //        cb_patient.SelectedIndex = 0;
        //        dgv_medicalrecord.Columns["MedicalId"].Visible = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btn_add_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        MedicalRecord m = new MedicalRecord
        //        {
        //            DateOfVist = DateTime.Parse(txt_dateOfVisit.Text),
        //            Diaqnois = txt_diaqnois.Text,
        //            Prescription = txt_prescription.Text,
        //            LabResult = txt_labResult.Text,
        //            TreatmentDetails = txt_treatment.Text,
        //            PatientId = (int)cb_patient.SelectedValue,
        //            DoctorDetailsId = (int)_loggedUser.DoctorDetailsId
        //        };

        //        db.MedicalRecords.Add(m);
        //        db.SaveChanges();
        //        getData();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error adding medical record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void btn_medicalrecord_Click(object sender, EventArgs e)
        {
            panel_HomePage.Hide();
            panel_profile.Hide();
            panel_medicalrecord.Show();
            panel_patient.Hide();
            panel_appointment.Hide();

            try
            {
                getData();
                btn_update.Hide();
                btn_delete.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during form load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public void getData()
        {
            try
            {
                dgv_medicalrecord.DataSource = db.MedicalRecords
                    .Where(n => n.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId)
                    .Select(n => new { n.MedicalId, n.DateOfVist, n.Diaqnois, n.Prescription, n.LabResult, n.TreatmentDetails, n.PatientId, n.DoctorDetailsId })
                    .ToList();

                cb_patient.DataSource = db.Patients.Select(n => n).ToList();
                cb_patient.ValueMember = "PatientId";
                cb_patient.DisplayMember = "FirstName";

                txt_dateOfVisit.Text = txt_diaqnois.Text = txt_labResult.Text = txt_prescription.Text = txt_treatment.Text = "";
                cb_patient.SelectedIndex = 0;
                dgv_medicalrecord.Columns["MedicalId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                MedicalRecord m = new MedicalRecord
                {
                    DateOfVist = DateTime.Parse(txt_dateOfVisit.Text),
                    Diaqnois = txt_diaqnois.Text,
                    Prescription = txt_prescription.Text,
                    LabResult = txt_labResult.Text,
                    TreatmentDetails = txt_treatment.Text,
                    PatientId = (int)cb_patient.SelectedValue,
                    DoctorDetailsId = (int)_loggedUser.doctorDetails.DoctorDetailsId
                };

                db.MedicalRecords.Add(m);
                db.SaveChanges();
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding medical record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        int id;

        //private void dgv_medicalrecord_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    try
        //    {
        //        id = (int)dgv_medicalrecord.SelectedRows[0].Cells[0].Value;

        //        var m = db.MedicalRecords.FirstOrDefault(n => n.MedicalId == id);
        //        if (m != null)
        //        {
        //            txt_treatment.Text = m.TreatmentDetails;
        //            txt_prescription.Text = m.Prescription;
        //            txt_labResult.Text = m.LabResult;
        //            txt_diaqnois.Text = m.Diaqnois;
        //            txt_dateOfVisit.Text = m.DateOfVist.ToString("yyyy-MM-dd HH:mm");
        //            //cb_patient.SelectedValue = m.PatientId;

        //            btn_update.Show();
        //            btn_delete.Show();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading medical record details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btn_update_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var m = db.MedicalRecords.FirstOrDefault(n => n.MedicalId == id);
        //        if (m != null)
        //        {
        //            m.TreatmentDetails = txt_treatment.Text;
        //            m.Prescription = txt_prescription.Text;
        //            m.LabResult = txt_labResult.Text;
        //            m.Diaqnois = txt_diaqnois.Text;

        //            if (DateTime.TryParse(txt_dateOfVisit.Text, out DateTime visitDate))
        //            {
        //                m.DateOfVist = visitDate;
        //            }
        //            else
        //            {
        //                MessageBox.Show("Invalid date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            m.PatientId = (int)cb_patient.SelectedValue;

        //            db.SaveChanges();
        //            MessageBox.Show("Data has been successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            getData();

        //            btn_update.Hide();
        //            btn_delete.Hide();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error updating medical record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btn_delete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var m = db.MedicalRecords.FirstOrDefault(n => n.MedicalId == id);
        //        if (m != null && MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            db.MedicalRecords.Remove(m);
        //            db.SaveChanges();
        //            getData();

        //            btn_delete.Hide();
        //            btn_update.Hide();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error deleting medical record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        // End Medical Record
        /*---------------------------------------------------------------------------*/
        // Start Patient Form
        private void btn_patient_Click(object sender, EventArgs e)
        {
            panel_HomePage.Hide();
            panel_profile.Hide();
            panel_medicalrecord.Hide();
            panel_patient.Show();
            panel_appointment.Hide();

            dgv_patientlist.DataSource = db.Patients.Join(db.Appointments, patient => patient.PatientId, appointment => appointment.PatientId, (patient, appointment) => new { patient, appointment })
                .Join(db.MedicalRecords, pa => pa.appointment.medicalRecordId, medicalRecord => medicalRecord.MedicalId, (pa, medicalRecord) => new { pa.patient, medicalRecord })
                .Where(result => result.patient.DoctorDetailsId == _loggedUser.DoctorDetailsId)
                .Select(result => new { result.patient.DoctorDetailsId, result.patient.PatientId, FullName = result.patient.FirstName + " " + result.patient.LastName })
                .Distinct()
                .ToList();


            dgv_patientlist.Columns["DoctorDetailsId"].Visible = false;

            dgv_patientlist.DataSource = db.Patients.Where(n => n.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId).Select(n => new { n.PatientId, FullName = n.FirstName + " " + n.LastName }).ToList();

            dgv_patientlist.Columns["PatientId"].Visible = false;

            btn_updatemedicalhistory.Hide();
            cb_searchitem.Items.AddRange(new string[] { "Full Name", "Email", "Phone Number" });
            cb_searchitem.SelectedIndex = 0;
            search_bar.Text += search_bar.Text;

        }

        int idOfDoctor;
        int idOfPatient;
        private void dgv_patientlist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }

            idOfDoctor = (int)dgv_patientlist.SelectedRows[0].Cells[0].Value;
            idOfPatient = (int)dgv_patientlist.SelectedRows[0].Cells[1].Value;


            var query = con.Query(@"       select P.FirstName , P.LastName, P.DateOfBirth , P.Gender , P.MedicalHistory , M.Diaqnois , M.LabResult , M.Prescription , M.TreatmentDetails
from Appointments A Inner Join Patients P
on A.PatientId = P.PatientId
Inner Join MedicalRecords M
on A.medicalRecordId = M.MedicalId
Where P.DoctorDetailsId = @DoctorId And P.PatientId = @patientId", new { DoctorId = idOfDoctor, patientId = idOfPatient }).ToList();


            if (query != null && query.Any())
            {
                txtDateOfBirth.Text = query.FirstOrDefault()?.DateOfBirth?.ToString("yyyy-MM-dd");
                txtGender.Text = query.FirstOrDefault().Gender;
                txtMerdicalHistory.Text = query.FirstOrDefault()?.MedicalHistory;
                txtDiaqnois.Text = query.FirstOrDefault()?.Diaqnois;
                txtPrescription.Text = query.FirstOrDefault()?.Prescription;
                txtLabResult.Text = query.FirstOrDefault()?.LabResult;
                txtTreatmentDetails.Text = query.FirstOrDefault()?.TreatmentDetails;

            }

            var patientName = db.Patients.Select(n => new { FullName = n.FirstName + " " + n.LastName });
            txtNamePatient.Text = patientName?.FirstOrDefault()?.FullName;

            GenerateQRCode();

        }

        private void GenerateQRCode()
        {
            if (dgv_patientlist.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Selecet a Patient");
                return;
            }

            try
            {
                var query = con.Query(@"select P.FirstName , P.LastName, P.DateOfBirth , P.Gender , P.MedicalHistory , M.Diaqnois , M.LabResult , M.Prescription , M.TreatmentDetails
from Appointments A Inner Join Patients P
on A.PatientId = P.PatientId
Inner Join MedicalRecords M
on A.medicalRecordId = M.MedicalId
Where P.DoctorDetailsId = @DoctorId And P.PatientId = @patientId", new { DoctorId = idOfDoctor, patientId = idOfPatient }).ToList();


                string patientData = $"Patient Info\n" +
                    $"FirstName: {query.FirstOrDefault().FirstName}\n" +
                    $"LastName: {query.FirstOrDefault().LastName}\n" +
                    $"DateOfBirth: {query.FirstOrDefault()?.DateOfBirth?.ToString("yyyy-MM-dd")}\n" +
                    $"Gender: {query.FirstOrDefault()?.Gender}\n" +
                    $"MedicalHistory: {query.FirstOrDefault()?.MedicalHistory}\n" +
                    $"Diagnosis: {query.FirstOrDefault()?.Diaqnois}\n" +
                    $"Prescription: {query.FirstOrDefault()?.Prescription}\n" +
                    $"LabResult: {query.FirstOrDefault()?.LabResult}\n" +
                    $"TreatmentDetails: {query.FirstOrDefault()?.TreatmentDetails}\n";

                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(patientData, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);

                Bitmap qrCodeImage = qRCode.GetGraphic(20, System.Drawing.Color.Black, System.Drawing.Color.White, true);
                pictureBox.Image = qrCodeImage;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                pictureBox.Tag = patientData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        private void btn_updatemedicalhistory_Click(object sender, EventArgs e)
        {

            if (dgv_patientlist.SelectedRows.Count > 0)
            {
                try
                {
                    idOfDoctor = (int)dgv_patientlist.SelectedRows[0].Cells[0].Value;
                    idOfPatient = (int)dgv_patientlist.SelectedRows[0].Cells[1].Value;


                    var patient = db.Patients.FirstOrDefault(n => n.PatientId == idOfPatient && n.DoctorDetailsId == idOfDoctor);

                    if (patient != null)
                    {

                        patient.MedicalHistory = txtMerdicalHistory.Text;


                        db.SaveChanges();

                        MessageBox.Show("Medical history updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Patient not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btn_updatemedicalhistory.Hide();
                txtMerdicalHistory.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Please select a patient from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMerdicalHistory_DoubleClick(object sender, EventArgs e)
        {
            txtMerdicalHistory.ReadOnly = false;
            btn_updatemedicalhistory.Show();
            pictureBox.Hide();
            btn_Qr.Hide();
        }

        private void btn_word_Click(object sender, EventArgs e)
        {
            if (pictureBox.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }

            string patientData = pictureBox.Tag.ToString();
            //SaveToWordWithDocX(patientData);
        }

        //public void SaveToWordWithDocX(string data)
        //{
        //    try
        //    {

        //        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PatientReport.docx");

        //        using (var doc = DocX.Create(filePath))
        //        {

        //            var header = doc.InsertParagraph("Monufia General Hospital")
        //                .Font("Arial")
        //                .FontSize(16)
        //                .Bold();
        //            header.Alignment = Alignment.center;
        //            doc.InsertParagraph("Patient Medical Report")
        //                .Font("Arial")
        //                .FontSize(16)
        //                .Bold()
        //                .Alignment = Alignment.center;
        //            doc.InsertParagraph($"Date: {DateTime.Now.ToString("yyyy-MM-dd")}")
        //                .Font("Arial")
        //                .FontSize(12)
        //                .Alignment = Alignment.center;

        //            doc.InsertParagraph("---------------------------------------------------")
        //                .Font("Arial")
        //                .FontSize(12)

        //                .Alignment = Alignment.center;

        //            string[] lines = data.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        //            foreach (string line in lines)
        //            {
        //                string[] keyValue = line.Split(new[] { ':' }, 2);
        //                if (keyValue.Length == 2)
        //                {
        //                    var p = doc.InsertParagraph();
        //                    p.Append(keyValue[0].Trim() + ": ").Bold();
        //                    p.Append(keyValue[1].Trim());
        //                }
        //            }

        //            doc.InsertParagraph("---------------------------------------------------")
        //                .Font("Arial")
        //                .FontSize(12)
        //                .Alignment = Alignment.center;
        //            doc.InsertParagraph("Doctor's Signature: ___ ")
        //                .Font("Arial")
        //                .FontSize(12);
        //            doc.Save();
        //        }
        //        MessageBox.Show($"Report saved successfully: {filePath}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error exporting to Word: " + ex.Message);
        //    }

        //}

        private void btn_Qr_Click(object sender, EventArgs e)
        {
            if (pictureBox.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }

            string patientData = pictureBox.Tag.ToString();

            //SaveToExcel(patientData);

        }

        //public void SaveToExcel(string data)
        //{
        //    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        //    using (var package = new ExcelPackage())
        //    {
        //        var worksheet = package.Workbook.Worksheets.Add("Patient Data");

        //        string[] lines = data.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

        //        for (int i = 0; i < lines.Length; i++)
        //        {
        //            string[] keyValue = lines[i].Split(new[] { ':' }, 2);
        //            worksheet.Cells[i + 1, 1].Value = keyValue[0].Trim();
        //            worksheet.Cells[i + 1, 2].Value = keyValue.Length > 1 ? keyValue[1].Trim() : "";
        //        }

        //        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PatientData.xlsx");
        //        package.SaveAs(new FileInfo(filePath));

        //        MessageBox.Show($"Data saved to Excel file: {filePath}");
        //    }

        //}

        private void labelScan_Click(object sender, EventArgs e)
        {
            pictureBox.Show();
            btn_Qr.Show();
        }



        private void search_bar_TextChanged_1(object sender, EventArgs e)
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
                        (pa, medicalRecord) => new { pa.patient, medicalRecord })
                    .Where(result => result.patient.DoctorDetailsId == _loggedUser.DoctorDetailsId);

                IQueryable<Patient> query = db.Patients.AsQueryable().Where(n => n.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId); ;


                switch (searchCriteria)
                {
                    case "Full Name":
                        baseQuery = baseQuery.Where(result =>
                            (result.patient.FirstName + " " + result.patient.LastName).Contains(searchItem));
                        break;
                    case "Email":
                        baseQuery = baseQuery.Where(result =>
                            result.patient.Email.Contains(searchItem));
                        break;
                    case "Phone Number":
                        baseQuery = baseQuery.Where(result =>
                            result.patient.PhoneNumber.Contains(searchItem));
                        break;
                }


                var result = baseQuery
                    .Select(result => new
                    {
                        result.patient.PatientId,
                        FullName = result.patient.FirstName + " " + result.patient.LastName,
                        result.patient.Email,
                        result.patient.PhoneNumber,
                        result.patient.DateOfBirth,
                        result.patient.Gender,
                        result.patient.Address,
                        result.patient.MedicalHistory
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
        int idOfResarchOfDoctorId;
        int idOfResarchOfPatient;

        private void dgv_resultofsearch_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_resultofsearch.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select a Patient");
                return;
            }

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }

            int idOfResearchOfPatient = (int)dgv_resultofsearch.SelectedRows[0].Cells["PatientId"].Value;

            try
            {
                var query = con.Query(@"

SELECT CONCAT(P.FirstName, ' ', P.LastName) AS FullName, 
       P.DateOfBirth, 
       P.Gender, 
       P.MedicalHistory, 
       M.Diaqnois, 
       M.LabResult, 
       M.Prescription, 
       M.TreatmentDetails 
FROM Patients P
INNER JOIN Appointments A ON P.PatientId = A.PatientId
INNER JOIN MedicalRecords M ON A.medicalRecordId = M.MedicalId
WHERE P.DoctorDetailsId = @DoctorId AND P.PatientId = @PatientId",
                    new { DoctorId = _loggedUser.DoctorDetailsId, PatientId = idOfResearchOfPatient }).ToList();

                if (query == null || !query.Any())
                {
                    MessageBox.Show("No patient data found.");
                    return;
                }

        SELECT 
            
            P.FirstName As FirstName,
            P.LastName As LastName,
            P.DateOfBirth AS DateOfBirth, 
            P.Gender AS Gender, 
            P.MedicalHistory AS MedicalHistory,  
            M.Diaqnois AS Diagnosis, 
            M.Prescription AS Prescription, 
            M.LabResult AS LabResult, 
            M.TreatmentDetails AS TreatmentDetails
        FROM Patients P 
        INNER JOIN MedicalRecords M ON P.PatientId = M.PatientId
        WHERE P.PatientId = @id", new { id = idOfResarchOfPatient}).ToList();

                var patient = query.FirstOrDefault();
                string patientData = $"Patient Info\n" +
                    $"Full Name: {patient.FullName}\n" +
                    $"DateOfBirth: {patient.DateOfBirth?.ToString("yyyy-MM-dd")}\n" +
                    $"Gender: {patient.Gender}\n" +
                    $"MedicalHistory: {patient.MedicalHistory}\n" +
                    $"Diagnosis: {patient.Diaqnois}\n" +
                    $"Prescription: {patient.Prescription}\n" +
                    $"LabResult: {patient.LabResult}\n" +
                    $"TreatmentDetails: {patient.TreatmentDetails}\n";

                GenerateAndDisplayQRCode(patientData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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
            //SaveToWordWithDocX(patientData);

        }

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            if (pictureTwo.Tag == null)
            {
                MessageBox.Show("No QR code data to save.");
                return;
            }

            string patientData = pictureTwo.Tag.ToString();

            //SaveToExcel(patientData);
        }
        // End Patient Form

        /*---------------------------------------------------------------------------*/

        // Start Appointment Form

        public void getAppointmetData()
        {
            var dt = new System.Data.DataTable();
            dt.Columns.Add("AppointmentId", typeof(int));
            dt.Columns.Add("PatientId", typeof(int));
            dt.Columns.Add("Appointment Time", typeof(DateTime));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Note", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("MedicalId", typeof(int));



            var results = con.Query(

    @"SELECT A.AppointmentId, P.PatientId, A.AppointmentDateTime, A.Status, A.Note, 
             P.FirstName, P.LastName, M.MedicalId
      FROM Appointments A 
      INNER JOIN Patients P ON A.PatientId = P.PatientId 
      LEFT JOIN MedicalRecords M ON A.medicalRecordId = M.MedicalId 
      WHERE A.DoctorDetailsId = @doctorId 
        AND CAST(A.AppointmentDateTime AS DATE) = CAST(GETDATE() AS DATE)
      ORDER BY A.AppointmentDateTime ASC",
    new { doctorId = _loggedUser.DoctorDetailsId }
);

                "select A.AppointmentId , A.AppointmentDateTime, A.Status, A.Note, P.FirstName, P.LastName " +
                "from Appointments A Inner Join Patients P " +
                "on A.PatientId = P.PatientId " +
                "where A.DoctorDetailsId = @doctorId",
                new { doctorId = _loggedUser.doctorDetails.DoctorDetailsId }
            );




            foreach (var row in results)
            {
                string statusName = Enum.GetName(typeof(AppointmentStatus), row.Status) ?? "Unknown";
                dt.Rows.Add(row.AppointmentId, row.PatientId, row.AppointmentDateTime, statusName, row.Note, row.FirstName, row.LastName, row.MedicalId);
            }
            dgv_appointment.DataSource = dt;
            dgv_appointment.Columns["AppointmentId"].Visible = false;
            dgv_appointment.Columns["PatientId"].Visible = false;

        }
        private void btn_appointment_Click(object sender, EventArgs e)
        {
            panel_HomePage.Hide();
            panel_profile.Hide();
            panel_medicalrecord.Hide();
            panel_patient.Hide();
            panel_appointment.Show();
            btn_EditMedicalRecord.Hide();
            getAppointmetData();
        }

        int appointmentId;
        int patientId;
        private void dgv_appointment_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_editstatus.Show();
            label33.Show();
            txt_editStatus.Show();
            btn_EditMedicalRecord.Show();

            appointmentId = (int)dgv_appointment.SelectedRows[0].Cells[0].Value;

            if (dgv_appointment.SelectedRows[0].Cells[1].Value != DBNull.Value)
            {
                patientId = Convert.ToInt32(dgv_appointment.SelectedRows[0].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("PatientId is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var appointmentStatusAndNote = db.Appointments.FirstOrDefault(n => n.AppointmentId == appointmentId);

            txt_editStatus.Text = appointmentStatusAndNote.Status.ToString();


            bool hasMedicalRecord = appointmentStatusAndNote.medicalRecordId != null && appointmentStatusAndNote.medicalRecordId > 0;
            UpdateButtonVisibility(appointmentStatusAndNote.Status, hasMedicalRecord);
        }
        private void btn_editstatus_Click(object sender, EventArgs e)
        {
            try
            {
                var appointmentStatusAndNote = db.Appointments.FirstOrDefault(n => n.AppointmentId == appointmentId);

                if (appointmentStatusAndNote == null)
                {
                    MessageBox.Show("Appointment not found.");
                    return;
                }

                if (!Enum.TryParse(txt_editStatus.Text, out AppointmentStatus newStatus) ||
                    !Enum.IsDefined(typeof(AppointmentStatus), newStatus))
                {
                    MessageBox.Show("Invalid status. Please enter a valid status: Upcoming, Cancel, or Done.");
                    return;
                }

                appointmentStatusAndNote.Status = newStatus;

                if (newStatus == AppointmentStatus.Cancel)
                {
                    appointmentStatusAndNote.Note = "Cancel With Doctor";
                }
                else if (newStatus == AppointmentStatus.Done && appointmentStatusAndNote.medicalRecordId == null)
                {
                    appointmentStatusAndNote.Note = "Appointment Completed";

                    db.SaveChanges();

                    getAppointmetData();


                    OpenAddMedicalRecordForm(appointmentStatusAndNote.AppointmentId, appointmentStatusAndNote?.PatientId);
                    MessageBox.Show("Status updated. Please add medical record details.");


                    UpdateButtonVisibility(newStatus, hasMedicalRecord: false);
                    return;
                }
                else
                {
                    appointmentStatusAndNote.Note = "No Thing";
                }


                db.SaveChanges();


                getAppointmetData();

                MessageBox.Show("Status updated successfully.");


                bool hasMedicalRecord = appointmentStatusAndNote.medicalRecordId != null && appointmentStatusAndNote.medicalRecordId > 0;
                UpdateButtonVisibility(newStatus, hasMedicalRecord);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                getAppointmetData();
            }
        }
        public void OpenAddMedicalRecordForm(int appointmentId, int? patientId)
        {
            Add_Medical_Record add_medical_Record = new Add_Medical_Record(appointmentId, patientId);
            add_medical_Record.FormClosed += (s, arg) => getAppointmetData();
            add_medical_Record.Show();
            btn_add.Hide();
            btn_update.Show();
        }
        public void OpenEditMedicalRecordForm(int medicalRecordId, int? patientId, int appointmentId)
        {
            Edit_Medical_Record edit_Medical_Record = new Edit_Medical_Record(medicalRecordId, patientId, appointmentId);
            edit_Medical_Record.FormClosed += (s, args) => getAppointmetData();
            edit_Medical_Record.Show();

        }


        private void btn_EditMedicalRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var appointmentStatusAndNote = db.Appointments.FirstOrDefault(n => n.AppointmentId == appointmentId);

            var results = con.Query(
                "select A.AppointmentId , A.AppointmentDateTime, A.Status, A.Note, P.FirstName, P.LastName " +
                "from Appointments A Inner Join Patients P " +
                "on A.PatientId = P.PatientId " +
                "where A.DoctorDetailsId = @doctorId",
                new { doctorId = _loggedUser.doctorDetails.DoctorDetailsId }
            );

                if (appointmentStatusAndNote != null)
                {
                    if (appointmentStatusAndNote.Status == AppointmentStatus.Done)
                    {
                        bool hasMedicalRecord = appointmentStatusAndNote.medicalRecordId != null &&
                        appointmentStatusAndNote.medicalRecordId > 0;

                        if (hasMedicalRecord)
                        {
                            OpenEditMedicalRecordForm(appointmentStatusAndNote.medicalRecordId.Value, appointmentStatusAndNote?.PatientId, appointmentStatusAndNote.AppointmentId);
                            MessageBox.Show("Status updated. This appointment already has a medical record.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void UpdateButtonVisibility(AppointmentStatus status, bool hasMedicalRecord)
        {
            if (status == AppointmentStatus.Done && !hasMedicalRecord)
            {
                btn_EditMedicalRecord.Hide();
                btn_editstatus.Show();
                label33.Show();
                txt_editStatus.Hide();
            }
            else if (status == AppointmentStatus.Done && hasMedicalRecord)
            {
                btn_EditMedicalRecord.Show();
                btn_editstatus.Hide();
                label33.Hide();
                txt_editStatus.Hide();
            }
            else
            {
                btn_EditMedicalRecord.Show();
                btn_editstatus.Show();
                label33.Show();
                txt_editStatus.Show();
            }
        }



        private void panel_appointment_Paint(object sender, PaintEventArgs e)
        {

        }


        // End Appointment Form
    }
}
