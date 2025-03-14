namespace ProjectHospitalSystem.Forms.Admin
{
    partial class AdminReceptionsitCRUDOpeartion
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
            txt_Lname = new TextBox();
            lb_LastNameDoctor = new Label();
            lb_close = new Label();
            dgv_AdminReceptionist = new DataGridView();
            btn_removeReceptionist = new Button();
            btn_UpdateReceptionist = new Button();
            btn_AddReceptionist = new Button();
            txt_Email = new TextBox();
            lb_DoctorEmail = new Label();
            txt_confirmPassword = new TextBox();
            lb_confirmPassword = new Label();
            txt_Password = new TextBox();
            lb_password = new Label();
            txt_Fname = new TextBox();
            lb_Fname = new Label();
            txt_username = new TextBox();
            lb_userName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminReceptionist).BeginInit();
            SuspendLayout();
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(212, 192);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(233, 23);
            txt_phone.TabIndex = 48;
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.Location = new Point(90, 200);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(44, 15);
            lb_Phone.TabIndex = 63;
            lb_Phone.Text = "Phone:";
            // 
            // txt_Lname
            // 
            txt_Lname.Location = new Point(212, 147);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(233, 23);
            txt_Lname.TabIndex = 47;
            // 
            // lb_LastNameDoctor
            // 
            lb_LastNameDoctor.AutoSize = true;
            lb_LastNameDoctor.Location = new Point(90, 155);
            lb_LastNameDoctor.Name = "lb_LastNameDoctor";
            lb_LastNameDoctor.Size = new Size(46, 15);
            lb_LastNameDoctor.TabIndex = 62;
            lb_LastNameDoctor.Text = "Lname:";
            // 
            // lb_close
            // 
            lb_close.AutoSize = true;
            lb_close.Location = new Point(712, 421);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(36, 15);
            lb_close.TabIndex = 61;
            lb_close.Text = "Close";
            // 
            // dgv_AdminReceptionist
            // 
            dgv_AdminReceptionist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminReceptionist.Location = new Point(473, 42);
            dgv_AdminReceptionist.Name = "dgv_AdminReceptionist";
            dgv_AdminReceptionist.Size = new Size(692, 342);
            dgv_AdminReceptionist.TabIndex = 60;
            dgv_AdminReceptionist.RowHeaderMouseDoubleClick += dgv_AdminReceptionist_RowHeaderMouseDoubleClick;
            // 
            // btn_removeReceptionist
            // 
            btn_removeReceptionist.Location = new Point(267, 428);
            btn_removeReceptionist.Name = "btn_removeReceptionist";
            btn_removeReceptionist.Size = new Size(105, 53);
            btn_removeReceptionist.TabIndex = 59;
            btn_removeReceptionist.Text = "Remove";
            btn_removeReceptionist.UseVisualStyleBackColor = true;
            btn_removeReceptionist.Visible = false;
            btn_removeReceptionist.Click += btn_removeReceptionist_Click;
            // 
            // btn_UpdateReceptionist
            // 
            btn_UpdateReceptionist.Location = new Point(340, 358);
            btn_UpdateReceptionist.Name = "btn_UpdateReceptionist";
            btn_UpdateReceptionist.Size = new Size(105, 53);
            btn_UpdateReceptionist.TabIndex = 58;
            btn_UpdateReceptionist.Text = "Update";
            btn_UpdateReceptionist.UseVisualStyleBackColor = true;
            btn_UpdateReceptionist.Visible = false;
            btn_UpdateReceptionist.Click += btn_UpdateReceptionist_Click;
            // 
            // btn_AddReceptionist
            // 
            btn_AddReceptionist.Location = new Point(212, 358);
            btn_AddReceptionist.Name = "btn_AddReceptionist";
            btn_AddReceptionist.Size = new Size(105, 53);
            btn_AddReceptionist.TabIndex = 57;
            btn_AddReceptionist.Text = "Add ";
            btn_AddReceptionist.UseVisualStyleBackColor = true;
            btn_AddReceptionist.Visible = false;
            btn_AddReceptionist.Click += btn_AddReceptionist_Click;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(212, 235);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(233, 23);
            txt_Email.TabIndex = 49;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.Location = new Point(90, 243);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(39, 15);
            lb_DoctorEmail.TabIndex = 56;
            lb_DoctorEmail.Text = "Email:";
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.Location = new Point(212, 320);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(233, 23);
            txt_confirmPassword.TabIndex = 51;
            txt_confirmPassword.Visible = false;
            // 
            // lb_confirmPassword
            // 
            lb_confirmPassword.AutoSize = true;
            lb_confirmPassword.Location = new Point(90, 323);
            lb_confirmPassword.Name = "lb_confirmPassword";
            lb_confirmPassword.Size = new Size(104, 15);
            lb_confirmPassword.TabIndex = 55;
            lb_confirmPassword.Text = "ConfirmPassword:";
            lb_confirmPassword.Visible = false;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(212, 275);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(233, 23);
            txt_Password.TabIndex = 50;
            txt_Password.Visible = false;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(90, 283);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(60, 15);
            lb_password.TabIndex = 54;
            lb_password.Text = "Password:";
            lb_password.Visible = false;
            // 
            // txt_Fname
            // 
            txt_Fname.Location = new Point(212, 110);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(233, 23);
            txt_Fname.TabIndex = 46;
            // 
            // lb_Fname
            // 
            lb_Fname.AutoSize = true;
            lb_Fname.Location = new Point(90, 113);
            lb_Fname.Name = "lb_Fname";
            lb_Fname.Size = new Size(46, 15);
            lb_Fname.TabIndex = 53;
            lb_Fname.Text = "Fname:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(212, 65);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(233, 23);
            txt_username.TabIndex = 45;
            // 
            // lb_userName
            // 
            lb_userName.AutoSize = true;
            lb_userName.Location = new Point(90, 68);
            lb_userName.Name = "lb_userName";
            lb_userName.Size = new Size(65, 15);
            lb_userName.TabIndex = 52;
            lb_userName.Text = "UserName:";
            // 
            // AdminReceptionsitCRUDOpeartion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 559);
            Controls.Add(txt_phone);
            Controls.Add(lb_Phone);
            Controls.Add(txt_Lname);
            Controls.Add(lb_LastNameDoctor);
            Controls.Add(lb_close);
            Controls.Add(dgv_AdminReceptionist);
            Controls.Add(btn_removeReceptionist);
            Controls.Add(btn_UpdateReceptionist);
            Controls.Add(btn_AddReceptionist);
            Controls.Add(txt_Email);
            Controls.Add(lb_DoctorEmail);
            Controls.Add(txt_confirmPassword);
            Controls.Add(lb_confirmPassword);
            Controls.Add(txt_Password);
            Controls.Add(lb_password);
            Controls.Add(txt_Fname);
            Controls.Add(lb_Fname);
            Controls.Add(txt_username);
            Controls.Add(lb_userName);
            Name = "AdminReceptionsitCRUDOpeartion";
            Text = "AdminReceptionsitCRUDOpeartion";
            Load += AdminReceptionsitCRUDOpeartion_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminReceptionist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_phone;
        private Label lb_Phone;
        private TextBox txt_Lname;
        private Label lb_LastNameDoctor;
        private Label lb_close;
        private DataGridView dgv_AdminReceptionist;
        private Button btn_removeReceptionist;
        private Button btn_UpdateReceptionist;
        private Button btn_AddReceptionist;
        private TextBox txt_Email;
        private Label lb_DoctorEmail;
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