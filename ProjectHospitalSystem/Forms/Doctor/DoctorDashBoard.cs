using MaterialSkin;
using MaterialSkin.Controls;
using ProjectHospitalSystem.Forms.Admin;
using ProjectHospitalSystem.Forms.Receptionist;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class DoctorDashBoard : MaterialForm
    {
        private DoctorAppointmentToday DoctorAppointmentToday;
        private DoctorProfileForm DoctorProfileForm;
        private MedicalRecordForm MedicalRecordForm;
        private PatientDoctorsForm PatientDoctorsForm;
        private HomePageDoctor HomePageDoctor;
        private System.Windows.Forms.Timer reminderTimer;
        private User user;
        private HospitalSystemContext db;
        private int _doctorId;
        private NotifyIcon notifyIcon;
        public DoctorDashBoard(User user)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
            InitializeComponent();
            this.user = user;
            db = new HospitalSystemContext();
            _doctorId = user.doctorDetails.DoctorDetailsId;
            DoctorAppointmentToday = new DoctorAppointmentToday(user);
            DoctorProfileForm = new DoctorProfileForm(user);
            MedicalRecordForm = new MedicalRecordForm(user.doctorDetails.DoctorDetailsId);
            PatientDoctorsForm = new PatientDoctorsForm(user);
            HomePageDoctor = new HomePageDoctor(user);
            InitializeNotifyIcon();
            SetupReminders();
        }
        private void InitializeNotifyIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information; // You can use a custom icon: notifyIcon.Icon = Properties.Resources.YourCustomIcon;
            notifyIcon.Visible = true;
            notifyIcon.Text = "Hospital System";

            // Create context menu for the notify icon
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem openItem = new ToolStripMenuItem("Open Hospital System");
            openItem.Click += (s, e) => { this.Show(); this.WindowState = FormWindowState.Normal; };
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Exit");
            exitItem.Click += (s, e) => { Application.Exit(); };

            contextMenu.Items.Add(openItem);
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add(exitItem);

            notifyIcon.ContextMenuStrip = contextMenu;

            // Double-click to show the form
            notifyIcon.DoubleClick += (s, e) => { this.Show(); this.WindowState = FormWindowState.Normal; };
        }
        private void DoctorDashBoard_Load(object sender, EventArgs e)
        {
            docTabControl.SelectedTab = tabPageHome;
            LoadForm(HomePageDoctor, panelHome);
            HomePageDoctor.Reload();
            InitializeDateTime();
        }
        private void SetupReminders()
        {
            reminderTimer = new System.Windows.Forms.Timer();
            reminderTimer.Interval = 60000; 
            reminderTimer.Tick += CheckAppointments;
            reminderTimer.Start();
        }
        private void CheckAppointments(object sender, EventArgs e)
        {
            var upcomingAppointments = db.Appointments
                .Where(a => a.DoctorDetailsId == _doctorId &&
                           a.AppointmentDateTime > DateTime.Now &&
                           a.AppointmentDateTime <= DateTime.Now.AddMinutes(5) &&
                           a.Status == (int)AppointmentStatus.Upcoming)
                .ToList();

            foreach (var appointment in upcomingAppointments)
            {
                string patientName = db.Patients
                    .Where(p => p.PatientId == appointment.PatientId)
                    .Select(p => p.FirstName + " " + p.LastName)
                    .FirstOrDefault();

                ShowNotification($"You have an appointment with {patientName} after 5 minutes", "Appointment Reminder");
            }
        }
        private void ShowNotification(string message, string title)
        {
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.ShowBalloonTip(5000);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
                ShowNotification("Hospital System is still running in the background", "Information");
                return;
            }
            if (reminderTimer != null)
            {
                reminderTimer.Stop();
                reminderTimer.Dispose();
            }
            if (notifyIcon != null)
            {
                notifyIcon.Visible = false;
                notifyIcon.Dispose();
            }

            db?.Dispose();
            base.OnFormClosing(e);
            db?.Dispose();
        }

    

        private void docTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = docTabControl.SelectedTab;
            if (selectedTab == tabPageHome)
            {
                HomePageDoctor.Reload();
            }

            else if (selectedTab == tabPagePatients)
            {
                LoadForm(PatientDoctorsForm, panelPatient);
                PatientDoctorsForm.Reload();
            }
            else if (selectedTab == tabPageMedicalRecord)
            {
                LoadForm(MedicalRecordForm, panelMedical);
                MedicalRecordForm.Reload();
            }
            else if (selectedTab == tabPageAllAppoinments)
            {
                LoadForm(DoctorAppointmentToday, panelAppointmets);
                DoctorAppointmentToday.Reload();
            }
            else if (selectedTab == tabPageProfile)
            {
                LoadForm(DoctorProfileForm, panelProfile);
                DoctorProfileForm.Reload();
            }
            else if (selectedTab == tabPageLogOut)
            {
                Logout();
            }
        }
        private void LoadForm(Form form, Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }
        private void InitializeDateTime()
        {
            timerDt.Interval = 1000;
            timerDt.Tick += timerDt_Tick;
            timerDt.Start();
        }
        private void Logout()
        {
            DoctorProfileForm?.Dispose();
            DoctorAppointmentToday?.Dispose();
            MedicalRecordForm?.Dispose();
            HomePageDoctor?.Dispose();
            PatientDoctorsForm?.Dispose();
            if (notifyIcon != null)
            {
                notifyIcon.Visible = false;
            }
            this.Hide();
            Form welcomeScreen = Application.OpenForms["WelcomeScreen"];
            welcomeScreen.Show();
        }

        private void timerDt_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | hh:mm:ss tt");
        }
    }
}
