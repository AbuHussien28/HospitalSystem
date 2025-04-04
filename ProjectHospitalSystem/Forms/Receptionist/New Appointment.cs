﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using System.Net;
using System.Net.Mail;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class New_Appointment : Form
    {

        private HospitalSystemContext db;
        private int userid;
        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
        // private readonly MaterialSkinManager materialSkinManager;
        public New_Appointment(int uid)
        {
            InitializeComponent();
            userid = uid;
            db = new HospitalSystemContext();
            ConfigureAutoComplete();
        }
        private async void ConfigureAutoComplete()
        {
            var patientNames = await db.Patients
                                       .Where(p => !string.IsNullOrEmpty(p.FirstName) && !string.IsNullOrEmpty(p.LastName))
                                       .Select(p => p.FirstName + " " + p.LastName)
                                       .ToListAsync();

            autoCompleteCollection.AddRange(patientNames.ToArray());

            txt_SearchPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_SearchPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_SearchPatient.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void LoadDoctorsData(string department = null)
        {


            var doctorsQuery = db.Doctors
         .Include(d => d.User)
         .Include(d => d.Dept)
         .Include(d => d.doctorSchedule)
         .Select(d => new
         {
             FullName = d.User.FName + " " + d.User.LName,
             d.Specialization,
             DeptName = d.Dept.DeptName,
             Appointments = d.doctorSchedule.Any() ? d.doctorSchedule.FirstOrDefault().ScheduleDay.ToString("yyyy-MM-dd HH:mm") : "No Schedule"

         });

            if (!string.IsNullOrEmpty(department) && department != "All Departments")
            {
                doctorsQuery = doctorsQuery.Where(d => d.DeptName == department);
            }

            var doctors = doctorsQuery.ToList();

            comEdit_doctor.Properties.Items.Clear();
            foreach (var doctor in doctors)
            {
                comEdit_doctor.Properties.Items.Add(doctor.FullName);
            }
            if (comEdit_doctor.Properties.Items.Count > 0)
            {
                comEdit_doctor.SelectedIndex = 0;
            }

            dgv_doctors.DataSource = doctors;
        }
        private void LoadDepartments()
        {
            var departments = db.Departments
                                .Select(d => d.DeptName)
                                .ToList();

            comboxEdit_dept.Properties.Items.Clear();
            comboxEdit_dept.Properties.Items.Add("All Departments");
            comboxEdit_dept.Properties.Items.AddRange(departments);
            comboxEdit_dept.SelectedIndex = 0;
        }
        private void SendConfirmationEmail(string patientEmail, string patientName, string doctorName, string specializationOrDept, DateTime appointmentDate)
        {
            try
            {
                //Put your Email and password Here
                string senderEmail = "";
                string senderPassword = "";

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(patientEmail);
                mail.Subject = "Appointment Confirmation";
                mail.Body = $"Dear {patientName},\n\nYour appointment has been successfully booked.\n\n" +
                            $"Doctor: {doctorName}\n" +
                            $"Department/Specialization: {specializationOrDept}\n" +
                            $"Date & Time: {appointmentDate:yyyy-MM-dd HH:mm}\n\n" +
                            $"Best regards,\nHospital Management System";
                mail.IsBodyHtml = false;
                string smtpServer = "smtp.gmail.com";
                int smtpPort = 587;
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Timeout = 20000
                };

                smtpClient.Send(mail);
                MessageBox.Show("Confirmation email sent successfully!", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void New_Appointment_Load(object sender, EventArgs e)
        {
            LoadDoctorsData();
            LoadDepartments();

        }

        private void comboxEdit_dept_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedDepartment = comboxEdit_dept.Text;
            LoadDoctorsData(selectedDepartment);
        }

        private void comEdit_doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctor = comEdit_doctor.Text;
            var filteredDoctors = db.Doctors
                .Include(d => d.User)
                .Include(d => d.Dept)
                .Where(d => (d.User.FName + " " + d.User.LName) == selectedDoctor)
                .Select(d => new
                {
                    FullName = d.User.FName + " " + d.User.LName,
                    d.Specialization,
                    DeptName = d.Dept.DeptName
                })
                .ToList();


            dgv_doctors.DataSource = filteredDoctors;
        }

        private void btn_bookApp_Click(object sender, EventArgs e)
        {

            bool reminder = Rbtn_sent.Checked;
            string patientFullName = txt_SearchPatient.Text.Trim();
            if (string.IsNullOrEmpty(patientFullName))
            {
                MessageBox.Show("Please enter a patient's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = db.Patients.FirstOrDefault(p => (p.FirstName + " " + p.LastName) == patientFullName);
            if (patient == null)
            {
                MessageBox.Show("Patient not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int pid = patient.PatientId;
            string doctorFullName = comEdit_doctor.Text.Trim();
            if (string.IsNullOrEmpty(doctorFullName))
            {
                MessageBox.Show("Please select a doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctor = db.Doctors.Include(d => d.User).Include(d => d.Dept)
                .FirstOrDefault(d => (d.User.FName + " " + d.User.LName) == doctorFullName);
            if (doctor == null)
            {
                MessageBox.Show("Doctor not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int doctorId = doctor.DoctorDetailsId;
            int doctorUserId = doctor.UserId ?? 1;
            string specializationOrDept = doctor.Dept?.DeptName ?? doctor.Specialization ?? "Not Available";

            if (comboBox_date.SelectedItem == null || comboBox_date.SelectedItem.ToString() == "No Schedule")
            {
                MessageBox.Show("Please select a valid appointment time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSchedule = comboBox_date.SelectedItem.ToString();
            DateTime finalAppointmentDateTime;
            if (!DateTime.TryParseExact(comboBox_date.SelectedItem.ToString(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out finalAppointmentDateTime))
            {
                MessageBox.Show("Invalid appointment format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var existingAppointment = db.Appointments
                .FirstOrDefault(a => a.PatientId == pid && a.AppointmentDateTime == finalAppointmentDateTime);

            if (existingAppointment != null)
            {
                MessageBox.Show("This patient already has an appointment at the selected time.", "Duplicate Appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var availableAppointment = db.Appointments
                .FirstOrDefault(a => a.DoctorDetailsId == doctorId &&
                                   a.AppointmentDateTime == finalAppointmentDateTime &&
                                   a.PatientId == null);

            if (availableAppointment != null)
            {
                availableAppointment.PatientId = pid;
                availableAppointment.Note = txt_note.Text;
                availableAppointment.ReminderSent = reminder;
                db.SaveChanges();
                MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            if (reminder)
            {
                SendConfirmationEmail(patient.Email, patientFullName, doctorFullName, specializationOrDept, finalAppointmentDateTime);
            }

            ClearFields();
            HomeRecp homeRecp = new HomeRecp(userid);
            homeRecp.Reload();
        }
        private void ClearFields()
        {
            txt_note.Clear();
            txt_SearchPatient.Clear();
            comboxEdit_dept.SelectedIndex = 0;
            comEdit_doctor.SelectedIndex = 0;
            comboBox_date.Clear();

        }
        private void dgv_doctors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_doctors.Rows[e.RowIndex];
                string doctorName = row.Cells["FullName"].Value?.ToString() ?? "";
                string departmentName = row.Cells["DeptName"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(doctorName))
                {
                    MessageBox.Show("Invalid selection. No doctor found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                comEdit_doctor.Text = doctorName;
                comboxEdit_dept.Text = departmentName;

                var doctor = db.Doctors
                               .Include(d => d.doctorSchedule)
                               .Include(d => d.User)
                               .Include(d => d.Dept)
                               .FirstOrDefault(d => (d.User.FName + " " + d.User.LName) == doctorName);

                if (doctor == null)
                {
                    MessageBox.Show("Doctor not found in the database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                comboBox_date.Properties.Items.Clear();
                var availableSchedules = db.Doctor_Schedules
                    .Where(s => s.DoctorDetailsId == doctor.DoctorDetailsId && s.ScheduleDay > DateTime.Now)
                    .Select(s => s.ScheduleDay)
                    .ToList();
                var bookedAppointments = db.Appointments
                    .Where(a => a.DoctorDetailsId == doctor.DoctorDetailsId && a.PatientId != null)
                    .Select(a => a.AppointmentDateTime)
                    .ToList();
                var freeSchedules = availableSchedules
                    .Where(s => !bookedAppointments.Contains(s))
                    .OrderBy(d => d)
                    .ToList();
                if (freeSchedules.Any())
                {
                    foreach (var schedule in freeSchedules)
                    {
                        comboBox_date.Properties.Items.Add(schedule.ToString("yyyy-MM-dd HH:mm"));
                    }
                    comboBox_date.SelectedIndex = 0;
                }
                else
                {
                    comboBox_date.Properties.Items.Add("No Available Slots");
                    comboBox_date.SelectedIndex = 0;
                }
            }


        }

  
    }
}