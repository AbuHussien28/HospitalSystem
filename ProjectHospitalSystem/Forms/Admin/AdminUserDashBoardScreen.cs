﻿using MaterialSkin;
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
using ProjectHospitalSystem.Reports;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class AdminUserDashBoardScreen : MaterialForm
    {
        User User;
        private AdminDoctorCRUDOpeartionForm doctorForm;
        private AdminReceptionsitCRUDOpeartion receptionistForm;
        private AdminPatientCRUD AdminPatientCRUD;
        private AdminDepartmentCRUD AdminDepartmentCRUD;
        private AdminPaymentMethod AdminPaymentMethod;
        private Appointment_Form Appointment_Form;
        private Reports_Logging Reports;
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
            AdminPatientCRUD = new AdminPatientCRUD(User);
            AdminDepartmentCRUD = new AdminDepartmentCRUD();
            AdminPaymentMethod = new AdminPaymentMethod();
            Appointment_Form = new Appointment_Form();
            Reports = new Reports_Logging();

        }

        private void AdminUserDashBoardScreen_Load(object sender, EventArgs e)
        {
            InitializeDateTime();
        }
        private void tabPageHome_Click(object sender, EventArgs e)
        {

        }
        private void tabPageDoctor_Click(object sender, EventArgs e)
        {
        }

        private void AdminTabContol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTab = AdminTabContol.SelectedTab;

            if (selectedTab == tabPageDoctor)
            {
                LoadForm(doctorForm, panelDoctorData);
                doctorForm.Reload();
            }
            else if (selectedTab == tabPageReceptionsit)
            {
                LoadForm(receptionistForm, panelReceptionsit);
            }
            else if (selectedTab == tabPagePaientent)
            {
                LoadForm(AdminPatientCRUD, panelPatient);
            }
            else if (selectedTab == tabPageDepartment)
            {
                LoadForm(AdminDepartmentCRUD, panelDepartment);
            }
            else if (selectedTab == tabPagePaymentMethod)
            {
                LoadForm(AdminPaymentMethod, panelPaymentMethod);
            }
            else if (selectedTab == tabPageReports)
            {
                LoadForm(Reports, panelReports);
            }
            else if (selectedTab == tabAppoinments)
            {
                LoadForm(Appointment_Form, panelAppoiments);
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

    }
}
