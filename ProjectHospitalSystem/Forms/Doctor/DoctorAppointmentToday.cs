using Dapper;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Forms.Receptionist;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class DoctorAppointmentToday : Form
    {
        HospitalSystemContext db;
        private User _loggedUser;
        SqlConnection con;
        public DoctorAppointmentToday(User loggedUser)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            _loggedUser = loggedUser;
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }
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
                @"select A.AppointmentId, P.PatientId, A.AppointmentDateTime, A.Status, A.Note, 
                 P.FirstName, P.LastName
                 from Appointments A
                 inner join Patients p on A.PatientId=P.PatientId
                 left join Doctors d on A.DoctorDetailsId=d.DoctorDetailsId
                 WHERE A.DoctorDetailsId = @doctorId 
            AND CAST(A.AppointmentDateTime AS DATE) = CAST(GETDATE() AS DATE)
          ORDER BY A.AppointmentDateTime ASC",
                new { doctorId = _loggedUser.doctorDetails.DoctorDetailsId }
            );

            if (!results.Any())
            {
                dgv_appointment.DataSource = null;
                MessageBox.Show("No appointments assigned for today.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var row in results)
            {
                string statusName = Enum.GetName(typeof(AppointmentStatus), row.Status) ?? "Unknown";
                dt.Rows.Add(row.AppointmentId, row.PatientId, row.AppointmentDateTime, statusName, row.Note, row.FirstName, row.LastName, row.MedicalId);
            }

            dgv_appointment.DataSource = dt;
            dgv_appointment.Columns["AppointmentId"].Visible = false;
            dgv_appointment.Columns["PatientId"].Visible = false;
            dgv_appointment.Columns["MedicalId"].Visible = false;
        }

        private void btn_editstatus_Click(object sender, EventArgs e)
        {
            try
            {
                var appointment = db.Appointments
                    .Include(a => a.Patient)
                    .Include(a => a.Doctor)
                    .ThenInclude(d => d.User) 
                    .Include(a => a.Doctor.Dept)
                    .FirstOrDefault(n => n.AppointmentId == appointmentId);

                if (appointment == null)
                {
                    MessageBox.Show("Appointment not found.");
                    return;
                }
                if (appointment.Doctor == null || appointment.Doctor.User == null)
                {
                    MessageBox.Show("Appointment is not assigned to a valid doctor.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!appointment.UserId.HasValue)
                {
                    appointment.UserId = appointment.Doctor.UserId;
                }

                if (!Enum.TryParse(txt_status.Text, out AppointmentStatus newStatus) ||
                    !Enum.IsDefined(typeof(AppointmentStatus), newStatus))
                {
                    MessageBox.Show("Invalid status. Please enter a valid status: Upcoming, Cancel, or Done.");
                    return;
                }

                appointment.Status = newStatus;

                if (newStatus == AppointmentStatus.Cancel)
                {
                    appointment.Note = "Cancel With Doctor";
                    db.SaveChanges();
                    RefreshAppointmentData();
                    MessageBox.Show("Appointment cancelled successfully.");
                }
                else if (newStatus == AppointmentStatus.Done)
                {
                    appointment.Note = "Appointment Completed";
                    db.SaveChanges(); 
                    if (CanCreateBill(appointment))
                    {
                        if (appointment.Bill == null)
                        {
                            CreateBillForAppointment(appointment);
                        }

                        if (appointment.medicalRecordId == null)
                        {
                            OpenAddMedicalRecordForm(appointment.AppointmentId, appointment.PatientId);
                        }
                        else
                        {
                            OpenEditMedicalRecordForm(appointment.AppointmentId, appointment.PatientId,
                                                   appointment.medicalRecordId.Value);
                        }
                    }
                    RefreshAppointmentData();
                }
                else
                {
                    appointment.Note = "No Thing";
                    db.SaveChanges();
                    RefreshAppointmentData();
                    MessageBox.Show("Status updated successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                RefreshAppointmentData();
            }
        }
        public void OpenAddMedicalRecordForm(int appointmentId, int? patientId)
        {
            Add_Medical_Record add_medical_Record = new Add_Medical_Record(appointmentId, patientId);
            add_medical_Record.FormClosed += (s, arg) => getAppointmetData();
            add_medical_Record.Show();
        }
        public void OpenEditMedicalRecordForm(int medicalRecordId, int? patientId, int appointmentId)
        {
            Edit_Medical_Record edit_Medical_Record = new Edit_Medical_Record(medicalRecordId, patientId, appointmentId);
            edit_Medical_Record.FormClosed += (s, args) => getAppointmetData();
            edit_Medical_Record.Show();

        }
        int appointmentId;
        int patientId;
        private void dgv_appointment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("Please click on a valid cell.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selectedRow = dgv_appointment.Rows[e.RowIndex];

            if (selectedRow.Cells["AppointmentId"].Value == null)
            {
                MessageBox.Show("No valid appointment selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btn_editstatus.Show();
            lbStatusAppoint.Show();
            txt_status.Show();
            btn_EditMedicalRecord.Show();
            appointmentId = Convert.ToInt32(selectedRow.Cells["AppointmentId"].Value);
            if (selectedRow.Cells["PatientId"].Value != DBNull.Value)
            {
                patientId = Convert.ToInt32(selectedRow.Cells["PatientId"].Value);
            }
            else
            {
                MessageBox.Show("PatientId is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var appointmentStatusAndNote = db.Appointments.FirstOrDefault(n => n.AppointmentId == appointmentId);
            if (appointmentStatusAndNote == null)
            {
                MessageBox.Show("Appointment not found in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txt_status.Text = appointmentStatusAndNote.Status.ToString();
            bool hasMedicalRecord = appointmentStatusAndNote.medicalRecordId != null && appointmentStatusAndNote.medicalRecordId > 0;
            UpdateButtonVisibility(appointmentStatusAndNote.Status, hasMedicalRecord);
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
            if (status == AppointmentStatus.Upcoming)
            {
                btn_EditMedicalRecord.Hide();
                pnlAppoinmentDocDetails.Show();
                btn_editstatus.Show();
            }
            else if (status == AppointmentStatus.Done)
            {
                if (hasMedicalRecord)
                {
                    btn_EditMedicalRecord.Show();
                    pnlAppoinmentDocDetails.Hide();
                    btn_editstatus.Hide();
                    var appointment = db.Appointments
                        .Include(a => a.Bill)
                        .FirstOrDefault(a => a.AppointmentId == appointmentId);

                    if (appointment?.Bill != null)
                    {
                        MessageBox.Show("Appointment completed with medical record and bill generated.",
                                      "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    btn_EditMedicalRecord.Hide();
                    pnlAppoinmentDocDetails.Show();
                    btn_editstatus.Show();
                    MessageBox.Show("Please create a medical record for this appointment.",
                                  "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                btn_EditMedicalRecord.Show();
                btn_editstatus.Hide();
                pnlAppoinmentDocDetails.Show();
            }
        }
        private void CreateBillForAppointment(Appointment appointment)
        {

           try
            {
                if (db.Bills.Any(b => b.AppointmentId == appointment.AppointmentId))
                {
                    MessageBox.Show("A bill already exists for this appointment.", "Information",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Bill newBill = new Bill
                {
                    PatientId = appointment.PatientId.Value,
                    DepartmentId = appointment.Doctor.Dept.DeptId,
                    UserId = appointment.UserId.Value,
                    AppointmentId = appointment.AppointmentId,
                    OriginalAmount = appointment.Doctor.Dept.FeeAmount,
                    LateFee = 0,
                    DueDate = appointment.AppointmentDateTime.AddDays(3),
                    Status = BillStatus.unPaid,
                    GenertedDate = DateTime.Now
                };

                db.Bills.Add(newBill);
                db.SaveChanges();

                MessageBox.Show("Bill created successfully!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to create bill: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"Bill creation error: {ex.Message}\n{ex.StackTrace}");
            }
        }
            
        private bool CanCreateBill(Appointment appointment)
        {
            if (!appointment.PatientId.HasValue)
            {
                MessageBox.Show("Cannot create bill - missing patient information.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!appointment.UserId.HasValue)
            {
                MessageBox.Show("Cannot create bill - missing user information.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (appointment.Doctor?.Dept == null)
            {
                MessageBox.Show("Cannot create bill - missing department information.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void DoctorAppointmentToday_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
            getAppointmetData();
        }
        public void Reload()
        {
            try
            {
                appointmentId = 0;
                patientId = 0;
                ResetFormControls();
                RefreshAppointmentData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to reload data: {ex.Message}",
          "Error",
          MessageBoxButtons.OK,
          MessageBoxIcon.Error);
            }
        }
        private void RefreshAppointmentData()
        {
            try
            {
                dgv_appointment.ClearSelection();
                db.Entry(db.Appointments.Local.FirstOrDefault(a => a.AppointmentId == appointmentId)).Reload();
                getAppointmetData();
                var currentAppointment = db.Appointments
                    .FirstOrDefault(a => a.AppointmentId == appointmentId);

                if (currentAppointment != null)
                {
                    bool hasMedicalRecord = currentAppointment.medicalRecordId != null;
                    UpdateButtonVisibility(currentAppointment.Status, hasMedicalRecord);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error refreshing data: {ex.Message}");
            }
        }
        private void ResetFormControls()
        {
            btn_editstatus.Hide();
            lbStatusAppoint.Hide();
            txt_status.Hide();
            btn_EditMedicalRecord.Hide();
            pnlAppoinmentDocDetails.Hide();
            txt_status.Clear();
        }
    }
}
