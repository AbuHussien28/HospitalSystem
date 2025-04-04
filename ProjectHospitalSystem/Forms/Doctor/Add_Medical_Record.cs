﻿using DocumentFormat.OpenXml.InkML;
using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class Add_Medical_Record : Form
    {
        private int? appointmentId;
        private int? patienId;
        private DateTime birthDateTime;
        HospitalSystemContext db;
        public Add_Medical_Record(int? appointmentId, int? patientId)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            this.appointmentId = appointmentId;
            patienId = patientId;
            patientName.Text = db.Patients.Where(n => n.PatientId == patientId).Select(n => n.FullName).FirstOrDefault();
            doctorName.Text = db.Appointments.Where(n => n.AppointmentId == appointmentId).Select(n => n.User.UserName).FirstOrDefault();
            deptName.Text = db.Departments.Join(db.Doctors, dept=>dept.DeptId,doc=>doc.DeptId,(dept,doc)=>new {dept.DeptName,doc.User.UserName}).Where(d=>d.UserName==doctorName.Text).Select(d => d.DeptName).FirstOrDefault();
            birthDateTime = db.Patients.Where(n => n.PatientId == patientId).Select(n => n.DateOfBirth).FirstOrDefault();
            patientAge.Text = (DateTime.Now.Year - birthDateTime.Year).ToString();
            patientDateVisit.Text = db.Appointments.Where(db=>db.PatientId==patientId && db.AppointmentId== appointmentId).Select(db => db.AppointmentDateTime).FirstOrDefault().ToString();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try 
            {
                if (string.IsNullOrEmpty(txt_Diaqnois.Text) || string.IsNullOrEmpty(txt_prescription.Text) || string.IsNullOrEmpty(txt_labresult.Text) || string.IsNullOrEmpty(txt_treatmentDeatis.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                MedicalRecord record = new MedicalRecord
                {
                    DateOfVist = DateTime.Now,
                    Diaqnois = txt_Diaqnois.Text,
                    Prescription = txt_prescription.Text,
                    LabResult = txt_labresult.Text,
                    TreatmentDetails = txt_treatmentDeatis.Text,
                };
                db.MedicalRecords.Add(record);
                db.SaveChanges();
                var appointment = db.Appointments.FirstOrDefault(a => a.AppointmentId == appointmentId);
                if (appointment == null)
                {
                    MessageBox.Show("Appointment not found.");
                    return;
                }
                appointment.medicalRecordId = record.MedicalId;
                db.SaveChanges();
                MessageBox.Show("Medical record created and associated with the appointment successfully!");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
    }
}
