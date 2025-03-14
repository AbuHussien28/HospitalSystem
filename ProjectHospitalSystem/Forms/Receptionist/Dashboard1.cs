using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHospitalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class Dashboard1 : Form
    {
        int userid; HospitalSystemContext db;
       // private readonly MaterialSkinManager materialSkinManager;
        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
        public Dashboard1(int uid)
        {
            db = new HospitalSystemContext();
            InitializeComponent();
            ConfigureAutoComplete();
            userid = uid;
            //materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Blue800, Primary.Blue800, Primary.Blue800,
            //    Accent.LightBlue700, TextShade.WHITE
           // );
        }
        private async void ConfigureAutoComplete()
        {
            var patientNames = await db.Patients
                                       .Where(p => !string.IsNullOrEmpty(p.FirstName) && !string.IsNullOrEmpty(p.LastName))
                                       .Select(p => p.FirstName + " " + p.LastName)
                                       .ToListAsync();

            autoCompleteCollection.AddRange(patientNames.ToArray());

            txt_search_pat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_search_pat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_search_pat.AutoCompleteCustomSource = autoCompleteCollection;
        }
        
        private void Receptionist_Load(object sender, EventArgs e)
        {
            LoadTodayAppointments();
        }

        private void btn_patients_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients(userid);
            patients.Show();
        }

        private void btn_Appoint_Click(object sender, EventArgs e)
        {
            Appointments appointments = new Appointments();
            appointments.Show();
        }

        private void btn_bills_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
        }
        private void SearchPatients()
        {
            string searchText = txt_search_pat.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadTodayAppointments();
                return;
            }

            var patient = db.Patients
                            .Where(p => (p.FirstName + " " + p.LastName) == searchText)
                            .FirstOrDefault();

            if (patient != null)
            {
                var todayAppointments = db.Appointments
                                          .Include(a => a.Patient)
                                          .Include(a => a.Doctor)
                                          .Where(a => a.AppointmentDateTime.Date == DateTime.Today && a.PatientId == patient.PatientId)
                                          .Select(a => new
                                          {
                                              a.AppointmentId,
                                              PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                                              DoctorName = a.Doctor.User.FName + " " + a.Doctor.User.LName,
                                              AppointmentDateTime = a.AppointmentDateTime,
                                              a.Status
                                          })
                                          .OrderBy(a => a.AppointmentDateTime)
                                          .ToList();

                dgv_Appup.DataSource = todayAppointments;
            }
            else
            {
                dgv_Appup.DataSource = null; 
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {

        }

        private void btn_newApp_Click(object sender, EventArgs e)
        {
            New_Appointment new_Appointment = new New_Appointment(userid);
            new_Appointment.Show();
        }

        private void btn_paybill_Click(object sender, EventArgs e)
        {
            New_Patient _Patient = new New_Patient();
            _Patient.Show();
        }
        private void LoadTodayAppointments()
        {
            var todayAppointments = db.Appointments
                                      .Include(a => a.Patient)
                                      .Include(a => a.Doctor)
                                      .Where(a => a.AppointmentDateTime.Date == DateTime.Today)
                                      .Select(a => new
                                      {
                                          a.AppointmentId,
                                          PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                                          DoctorName = a.Doctor.User.FName + " " + a.Doctor.User.LName,
                                          AppointmentDateTime = a.AppointmentDateTime,
                                          a.Status
                                      })
                                      .OrderBy(a => a.AppointmentDateTime)
                                      .ToList();

            dgv_Appup.DataSource = todayAppointments;
        }
        private void dgv_Appup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_search_pat_TextChanged(object sender, EventArgs e)
        {
            SearchPatients();
        }
    }
}
