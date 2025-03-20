namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class Appointments
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
            Rbtn_Nsent = new RadioButton();
            Rbtn_sent = new RadioButton();
            lab_reminder = new Label();
            dgv_appointments = new DataGridView();
            pictureBox8 = new PictureBox();
            txt_search = new TextBox();
            lbPatienitNameSearch = new Label();
            comb_searchBy = new ComboBox();
            pnlDoctorDetails = new Panel();
            pictureBox3 = new PictureBox();
            combx_status = new ComboBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            txt_doctor = new TextBox();
            label1 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox9 = new PictureBox();
            txt_dept = new TextBox();
            lb_Phone = new Label();
            txt_note = new TextBox();
            lb_Specialization = new Label();
            lb_LastNameDoctor = new Label();
            txt_date = new TextBox();
            lb_DoctorEmail = new Label();
            txt_patient = new TextBox();
            lb_patientName = new Label();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_new = new Button();
            icon = new DataGridViewImageColumn();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            pnlDoctorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // Rbtn_Nsent
            // 
            Rbtn_Nsent.AutoSize = true;
            Rbtn_Nsent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Rbtn_Nsent.Location = new Point(302, 148);
            Rbtn_Nsent.Name = "Rbtn_Nsent";
            Rbtn_Nsent.Size = new Size(51, 25);
            Rbtn_Nsent.TabIndex = 10;
            Rbtn_Nsent.TabStop = true;
            Rbtn_Nsent.Text = "No";
            Rbtn_Nsent.UseVisualStyleBackColor = true;
            // 
            // Rbtn_sent
            // 
            Rbtn_sent.AutoSize = true;
            Rbtn_sent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Rbtn_sent.Location = new Point(221, 148);
            Rbtn_sent.Name = "Rbtn_sent";
            Rbtn_sent.Size = new Size(53, 25);
            Rbtn_sent.TabIndex = 9;
            Rbtn_sent.TabStop = true;
            Rbtn_sent.Text = "Yes";
            Rbtn_sent.UseVisualStyleBackColor = true;
            // 
            // lab_reminder
            // 
            lab_reminder.AutoSize = true;
            lab_reminder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lab_reminder.Location = new Point(41, 148);
            lab_reminder.Name = "lab_reminder";
            lab_reminder.Size = new Size(126, 21);
            lab_reminder.TabIndex = 23;
            lab_reminder.Text = "Reminder Sent:";
            // 
            // dgv_appointments
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_appointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_appointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointments.BackgroundColor = Color.White;
            dgv_appointments.BorderStyle = BorderStyle.None;
            dgv_appointments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_appointments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_appointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointments.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_appointments.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_appointments.EnableHeadersVisualStyles = false;
            dgv_appointments.Location = new Point(12, 119);
            dgv_appointments.MultiSelect = false;
            dgv_appointments.Name = "dgv_appointments";
            dgv_appointments.RowHeadersVisible = false;
            dgv_appointments.RowTemplate.Height = 40;
            dgv_appointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_appointments.Size = new Size(1039, 288);
            dgv_appointments.TabIndex = 103;
            dgv_appointments.CellDoubleClick += dgv_appointments_CellDoubleClick;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.IconPatientSerach;
            pictureBox8.Location = new Point(12, 69);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 109;
            pictureBox8.TabStop = false;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search.ForeColor = Color.Gray;
            txt_search.Location = new Point(383, 69);
            txt_search.Margin = new Padding(5);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search by Name";
            txt_search.Size = new Size(233, 29);
            txt_search.TabIndex = 2;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // lbPatienitNameSearch
            // 
            lbPatienitNameSearch.AutoSize = true;
            lbPatienitNameSearch.BackColor = Color.Transparent;
            lbPatienitNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbPatienitNameSearch.Location = new Point(42, 72);
            lbPatienitNameSearch.Name = "lbPatienitNameSearch";
            lbPatienitNameSearch.Size = new Size(84, 21);
            lbPatienitNameSearch.TabIndex = 107;
            lbPatienitNameSearch.Text = "Search By";
            lbPatienitNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comb_searchBy
            // 
            comb_searchBy.BackColor = Color.White;
            comb_searchBy.Font = new Font("Segoe UI", 12F);
            comb_searchBy.ForeColor = Color.Black;
            comb_searchBy.FormattingEnabled = true;
            comb_searchBy.Location = new Point(132, 69);
            comb_searchBy.Name = "comb_searchBy";
            comb_searchBy.Size = new Size(233, 29);
            comb_searchBy.TabIndex = 1;
            comb_searchBy.SelectedIndexChanged += comb_searchBy_SelectedIndexChanged;
            // 
            // pnlDoctorDetails
            // 
            pnlDoctorDetails.BackColor = Color.WhiteSmoke;
            pnlDoctorDetails.Controls.Add(pictureBox3);
            pnlDoctorDetails.Controls.Add(combx_status);
            pnlDoctorDetails.Controls.Add(pictureBox4);
            pnlDoctorDetails.Controls.Add(pictureBox1);
            pnlDoctorDetails.Controls.Add(txt_doctor);
            pnlDoctorDetails.Controls.Add(label1);
            pnlDoctorDetails.Controls.Add(pictureBox10);
            pnlDoctorDetails.Controls.Add(pictureBox2);
            pnlDoctorDetails.Controls.Add(pictureBox6);
            pnlDoctorDetails.Controls.Add(pictureBox9);
            pnlDoctorDetails.Controls.Add(txt_dept);
            pnlDoctorDetails.Controls.Add(Rbtn_Nsent);
            pnlDoctorDetails.Controls.Add(lb_Phone);
            pnlDoctorDetails.Controls.Add(Rbtn_sent);
            pnlDoctorDetails.Controls.Add(txt_note);
            pnlDoctorDetails.Controls.Add(lb_Specialization);
            pnlDoctorDetails.Controls.Add(lab_reminder);
            pnlDoctorDetails.Controls.Add(lb_LastNameDoctor);
            pnlDoctorDetails.Controls.Add(txt_date);
            pnlDoctorDetails.Controls.Add(lb_DoctorEmail);
            pnlDoctorDetails.Controls.Add(txt_patient);
            pnlDoctorDetails.Controls.Add(lb_patientName);
            pnlDoctorDetails.Location = new Point(12, 432);
            pnlDoctorDetails.Name = "pnlDoctorDetails";
            pnlDoctorDetails.Size = new Size(912, 203);
            pnlDoctorDetails.TabIndex = 142;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconRemider;
            pictureBox3.Location = new Point(11, 149);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 144;
            pictureBox3.TabStop = false;
            // 
            // combx_status
            // 
            combx_status.BackColor = Color.White;
            combx_status.Font = new Font("Segoe UI", 12F);
            combx_status.ForeColor = Color.Black;
            combx_status.FormattingEnabled = true;
            combx_status.Location = new Point(184, 65);
            combx_status.Name = "combx_status";
            combx_status.Size = new Size(233, 29);
            combx_status.TabIndex = 5;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconRecStatus;
            pictureBox4.Location = new Point(11, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 124;
            pictureBox4.TabStop = false;
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
            // txt_doctor
            // 
            txt_doctor.BackColor = Color.WhiteSmoke;
            txt_doctor.BorderStyle = BorderStyle.FixedSingle;
            txt_doctor.Font = new Font("Segoe UI", 12.75F);
            txt_doctor.ForeColor = Color.Black;
            txt_doctor.Location = new Point(627, 24);
            txt_doctor.Margin = new Padding(5);
            txt_doctor.Name = "txt_doctor";
            txt_doctor.Size = new Size(233, 30);
            txt_doctor.TabIndex = 4;
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
            pictureBox6.Location = new Point(11, 110);
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
            // txt_dept
            // 
            txt_dept.BackColor = Color.WhiteSmoke;
            txt_dept.BorderStyle = BorderStyle.FixedSingle;
            txt_dept.Font = new Font("Segoe UI", 12.75F);
            txt_dept.ForeColor = Color.Black;
            txt_dept.Location = new Point(627, 68);
            txt_dept.Margin = new Padding(5);
            txt_dept.Name = "txt_dept";
            txt_dept.Size = new Size(233, 30);
            txt_dept.TabIndex = 6;
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
            txt_note.TabIndex = 8;
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
            // lb_LastNameDoctor
            // 
            lb_LastNameDoctor.AutoSize = true;
            lb_LastNameDoctor.BackColor = Color.Transparent;
            lb_LastNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_LastNameDoctor.Location = new Point(41, 68);
            lb_LastNameDoctor.Name = "lb_LastNameDoctor";
            lb_LastNameDoctor.Size = new Size(61, 21);
            lb_LastNameDoctor.TabIndex = 104;
            lb_LastNameDoctor.Text = "Status:";
            lb_LastNameDoctor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_date
            // 
            txt_date.BackColor = Color.WhiteSmoke;
            txt_date.BorderStyle = BorderStyle.FixedSingle;
            txt_date.Font = new Font("Segoe UI", 12.75F);
            txt_date.ForeColor = Color.Black;
            txt_date.Location = new Point(184, 106);
            txt_date.Margin = new Padding(5);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(233, 30);
            txt_date.TabIndex = 7;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.BackColor = Color.Transparent;
            lb_DoctorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DoctorEmail.Location = new Point(41, 108);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(50, 21);
            lb_DoctorEmail.TabIndex = 103;
            lb_DoctorEmail.Text = "Date:";
            lb_DoctorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_patient
            // 
            txt_patient.BackColor = Color.WhiteSmoke;
            txt_patient.BorderStyle = BorderStyle.FixedSingle;
            txt_patient.Font = new Font("Segoe UI", 12.75F);
            txt_patient.ForeColor = Color.Black;
            txt_patient.Location = new Point(184, 27);
            txt_patient.Margin = new Padding(5);
            txt_patient.Name = "txt_patient";
            txt_patient.Size = new Size(233, 30);
            txt_patient.TabIndex = 3;
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
            // btn_delete
            // 
            btn_delete.BackColor = Color.Crimson;
            btn_delete.Cursor = Cursors.No;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.IconCancel;
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(947, 582);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(136, 53);
            btn_delete.TabIndex = 145;
            btn_delete.Text = "Cancel";
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Visible = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.DodgerBlue;
            btn_edit.Cursor = Cursors.Hand;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_edit.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_edit.ForeColor = Color.White;
            btn_edit.Image = Properties.Resources.IconUpdateAdmin;
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(947, 508);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(136, 53);
            btn_edit.TabIndex = 144;
            btn_edit.Text = "Update";
            btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Visible = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.LimeGreen;
            btn_new.Cursor = Cursors.Cross;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_new.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_new.ForeColor = Color.White;
            btn_new.Image = Properties.Resources.IconReceptiGerentedDate;
            btn_new.ImageAlign = ContentAlignment.MiddleLeft;
            btn_new.Location = new Point(947, 438);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(136, 53);
            btn_new.TabIndex = 143;
            btn_new.Text = "Assign New ";
            btn_new.TextAlign = ContentAlignment.MiddleRight;
            btn_new.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Visible = false;
            btn_new.Click += btn_new_Click;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconAppoinmentDgv;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.IconDailyApp;
            pictureBox5.Location = new Point(396, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 147;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 20);
            label2.Name = "label2";
            label2.Size = new Size(336, 30);
            label2.TabIndex = 146;
            label2.Text = "Hospital Appointment Scheduler";
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1099, 701);
            Controls.Add(pictureBox5);
            Controls.Add(label2);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_new);
            Controls.Add(pnlDoctorDetails);
            Controls.Add(comb_searchBy);
            Controls.Add(pictureBox8);
            Controls.Add(txt_search);
            Controls.Add(lbPatienitNameSearch);
            Controls.Add(dgv_appointments);
            Name = "Appointments";
            Text = "Appointments";
            Load += Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            pnlDoctorDetails.ResumeLayout(false);
            pnlDoctorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_date;
        private Button btn_delete;
        private Button btn_edit;
        private RadioButton Rbtn_Nsent;
        private RadioButton Rbtn_sent;
        private Label lab_dept;
        private Label lab_status;
        private Label lab_doc;
        private Label lab_reminder;
        private Label lab_note;
        private Label lab_patient;
        private TextBox txt_doctor;
        private TextBox txt_dept;
        private DataGridView dgv_appointments;
        private PictureBox pictureBox8;
        private TextBox txt_search;
        private Label lbPatienitNameSearch;
        private ComboBox comb_searchBy;
        private Panel pnlDoctorDetails;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private TextBox txt_doc;
        private Label label1;
        private TextBox txt_total;
        private Label label3;
        private TextBox txt_Due;
        private Label label5;
        private PictureBox pictureBox10;
        private PictureBox pBoxRemainingBalance;
        private PictureBox pictureBox2;
        private PictureBox pBoxTotalPaid;
        private PictureBox pictureBox6;
        private PictureBox pictureBox9;
        private TextBox textBox1;
        private Label lb_Phone;
        private TextBox txt_note;
        private Label lb_Specialization;
        private TextBox txt_status;
        private Label lb_LastNameDoctor;
        private TextBox txt_date;
        private Label lb_DoctorEmail;
        private TextBox txt_remain;
        private Label lab_Remain;
        private TextBox txt_tolPaid;
        private Label lab_tolPaid;
        private TextBox txt_patient;
        private Label lb_patientName;
        private TextBox txt_GenDate;
        private Label lb_Fname;
        private ComboBox combx_status;
        private PictureBox pictureBox3;
        private Button btn_remove;
        private Button btn_Update;
        private Button btn_new;
        private DataGridViewImageColumn icon;
        private Label label2;
    }
}