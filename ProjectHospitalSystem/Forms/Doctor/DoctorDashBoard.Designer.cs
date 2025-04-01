namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class DoctorDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDashBoard));
            docTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPageHome = new TabPage();
            panelHome = new Panel();
            tabPagePatients = new TabPage();
            panelPatient = new Panel();
            tabPageMedicalRecord = new TabPage();
            panelMedical = new Panel();
            tabPageAllAppoinments = new TabPage();
            panelAppointmets = new Panel();
            tabPageProfile = new TabPage();
            panelProfile = new Panel();
            tabPageLogOut = new TabPage();
            panelLogOut = new Panel();
            imageList1 = new ImageList(components);
            timerDt = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblDateTime = new Label();
            docTabControl.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageMedicalRecord.SuspendLayout();
            tabPageAllAppoinments.SuspendLayout();
            tabPageProfile.SuspendLayout();
            tabPageLogOut.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // docTabControl
            // 
            docTabControl.Controls.Add(tabPageHome);
            docTabControl.Controls.Add(tabPagePatients);
            docTabControl.Controls.Add(tabPageMedicalRecord);
            docTabControl.Controls.Add(tabPageAllAppoinments);
            docTabControl.Controls.Add(tabPageProfile);
            docTabControl.Controls.Add(tabPageLogOut);
            docTabControl.Depth = 0;
            docTabControl.Dock = DockStyle.Fill;
            docTabControl.ImageList = imageList1;
            docTabControl.Location = new Point(3, 64);
            docTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            docTabControl.Multiline = true;
            docTabControl.Name = "docTabControl";
            docTabControl.SelectedIndex = 0;
            docTabControl.Size = new Size(1210, 711);
            docTabControl.TabIndex = 11;
            docTabControl.SelectedIndexChanged += docTabControl_SelectedIndexChanged;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.FromArgb(254, 251, 244);
            tabPageHome.Controls.Add(panelHome);
            tabPageHome.ImageKey = "IconHome.png";
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1202, 683);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // panelHome
            // 
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(3, 3);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1196, 677);
            panelHome.TabIndex = 0;
            // 
            // tabPagePatients
            // 
            tabPagePatients.BackColor = Color.FromArgb(254, 251, 244);
            tabPagePatients.BackgroundImageLayout = ImageLayout.None;
            tabPagePatients.Controls.Add(panelPatient);
            tabPagePatients.ImageKey = "IconPaientent.png";
            tabPagePatients.Location = new Point(4, 24);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Size = new Size(1202, 683);
            tabPagePatients.TabIndex = 4;
            tabPagePatients.Text = "Patients";
            // 
            // panelPatient
            // 
            panelPatient.BackColor = Color.FromArgb(254, 251, 244);
            panelPatient.Dock = DockStyle.Fill;
            panelPatient.Location = new Point(0, 0);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(1202, 683);
            panelPatient.TabIndex = 1;
            // 
            // tabPageMedicalRecord
            // 
            tabPageMedicalRecord.BackColor = Color.FromArgb(254, 251, 244);
            tabPageMedicalRecord.Controls.Add(panelMedical);
            tabPageMedicalRecord.ImageKey = "IconDoctorMedicalRecord.png";
            tabPageMedicalRecord.Location = new Point(4, 24);
            tabPageMedicalRecord.Name = "tabPageMedicalRecord";
            tabPageMedicalRecord.Size = new Size(1202, 683);
            tabPageMedicalRecord.TabIndex = 6;
            tabPageMedicalRecord.Text = "Medical Record";
            // 
            // panelMedical
            // 
            panelMedical.Dock = DockStyle.Fill;
            panelMedical.Location = new Point(0, 0);
            panelMedical.Name = "panelMedical";
            panelMedical.Size = new Size(1202, 683);
            panelMedical.TabIndex = 0;
            // 
            // tabPageAllAppoinments
            // 
            tabPageAllAppoinments.BackColor = Color.FromArgb(254, 251, 244);
            tabPageAllAppoinments.Controls.Add(panelAppointmets);
            tabPageAllAppoinments.ImageKey = "IconAppoimnet.png";
            tabPageAllAppoinments.Location = new Point(4, 24);
            tabPageAllAppoinments.Name = "tabPageAllAppoinments";
            tabPageAllAppoinments.Padding = new Padding(3);
            tabPageAllAppoinments.Size = new Size(1202, 683);
            tabPageAllAppoinments.TabIndex = 1;
            tabPageAllAppoinments.Text = "Appointments";
            // 
            // panelAppointmets
            // 
            panelAppointmets.BackColor = Color.FromArgb(254, 251, 244);
            panelAppointmets.Dock = DockStyle.Fill;
            panelAppointmets.Location = new Point(3, 3);
            panelAppointmets.Name = "panelAppointmets";
            panelAppointmets.Size = new Size(1196, 677);
            panelAppointmets.TabIndex = 0;
            // 
            // tabPageProfile
            // 
            tabPageProfile.BackColor = Color.FromArgb(254, 251, 244);
            tabPageProfile.Controls.Add(panelProfile);
            tabPageProfile.ImageKey = "IconProfileForm.png";
            tabPageProfile.Location = new Point(4, 24);
            tabPageProfile.Name = "tabPageProfile";
            tabPageProfile.Size = new Size(1202, 683);
            tabPageProfile.TabIndex = 2;
            tabPageProfile.Text = "Profile";
            // 
            // panelProfile
            // 
            panelProfile.Dock = DockStyle.Fill;
            panelProfile.Location = new Point(0, 0);
            panelProfile.Name = "panelProfile";
            panelProfile.Size = new Size(1202, 683);
            panelProfile.TabIndex = 0;
            // 
            // tabPageLogOut
            // 
            tabPageLogOut.Controls.Add(panelLogOut);
            tabPageLogOut.ImageKey = "IconLogout.png";
            tabPageLogOut.Location = new Point(4, 24);
            tabPageLogOut.Name = "tabPageLogOut";
            tabPageLogOut.Size = new Size(1202, 683);
            tabPageLogOut.TabIndex = 5;
            tabPageLogOut.Text = "Log Out";
            tabPageLogOut.UseVisualStyleBackColor = true;
            // 
            // panelLogOut
            // 
            panelLogOut.BackColor = Color.FromArgb(254, 251, 244);
            panelLogOut.Location = new Point(3, 3);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(1406, 884);
            panelLogOut.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconPatientData.png");
            imageList1.Images.SetKeyName(1, "IconMedical.png");
            imageList1.Images.SetKeyName(2, "IconDoctorAppoiment.png");
            imageList1.Images.SetKeyName(3, "IconProfileForm.png");
            imageList1.Images.SetKeyName(4, "IconHome.png");
            imageList1.Images.SetKeyName(5, "IconLogout.png");
            imageList1.Images.SetKeyName(6, "IconPaientent.png");
            imageList1.Images.SetKeyName(7, "IconDailyApp.png");
            imageList1.Images.SetKeyName(8, "IconAppoimnet.png");
            imageList1.Images.SetKeyName(9, "IconDoctorMedicalRecord.png");
            // 
            // timerDt
            // 
            timerDt.Tick += timerDt_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 251, 244);
            panel1.Controls.Add(lblDateTime);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 730);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 45);
            panel1.TabIndex = 14;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(32, 13);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 15);
            lblDateTime.TabIndex = 0;
            // 
            // DoctorDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1216, 778);
            Controls.Add(panel1);
            Controls.Add(docTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = docTabControl;
            Name = "DoctorDashBoard";
            Text = "DoctorDashBoard";
            WindowState = FormWindowState.Maximized;
            Load += DoctorDashBoard_Load;
            docTabControl.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            tabPageMedicalRecord.ResumeLayout(false);
            tabPageAllAppoinments.ResumeLayout(false);
            tabPageProfile.ResumeLayout(false);
            tabPageLogOut.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl docTabControl;
        private TabPage tabPageHome;
        private Panel panelHome;
        private TabPage tabPagePatients;
        private Panel panelPatient;
        private TabPage tabPageAllAppoinments;
        private Panel panelAppointmets;
        private TabPage tabPageProfile;
        private TabPage tabPageLogOut;
        private Panel panelLogOut;
        private TabPage tabPageMedicalRecord;
        private Panel panelMedical;
        private Panel panelProfile;
        private System.Windows.Forms.Timer timerDt;
        private Panel panel1;
        private Label lblDateTime;
        private ImageList imageList1;
    }
}