﻿namespace ProjectHospitalSystem.Forms.Admin
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
            // 
            // AdminTabContol
            // 
            AdminTabContol.Controls.Add(tabPageHome);
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
            tabPageHome.ImageKey = "IconHome.png";
            tabPageHome.Location = new Point(4, 31);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1603, 771);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
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
            panelDoctorData.Location = new Point(-1, 3);
            panelDoctorData.Name = "panelDoctorData";
            panelDoctorData.Size = new Size(1513, 946);
            panelDoctorData.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 929);
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
            panelReceptionsit.Location = new Point(6, 8);
            panelReceptionsit.Name = "panelReceptionsit";
            panelReceptionsit.Size = new Size(1509, 651);
            panelReceptionsit.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 634);
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
            panelPatient.Controls.Add(label3);
            panelPatient.Location = new Point(3, 3);
            panelPatient.Name = "panelPatient";
            panelPatient.Size = new Size(1662, 934);
            panelPatient.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 917);
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
            panelDepartment.Location = new Point(3, 3);
            panelDepartment.Name = "panelDepartment";
            panelDepartment.Size = new Size(1539, 702);
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
            panelPaymentMethod.Location = new Point(3, 3);
            panelPaymentMethod.Name = "panelPaymentMethod";
            panelPaymentMethod.Size = new Size(1512, 702);
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
            panelReports.Location = new Point(3, 3);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(1512, 702);
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
            panelAppoiments.Location = new Point(3, 3);
            panelAppoiments.Name = "panelAppoiments";
            panelAppoiments.Size = new Size(1543, 702);
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
    }
}