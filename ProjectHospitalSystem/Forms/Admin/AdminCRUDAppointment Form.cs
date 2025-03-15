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
        #region Fields and Initialization
        HospitalSystemContext db;
        private int _selectedDoctorId;
        private DateTime _oldScheduleDate;
        public Appointment_Form()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
        }
        #endregion
        #region Form Load and Data Loading
        public void getAppointmentDate()
        {
            dgv_Appointment.DataSource = db.Appointments
          .Include(a => a.Doctor)
          .Select(n => new
          {
              n.AppointmentId,
              n.AppointmentDateTime,
              n.Status,
              n.Note,
              n.ReminderSent,
              n.DoctorDetailsId,
              DoctorFullName = n.Doctor.User.FName + " " + n.Doctor.User.LName
          })
          .OrderBy(n => n.AppointmentDateTime)
          .ToList();
        }
        private void Appointment_Form_Load(object sender, EventArgs e)
        {
            getAppointmentDate();
            cb_Depart.DataSource = db.Departments.ToList();
            cb_Depart.DisplayMember = "DeptName";
            cb_Depart.ValueMember = "DeptId";
            dgv_Appointment.Columns["AppointmentId"].Visible = false;
            cb_Depart_SelectedValueChanged(null, null);
            dtp_FilterDate.Value = DateTime.Today;
            btn_delete.Hide();
            btn_Update.Hide();
            ClearFields();
        }
        #endregion
        #region Event Handlers
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
                DateTime selectedDateTime = dtp_AppoinmnetDate.Value;
                int doctorDetailsId = (int)cb_Doctor.SelectedValue;
                var existingSchedule = db.Doctor_Schedules
                    .FirstOrDefault(ds => ds.DoctorDetailsId == doctorDetailsId && ds.ScheduleDay.Date == selectedDateTime.Date);
                if (!ValidateAppointmentDateTime())
                    return;
                if (existingSchedule != null)
                {
                    MessageBox.Show("An appointment already exists for this doctor at the selected date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (existingSchedule == null)
                {
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
                ClearFields();
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
        private void dgv_Appointment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_Appointment.SelectedRows[0].Cells[0].Value;
            var appointment = db.Appointments.FirstOrDefault(n => n.AppointmentId == id);
            if (appointment != null)
            {
                _selectedDoctorId = appointment.DoctorDetailsId ?? 0;
                _oldScheduleDate = appointment.AppointmentDateTime;
                dtp_AppoinmnetDate.Value = appointment.AppointmentDateTime;
                cb_Doctor.SelectedValue = appointment.DoctorDetailsId;
                cb_Depart.Hide();
                cb_Doctor.Hide();
                lb_DeptName.Hide();
                pBoxDeptName.Hide();
                pBoxDoctorName.Hide();
                lb_Doctor.Hide();
                btn_add.Hide();
                btn_Update.Show();
                btn_delete.Show();
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!ValidateAppointmentDateTime())
                return;
            try
            {
                int appointmentId = (int)dgv_Appointment.SelectedRows[0].Cells["AppointmentId"].Value;
                DateTime selectedDateTime = dtp_AppoinmnetDate.Value;
                var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
                if (appointment == null)
                {
                    MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (appointment.AppointmentDateTime == selectedDateTime)
                {
                    MessageBox.Show("No changes detected. Please modify the appointment before updating.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                appointment.AppointmentDateTime = selectedDateTime;
                db.SaveChanges();
                MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAppointmentDate();
                ClearFields();
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
                lb_DeptName.Show();
                lb_Doctor.Show();
                btn_Update.Hide();
                btn_delete.Hide();
                pBoxDeptName.Show();
                pBoxDoctorName.Show();
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
                        ClearFields();
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
            ClearFields();
        }
      private void lbBtnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dtp_FilterDate.Value.Date;
                var filteredAppointments = db.Appointments
                    .Include(a => a.Doctor)
                    .Where(a => a.AppointmentDateTime.Date == selectedDate)
                    .Select(n => new
                    {
                        n.AppointmentId,
                        n.AppointmentDateTime,
                        n.Status,
                        n.Note,
                        n.ReminderSent,
                        n.DoctorDetailsId,
                        DoctorFullName = n.Doctor.User.FName + " " + n.Doctor.User.LName
                    })
                    .OrderBy(n => n.AppointmentDateTime)
                    .ToList();
                dgv_Appointment.DataSource = filteredAppointments;
                dgv_Appointment.Columns["AppointmentId"].Visible = false;
                pBoxClearFilterDate.Show();
                lb_clearFilter.Show();
                lbBtnFilter.Hide();
                pBoxFilterDate.Hide();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lb_clearFilter_Click(object sender, EventArgs e)
        {
            try
            {
                getAppointmentDate();
                pBoxClearFilterDate.Hide();
                lb_clearFilter.Hide();
                lbBtnFilter.Show();
                pBoxFilterDate.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing filter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        #region Helper Methods
        private bool ValidateAppointmentDateTime()
        {
            if (dtp_AppoinmnetDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Please select a date and time in the future.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_AppoinmnetDate.Focus();
                return false;
            }
            return true;
        }
        private bool IsScheduleUnique(DateTime scheduleDay, int doctorDetailsId)
        {
            return !db.Doctor_Schedules.Any(ds => ds.ScheduleDay.Date == scheduleDay.Date && ds.DoctorDetailsId == doctorDetailsId);
        }
        private void ClearFields()
        {
            dtp_AppoinmnetDate.Value = DateTime.Now;
            cb_Depart.SelectedIndex = -1;
            cb_Doctor.SelectedIndex = -1;
            cb_Depart.Show();
            cb_Doctor.Show();
            lb_DeptName.Show();
            pBoxDeptName.Show();
            pBoxDoctorName.Show();
            lb_Doctor.Show();
            btn_Update.Hide();
            btn_delete.Hide();
            btn_add.Show();
            dtp_FilterDate.Value = DateTime.Today;

        }
        public void Reload()
        {
            getAppointmentDate();
            ClearFields();
            pBoxClearFilterDate.Hide();
            lb_clearFilter.Hide();
            lbBtnFilter.Show();
            pBoxFilterDate.Show();
        }
        #endregion
    }
}
