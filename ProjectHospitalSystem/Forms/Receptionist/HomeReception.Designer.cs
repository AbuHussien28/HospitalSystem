namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class HomeReception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeReception));
            RecpTabControl = new MaterialSkin.Controls.MaterialTabControl();
            tabPageHome = new TabPage();
            panelHome = new Panel();
            tabPagePatients = new TabPage();
            panelPatient = new Panel();
            tabPageAllAppoinments = new TabPage();
            panelAppointmets = new Panel();
            tabPageBills = new TabPage();
            panelBills = new Panel();
            tabPageReports = new TabPage();
            panelReports = new Panel();
            tabPageLogOut = new TabPage();
            panelLogOut = new Panel();
            imageList1 = new ImageList(components);
            timerDt = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblDateTime = new Label();
            RecpTabControl.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPagePatients.SuspendLayout();
            tabPageAllAppoinments.SuspendLayout();
            tabPageBills.SuspendLayout();
            tabPageReports.SuspendLayout();
            tabPageLogOut.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.FromArgb(254, 251, 244);
            tabPageHome.Controls.Add(panelHome);
            tabPageHome.ImageKey = "IconHome.png";
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1412, 777);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // panelHome
            // 
            panelHome.Location = new Point(6, 6);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1403, 722);
            panelHome.TabIndex = 0;
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
            panelPatient.Location = new Point(3, 3);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(1406, 884);
            panelPatient.TabIndex = 1;
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
            panelAppointmets.Location = new Point(6, 6);
            panelAppointmets.Name = "panelAppointmets";
            panelAppointmets.Size = new Size(1400, 881);
            panelAppointmets.TabIndex = 0;
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
            panelBills.Location = new Point(3, 3);
            panelBills.Name = "panelBills";
            panelBills.Size = new Size(1406, 884);
            panelBills.TabIndex = 1;
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
            panelReports.Location = new Point(3, 3);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(1406, 884);
            panelReports.TabIndex = 2;
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
            // HomeReception
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1426, 1031);
            Controls.Add(panel1);
            Controls.Add(RecpTabControl);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = RecpTabControl;
            Name = "HomeReception";
            Text = "Receptionist";
            WindowState = FormWindowState.Maximized;
            Load += Receptionist_Load;
            RecpTabControl.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPagePatients.ResumeLayout(false);
            tabPageAllAppoinments.ResumeLayout(false);
            tabPageBills.ResumeLayout(false);
            tabPageReports.ResumeLayout(false);
            tabPageLogOut.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl RecpTabControl;
        private TabPage tabPageHome;
        private TabPage tabPageAllAppoinments;
        private TabPage tabPageBills;
        private TabPage tabPageReports;
        private TabPage tabPagePatients;
        private Panel panel1;
        private TabPage tabPageLogOut;
        private ImageList imageList1;
        private Panel panelAppointmets;
        private Panel panelBills;
        private Panel panelReports;
        private Panel panelLogOut;
        private Panel panelPatient;
        private System.Windows.Forms.Timer timerDt;
        private Label lblDateTime;
        private Panel panelHome;
    }
}