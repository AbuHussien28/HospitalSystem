namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class Dashboard1
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btn_report = new Button();
            btn_bills = new Button();
            btn_Appoint = new Button();
            btn_patients = new Button();
            btn_newApp = new Button();
            btn_paybill = new Button();
            dgv_Appup = new DataGridView();
            label1 = new Label();
            txt_search_pat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Appup).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            panelControl1.Controls.Add(btn_report);
            panelControl1.Controls.Add(btn_bills);
            panelControl1.Controls.Add(btn_Appoint);
            panelControl1.Controls.Add(btn_patients);
            panelControl1.Dock = DockStyle.Left;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(212, 440);
            panelControl1.TabIndex = 2;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.White;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_report.ForeColor = Color.Black;
            btn_report.Location = new Point(0, 287);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(207, 78);
            btn_report.TabIndex = 3;
            btn_report.Text = "Reports";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // btn_bills
            // 
            btn_bills.BackColor = Color.White;
            btn_bills.FlatStyle = FlatStyle.Flat;
            btn_bills.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bills.ForeColor = Color.Black;
            btn_bills.Location = new Point(0, 194);
            btn_bills.Name = "btn_bills";
            btn_bills.Size = new Size(207, 78);
            btn_bills.TabIndex = 2;
            btn_bills.Text = "Bills";
            btn_bills.UseVisualStyleBackColor = false;
            btn_bills.Click += btn_bills_Click;
            // 
            // btn_Appoint
            // 
            btn_Appoint.BackColor = Color.White;
            btn_Appoint.FlatStyle = FlatStyle.Flat;
            btn_Appoint.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Appoint.ForeColor = Color.Black;
            btn_Appoint.Location = new Point(0, 101);
            btn_Appoint.Name = "btn_Appoint";
            btn_Appoint.Size = new Size(207, 78);
            btn_Appoint.TabIndex = 1;
            btn_Appoint.Text = "Appointments ";
            btn_Appoint.UseVisualStyleBackColor = false;
            btn_Appoint.Click += btn_Appoint_Click;
            // 
            // btn_patients
            // 
            btn_patients.BackColor = Color.White;
            btn_patients.FlatStyle = FlatStyle.Flat;
            btn_patients.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_patients.ForeColor = Color.Black;
            btn_patients.Location = new Point(0, 5);
            btn_patients.Name = "btn_patients";
            btn_patients.Size = new Size(207, 78);
            btn_patients.TabIndex = 0;
            btn_patients.Text = "Patients";
            btn_patients.UseVisualStyleBackColor = false;
            btn_patients.Click += btn_patients_Click;
            // 
            // btn_newApp
            // 
            btn_newApp.BackColor = Color.White;
            btn_newApp.FlatStyle = FlatStyle.Flat;
            btn_newApp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_newApp.Location = new Point(306, 366);
            btn_newApp.Name = "btn_newApp";
            btn_newApp.Size = new Size(156, 56);
            btn_newApp.TabIndex = 4;
            btn_newApp.Text = "New Appointment";
            btn_newApp.UseVisualStyleBackColor = false;
            btn_newApp.Click += btn_newApp_Click;
            // 
            // btn_paybill
            // 
            btn_paybill.BackColor = Color.White;
            btn_paybill.FlatStyle = FlatStyle.Flat;
            btn_paybill.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_paybill.Location = new Point(475, 366);
            btn_paybill.Name = "btn_paybill";
            btn_paybill.Size = new Size(150, 56);
            btn_paybill.TabIndex = 6;
            btn_paybill.Text = "New Patient";
            btn_paybill.UseVisualStyleBackColor = false;
            btn_paybill.Click += btn_paybill_Click;
            // 
            // dgv_Appup
            // 
            dgv_Appup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Appup.Location = new Point(245, 74);
            dgv_Appup.Name = "dgv_Appup";
            dgv_Appup.Size = new Size(551, 277);
            dgv_Appup.TabIndex = 7;
            dgv_Appup.CellContentClick += dgv_Appup_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(383, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Patient Name";
            // 
            // txt_search_pat
            // 
            txt_search_pat.Location = new Point(488, 36);
            txt_search_pat.Name = "txt_search_pat";
            txt_search_pat.Size = new Size(137, 23);
            txt_search_pat.TabIndex = 9;
            txt_search_pat.TextChanged += txt_search_pat_TextChanged;
            // 
            // Dashboard1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 440);
            Controls.Add(txt_search_pat);
            Controls.Add(label1);
            Controls.Add(dgv_Appup);
            Controls.Add(btn_paybill);
            Controls.Add(btn_newApp);
            Controls.Add(panelControl1);
            Name = "Dashboard1";
            Text = "Receptionist";
            Load += Receptionist_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Appup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Button btn_patients;
        private Button btn_report;
        private Button btn_bills;
        private Button btn_Appoint;
        private Button btn_newApp;
        private Button btn_paybill;
        private DataGridView dgv_Appup;
        private Label label1;
        private TextBox txt_search_pat;
    }
}