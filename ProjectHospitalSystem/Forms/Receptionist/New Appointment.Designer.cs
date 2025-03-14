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
            comboBox_date = new DevExpress.XtraEditors.ComboBoxEdit();
            comEdit_doctor = new DevExpress.XtraEditors.ComboBoxEdit();
            comboxEdit_dept = new DevExpress.XtraEditors.ComboBoxEdit();
            lab_patName = new Label();
            btn_bookApp = new Button();
            txt_SearchPatient = new TextBox();
            lab_date = new Label();
            lab_doc = new Label();
            txt_note = new TextBox();
            lab_note = new Label();
            lab_remider = new Label();
            Rbtn_sent = new RadioButton();
            Rbtn_Nsent = new RadioButton();
            dgv_doctors = new DataGridView();
            lab_dept = new Label();
            ((System.ComponentModel.ISupportInitialize)comboBox_date.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comEdit_doctor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comboxEdit_dept.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).BeginInit();
            SuspendLayout();
            // 
            // comboBox_date
            // 
            comboBox_date.Location = new Point(152, 254);
            comboBox_date.Name = "comboBox_date";
            comboBox_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBox_date.Size = new Size(100, 20);
            comboBox_date.TabIndex = 71;
            // 
            // comEdit_doctor
            // 
            comEdit_doctor.Location = new Point(142, 185);
            comEdit_doctor.Name = "comEdit_doctor";
            comEdit_doctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comEdit_doctor.Size = new Size(139, 20);
            comEdit_doctor.TabIndex = 70;
            comEdit_doctor.SelectedIndexChanged += comEdit_doctor_SelectedIndexChanged;
            // 
            // comboxEdit_dept
            // 
            comboxEdit_dept.Location = new Point(142, 223);
            comboxEdit_dept.Name = "comboxEdit_dept";
            comboxEdit_dept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboxEdit_dept.Size = new Size(139, 20);
            comboxEdit_dept.TabIndex = 69;
            comboxEdit_dept.SelectedIndexChanged += comboxEdit_dept_SelectedIndexChanged;
            // 
            // lab_patName
            // 
            lab_patName.AutoSize = true;
            lab_patName.ImeMode = ImeMode.NoControl;
            lab_patName.Location = new Point(37, 60);
            lab_patName.Name = "lab_patName";
            lab_patName.Size = new Size(79, 15);
            lab_patName.TabIndex = 55;
            lab_patName.Text = "Patient Name";
            // 
            // btn_bookApp
            // 
            btn_bookApp.ImeMode = ImeMode.NoControl;
            btn_bookApp.Location = new Point(338, 257);
            btn_bookApp.Name = "btn_bookApp";
            btn_bookApp.Size = new Size(126, 41);
            btn_bookApp.TabIndex = 67;
            btn_bookApp.Text = "Book Appointment";
            btn_bookApp.UseVisualStyleBackColor = true;
            btn_bookApp.Click += btn_bookApp_Click;
            // 
            // txt_SearchPatient
            // 
            txt_SearchPatient.Location = new Point(167, 60);
            txt_SearchPatient.Name = "txt_SearchPatient";
            txt_SearchPatient.Size = new Size(153, 23);
            txt_SearchPatient.TabIndex = 56;
            txt_SearchPatient.TextChanged += txt_SearchPatient_TextChanged;
            // 
            // lab_date
            // 
            lab_date.AutoSize = true;
            lab_date.ImeMode = ImeMode.NoControl;
            lab_date.Location = new Point(55, 259);
            lab_date.Name = "lab_date";
            lab_date.Size = new Size(31, 15);
            lab_date.TabIndex = 66;
            lab_date.Text = "Date";
            // 
            // lab_doc
            // 
            lab_doc.AutoSize = true;
            lab_doc.ImeMode = ImeMode.NoControl;
            lab_doc.Location = new Point(55, 187);
            lab_doc.Name = "lab_doc";
            lab_doc.Size = new Size(43, 15);
            lab_doc.TabIndex = 58;
            lab_doc.Text = "Doctor";
            // 
            // txt_note
            // 
            txt_note.Location = new Point(152, 96);
            txt_note.Name = "txt_note";
            txt_note.Size = new Size(153, 23);
            txt_note.TabIndex = 60;
            // 
            // lab_note
            // 
            lab_note.AutoSize = true;
            lab_note.ImeMode = ImeMode.NoControl;
            lab_note.Location = new Point(54, 96);
            lab_note.Name = "lab_note";
            lab_note.Size = new Size(33, 15);
            lab_note.TabIndex = 57;
            lab_note.Text = "Note";
            // 
            // lab_remider
            // 
            lab_remider.AutoSize = true;
            lab_remider.ImeMode = ImeMode.NoControl;
            lab_remider.Location = new Point(54, 139);
            lab_remider.Name = "lab_remider";
            lab_remider.Size = new Size(77, 15);
            lab_remider.TabIndex = 59;
            lab_remider.Text = "Remider Sent";
            // 
            // Rbtn_sent
            // 
            Rbtn_sent.AutoSize = true;
            Rbtn_sent.ImeMode = ImeMode.NoControl;
            Rbtn_sent.Location = new Point(167, 139);
            Rbtn_sent.Name = "Rbtn_sent";
            Rbtn_sent.Size = new Size(48, 19);
            Rbtn_sent.TabIndex = 61;
            Rbtn_sent.TabStop = true;
            Rbtn_sent.Text = "Sent";
            Rbtn_sent.UseVisualStyleBackColor = true;
            // 
            // Rbtn_Nsent
            // 
            Rbtn_Nsent.AutoSize = true;
            Rbtn_Nsent.ImeMode = ImeMode.NoControl;
            Rbtn_Nsent.Location = new Point(246, 137);
            Rbtn_Nsent.Name = "Rbtn_Nsent";
            Rbtn_Nsent.Size = new Size(74, 19);
            Rbtn_Nsent.TabIndex = 62;
            Rbtn_Nsent.TabStop = true;
            Rbtn_Nsent.Text = "Not Send";
            Rbtn_Nsent.UseVisualStyleBackColor = true;
            // 
            // dgv_doctors
            // 
            dgv_doctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_doctors.Location = new Point(6, 310);
            dgv_doctors.Name = "dgv_doctors";
            dgv_doctors.Size = new Size(753, 217);
            dgv_doctors.TabIndex = 63;
            dgv_doctors.CellDoubleClick += dgv_doctors_CellDoubleClick;
            dgv_doctors.RowHeaderMouseDoubleClick += dgv_doctors_RowHeaderMouseDoubleClick;
            // 
            // lab_dept
            // 
            lab_dept.AutoSize = true;
            lab_dept.ImeMode = ImeMode.NoControl;
            lab_dept.Location = new Point(37, 225);
            lab_dept.Name = "lab_dept";
            lab_dept.Size = new Size(70, 15);
            lab_dept.TabIndex = 65;
            lab_dept.Text = "Department";
            // 
            // New_Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 533);
            Controls.Add(comboBox_date);
            Controls.Add(comEdit_doctor);
            Controls.Add(comboxEdit_dept);
            Controls.Add(lab_patName);
            Controls.Add(btn_bookApp);
            Controls.Add(txt_SearchPatient);
            Controls.Add(lab_date);
            Controls.Add(lab_doc);
            Controls.Add(txt_note);
            Controls.Add(lab_note);
            Controls.Add(lab_remider);
            Controls.Add(Rbtn_sent);
            Controls.Add(Rbtn_Nsent);
            Controls.Add(dgv_doctors);
            Controls.Add(lab_dept);
            Name = "New_Appointment";
            Text = "New_Appointment";
            Load += New_Appointment_Load;
            ((System.ComponentModel.ISupportInitialize)comboBox_date.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comEdit_doctor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)comboxEdit_dept.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_doctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBox_date;
        private DevExpress.XtraEditors.ComboBoxEdit comEdit_doctor;
        private DevExpress.XtraEditors.ComboBoxEdit comboxEdit_dept;
        private Label lab_patName;
        private Button btn_bookApp;
        private TextBox txt_SearchPatient;
        private Label lab_date;
        private Label lab_doc;
        private TextBox txt_note;
        private Label lab_note;
        private Label lab_remider;
        private RadioButton Rbtn_sent;
        private RadioButton Rbtn_Nsent;
        private DataGridView dgv_doctors;
        private Label lab_dept;
    }
}