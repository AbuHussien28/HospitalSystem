using MaterialSkin;
using MaterialSkin.Controls;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class AdminUserDashBoardScreen : MaterialForm
    {
        User User;
        private AdminDoctorCRUDOpeartionForm doctorForm;
        private AdminReceptionsitCRUDOpeartion receptionistForm;
        public AdminUserDashBoardScreen(User user)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
            User = user;
            AdminTabContol.SelectedIndexChanged += AdminTabContol_SelectedIndexChanged;
            doctorForm = new AdminDoctorCRUDOpeartionForm(User);
            receptionistForm = new AdminReceptionsitCRUDOpeartion(User);

        }

        private void AdminUserDashBoardScreen_Load(object sender, EventArgs e)
        {

        }

        private void tabPageHome_Click(object sender, EventArgs e)
        {

        }

        private void tabPageDoctor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test Doctor");
        }

        private void AdminTabContol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = AdminTabContol.SelectedTab;

            if (selectedTab == tabPageDoctor)
            {
                LoadForm(doctorForm, panelDoctorData);
            }
            else if (selectedTab == tabPageReceptionsit)
            {
                LoadForm(receptionistForm, panelReceptionsit);
            }
            else if (selectedTab == tabPagePaientent)
            {
                //LoadForm(patientForm, panelPatient);
            }
            else if (selectedTab == tabPageDepartment)
            {
                //LoadForm(appointmentForm, panelAppointment);
            }
            else if (selectedTab == tabPagePaymentMethod)
            {
                //LoadForm(appointmentForm, panelAppointment);
            }
            else if (selectedTab == tabPageReports)
            {
                //LoadForm(appointmentForm, panelAppointment);
            }
            else if (selectedTab == tabPageLogOut)
            {
                this.Hide();
                Form welcomeScreen = Application.OpenForms["WelcomeScreen"];
                welcomeScreen.Show();
            }
        }
        private void LoadForm(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.Show();
        }


    }
}
