using Dapper;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class HomePageDoctor : Form
    {
        HospitalSystemContext db;
        private User _loggedUser;
        SqlConnection con;
        public HomePageDoctor(User loggedUser)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            _loggedUser = loggedUser;
        }
        public void loadDataOfHomePage()
        {
            var query = db.Users.Where(n => n.doctorDetails.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId)
                             .Select(n => new { FullName = n.FName + " " + n.LName });
            label36.Text = query.FirstOrDefault().FullName;
            dgv_patientListHome.DataSource = db.Patients
                .Join(db.Appointments,
                    p => p.PatientId,
                    a => a.PatientId,
                    (p, a) => new { Patient = p, Appointment = a })
                .Where(x => x.Appointment.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId)
                .Select(x => new
                {
                    x.Patient.PatientId,
                    FullName = x.Patient.FirstName + " " + x.Patient.LastName
                })
                .ToList();
            dgv_patientListHome.Columns["PatientId"].Visible = false;
            LoadAppointments(DateTime.Today);
        }
        private void LoadAppointments(DateTime selectedDate)
        {
            var dt = new System.Data.DataTable();
            dt.Columns.Add("AppointmentId", typeof(int));
            dt.Columns.Add("Appointment Time", typeof(DateTime));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Note", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("StatusIcon", typeof(Image)); 

            var results = con.Query(
                @"SELECT A.AppointmentId, A.AppointmentDateTime, A.Status, A.Note, P.FirstName, P.LastName 
                  FROM Appointments A 
                  INNER JOIN Patients P ON A.PatientId = P.PatientId 
                  WHERE A.DoctorDetailsId = @doctorId 
                  AND CAST(A.AppointmentDateTime AS DATE) = @selectedDate
                  ORDER BY A.AppointmentDateTime ASC",
                new
                {
                    doctorId = _loggedUser.doctorDetails.DoctorDetailsId,
                    selectedDate = selectedDate.Date
                });

            foreach (var row in results)
            {
                string statusName = Enum.GetName(typeof(AppointmentStatus), row.Status) ?? "Unknown";
                dt.Rows.Add(row.AppointmentId, row.AppointmentDateTime, statusName, row.Note,
                           row.FirstName, row.LastName, GetStatusIcon(statusName));
            }
            dgv_upcommingAppointmentHomePage.DataSource = dt;
            dgv_upcommingAppointmentHomePage.Columns["AppointmentId"].Visible = false;
            btnReset.Visible = false;
            btnFilter.Visible = true;
        }

        private Image GetStatusIcon(string status)
        {
            switch (status)
            {
                case "Upcoming": return Properties.Resources.IconUpcoming; 
                case "Cancel": return Properties.Resources.IconCancel;   
                case "Done": return Properties.Resources.IconDone;     
                default: return null;
            }
        }
        private void HomePageDoctor_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
            loadDataOfHomePage();
            dgv_upcommingAppointmentHomePage.CellFormatting += dgv_upcommingAppointmentHomePage_CellFormatting;
        }

       
      
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = ((DateTimePicker)Controls["dtpFilterDate"]).Value;
            LoadAppointments(selectedDate);
            btnReset.Visible = true;
            btnFilter.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          Reload();
        }
        private void NotifyUser(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_upcommingAppointmentHomePage_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_upcommingAppointmentHomePage.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
                {
                    string status = e.Value.ToString();
                    DataGridViewRow row = dgv_upcommingAppointmentHomePage.Rows[e.RowIndex];
                    if (status == "Upcoming")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    else if (status == "Cancel")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else if (status == "Done")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }  
                }
            }
        }
        public void Reload()
        {
            dtpFilterDate.Value = DateTime.Today;
            loadDataOfHomePage();
            btnReset.Visible = false;
            btnFilter.Visible = true;
        }
    }
}
