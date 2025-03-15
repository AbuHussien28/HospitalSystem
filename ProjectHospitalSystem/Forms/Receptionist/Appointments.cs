using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Migrations;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static DevExpress.XtraBars.Painters.PrimitivesPainterWindowsXP;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class Appointments : Form
    {
        HospitalSystemContext db; int userid;
        public Appointments()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
        }
        private void LoadAppointemtData()
        {
            var appointmentdetails = db.Appointments
           .Include(a => a.User)
           .Include(a => a.Doctor)
           .ThenInclude(d => d.User)
           .Include(a => a.Patient)
           .Select(a => new
           {
               PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
               DoctorName = a.Doctor.User.FName + " " + a.Doctor.User.LName,
               Specialization = a.Doctor.Specialization,
               a.AppointmentDateTime,
               a.ReminderSent,
               a.Note,
               a.Status
           })
           .ToList();


            dgv_appointments.DataSource = appointmentdetails;

        }
        private void CreateBillForAppointment(Appointment appointment)
        {
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
                GenertedDate = appointment.AppointmentDateTime
            };

            db.Bills.Add(newBill);
            db.SaveChanges();
           
        }
        private void Appointments_Load(object sender, EventArgs e)
        {
            LoadAppointemtData();
            comb_searchBy.Items.Add("Patient Name");
            comb_searchBy.Items.Add("Department");
            comb_searchBy.Items.Add("Doctor");
            combx_status.Items.Add("Upcoming");
            combx_status.Items.Add("Cancel");
            combx_status.Items.Add("Done");
            comb_searchBy.SelectedIndex = 0;
            combx_status.SelectedIndex = 0;
            SearchAppointments();
        }
        private void SearchAppointments()
        {
            string searchText = txt_search.Text.Trim();
            string selectedFilter = comb_searchBy.SelectedItem?.ToString();

            var query = db.Appointments
                .Include(a => a.Doctor)
                .ThenInclude(d => d.User)
                .Include(a => a.Patient)
                .AsQueryable();

            if (selectedFilter == "Patient Name")
            {
                query = query.Where(a => a.Patient.FirstName.ToLower().StartsWith(searchText.ToLower()) ||
                                         a.Patient.LastName.ToLower().StartsWith(searchText.ToLower()));
            }
            else if (selectedFilter == "Department")
            {
                query = query.Where(a => a.Doctor.Dept.DeptName.ToLower().StartsWith(searchText.ToLower()));
            }
            else if (selectedFilter == "Doctor")
            {
                query = query.Where(a => a.Doctor.User.FName.ToLower().StartsWith(searchText.ToLower()) ||
                                         a.Doctor.User.LName.ToLower().StartsWith(searchText.ToLower()));
            }

            var searchResults = query.Select(a => new
            {
                PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                DoctorName = a.Doctor.User.FName + " " + a.Doctor.User.LName,
                Specialization = a.Doctor.Specialization,
                a.AppointmentDateTime,
                a.ReminderSent,
                a.Note,
                a.Status
            }).ToList();

            dgv_appointments.DataSource = null;
            dgv_appointments.DataSource = searchResults;
            dgv_appointments.Refresh();

        }



        private void dgv_appointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_appointments.Rows[e.RowIndex];

                txt_patient.Text = row.Cells["PatientName"].Value.ToString();
                txt_doctor.Text = row.Cells["DoctorName"].Value.ToString();
                txt_dept.Text = row.Cells["Specialization"].Value.ToString();
                txt_date.Text = row.Cells["AppointmentDateTime"].Value.ToString();
                txt_note.Text = row.Cells["Note"].Value.ToString();
                combx_status.SelectedItem = row.Cells["Status"].Value.ToString();
                if (row.Cells["ReminderSent"].Value == "Sent")
                {

                    Rbtn_sent.Checked = true;
                }
                else
                {
                    Rbtn_Nsent.Checked = true;
                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            SearchAppointments();
        }

        private void comb_searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchAppointments();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

             New_Appointment  newa= new New_Appointment(userid);
            newa.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_appointments.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_appointments.SelectedRows[0].Index;
                string patientName = dgv_appointments.Rows[selectedIndex].Cells["PatientName"].Value.ToString();
                string doctorName = dgv_appointments.Rows[selectedIndex].Cells["DoctorName"].Value.ToString();
                DateTime appointmentDate = Convert.ToDateTime(dgv_appointments.Rows[selectedIndex].Cells["AppointmentDateTime"].Value);

                var appointment = db.Appointments
                    .Include(a => a.Patient)
                    .Include(a => a.Doctor)
                    .ThenInclude(d => d.User)
                    .FirstOrDefault(a =>
                        (a.Patient.FirstName + " " + a.Patient.LastName) == patientName &&
                        (a.Doctor.User.FName + " " + a.Doctor.User.LName) == doctorName &&
                        a.AppointmentDateTime == appointmentDate);

                if (appointment != null)
                {
                    if (appointment != null)
                    {
                        if (combx_status.SelectedItem != null)
                        {
                            string selectedStatus = combx_status.SelectedItem.ToString();

                            if (selectedStatus == "Upcoming")
                                appointment.Status = AppointmentStatus.Upcoming;
                            else if (selectedStatus == "Cancel")
                                appointment.Status = AppointmentStatus.Cancel;
                            else if (selectedStatus == "Done")
                            {
                                appointment.Status = AppointmentStatus.Done;

                               
                                if (appointment.Bill == null)
                                {
                                    CreateBillForAppointment(appointment);
                                }
                            }

                            db.SaveChanges();
                            MessageBox.Show("Appointment status updated successfully!");
                        }
                    }

                    appointment.Note = txt_note.Text;
                    appointment.ReminderSent = Rbtn_sent.Checked;
                    appointment.AppointmentDateTime = Convert.ToDateTime(txt_date.Text);

                    db.SaveChanges();
                    LoadAppointemtData();
                    MessageBox.Show("Appointment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_appointments.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_appointments.SelectedRows[0].Index;
                string patientName = dgv_appointments.Rows[selectedIndex].Cells["PatientName"].Value.ToString();
                string doctorName = dgv_appointments.Rows[selectedIndex].Cells["DoctorName"].Value.ToString();
                DateTime appointmentDate = Convert.ToDateTime(dgv_appointments.Rows[selectedIndex].Cells["AppointmentDateTime"].Value);

                var appointment = db.Appointments
                    .Include(a => a.Patient)
                    .Include(a => a.Doctor)
                    .ThenInclude(d => d.User)
                    .FirstOrDefault(a =>
                        (a.Patient.FirstName + " " + a.Patient.LastName) == patientName &&
                        (a.Doctor.User.FName + " " + a.Doctor.User.LName) == doctorName &&
                        a.AppointmentDateTime == appointmentDate);

                if (appointment != null)
                {
                    var result = MessageBox.Show("Are you sure you want to Cancel this appointment?",
                                                 "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        appointment.Status =AppointmentStatus.Cancel ; 
                        db.SaveChanges();
                        LoadAppointemtData();
                        MessageBox.Show("Appointment Canceled successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
