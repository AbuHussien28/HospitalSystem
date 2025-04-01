namespace ProjectHospitalSystem.Forms.Admin
{
    partial class DashBoardForSystemAdmin
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panelDoctorWorkload = new Panel();
            panelDepartmentStats = new Panel();
            panelAppointments = new Panel();
            panelPatientDemographics = new Panel();
            panelKpi4 = new Panel();
            panelKpi3 = new Panel();
            panelKpi2 = new Panel();
            panelKpi1 = new Panel();
            lblStatus = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelDoctorWorkload, 1, 3);
            tableLayoutPanel1.Controls.Add(panelDepartmentStats, 0, 3);
            tableLayoutPanel1.Controls.Add(panelAppointments, 1, 2);
            tableLayoutPanel1.Controls.Add(panelPatientDemographics, 0, 2);
            tableLayoutPanel1.Controls.Add(panelKpi4, 1, 1);
            tableLayoutPanel1.Controls.Add(panelKpi3, 0, 1);
            tableLayoutPanel1.Controls.Add(panelKpi2, 1, 0);
            tableLayoutPanel1.Controls.Add(panelKpi1, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1102, 700);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelDoctorWorkload
            // 
            panelDoctorWorkload.BackColor = Color.FromArgb(254, 251, 244);
            panelDoctorWorkload.Dock = DockStyle.Fill;
            panelDoctorWorkload.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelDoctorWorkload.ForeColor = Color.Black;
            panelDoctorWorkload.Location = new Point(561, 472);
            panelDoctorWorkload.Margin = new Padding(10);
            panelDoctorWorkload.Name = "panelDoctorWorkload";
            panelDoctorWorkload.Padding = new Padding(10);
            panelDoctorWorkload.Size = new Size(521, 208);
            panelDoctorWorkload.TabIndex = 6;
            // 
            // panelDepartmentStats
            // 
            panelDepartmentStats.BackColor = Color.FromArgb(254, 251, 244);
            panelDepartmentStats.Dock = DockStyle.Fill;
            panelDepartmentStats.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelDepartmentStats.ForeColor = Color.Black;
            panelDepartmentStats.Location = new Point(20, 472);
            panelDepartmentStats.Margin = new Padding(10);
            panelDepartmentStats.Name = "panelDepartmentStats";
            panelDepartmentStats.Padding = new Padding(10);
            panelDepartmentStats.Size = new Size(521, 208);
            panelDepartmentStats.TabIndex = 5;
            // 
            // panelAppointments
            // 
            panelAppointments.BackColor = Color.FromArgb(254, 251, 244);
            panelAppointments.Dock = DockStyle.Fill;
            panelAppointments.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelAppointments.ForeColor = Color.Black;
            panelAppointments.Location = new Point(561, 246);
            panelAppointments.Margin = new Padding(10);
            panelAppointments.Name = "panelAppointments";
            panelAppointments.Padding = new Padding(10);
            panelAppointments.Size = new Size(521, 206);
            panelAppointments.TabIndex = 4;
            // 
            // panelPatientDemographics
            // 
            panelPatientDemographics.BackColor = Color.FromArgb(254, 251, 244);
            panelPatientDemographics.Dock = DockStyle.Fill;
            panelPatientDemographics.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelPatientDemographics.ForeColor = Color.Black;
            panelPatientDemographics.Location = new Point(20, 246);
            panelPatientDemographics.Margin = new Padding(10);
            panelPatientDemographics.Name = "panelPatientDemographics";
            panelPatientDemographics.Padding = new Padding(10);
            panelPatientDemographics.Size = new Size(521, 206);
            panelPatientDemographics.TabIndex = 1;
            // 
            // panelKpi4
            // 
            panelKpi4.BackColor = Color.White;
            panelKpi4.Dock = DockStyle.Fill;
            panelKpi4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelKpi4.ForeColor = Color.Black;
            panelKpi4.Location = new Point(561, 133);
            panelKpi4.Margin = new Padding(10);
            panelKpi4.Name = "panelKpi4";
            panelKpi4.Padding = new Padding(10);
            panelKpi4.Size = new Size(521, 93);
            panelKpi4.TabIndex = 3;
            // 
            // panelKpi3
            // 
            panelKpi3.BackColor = Color.White;
            panelKpi3.Dock = DockStyle.Fill;
            panelKpi3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelKpi3.ForeColor = Color.Black;
            panelKpi3.Location = new Point(20, 133);
            panelKpi3.Margin = new Padding(10);
            panelKpi3.Name = "panelKpi3";
            panelKpi3.Padding = new Padding(10);
            panelKpi3.Size = new Size(521, 93);
            panelKpi3.TabIndex = 2;
            // 
            // panelKpi2
            // 
            panelKpi2.BackColor = Color.White;
            panelKpi2.Dock = DockStyle.Fill;
            panelKpi2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelKpi2.ForeColor = Color.Black;
            panelKpi2.Location = new Point(561, 20);
            panelKpi2.Margin = new Padding(10);
            panelKpi2.Name = "panelKpi2";
            panelKpi2.Padding = new Padding(10);
            panelKpi2.Size = new Size(521, 93);
            panelKpi2.TabIndex = 1;
            // 
            // panelKpi1
            // 
            panelKpi1.BackColor = Color.White;
            panelKpi1.Dock = DockStyle.Fill;
            panelKpi1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            panelKpi1.ForeColor = Color.Black;
            panelKpi1.Location = new Point(20, 20);
            panelKpi1.Margin = new Padding(10);
            panelKpi1.Name = "panelKpi1";
            panelKpi1.Padding = new Padding(10);
            panelKpi1.Size = new Size(521, 93);
            panelKpi1.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.DarkSlateGray;
            lblStatus.Location = new Point(255, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(96, 32);
            lblStatus.TabIndex = 92;
            lblStatus.Text = "Fname:";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DashBoardForSystemAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1126, 831);
            Controls.Add(lblStatus);
            Controls.Add(tableLayoutPanel1);
            Name = "DashBoardForSystemAdmin";
            Text = "DashBoardForSystemAdmin";
            Load += DashBoardForSystemAdmin_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelAppointments;
        private Panel panelPatientDemographics;
        private Panel panelKpi4;
        private Panel panelKpi3;
        private Panel panelKpi2;
        private Panel panelKpi1;
        private Panel panelDoctorWorkload;
        private Panel panelDepartmentStats;
        private Label lblStatus;
    }
}