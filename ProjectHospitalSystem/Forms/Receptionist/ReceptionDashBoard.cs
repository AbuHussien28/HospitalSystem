using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Forms.Admin;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Reports;
using System.Data;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class ReceptionDashBoard : MaterialForm
    {
        int userid; 
        User user;
        private Appointments appointments;
        private Bills bills;
        private Reports_Logging Reports;
        private PaitenitCRUD paitenit;
        private HomeRecp HomeRecp;
        private AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
        public ReceptionDashBoard(User user)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
            InitializeComponent();
            this.user = user;
            userid = user.UserId;
            appointments = new Appointments(userid);
            bills = new Bills();
            Reports = new Reports_Logging();
            paitenit = new PaitenitCRUD(user);
            HomeRecp = new HomeRecp(userid);
            RecpTabControl.SelectedIndexChanged += RecpTabControl_SelectedIndexChanged;

        }


        private void Receptionist_Load(object sender, EventArgs e)
        {
            RecpTabControl.SelectedTab = tabPageHome;
            LoadForm(HomeRecp, panelHome);
            HomeRecp.Reload();
            InitializeDateTime();
        }

       
        private void RecpTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = RecpTabControl.SelectedTab;
            if (selectedTab == tabPageHome) 
            {
                HomeRecp.Reload();
            }
                
           else if (selectedTab == tabPagePatients)
            {
                paitenit = new PaitenitCRUD(user);
                LoadForm(paitenit, panelPatient);
                paitenit.Reload();
            }
            else if (selectedTab == tabPageAllAppoinments)
            {
                appointments = new Appointments(userid);
                LoadForm(appointments, panelAppointmets);
                appointments.Reload();
            }
            else if (selectedTab == tabPageBills)
            {
                bills = new Bills();
                LoadForm(bills, panelBills);
                bills.Reload();
            }
            else if (selectedTab == tabPageReports)
            {
                Reports = new Reports_Logging();
                LoadForm(Reports, panelReports);
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
        private void timerDt_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy | hh:mm:ss tt");
        }
        private void Logout()
        {
            // Dispose of all forms
            paitenit?.Dispose();
            appointments?.Dispose();
            bills?.Dispose();
            Reports?.Dispose();
            HomeRecp?.Dispose();
            this.Hide();
            Form welcomeScreen = Application.OpenForms["WelcomeScreen"];
            welcomeScreen.Show();
        }
    }
}
