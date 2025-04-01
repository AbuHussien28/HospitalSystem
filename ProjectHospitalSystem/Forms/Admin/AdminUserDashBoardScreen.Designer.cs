namespace ProjectHospitalSystem.Forms.Admin
{
    partial class AdminUserDashBoardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserDashBoardScreen));
            imageList1 = new ImageList(components);
            AdminTabContol = new MaterialSkin.Controls.MaterialTabControl();
            tabPageHome = new TabPage();
            panelHome = new Panel();
            label5 = new Label();
            tabPageAdminRole = new TabPage();
            panelAdmin = new Panel();
            label4 = new Label();
            tabPageDoctor = new TabPage();
            panelDoctorData = new Panel();
            label1 = new Label();
            tabPageReceptionsit = new TabPage();
            panelReceptionsit = new Panel();
            label2 = new Label();
            tabPagePaientent = new TabPage();
            panelPatient = new Panel();
            label3 = new Label();
            tabPageDepartment = new TabPage();
            panelDepartment = new Panel();
            tabPagePaymentMethod = new TabPage();
            panelPaymentMethod = new Panel();
            tabPageReports = new TabPage();
            panelReports = new Panel();
            tabAppoinments = new TabPage();
            panelAppoiments = new Panel();
            tabPageLogOut = new TabPage();
            timerDt = new System.Windows.Forms.Timer(components);
            lblDateTime = new Label();
            panel1 = new Panel();
            AdminTabContol.SuspendLayout();
            tabPageHome.SuspendLayout();
            panelHome.SuspendLayout();
            tabPageAdminRole.SuspendLayout();
            panelAdmin.SuspendLayout();
            tabPageDoctor.SuspendLayout();
            panelDoctorData.SuspendLayout();
            tabPageReceptionsit.SuspendLayout();
            panelReceptionsit.SuspendLayout();
            tabPagePaientent.SuspendLayout();
            panelPatient.SuspendLayout();
            tabPageDepartment.SuspendLayout();
            tabPagePaymentMethod.SuspendLayout();
            tabPageReports.SuspendLayout();
            tabAppoinments.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconDepartments.png");
            imageList1.Images.SetKeyName(1, "IconDoctor.png");
            imageList1.Images.SetKeyName(2, "IconPaientent.png");
            imageList1.Images.SetKeyName(3, "IconPaymentMethod.png");
            imageList1.Images.SetKeyName(4, "IconReceptionsit.png");
            imageList1.Images.SetKeyName(5, "IconReport.png");
            imageList1.Images.SetKeyName(6, "IconHome.png");
            imageList1.Images.SetKeyName(7, "IconLogout.png");
            imageList1.Images.SetKeyName(8, "IconAppoimnet.png");
            imageList1.Images.SetKeyName(9, "IconAdminTab.png");
            // 
            // AdminTabContol
            // 
            AdminTabContol.Controls.Add(tabPageHome);
            AdminTabContol.Controls.Add(tabPageAdminRole);
            AdminTabContol.Controls.Add(tabPageDoctor);
            AdminTabContol.Controls.Add(tabPageReceptionsit);
            AdminTabContol.Controls.Add(tabPagePaientent);
            AdminTabContol.Controls.Add(tabPageDepartment);
            AdminTabContol.Controls.Add(tabPagePaymentMethod);
            AdminTabContol.Controls.Add(tabPageReports);
            AdminTabContol.Controls.Add(tabAppoinments);
            AdminTabContol.Controls.Add(tabPageLogOut);
            AdminTabContol.Depth = 0;
            AdminTabContol.Dock = DockStyle.Fill;
            AdminTabContol.ImageList = imageList1;
            AdminTabContol.Location = new Point(3, 64);
            AdminTabContol.MouseState = MaterialSkin.MouseState.HOVER;
            AdminTabContol.Multiline = true;
            AdminTabContol.Name = "AdminTabContol";
            AdminTabContol.SelectedIndex = 0;
            AdminTabContol.Size = new Size(1611, 806);
            AdminTabContol.TabIndex = 1;
            AdminTabContol.SelectedIndexChanged += AdminTabContol_SelectedIndexChanged;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.FromArgb(254, 251, 244);
            tabPageHome.Controls.Add(panelHome);
            tabPageHome.ImageKey = "IconHome.png";
            tabPageHome.Location = new Point(4, 31);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1603, 771);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.FromArgb(254, 251, 244);
            panelHome.Controls.Add(label5);
            panelHome.Dock = DockStyle.Fill;
            panelHome.Location = new Point(3, 3);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1597, 765);
            panelHome.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(0, 748);
            label5.Name = "label5";
            label5.Size = new Size(0, 17);
            label5.TabIndex = 42;
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPageAdminRole
            // 
            tabPageAdminRole.Controls.Add(panelAdmin);
            tabPageAdminRole.ImageKey = "IconAdminTab.png";
            tabPageAdminRole.Location = new Point(4, 31);
            tabPageAdminRole.Name = "tabPageAdminRole";
            tabPageAdminRole.Padding = new Padding(3);
            tabPageAdminRole.Size = new Size(1603, 771);
            tabPageAdminRole.TabIndex = 9;
            tabPageAdminRole.Text = "Admin";
            tabPageAdminRole.UseVisualStyleBackColor = true;
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.FromArgb(254, 251, 244);
            panelAdmin.Controls.Add(label4);
            panelAdmin.Dock = DockStyle.Fill;
            panelAdmin.Location = new Point(3, 3);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(1597, 765);
            panelAdmin.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 748);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 42;
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPageDoctor
            // 
            tabPageDoctor.Controls.Add(panelDoctorData);
            tabPageDoctor.ImageKey = "IconDoctor.png";
            tabPageDoctor.Location = new Point(4, 31);
            tabPageDoctor.Name = "tabPageDoctor";
            tabPageDoctor.Padding = new Padding(3);
            tabPageDoctor.Size = new Size(1603, 771);
            tabPageDoctor.TabIndex = 1;
            tabPageDoctor.Text = "Doctor";
            tabPageDoctor.UseVisualStyleBackColor = true;
            tabPageDoctor.Click += tabPageDoctor_Click;
            // 
            // panelDoctorData
            // 
            panelDoctorData.BackColor = Color.FromArgb(254, 251, 244);
            panelDoctorData.Controls.Add(label1);
            panelDoctorData.Dock = DockStyle.Fill;
            panelDoctorData.Location = new Point(3, 3);
            panelDoctorData.Name = "panelDoctorData";
            panelDoctorData.Size = new Size(1597, 765);
            panelDoctorData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 748);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 42;
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPageReceptionsit
            // 
            tabPageReceptionsit.Controls.Add(panelReceptionsit);
            tabPageReceptionsit.ImageKey = "IconReceptionsit.png";
            tabPageReceptionsit.Location = new Point(4, 31);
            tabPageReceptionsit.Name = "tabPageReceptionsit";
            tabPageReceptionsit.Size = new Size(1603, 771);
            tabPageReceptionsit.TabIndex = 2;
            tabPageReceptionsit.Text = "Receptionsit";
            tabPageReceptionsit.UseVisualStyleBackColor = true;
            // 
            // panelReceptionsit
            // 
            panelReceptionsit.BackColor = Color.FromArgb(254, 251, 244);
            panelReceptionsit.Controls.Add(label2);
            panelReceptionsit.Dock = DockStyle.Fill;
            panelReceptionsit.Location = new Point(0, 0);
            panelReceptionsit.Name = "panelReceptionsit";
            panelReceptionsit.Size = new Size(1603, 771);
            panelReceptionsit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 754);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 42;
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPagePaientent
            // 
            tabPagePaientent.Controls.Add(panelPatient);
            tabPagePaientent.ImageKey = "IconPaientent.png";
            tabPagePaientent.Location = new Point(4, 31);
            tabPagePaientent.Name = "tabPagePaientent";
            tabPagePaientent.Size = new Size(1603, 771);
            tabPagePaientent.TabIndex = 3;
            tabPagePaientent.Text = "patient";
            tabPagePaientent.UseVisualStyleBackColor = true;
            // 
            // panelPatient
            // 
            panelPatient.AutoScroll = true;
            panelPatient.AutoSize = true;
            panelPatient.BackColor = Color.FromArgb(254, 251, 244);
            panelPatient.Controls.Add(label3);
            panelPatient.Dock = DockStyle.Fill;
            panelPatient.Location = new Point(0, 0);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(1603, 771);
            panelPatient.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 754);
            label3.Name = "label3";
            label3.Size = new Size(0, 17);
            label3.TabIndex = 42;
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tabPageDepartment
            // 
            tabPageDepartment.BackColor = Color.FromArgb(254, 251, 244);
            tabPageDepartment.Controls.Add(panelDepartment);
            tabPageDepartment.ImageKey = "IconDepartments.png";
            tabPageDepartment.Location = new Point(4, 31);
            tabPageDepartment.Name = "tabPageDepartment";
            tabPageDepartment.Size = new Size(1603, 771);
            tabPageDepartment.TabIndex = 4;
            tabPageDepartment.Text = "Department";
            // 
            // panelDepartment
            // 
            panelDepartment.Dock = DockStyle.Fill;
            panelDepartment.Location = new Point(0, 0);
            panelDepartment.Name = "panelDepartment";
            panelDepartment.Size = new Size(1603, 771);
            panelDepartment.TabIndex = 1;
            // 
            // tabPagePaymentMethod
            // 
            tabPagePaymentMethod.Controls.Add(panelPaymentMethod);
            tabPagePaymentMethod.ImageKey = "IconPaymentMethod.png";
            tabPagePaymentMethod.Location = new Point(4, 31);
            tabPagePaymentMethod.Name = "tabPagePaymentMethod";
            tabPagePaymentMethod.Size = new Size(1603, 771);
            tabPagePaymentMethod.TabIndex = 5;
            tabPagePaymentMethod.Text = "Payment Methods";
            tabPagePaymentMethod.UseVisualStyleBackColor = true;
            // 
            // panelPaymentMethod
            // 
            panelPaymentMethod.BackColor = Color.FromArgb(254, 251, 244);
            panelPaymentMethod.Dock = DockStyle.Fill;
            panelPaymentMethod.Location = new Point(0, 0);
            panelPaymentMethod.Name = "panelPaymentMethod";
            panelPaymentMethod.Size = new Size(1603, 771);
            panelPaymentMethod.TabIndex = 2;
            // 
            // tabPageReports
            // 
            tabPageReports.Controls.Add(panelReports);
            tabPageReports.ImageKey = "IconReport.png";
            tabPageReports.Location = new Point(4, 31);
            tabPageReports.Name = "tabPageReports";
            tabPageReports.Size = new Size(1603, 771);
            tabPageReports.TabIndex = 6;
            tabPageReports.Text = "Reports";
            tabPageReports.UseVisualStyleBackColor = true;
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.FromArgb(254, 251, 244);
            panelReports.Dock = DockStyle.Fill;
            panelReports.Location = new Point(0, 0);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(1603, 771);
            panelReports.TabIndex = 3;
            // 
            // tabAppoinments
            // 
            tabAppoinments.Controls.Add(panelAppoiments);
            tabAppoinments.ImageKey = "IconAppoimnet.png";
            tabAppoinments.Location = new Point(4, 31);
            tabAppoinments.Name = "tabAppoinments";
            tabAppoinments.Size = new Size(1603, 771);
            tabAppoinments.TabIndex = 8;
            tabAppoinments.Text = "Appoinment";
            tabAppoinments.UseVisualStyleBackColor = true;
            // 
            // panelAppoiments
            // 
            panelAppoiments.BackColor = Color.FromArgb(254, 251, 244);
            panelAppoiments.Dock = DockStyle.Fill;
            panelAppoiments.Location = new Point(0, 0);
            panelAppoiments.Name = "panelAppoiments";
            panelAppoiments.Size = new Size(1603, 771);
            panelAppoiments.TabIndex = 3;
            // 
            // tabPageLogOut
            // 
            tabPageLogOut.ImageKey = "IconLogout.png";
            tabPageLogOut.Location = new Point(4, 31);
            tabPageLogOut.Name = "tabPageLogOut";
            tabPageLogOut.Size = new Size(1603, 771);
            tabPageLogOut.TabIndex = 7;
            tabPageLogOut.Text = "Log Out";
            tabPageLogOut.UseVisualStyleBackColor = true;
            // 
            // timerDt
            // 
            timerDt.Tick += timerDt_Tick;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(32, 13);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 15);
            lblDateTime.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 251, 244);
            panel1.Controls.Add(lblDateTime);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 823);
            panel1.Name = "panel1";
            panel1.Size = new Size(1611, 47);
            panel1.TabIndex = 2;
            // 
            // AdminUserDashBoardScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1617, 873);
            Controls.Add(panel1);
            Controls.Add(AdminTabContol);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = AdminTabContol;
            Name = "AdminUserDashBoardScreen";
            Text = "AdminUserDashBoardScreen";
            WindowState = FormWindowState.Maximized;
            Load += AdminUserDashBoardScreen_Load;
            AdminTabContol.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            tabPageAdminRole.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            tabPageDoctor.ResumeLayout(false);
            panelDoctorData.ResumeLayout(false);
            panelDoctorData.PerformLayout();
            tabPageReceptionsit.ResumeLayout(false);
            panelReceptionsit.ResumeLayout(false);
            panelReceptionsit.PerformLayout();
            tabPagePaientent.ResumeLayout(false);
            tabPagePaientent.PerformLayout();
            panelPatient.ResumeLayout(false);
            panelPatient.PerformLayout();
            tabPageDepartment.ResumeLayout(false);
            tabPagePaymentMethod.ResumeLayout(false);
            tabPageReports.ResumeLayout(false);
            tabAppoinments.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private MaterialSkin.Controls.MaterialTabControl AdminTabContol;
        private TabPage tabPageHome;
        private TabPage tabPageDoctor;
        private TabPage tabPageReceptionsit;
        private TabPage tabPagePaientent;
        private TabPage tabPageDepartment;
        private TabPage tabPagePaymentMethod;
        private TabPage tabPageReports;
        private TabPage tabPageLogOut;
        private Panel panelDoctorData;
        private Panel panelReceptionsit;
        private Panel panelPatient;
        private Panel panelDepartment;
        private Panel panelPaymentMethod;
        private TabPage tabAppoinments;
        private Panel panelAppoiments;
        private System.Windows.Forms.Timer timerDt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panelReports;
        private Label lblDateTime;
        private Panel panel1;
        private TabPage tabPageAdminRole;
        private Panel panelAdmin;
        private Label label4;
        private Panel panelHome;
        private Label label5;
    }
}