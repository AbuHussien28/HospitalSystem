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
            tabPageDoctor = new TabPage();
            panelDoctorData = new Panel();
            tabPageReceptionsit = new TabPage();
            panelReceptionsit = new Panel();
            tabPagePaientent = new TabPage();
            tabPageDepartment = new TabPage();
            tabPagePaymentMethod = new TabPage();
            tabPageReports = new TabPage();
            tabPageLogOut = new TabPage();
            AdminTabContol.SuspendLayout();
            tabPageDoctor.SuspendLayout();
            tabPageReceptionsit.SuspendLayout();
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
            AdminTabContol.Controls.Add(tabPageLogOut);
            AdminTabContol.Depth = 0;
            AdminTabContol.Dock = DockStyle.Fill;
            AdminTabContol.ImageList = imageList1;
            AdminTabContol.Location = new Point(3, 64);
            AdminTabContol.MouseState = MaterialSkin.MouseState.HOVER;
            AdminTabContol.Multiline = true;
            AdminTabContol.Name = "AdminTabContol";
            AdminTabContol.SelectedIndex = 0;
            AdminTabContol.Size = new Size(1440, 636);
            AdminTabContol.TabIndex = 1;
            AdminTabContol.SelectedIndexChanged += AdminTabContol_SelectedIndexChanged;
            // 
            // tabPageHome
            // 
            tabPageHome.ImageKey = "IconHome.png";
            tabPageHome.Location = new Point(4, 31);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(1387, 601);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageDoctor
            // 
            tabPageDoctor.Controls.Add(panelDoctorData);
            tabPageDoctor.ImageKey = "IconDoctor.png";
            tabPageDoctor.Location = new Point(4, 31);
            tabPageDoctor.Name = "tabPageDoctor";
            tabPageDoctor.Padding = new Padding(3);
            tabPageDoctor.Size = new Size(1387, 601);
            tabPageDoctor.TabIndex = 1;
            tabPageDoctor.Text = "Doctor";
            tabPageDoctor.UseVisualStyleBackColor = true;
            tabPageDoctor.Click += tabPageDoctor_Click;
            // 
            // panelDoctorData
            // 
            panelDoctorData.Location = new Point(6, 3);
            panelDoctorData.Name = "panelDoctorData";
            panelDoctorData.Size = new Size(1255, 549);
            panelDoctorData.TabIndex = 1;
            // 
            // tabPageReceptionsit
            // 
            tabPageReceptionsit.Controls.Add(panelReceptionsit);
            tabPageReceptionsit.ImageKey = "IconReceptionsit.png";
            tabPageReceptionsit.Location = new Point(4, 31);
            tabPageReceptionsit.Name = "tabPageReceptionsit";
            tabPageReceptionsit.Size = new Size(1432, 601);
            tabPageReceptionsit.TabIndex = 2;
            tabPageReceptionsit.Text = "Receptionsit";
            tabPageReceptionsit.UseVisualStyleBackColor = true;
            // 
            // panelReceptionsit
            // 
            panelReceptionsit.Location = new Point(6, 8);
            panelReceptionsit.Name = "panelReceptionsit";
            panelReceptionsit.Size = new Size(1409, 590);
            panelReceptionsit.TabIndex = 2;
            // 
            // tabPagePaientent
            // 
            tabPagePaientent.ImageKey = "IconPaientent.png";
            tabPagePaientent.Location = new Point(4, 31);
            tabPagePaientent.Name = "tabPagePaientent";
            tabPagePaientent.Size = new Size(1387, 601);
            tabPagePaientent.TabIndex = 3;
            tabPagePaientent.Text = "Paientent";
            tabPagePaientent.UseVisualStyleBackColor = true;
            // 
            // tabPageDepartment
            // 
            tabPageDepartment.ImageKey = "IconDepartments.png";
            tabPageDepartment.Location = new Point(4, 31);
            tabPageDepartment.Name = "tabPageDepartment";
            tabPageDepartment.Size = new Size(1387, 601);
            tabPageDepartment.TabIndex = 4;
            tabPageDepartment.Text = "Department";
            tabPageDepartment.UseVisualStyleBackColor = true;
            // 
            // tabPagePaymentMethod
            // 
            tabPagePaymentMethod.ImageKey = "IconPaymentMethod.png";
            tabPagePaymentMethod.Location = new Point(4, 31);
            tabPagePaymentMethod.Name = "tabPagePaymentMethod";
            tabPagePaymentMethod.Size = new Size(1387, 601);
            tabPagePaymentMethod.TabIndex = 5;
            tabPagePaymentMethod.Text = "Payment Methods";
            tabPagePaymentMethod.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            tabPageReports.ImageKey = "IconReport.png";
            tabPageReports.Location = new Point(4, 31);
            tabPageReports.Name = "tabPageReports";
            tabPageReports.Size = new Size(1387, 601);
            tabPageReports.TabIndex = 6;
            tabPageReports.Text = "Reports";
            tabPageReports.UseVisualStyleBackColor = true;
            // 
            // tabPageLogOut
            // 
            tabPageLogOut.ImageKey = "IconLogout.png";
            tabPageLogOut.Location = new Point(4, 31);
            tabPageLogOut.Name = "tabPageLogOut";
            tabPageLogOut.Size = new Size(1387, 601);
            tabPageLogOut.TabIndex = 7;
            tabPageLogOut.Text = "Log Out";
            tabPageLogOut.UseVisualStyleBackColor = true;
            // 
            // AdminUserDashBoardScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1446, 703);
            Controls.Add(AdminTabContol);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = AdminTabContol;
            Name = "AdminUserDashBoardScreen";
            Text = "AdminUserDashBoardScreen";
            Load += AdminUserDashBoardScreen_Load;
            AdminTabContol.ResumeLayout(false);
            tabPageDoctor.ResumeLayout(false);
            tabPageReceptionsit.ResumeLayout(false);
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
    }
}