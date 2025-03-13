namespace ProjectHospitalSystem.Forms.Admin
{
    partial class AdminDoctorCRUDOpeartionForm
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
            txt_phone = new TextBox();
            lb_Phone = new Label();
            txt_Specialization = new TextBox();
            lb_Specialization = new Label();
            txt_Lname = new TextBox();
            lb_LastNameDoctor = new Label();
            dgv_AdminDoctors = new DataGridView();
            btn_remove = new Button();
            btn_Update = new Button();
            btn_AddDoctor = new Button();
            txt_Email = new TextBox();
            lb_DoctorEmail = new Label();
            cb_DeptName = new ComboBox();
            lb_DeptName = new Label();
            txt_confirmPassword = new TextBox();
            lb_confirmPassword = new Label();
            txt_Password = new TextBox();
            lb_password = new Label();
            txt_Fname = new TextBox();
            lb_Fname = new Label();
            txt_username = new TextBox();
            lb_userName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminDoctors).BeginInit();
            SuspendLayout();
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(195, 152);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(233, 23);
            txt_phone.TabIndex = 73;
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.Location = new Point(62, 155);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(44, 15);
            lb_Phone.TabIndex = 88;
            lb_Phone.Text = "Phone:";
            // 
            // txt_Specialization
            // 
            txt_Specialization.Location = new Point(195, 230);
            txt_Specialization.Name = "txt_Specialization";
            txt_Specialization.Size = new Size(233, 23);
            txt_Specialization.TabIndex = 76;
            // 
            // lb_Specialization
            // 
            lb_Specialization.AutoSize = true;
            lb_Specialization.Location = new Point(62, 233);
            lb_Specialization.Name = "lb_Specialization";
            lb_Specialization.Size = new Size(82, 15);
            lb_Specialization.TabIndex = 87;
            lb_Specialization.Text = "Specialization:";
            // 
            // txt_Lname
            // 
            txt_Lname.Location = new Point(195, 107);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(233, 23);
            txt_Lname.TabIndex = 71;
            // 
            // lb_LastNameDoctor
            // 
            lb_LastNameDoctor.AutoSize = true;
            lb_LastNameDoctor.Location = new Point(62, 115);
            lb_LastNameDoctor.Name = "lb_LastNameDoctor";
            lb_LastNameDoctor.Size = new Size(46, 15);
            lb_LastNameDoctor.TabIndex = 86;
            lb_LastNameDoctor.Text = "Lname:";
            // 
            // dgv_AdminDoctors
            // 
            dgv_AdminDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminDoctors.Location = new Point(453, 29);
            dgv_AdminDoctors.Name = "dgv_AdminDoctors";
            dgv_AdminDoctors.Size = new Size(742, 342);
            dgv_AdminDoctors.TabIndex = 85;
            dgv_AdminDoctors.RowHeaderMouseDoubleClick += dgv_AdminDoctors_RowHeaderMouseDoubleClick;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(240, 474);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(105, 53);
            btn_remove.TabIndex = 84;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Visible = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(313, 404);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(105, 53);
            btn_Update.TabIndex = 83;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Visible = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_AddDoctor
            // 
            btn_AddDoctor.Location = new Point(185, 404);
            btn_AddDoctor.Name = "btn_AddDoctor";
            btn_AddDoctor.Size = new Size(105, 53);
            btn_AddDoctor.TabIndex = 82;
            btn_AddDoctor.Text = "Add ";
            btn_AddDoctor.UseVisualStyleBackColor = true;
            btn_AddDoctor.Visible = false;
            btn_AddDoctor.Click += btn_AddDoctor_Click;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(195, 195);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(233, 23);
            txt_Email.TabIndex = 74;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.Location = new Point(62, 199);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(39, 15);
            lb_DoctorEmail.TabIndex = 81;
            lb_DoctorEmail.Text = "Email:";
            // 
            // cb_DeptName
            // 
            cb_DeptName.FormattingEnabled = true;
            cb_DeptName.Location = new Point(195, 356);
            cb_DeptName.Name = "cb_DeptName";
            cb_DeptName.Size = new Size(233, 23);
            cb_DeptName.TabIndex = 80;
            // 
            // lb_DeptName
            // 
            lb_DeptName.AutoSize = true;
            lb_DeptName.Location = new Point(62, 356);
            lb_DeptName.Name = "lb_DeptName";
            lb_DeptName.Size = new Size(99, 15);
            lb_DeptName.TabIndex = 78;
            lb_DeptName.Text = "Deprtment Name";
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(195, 308);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(233, 23);
            txt_confirmPassword.TabIndex = 79;
            // 
            // lb_confirmPassword
            // 
            lb_confirmPassword.AutoSize = true;
            lb_confirmPassword.Location = new Point(62, 308);
            lb_confirmPassword.Name = "lb_confirmPassword";
            lb_confirmPassword.Size = new Size(101, 15);
            lb_confirmPassword.TabIndex = 75;
            lb_confirmPassword.Text = "ConfirmPassword";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(195, 263);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(233, 23);
            txt_Password.TabIndex = 77;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(62, 266);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(60, 15);
            lb_password.TabIndex = 72;
            lb_password.Text = "Password:";
            // 
            // txt_Fname
            // 
            txt_Fname.Location = new Point(195, 70);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(233, 23);
            txt_Fname.TabIndex = 70;
            // 
            // lb_Fname
            // 
            lb_Fname.AutoSize = true;
            lb_Fname.Location = new Point(62, 73);
            lb_Fname.Name = "lb_Fname";
            lb_Fname.Size = new Size(46, 15);
            lb_Fname.TabIndex = 69;
            lb_Fname.Text = "Fname:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(195, 25);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(233, 23);
            txt_username.TabIndex = 68;
            // 
            // lb_userName
            // 
            lb_userName.AutoSize = true;
            lb_userName.Location = new Point(62, 25);
            lb_userName.Name = "lb_userName";
            lb_userName.Size = new Size(65, 15);
            lb_userName.TabIndex = 67;
            lb_userName.Text = "UserName:";
            // 
            // AdminDoctorCRUDOpeartionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 553);
            Controls.Add(txt_phone);
            Controls.Add(lb_Phone);
            Controls.Add(txt_Specialization);
            Controls.Add(lb_Specialization);
            Controls.Add(txt_Lname);
            Controls.Add(lb_LastNameDoctor);
            Controls.Add(dgv_AdminDoctors);
            Controls.Add(btn_remove);
            Controls.Add(btn_Update);
            Controls.Add(btn_AddDoctor);
            Controls.Add(txt_Email);
            Controls.Add(lb_DoctorEmail);
            Controls.Add(cb_DeptName);
            Controls.Add(lb_DeptName);
            Controls.Add(txt_confirmPassword);
            Controls.Add(lb_confirmPassword);
            Controls.Add(txt_Password);
            Controls.Add(lb_password);
            Controls.Add(txt_Fname);
            Controls.Add(lb_Fname);
            Controls.Add(txt_username);
            Controls.Add(lb_userName);
            Name = "AdminDoctorCRUDOpeartionForm";
            Text = "AdminDoctorCRUDOpeartionForm";
            Load += AdminDoctorCRUDOpeartionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_phone;
        private Label lb_Phone;
        private TextBox txt_Specialization;
        private Label lb_Specialization;
        private TextBox txt_Lname;
        private Label lb_LastNameDoctor;
        private DataGridView dgv_AdminDoctors;
        private Button btn_remove;
        private Button btn_Update;
        private Button btn_AddDoctor;
        private TextBox txt_Email;
        private Label lb_DoctorEmail;
        private ComboBox cb_DeptName;
        private Label lb_DeptName;
        private TextBox txt_confirmPassword;
        private Label lb_confirmPassword;
        private TextBox txt_Password;
        private Label lb_password;
        private TextBox txt_Fname;
        private Label lb_Fname;
        private TextBox txt_username;
        private Label lb_userName;
    }
}