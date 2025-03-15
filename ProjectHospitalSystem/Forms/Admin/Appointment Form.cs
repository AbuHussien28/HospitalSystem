using System.Data;
using DevExpress.XtraGantt.Base.Scheduling;
using DevExpress.XtraRichEdit.API.Native;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Services;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class Appointment_Form : Form
    {
        HospitalSystemContext db;
        private int _selectedDoctorId;
        private DateTime _oldScheduleDate;
        public Appointment_Form()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
        }


        public void getAppointmentDate()
        {
            dgv_Appointment.DataSource = db.Appointments
                .Select(n => new { n.AppointmentId, n.AppointmentDateTime, n.Status, n.Note, n.ReminderSent, n.DoctorDetailsId })
                .OrderBy(n => n.AppointmentDateTime)
                .ToList();
            dgv_Appointment.Columns["AppointmentId"].Visible = false;
        }
        private void Appointment_Form_Load(object sender, EventArgs e)
        {
            dgv_Appointment.DataSource = db.Appointments.Select(n => new { n.AppointmentId, n.AppointmentDateTime, n.Status, n.Note, n.ReminderSent, n.DoctorDetailsId }).OrderBy(n => n.AppointmentDateTime).ToList();
            cb_Depart.DataSource = db.Departments.ToList();
            cb_Depart.DisplayMember = "DeptName";
            cb_Depart.ValueMember = "DeptId";

            dgv_Appointment.Columns["AppointmentId"].Visible = false;

            cb_Depart_SelectedValueChanged(null, null);

            btn_delete.Hide();
            btn_Update.Hide();
        }

        private void cb_Depart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Depart.SelectedValue != null && int.TryParse(cb_Depart.SelectedValue.ToString(), out int selectedDeptId))
            {
                cb_Doctor.DataSource = db.Doctors.Where(n => n.DeptId == selectedDeptId).Join(db.Users, Doctor => Doctor.UserId, user => user.UserId, (doctor, user) => new { DoctorDetailsId = doctor.DoctorDetailsId, fullName = user.FName + " " + user.LName }).ToList();
                cb_Doctor.ValueMember = "DoctorDetailsId";
                cb_Doctor.DisplayMember = "FullName";
            }
            else
            {
                cb_Doctor.DataSource = null;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDateTime = dateTimePicker1.Value;
                int doctorDetailsId = (int)cb_Doctor.SelectedValue;
                var existingSchedule = db.Doctor_Schedules
                    .FirstOrDefault(ds => ds.DoctorDetailsId == doctorDetailsId && ds.ScheduleDay.Date == selectedDateTime.Date);
                if (existingSchedule == null)
                {
                    // Add a new schedule for the doctor
                    var newSchedule = new Doctor_Schedule
                    {
                        DoctorDetailsId = doctorDetailsId,
                        ScheduleDay = selectedDateTime.Date
                    };

                    db.Doctor_Schedules.Add(newSchedule);
                    db.SaveChanges(); 
                }

                var newAppointment = new Appointment
                {
                    AppointmentDateTime = selectedDateTime,
                    Status = AppointmentStatus.Upcoming,
                    Note = "Not Assigned for Doctor",
                    ReminderSent = false,
                    DoctorDetailsId = doctorDetailsId
                };

                db.Appointments.Add(newAppointment);
                db.SaveChanges(); 

                MessageBox.Show("Appointment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAppointmentDate(); 
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int id;
        private void dgv_Appointment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_Appointment.SelectedRows[0].Cells[0].Value;
            var appointment = db.Appointments.FirstOrDefault(n => n.AppointmentId == id);
            if (appointment != null)
            {
                _selectedDoctorId = appointment.DoctorDetailsId ?? 0;
                _oldScheduleDate = appointment.AppointmentDateTime;
                dateTimePicker1.Value = appointment.AppointmentDateTime;
                cb_Doctor.SelectedValue = appointment.DoctorDetailsId;
                cb_Depart.Hide();
                cb_Doctor.Hide();
                label4.Hide();
                label5.Hide();
                btn_Update.Show();
                btn_delete.Show();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsForUpdate())
                return;

            try
            {
                int appointmentId = (int)dgv_Appointment.SelectedRows[0].Cells["AppointmentId"].Value;
                DateTime selectedDateTime = dateTimePicker1.Value;

                var appointmentService = new AppointmentService(db);
                appointmentService.UpdateAppointmentAsync(appointmentId, selectedDateTime).Wait();

                MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAppointmentDate();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cb_Depart.Show();
                cb_Doctor.Show();
                label4.Show();
                label5.Show();
                btn_Update.Hide();
                btn_delete.Hide();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_Appointment.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this appointment?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int appointmentId = (int)dgv_Appointment.SelectedRows[0].Cells["AppointmentId"].Value;

                        var appointmentService = new AppointmentService(db);
                        appointmentService.DeleteAppointmentAsync(appointmentId).Wait();

                        MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAppointmentDate();
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an appointment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            cb_Depart.Show();
            cb_Doctor.Show();
            label4.Show();
            label5.Show();
            btn_Update.Hide();
            btn_delete.Hide();
        }
        private bool ValidateInputsForUpdate()
        {
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                MessageBox.Show("Please select a date and time in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Focus();
                return false;
            }
            return true;
        }
        private bool IsScheduleUnique(DateTime scheduleDay, int doctorDetailsId)
        {
            return !db.Doctor_Schedules.Any(ds => ds.ScheduleDay.Date == scheduleDay.Date && ds.DoctorDetailsId == doctorDetailsId);
        }
    }
}
