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
            lab_date = new Label();
            btn_delete = new Button();
            btn_edit = new Button();
            btn_new = new Button();
            Rbtn_Nsent = new RadioButton();
            Rbtn_sent = new RadioButton();
            txt_note = new TextBox();
            txt_patient = new TextBox();
            lab_dept = new Label();
            lab_status = new Label();
            lab_doc = new Label();
            lab_reminder = new Label();
            lab_note = new Label();
            lab_patient = new Label();
            dgv_appointments = new DataGridView();
            txt_doctor = new TextBox();
            combx_status = new ComboBox();
            comb_searchBy = new ComboBox();
            label1 = new Label();
            txt_search = new TextBox();
            txt_dept = new TextBox();
            txt_date = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).BeginInit();
            SuspendLayout();
            // 
            // lab_date
            // 
            lab_date.AutoSize = true;
            lab_date.Location = new Point(81, 128);
            lab_date.Name = "lab_date";
            lab_date.Size = new Size(31, 15);
            lab_date.TabIndex = 37;
            lab_date.Text = "Date";
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(364, 169);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 36;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(256, 169);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 23);
            btn_edit.TabIndex = 35;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(144, 169);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(75, 23);
            btn_new.TabIndex = 34;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // Rbtn_Nsent
            // 
            Rbtn_Nsent.AutoSize = true;
            Rbtn_Nsent.Location = new Point(656, 120);
            Rbtn_Nsent.Name = "Rbtn_Nsent";
            Rbtn_Nsent.Size = new Size(41, 19);
            Rbtn_Nsent.TabIndex = 33;
            Rbtn_Nsent.TabStop = true;
            Rbtn_Nsent.Text = "No";
            Rbtn_Nsent.UseVisualStyleBackColor = true;
            // 
            // Rbtn_sent
            // 
            Rbtn_sent.AutoSize = true;
            Rbtn_sent.Location = new Point(608, 121);
            Rbtn_sent.Name = "Rbtn_sent";
            Rbtn_sent.Size = new Size(42, 19);
            Rbtn_sent.TabIndex = 32;
            Rbtn_sent.TabStop = true;
            Rbtn_sent.Text = "Yes";
            Rbtn_sent.UseVisualStyleBackColor = true;
            // 
            // txt_note
            // 
            txt_note.Location = new Point(167, 85);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(100, 23);
            txt_note.TabIndex = 30;
            // 
            // txt_patient
            // 
            txt_patient.Location = new Point(167, 60);
            txt_patient.Name = "txt_patient";
            txt_patient.Size = new Size(100, 23);
            txt_patient.TabIndex = 27;
            // 
            // lab_dept
            // 
            lab_dept.AutoSize = true;
            lab_dept.Location = new Point(508, 76);
            lab_dept.Name = "lab_dept";
            lab_dept.Size = new Size(70, 15);
            lab_dept.TabIndex = 26;
            lab_dept.Text = "Department";
            // 
            // lab_status
            // 
            lab_status.AutoSize = true;
            lab_status.Location = new Point(303, 120);
            lab_status.Name = "lab_status";
            lab_status.Size = new Size(38, 15);
            lab_status.TabIndex = 25;
            lab_status.Text = "status";
            // 
            // lab_doc
            // 
            lab_doc.AutoSize = true;
            lab_doc.Location = new Point(288, 71);
            lab_doc.Name = "lab_doc";
            lab_doc.Size = new Size(78, 15);
            lab_doc.TabIndex = 24;
            lab_doc.Text = "Doctor Name";
            // 
            // lab_reminder
            // 
            lab_reminder.AutoSize = true;
            lab_reminder.Location = new Point(508, 123);
            lab_reminder.Name = "lab_reminder";
            lab_reminder.Size = new Size(84, 15);
            lab_reminder.TabIndex = 23;
            lab_reminder.Text = "Reminder Sent";
            // 
            // lab_note
            // 
            lab_note.AutoSize = true;
            lab_note.Location = new Point(74, 100);
            lab_note.Name = "lab_note";
            lab_note.Size = new Size(38, 15);
            lab_note.TabIndex = 22;
            lab_note.Text = "Notes";
            // 
            // lab_patient
            // 
            lab_patient.AutoSize = true;
            lab_patient.Location = new Point(60, 68);
            lab_patient.Name = "lab_patient";
            lab_patient.Size = new Size(79, 15);
            lab_patient.TabIndex = 21;
            lab_patient.Text = "Patient Name";
            // 
            // dgv_appointments
            // 
            dgv_appointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointments.Location = new Point(8, 198);
            dgv_appointments.Name = "dgv_appointments";
            dgv_appointments.Size = new Size(725, 206);
            dgv_appointments.TabIndex = 20;
            dgv_appointments.CellDoubleClick += dgv_appointments_CellDoubleClick;
            // 
            // txt_doctor
            // 
            txt_doctor.Location = new Point(385, 68);
            txt_doctor.Name = "txt_doctor";
            txt_doctor.Size = new Size(100, 23);
            txt_doctor.TabIndex = 43;
            // 
            // combx_status
            // 
            combx_status.FormattingEnabled = true;
            combx_status.Location = new Point(364, 120);
            combx_status.Name = "combx_status";
            combx_status.Size = new Size(121, 23);
            combx_status.TabIndex = 44;
            // 
            // comb_searchBy
            // 
            comb_searchBy.FormattingEnabled = true;
            comb_searchBy.Location = new Point(81, 10);
            comb_searchBy.Name = "comb_searchBy";
            comb_searchBy.Size = new Size(121, 23);
            comb_searchBy.TabIndex = 45;
            comb_searchBy.SelectedIndexChanged += comb_searchBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 46;
            label1.Text = "Search By";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(218, 10);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(113, 23);
            txt_search.TabIndex = 47;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // txt_dept
            // 
            txt_dept.Location = new Point(609, 65);
            txt_dept.Name = "txt_dept";
            txt_dept.Size = new Size(100, 23);
            txt_dept.TabIndex = 48;
            // 
            // txt_date
            // 
            txt_date.Location = new Point(167, 125);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(100, 23);
            txt_date.TabIndex = 49;
            // 
            // Appointments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 406);
            Controls.Add(txt_date);
            Controls.Add(txt_dept);
            Controls.Add(txt_search);
            Controls.Add(label1);
            Controls.Add(comb_searchBy);
            Controls.Add(combx_status);
            Controls.Add(txt_doctor);
            Controls.Add(lab_date);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_new);
            Controls.Add(Rbtn_Nsent);
            Controls.Add(Rbtn_sent);
            Controls.Add(txt_note);
            Controls.Add(txt_patient);
            Controls.Add(lab_dept);
            Controls.Add(lab_status);
            Controls.Add(lab_doc);
            Controls.Add(lab_reminder);
            Controls.Add(lab_note);
            Controls.Add(lab_patient);
            Controls.Add(dgv_appointments);
            Name = "Appointments";
            Text = "Appointments";
            Load += Appointments_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_appointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_date;
        private Button btn_delete;
        private Button btn_edit;
        private Button btn_new;
        private RadioButton Rbtn_Nsent;
        private RadioButton Rbtn_sent;
        private TextBox txt_note;
        private TextBox txt_patient;
        private Label lab_dept;
        private Label lab_status;
        private Label lab_doc;
        private Label lab_reminder;
        private Label lab_note;
        private Label lab_patient;
        private DataGridView dgv_appointments;
        private TextBox txt_doctor;
        private ComboBox combx_status;
        private ComboBox comb_searchBy;
        private Label label1;
        private TextBox txt_search;
        private TextBox txt_dept;
        private TextBox txt_date;
    }
}