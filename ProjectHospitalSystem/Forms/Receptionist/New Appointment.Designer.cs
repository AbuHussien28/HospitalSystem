namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class New_Appointment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lab_remider = new Label();
            Rbtn_sent = new RadioButton();
            Rbtn_Nsent = new RadioButton();
            dgv_doctors = new DataGridView();
            icon = new DataGridViewImageColumn();
            pnlDoctorDetails = new Panel();
            comboBox_date = new DevExpress.XtraEditors.ComboBoxEdit();
            comboxEdit_dept = new DevExpress.XtraEditors.ComboBoxEdit();
            comEdit_doctor = new DevExpress.XtraEditors.ComboBoxEdit();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            lb_Phone = new Label();
            txt_note = new TextBox();
            lb_Specialization = new Label();
            lb_DoctorEmail = new Label();
            txt_SearchPatient = new TextBox();
            lb_patientName = new Label();
            btn_bookApp = new Button();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).BeginInit();
            pnlDoctorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBox_date.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboxEdit_dept.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comEdit_doctor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lab_remider
            // 
            lab_remider.AutoSize = true;
            lab_remider.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lab_remider.ImeMode = ImeMode.NoControl;
            lab_remider.Location = new Point(41, 114);
            lab_remider.Name = "lab_remider";
            lab_remider.Size = new Size(112, 21);
            lab_remider.TabIndex = 59;
            lab_remider.Text = "Remider Sent";
            // 
            // Rbtn_sent
            // 
            Rbtn_sent.AutoSize = true;
            Rbtn_sent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Rbtn_sent.ImeMode = ImeMode.NoControl;
            Rbtn_sent.Location = new Point(195, 116);
            Rbtn_sent.Name = "Rbtn_sent";
            Rbtn_sent.Size = new Size(62, 25);
            Rbtn_sent.TabIndex = 61;
            Rbtn_sent.TabStop = true;
            Rbtn_sent.Text = "Sent";
            Rbtn_sent.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Nsent
            // 
            Rbtn_Nsent.AutoSize = true;
            Rbtn_Nsent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Rbtn_Nsent.ImeMode = ImeMode.NoControl;
            Rbtn_Nsent.Location = new Point(276, 116);
            Rbtn_Nsent.Name = "Rbtn_Nsent";
            Rbtn_Nsent.Size = new Size(99, 25);
            Rbtn_Nsent.TabIndex = 62;
            Rbtn_Nsent.TabStop = true;
            Rbtn_Nsent.Text = "Not Send";
            Rbtn_Nsent.UseVisualStyleBackColor = true;
            // 
            // dgv_doctors
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_doctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_doctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_doctors.BackgroundColor = Color.White;
            dgv_doctors.BorderStyle = BorderStyle.None;
            dgv_doctors.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_doctors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_doctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_doctors.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_doctors.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_doctors.EnableHeadersVisualStyles = false;
            dgv_doctors.Location = new Point(12, 71);
            dgv_doctors.MultiSelect = false;
            dgv_doctors.Name = "dgv_doctors";
            dgv_doctors.RowHeadersVisible = false;
            dgv_doctors.RowTemplate.Height = 40;
            dgv_doctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_doctors.Size = new Size(1082, 288);
            dgv_doctors.TabIndex = 104;
            dgv_doctors.CellDoubleClick += dgv_doctors_CellDoubleClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconAppoinmentDgv;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // pnlDoctorDetails
            // 
            pnlDoctorDetails.BackColor = Color.WhiteSmoke;
            pnlDoctorDetails.Controls.Add(comboBox_date);
            pnlDoctorDetails.Controls.Add(comboxEdit_dept);
            pnlDoctorDetails.Controls.Add(comEdit_doctor);
            pnlDoctorDetails.Controls.Add(pictureBox3);
            pnlDoctorDetails.Controls.Add(pictureBox1);
            pnlDoctorDetails.Controls.Add(label1);
            pnlDoctorDetails.Controls.Add(pictureBox10);
            pnlDoctorDetails.Controls.Add(pictureBox2);
            pnlDoctorDetails.Controls.Add(pictureBox6);
            pnlDoctorDetails.Controls.Add(pictureBox9);
            pnlDoctorDetails.Controls.Add(Rbtn_sent);
            pnlDoctorDetails.Controls.Add(lab_remider);
            pnlDoctorDetails.Controls.Add(Rbtn_Nsent);
            pnlDoctorDetails.Controls.Add(lb_Phone);
            pnlDoctorDetails.Controls.Add(txt_note);
            pnlDoctorDetails.Controls.Add(lb_Specialization);
            pnlDoctorDetails.Controls.Add(lb_DoctorEmail);
            pnlDoctorDetails.Controls.Add(txt_SearchPatient);
            pnlDoctorDetails.Controls.Add(lb_patientName);
            pnlDoctorDetails.Location = new Point(12, 388);
            pnlDoctorDetails.Name = "pnlDoctorDetails";
            pnlDoctorDetails.Size = new Size(890, 203);
            pnlDoctorDetails.TabIndex = 143;
            // 
            // comboBox_date
            // 
            comboBox_date.Location = new Point(184, 71);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            comboBox_date.Properties.Appearance.Options.UseFont = true;
            comboBox_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBox_date.Size = new Size(233, 28);
            comboBox_date.TabIndex = 149;
            // 
            // comboxEdit_dept
            // 
            comboxEdit_dept.Location = new Point(627, 71);
            comboxEdit_dept.Name = "comboxEdit_dept";
            comboxEdit_dept.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            comboxEdit_dept.Properties.Appearance.Options.UseFont = true;
            comboxEdit_dept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboxEdit_dept.Size = new Size(233, 28);
            comboxEdit_dept.TabIndex = 148;
            comboxEdit_dept.SelectedIndexChanged += comboxEdit_dept_SelectedIndexChanged;
            // 
            // comEdit_doctor
            // 
            comEdit_doctor.Location = new Point(627, 24);
            comEdit_doctor.Name = "comEdit_doctor";
            comEdit_doctor.Properties.Appearance.Font = new Font("Segoe UI", 12F);
            comEdit_doctor.Properties.Appearance.Options.UseFont = true;
            comEdit_doctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comEdit_doctor.Size = new Size(233, 28);
            comEdit_doctor.TabIndex = 147;
            comEdit_doctor.SelectedIndexChanged += comEdit_doctor_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconRemider;
            pictureBox3.Location = new Point(10, 114);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 144;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconDoctorData;
            pictureBox1.Location = new Point(429, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 123;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(462, 27);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 120;
            label1.Text = "Doctor Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.IconDepartment;
            pictureBox10.Location = new Point(429, 74);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 114;
            pictureBox10.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconLateFee;
            pictureBox2.Location = new Point(429, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 112;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconAddDate;
            pictureBox6.Location = new Point(11, 76);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.IconPaientent;
            pictureBox9.Location = new Point(11, 29);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 93;
            pictureBox9.TabStop = false;
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.BackColor = Color.Transparent;
            lb_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Phone.Location = new Point(459, 74);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(156, 21);
            lb_Phone.TabIndex = 106;
            lb_Phone.Text = "Department Name:";
            lb_Phone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_note
            // 
            txt_note.BackColor = Color.WhiteSmoke;
            txt_note.BorderStyle = BorderStyle.FixedSingle;
            txt_note.Font = new Font("Segoe UI", 12.75F);
            txt_note.ForeColor = Color.Black;
            txt_note.Location = new Point(627, 111);
            txt_note.Margin = new Padding(5);
            txt_note.Multiline = true;
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(233, 76);
            txt_note.TabIndex = 98;
            // 
            // lb_Specialization
            // 
            lb_Specialization.AutoSize = true;
            lb_Specialization.BackColor = Color.Transparent;
            lb_Specialization.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Specialization.Location = new Point(459, 113);
            lb_Specialization.Name = "lb_Specialization";
            lb_Specialization.Size = new Size(59, 21);
            lb_Specialization.TabIndex = 105;
            lb_Specialization.Text = "Notes:";
            lb_Specialization.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.BackColor = Color.Transparent;
            lb_DoctorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DoctorEmail.Location = new Point(41, 74);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(50, 21);
            lb_DoctorEmail.TabIndex = 103;
            lb_DoctorEmail.Text = "Date:";
            lb_DoctorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_SearchPatient
            // 
            txt_SearchPatient.BackColor = Color.WhiteSmoke;
            txt_SearchPatient.BorderStyle = BorderStyle.FixedSingle;
            txt_SearchPatient.Font = new Font("Segoe UI", 12.75F);
            txt_SearchPatient.ForeColor = Color.Black;
            txt_SearchPatient.Location = new Point(184, 27);
            txt_SearchPatient.Margin = new Padding(5);
            txt_SearchPatient.Name = "txt_SearchPatient";
            txt_SearchPatient.Size = new Size(233, 30);
            txt_SearchPatient.TabIndex = 90;
            // 
            // lb_patientName
            // 
            lb_patientName.AutoSize = true;
            lb_patientName.BackColor = Color.Transparent;
            lb_patientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_patientName.Location = new Point(41, 32);
            lb_patientName.Name = "lb_patientName";
            lb_patientName.Size = new Size(119, 21);
            lb_patientName.TabIndex = 89;
            lb_patientName.Text = "Patient Name:";
            lb_patientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_bookApp
            // 
            btn_bookApp.BackColor = Color.LimeGreen;
            btn_bookApp.Cursor = Cursors.Cross;
            btn_bookApp.FlatAppearance.BorderSize = 0;
            btn_bookApp.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_bookApp.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_bookApp.FlatStyle = FlatStyle.Flat;
            btn_bookApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_bookApp.ForeColor = Color.White;
            btn_bookApp.Image = Properties.Resources.IconReceptiGerentedDate;
            btn_bookApp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bookApp.Location = new Point(908, 446);
            btn_bookApp.Name = "btn_bookApp";
            btn_bookApp.Size = new Size(190, 53);
            btn_bookApp.TabIndex = 144;
            btn_bookApp.Text = "Book Appointment";
            btn_bookApp.TextAlign = ContentAlignment.MiddleRight;
            btn_bookApp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_bookApp.UseVisualStyleBackColor = false;
            btn_bookApp.Click += btn_bookApp_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconDailyApp;
            pictureBox4.Location = new Point(450, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 146;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(480, 23);
            label2.Name = "label2";
            label2.Size = new Size(267, 30);
            label2.TabIndex = 145;
            label2.Text = "Assign New Appointment";
            // 
            // New_Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1140, 642);
            Controls.Add(pictureBox4);
            Controls.Add(label2);
            Controls.Add(btn_bookApp);
            Controls.Add(pnlDoctorDetails);
            Controls.Add(dgv_doctors);
            Name = "New_Appointment";
            Text = "New_Appointment";
            Load += New_Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).EndInit();
            pnlDoctorDetails.ResumeLayout(false);
            pnlDoctorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBox_date.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboxEdit_dept.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comEdit_doctor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_patName;
        private Label lab_date;
        private Label lab_doc;
        private TextBox txt_note;
        private Label lab_note;
        private Label lab_remider;
        private RadioButton Rbtn_sent;
        private RadioButton Rbtn_Nsent;
        private Label lab_dept;
        private DataGridView dgv_doctors;
        private DataGridViewImageColumn icon;
        private Panel pnlDoctorDetails;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox10;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private RadioButton radioButton1;
        private Label lb_Phone;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private Label lb_Specialization;
        private Label lab_reminder;
        private Label lb_DoctorEmail;
        private TextBox txt_SearchPatient;
        private Label lb_patientName;
        private Button btn_bookApp;
        private PictureBox pictureBox4;
        private Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit comEdit_doctor;
        private DevExpress.XtraEditors.ComboBoxEdit comboBox_date;
        private DevExpress.XtraEditors.ComboBoxEdit comboxEdit_dept;
    }
}