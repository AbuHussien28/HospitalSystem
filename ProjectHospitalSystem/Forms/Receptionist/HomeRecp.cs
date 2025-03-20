using ProjectHospitalSystem.Forms.Admin;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class HomeRecp : Form
    {
        int userid;
        private HospitalSystemContext db;
        User user;
        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
        public HomeRecp(int uid)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            ConfigureAutoComplete();
            userid = uid;
            user = db.Users.Find(userid);
        }

        private async void ConfigureAutoComplete()
        {
            using (var db = new HospitalSystemContext()) 
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
            try
            {
                string searchText = txt_search_pat.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    LoadTodayAppointments();
                    return;
                }
                var patients = db.Patients
                                 .Where(p => (p.FirstName + " " + p.LastName).Contains(searchText))
                                 .ToList();

                if (patients.Any())
                {
                    var patientIds = patients.Select(p => p.PatientId).ToList();

                    var todayAppointments = db.Appointments
                                              .Include(a => a.Patient)
                                              .Include(a => a.Doctor)
                                              .Where(a => a.AppointmentDateTime.Date == DateTime.Today && patientIds.Contains(a.PatientId.Value))
                                              .Select(a => new
                                              {
                                                  a.AppointmentId,
                                                  PatientName = a.Patient.FirstName + " " + a.Patient.LastName,
                                                  DoctorName = a.Doctor.User.FName + " " + a.Doctor.User.LName,
                                                  AppointmentDateTime = a.AppointmentDateTime,
                                                  Status = a.Status.ToString()
                                              })
                                              .OrderBy(a => a.AppointmentDateTime)
                                              .ToList();

                    dgv_Appup.DataSource = todayAppointments;
                    AddCustomColumns();
                    CustomizeDataGridView();
                }
                else
                {
                    dgv_Appup.DataSource = null;
                    CustomizeDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for patients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_newApp_Click(object sender, EventArgs e)
        {
            New_Appointment new_Appointment = new New_Appointment(userid);
            new_Appointment.Show();
        }

        private void btn_paybill_Click(object sender, EventArgs e)
        {
            PaitenitCRUD paitenitCRUD = new PaitenitCRUD(user);
            paitenitCRUD.Show();
        }
        private void LoadTodayAppointments()
        {
            using (var db = new HospitalSystemContext()) 
            {
                var todayAppointments = db.Appointments
                           .Include(a => a.Patient)
                           .Include(a => a.Doctor)
                           .Where(a => a.AppointmentDateTime.Date == DateTime.Today)
                           .Select(a => new
                           {
                               a.AppointmentId,
                               PatientName = a.Patient != null ? a.Patient.FirstName + " " + a.Patient.LastName : "Not Assigned",
                               DoctorName = a.Doctor != null ? a.Doctor.User.FName + " " + a.Doctor.User.LName : "Not Assigned",
                               AppointmentDateTime = a.AppointmentDateTime,
                               Status = a.Status.ToString()
                           })
                           .OrderBy(a => a.AppointmentDateTime)
                           .ToList();

                if (todayAppointments != null && todayAppointments.Count > 0)
                {
                    dgv_Appup.DataSource = todayAppointments;
                    dgv_Appup.Columns["AppointmentId"].Visible = false;
                    AddCustomColumns();
                    CustomizeDataGridView();
                }
                else
                {
                    MessageBox.Show("No appointments found for today.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dailyAppointmentsLabel.Text = $"Total Appointments Today: {todayAppointments.Count}";
            }
        }
        private void dgv_Appup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_Appup.Columns[e.ColumnIndex].Name == "DetailsButton")
            {
                int appointmentId = Convert.ToInt32(dgv_Appup.Rows[e.RowIndex].Cells["AppointmentId"].Value);
                ShowAppointmentDetails(appointmentId);
            }
        }

        private void txt_search_pat_TextChanged(object sender, EventArgs e)
        {
            SearchPatients();
        }
        private void CustomizeDataGridView()
        {
            if (dgv_Appup.DataSource == null || dgv_Appup.Columns.Count == 0)
            {
                return;
            }
            if (!dgv_Appup.Columns.Contains("Status"))
            {
                MessageBox.Show("Column 'Status' not found in DataGridView. Check the query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dgv_Appup.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    string status = row.Cells["Status"]?.Value?.ToString();

                    if (status == "Done")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        row.Cells["StatusIcon"].Value = Properties.Resources.IconDone;
                    }
                    else if (status == "Upcoming")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        row.Cells["StatusIcon"].Value = Properties.Resources.IconUpcoming;
                    }
                    else if(status== "Cancel") 
                    {
                        row.DefaultCellStyle.BackColor = Color.RosyBrown;
                        row.Cells["StatusIcon"].Value = Properties.Resources.IconCanecel;
                    }
                    else 
                    {
                        row.DefaultCellStyle.BackColor = Color.Black;
                        row.Cells["StatusIcon"].Value = Properties.Resources.IconNotFound;
                    }
                }
            }
            foreach (DataGridViewRow row in dgv_Appup.Rows)
            {
                if (row.Cells["DetailsButton"] is DataGridViewButtonCell btnCell)
                {
                    btnCell.Style.BackColor = ColorTranslator.FromHtml("#2C3E50");
                    btnCell.Style.ForeColor = Color.White;
                    btnCell.Style.Font = new Font("Arial", 10, FontStyle.Bold);
                    btnCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DataGridViewButtonColumn btnColumn = (DataGridViewButtonColumn)dgv_Appup.Columns["DetailsButton"];
                    btnColumn.FlatStyle = FlatStyle.Flat;
                }
            }
        }
        private void ShowAppointmentDetails(int appointmentId)
        {
            panelShowDetails.Visible= true;
            var appointment = db.Appointments
                                .Include(a => a.Patient)
                                .Include(a => a.Doctor)
                                .FirstOrDefault(a => a.AppointmentId == appointmentId);

            if (appointment != null)
            {
                lb_PatientNameData.Text = appointment.Patient != null ? appointment.Patient.FirstName + " " + appointment.Patient.LastName : "Not Assigned";
                lb_DoctorNameData.Text = appointment.Doctor != null ? appointment.Doctor.User.FName + " " + appointment.Doctor.User.LName : "Not Assigned";
                lb_AppoimData.Text = appointment.AppointmentDateTime.ToString("dddd, dd MMMM yyyy | hh:mm tt");
                lb_PatientStatusData.Text = appointment.Status.ToString();
                if (appointment.Status.ToString() == "Done")
                {
                    lb_PatientStatusData.ForeColor = Color.Green;
                    pcBoxStatus.Image = Properties.Resources.IconDone;
                }
                else if (appointment.Status.ToString() == "Upcoming")
                {
                    lb_PatientStatusData.ForeColor = Color.Blue;
                    pcBoxStatus.Image = Properties.Resources.IconUpcoming;
                }
                else if (appointment.Status.ToString() == "Cancel")
                {
                    lb_PatientStatusData.ForeColor = Color.RosyBrown;
                    pcBoxStatus.Image = Properties.Resources.IconCanecel;
                }
                else
                {
                    lb_PatientStatusData.ForeColor = Color.Black;
                    pcBoxStatus.Image = Properties.Resources.IconNotFound;
                }
            }
            else
            {
                lb_PatientNameData.Text = "Not Assigned";
                lb_DoctorNameData.Text = "Not Assigned";
                lb_AppoimData.Text = "Not Assigned";
                lb_PatientStatusData.Text = "Not Assigned";
                pcBoxStatus.Image = null;
            }
        }

        private void AddCustomColumns()
        {
            if (dgv_Appup.DataSource == null)
                return;
            if (dgv_Appup.Columns.Contains("StatusIcon"))
                dgv_Appup.Columns.Remove("StatusIcon");

            if (dgv_Appup.Columns.Contains("DetailsButton"))
                dgv_Appup.Columns.Remove("DetailsButton");
            int statusColumnIndex = -1;
            for (int i = 0; i < dgv_Appup.Columns.Count; i++)
            {
                if (dgv_Appup.Columns[i].Name == "Status")
                {
                    statusColumnIndex = i;
                    break;
                }
            }

            if (statusColumnIndex == -1)
                return;
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "StatusIcon";
            imgColumn.HeaderText = "Status Icon";
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_Appup.Columns.Insert(statusColumnIndex + 1, imgColumn);
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "DetailsButton";
            btnColumn.HeaderText = "Details";
            btnColumn.Text = "Show Details";
            btnColumn.UseColumnTextForButtonValue = true;
            dgv_Appup.Columns.Insert(statusColumnIndex + 2, btnColumn);
            CustomizeDataGridView();
        }

        private void btn_newPaitent_Click(object sender, EventArgs e)
        {
            PaitenitCRUD paitenitCRUD = new PaitenitCRUD(user);
            paitenitCRUD.Show();
        }
        public void Reload()
        {
            LoadTodayAppointments();
            txt_search_pat.Clear();
            panelShowDetails.Visible = false;
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }
        private int GetDailyAppointmentsCount()
        {
            using (var db = new HospitalSystemContext()) 
            {
                try
                {
                    return db.Appointments.Count(a => a.AppointmentDateTime.Date == DateTime.Today);

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }
    }
}
