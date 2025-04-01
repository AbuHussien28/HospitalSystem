namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class ReceptionDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceptionDashBoard));
            imageList1 = new ImageList(components);
            timerDt = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblDateTime = new Label();
            tabPageLogOut = new TabPage();
            panelLogOut = new Panel();
            tabPageReports = new TabPage();
            panelReports = new Panel();
            tabPageBills = new TabPage();
            panelBills = new Panel();
            tabPageAllAppoinments = new TabPage();
            panelAppointmets = new Panel();
            tabPagePatients = new TabPage();
            panelPatient = new Panel();
            tabPageHome = new TabPage();
            panelHome = new Panel();
            RecpTabControl = new MaterialSkin.Controls.MaterialTabControl();
            panel1.SuspendLayout();
            tabPageLogOut.SuspendLayout();
            tabPageReports.SuspendLayout();
            tabPageBills.SuspendLayout();
            tabPageAllAppoinments.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageHome.SuspendLayout();
            RecpTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconBill.png");
            imageList1.Images.SetKeyName(1, "IconDepartments.png");
            imageList1.Images.SetKeyName(2, "IconHome.png");
            imageList1.Images.SetKeyName(3, "IconPaientent.png");
            imageList1.Images.SetKeyName(4, "IconReport.png");
            imageList1.Images.SetKeyName(5, "IconLogout.png");
            imageList1.Images.SetKeyName(6, "IconAppoimnet.png");
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
            panel1.Location = new Point(3, 981);
            panel1.Name = "panel1";
            panel1.Size = new Size(1420, 47);
            panel1.TabIndex = 11;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(32, 13);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 15);
            lblDateTime.TabIndex = 0;
            // 
            // tabPageLogOut
            // 
            tabPageLogOut.Controls.Add(panelLogOut);
            tabPageLogOut.ImageKey = "IconLogout.png";
            tabPageLogOut.Location = new Point(4, 24);
            tabPageLogOut.Name = "tabPageLogOut";
            tabPageLogOut.Size = new Size(1412, 936);
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
            // tabPageReports
            // 
            tabPageReports.Controls.Add(panelReports);
            tabPageReports.ImageKey = "IconReport.png";
            tabPageReports.Location = new Point(4, 24);
            tabPageReports.Name = "tabPageReports";
            tabPageReports.Size = new Size(1412, 936);
            tabPageReports.TabIndex = 3;
            tabPageReports.Text = "Reports";
            tabPageReports.UseVisualStyleBackColor = true;
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.FromArgb(254, 251, 244);
            panelReports.Dock = DockStyle.Fill;
            panelReports.Location = new Point(0, 0);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(1412, 936);
            panelReports.TabIndex = 2;
            // 
            // tabPageBills
            // 
            tabPageBills.Controls.Add(panelBills);
            tabPageBills.ImageKey = "IconBill.png";
            tabPageBills.Location = new Point(4, 24);
            tabPageBills.Name = "tabPageBills";
            tabPageBills.Size = new Size(1412, 936);
            tabPageBills.TabIndex = 2;
            tabPageBills.Text = "Bills ";
            tabPageBills.UseVisualStyleBackColor = true;
            // 
            // panelBills
            // 
            panelBills.BackColor = Color.FromArgb(254, 251, 244);
            panelBills.Dock = DockStyle.Fill;
            panelBills.Location = new Point(0, 0);
            panelBills.Name = "panelBills";
            panelBills.Size = new Size(1412, 936);
            panelBills.TabIndex = 1;
            // 
            // tabPageAllAppoinments
            // 
            tabPageAllAppoinments.Controls.Add(panelAppointmets);
            tabPageAllAppoinments.ImageKey = "IconAppoimnet.png";
            tabPageAllAppoinments.Location = new Point(4, 24);
            tabPageAllAppoinments.Name = "tabPageAllAppoinments";
            tabPageAllAppoinments.Padding = new Padding(3);
            tabPageAllAppoinments.Size = new Size(1412, 936);
            tabPageAllAppoinments.TabIndex = 1;
            tabPageAllAppoinments.Text = "Appointments";
            tabPageAllAppoinments.UseVisualStyleBackColor = true;
            // 
            // panelAppointmets
            // 
            panelAppointmets.BackColor = Color.FromArgb(254, 251, 244);
            panelAppointmets.Dock = DockStyle.Fill;
            panelAppointmets.Location = new Point(3, 3);
            panelAppointmets.Name = "panelAppointmets";
            panelAppointmets.Size = new Size(1406, 930);
            panelAppointmets.TabIndex = 0;
            // 
            // tabPagePatients
            // 
            tabPagePatients.Controls.Add(panelPatient);
            tabPagePatients.ImageKey = "IconPaientent.png";
            tabPagePatients.Location = new Point(4, 24);
            tabPagePatients.Name = "tabPagePatients";
            tabPagePatients.Size = new Size(1412, 936);
            tabPagePatients.TabIndex = 4;
            tabPagePatients.Text = "Patients";
            tabPagePatients.UseVisualStyleBackColor = true;
            // 
            // panelPatient
            // 
            panelPatient.BackColor = Color.FromArgb(254, 251, 244);
            panelPatient.Dock = DockStyle.Fill;
            panelPatient.Location = new Point(0, 0);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(1412, 936);
            panelPatient.TabIndex = 1;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.FromArgb(254, 251, 244);
            tabPageHome.Controls.Add(panelHome);
            tabPageHome.ImageKey = "IconHome.png";
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1412, 936);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // panelHome
            // 
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(3, 3);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1406, 930);
            panelHome.TabIndex = 0;
            // 
            // RecpTabControl
            // 
            RecpTabControl.Controls.Add(tabPageHome);
            RecpTabControl.Controls.Add(tabPagePatients);
            RecpTabControl.Controls.Add(tabPageAllAppoinments);
            RecpTabControl.Controls.Add(tabPageBills);
            RecpTabControl.Controls.Add(tabPageReports);
            RecpTabControl.Controls.Add(tabPageLogOut);
            RecpTabControl.Depth = 0;
            RecpTabControl.Dock = DockStyle.Fill;
            RecpTabControl.ImageList = imageList1;
            RecpTabControl.Location = new Point(3, 64);
            RecpTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            RecpTabControl.Multiline = true;
            RecpTabControl.Name = "RecpTabControl";
            RecpTabControl.SelectedIndex = 0;
            RecpTabControl.Size = new Size(1420, 964);
            RecpTabControl.TabIndex = 10;
            RecpTabControl.SelectedIndexChanged += RecpTabControl_SelectedIndexChanged;
            // 
            // ReceptionDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1426, 1031);
            Controls.Add(panel1);
            Controls.Add(RecpTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = RecpTabControl;
            Name = "ReceptionDashBoard";
            Text = "Receptionist";
            WindowState = FormWindowState.Maximized;
            Load += Receptionist_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPageLogOut.ResumeLayout(false);
            tabPageReports.ResumeLayout(false);
            tabPageBills.ResumeLayout(false);
            tabPageAllAppoinments.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            RecpTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timerDt;
        private Label lblDateTime;
        private TabPage tabPageLogOut;
        private Panel panelLogOut;
        private TabPage tabPageReports;
        private Panel panelReports;
        private TabPage tabPageBills;
        private Panel panelBills;
        private TabPage tabPageAllAppoinments;
        private Panel panelAppointmets;
        private TabPage tabPagePatients;
        private Panel panelPatient;
        private TabPage tabPageHome;
        private Panel panelHome;
        private MaterialSkin.Controls.MaterialTabControl RecpTabControl;
    }
}