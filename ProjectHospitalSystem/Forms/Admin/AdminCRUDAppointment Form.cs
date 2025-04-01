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
        int _selectedId;
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
        private void dgv_Appointment_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_Appointment.Rows.Count)
            {
                if (dgv_Appointment.Columns.Contains("AppointmentId"))
                {
                    _selectedId = (int)dgv_Appointment.Rows[e.RowIndex].Cells["AppointmentId"].Value;
                    var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentId == _selectedId);

                    if (appointment != null)
                    {
                        dtp_AppoinmnetDate.Value = appointment.AppointmentDateTime;
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
                    else
                    {
                        MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAppointmentDateTime())
                    return;

                int? doctorDetailsId = cb_Doctor.SelectedValue as int?;

                if (doctorDetailsId == null)
                {
                    MessageBox.Show("Please select a doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime selectedDateTime = dtp_AppoinmnetDate.Value;
                selectedDateTime = new DateTime(
                    selectedDateTime.Year, selectedDateTime.Month, selectedDateTime.Day,
                    selectedDateTime.Hour, selectedDateTime.Minute, 0); 
                bool isDuplicate = db.Appointments.Any(a =>
                    a.DoctorDetailsId == doctorDetailsId &&
                    a.AppointmentDateTime == selectedDateTime);
                if (isDuplicate)
                {
                    MessageBox.Show("This time slot is already booked for the selected doctor.",
                                  "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var newAppointment = new Appointment
                {
                    DoctorDetailsId = doctorDetailsId,
                    Note = "Not Assigend", 
                    AppointmentDateTime = selectedDateTime,
                    Status = AppointmentStatus.Upcoming 
                };

                db.Appointments.Add(newAppointment);
                var scheduleExists = db.Doctor_Schedules
                    .Any(ds => ds.DoctorDetailsId == doctorDetailsId &&
                              ds.ScheduleDay == selectedDateTime);
                if (!scheduleExists)
                {
                    var newSchedule = new Doctor_Schedule
                    {
                        DoctorDetailsId = doctorDetailsId,
                        ScheduleDay = selectedDateTime 
                    };
                    db.Doctor_Schedules.Add(newSchedule);
                }

                db.SaveChanges();

                MessageBox.Show("Appointment added successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAppointmentDate();
                ClearFields();
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.InnerException?.Message ?? dbEx.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) 
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateAppointmentDateTime())
                return;
            try
            {
                var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentId == _selectedId);

                if (appointment == null)
                {
                    MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime selectedDateTime = dtp_AppoinmnetDate.Value;
                if (appointment.AppointmentDateTime == selectedDateTime)
                {
                    MessageBox.Show("No changes detected. Please modify the appointment before updating.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!IsScheduleUnique(selectedDateTime, appointment.DoctorDetailsId))
                {
                    MessageBox.Show("An appointment already exists for this doctor at the selected date and time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                appointment.AppointmentDateTime = selectedDateTime;
                db.SaveChanges();

                MessageBox.Show("Appointment date updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAppointmentDate();
                ClearFields();
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
                btn_add.Show();
                lbBtnFilter.Show();
                pBoxFilterDate.Show();
                lb_clearFilter.Hide();
                pBoxClearFilterDate.Hide();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_selectedId == 0) 
            {
                MessageBox.Show("Please select an appointment to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentId == _selectedId);

                    if (appointment != null)
                    {
                        db.Appointments.Remove(appointment);
                        db.SaveChanges();

                        MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getAppointmentDate();
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting appointment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                dgv_Appointment.Columns["DoctorDetailsId"].Visible = false;
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
            DateTime today = DateTime.Today;
            DateTime selectedDate = dtp_AppoinmnetDate.Value.Date;
            if (selectedDate < today)
            {
                MessageBox.Show("Appointment date cannot be in the past. Please select today or a future date.",
                               "Invalid Date",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_AppoinmnetDate.Focus();
                return false;
            }
            if (selectedDate == today && dtp_AppoinmnetDate.Value.TimeOfDay < DateTime.Now.TimeOfDay)
            {
                MessageBox.Show("Cannot schedule an appointment for a time that has already passed today.",
                               "Invalid Time",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_AppoinmnetDate.Focus();
                return false;
            }

            return true;
        }
        private bool IsScheduleUnique(DateTime scheduleDay, int? doctorDetailsId)
        {
            return !db.Appointments.Any(a =>
       a.DoctorDetailsId == doctorDetailsId &&
       a.AppointmentDateTime == scheduleDay);
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
            _selectedId = 0;

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
