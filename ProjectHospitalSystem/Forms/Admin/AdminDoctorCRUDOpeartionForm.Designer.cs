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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_AdminDoctors = new DataGridView();
            icon = new DataGridViewImageColumn();
            btn_remove = new Button();
            btn_Update = new Button();
            btn_AddDoctor = new Button();
            txtBoxDoctorSerachData = new TextBox();
            lbDoctorNameSearch = new Label();
            pnlDoctorDetails = new Panel();
            pBoxShowConfrimPassword = new PictureBox();
            pictureBox10 = new PictureBox();
            pBoxShowPassword = new PictureBox();
            pBoxConfirmPassword = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pBoxPassword = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_phone = new TextBox();
            lb_Phone = new Label();
            txt_Specialization = new TextBox();
            lb_Specialization = new Label();
            txt_Lname = new TextBox();
            lb_LastNameDoctor = new Label();
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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminDoctors).BeginInit();
            pnlDoctorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxShowConfrimPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgv_AdminDoctors
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_AdminDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_AdminDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminDoctors.BackgroundColor = Color.White;
            dgv_AdminDoctors.BorderStyle = BorderStyle.None;
            dgv_AdminDoctors.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_AdminDoctors.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_AdminDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_AdminDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminDoctors.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_AdminDoctors.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_AdminDoctors.EnableHeadersVisualStyles = false;
            dgv_AdminDoctors.Location = new Point(12, 46);
            dgv_AdminDoctors.Name = "dgv_AdminDoctors";
            dgv_AdminDoctors.RowHeadersVisible = false;
            dgv_AdminDoctors.RowTemplate.Height = 40;
            dgv_AdminDoctors.Size = new Size(962, 336);
            dgv_AdminDoctors.TabIndex = 85;
            dgv_AdminDoctors.CellDoubleClick += dgv_AdminDoctors_CellDoubleClick;
            // 
            // icon
            // 
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconDoctorAdminDgv;
            icon.Name = "icon";
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Crimson;
            btn_remove.Cursor = Cursors.No;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_remove.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_remove.ForeColor = Color.White;
            btn_remove.Image = Properties.Resources.IconRemovedOCTOR;
            btn_remove.ImageAlign = ContentAlignment.MiddleLeft;
            btn_remove.Location = new Point(870, 566);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(104, 53);
            btn_remove.TabIndex = 84;
            btn_remove.Text = "Remove";
            btn_remove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Visible = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.DodgerBlue;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_Update.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.White;
            btn_Update.Image = Properties.Resources.IconUpdateAdmin;
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(870, 494);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(104, 53);
            btn_Update.TabIndex = 83;
            btn_Update.Text = "Update";
            btn_Update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Visible = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_AddDoctor
            // 
            btn_AddDoctor.BackColor = Color.LimeGreen;
            btn_AddDoctor.Cursor = Cursors.Cross;
            btn_AddDoctor.FlatAppearance.BorderSize = 0;
            btn_AddDoctor.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_AddDoctor.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_AddDoctor.FlatStyle = FlatStyle.Flat;
            btn_AddDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddDoctor.ForeColor = Color.White;
            btn_AddDoctor.Image = Properties.Resources.IconAddDoctor;
            btn_AddDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddDoctor.Location = new Point(870, 415);
            btn_AddDoctor.Name = "btn_AddDoctor";
            btn_AddDoctor.Size = new Size(104, 53);
            btn_AddDoctor.TabIndex = 82;
            btn_AddDoctor.Text = "Add ";
            btn_AddDoctor.TextAlign = ContentAlignment.MiddleRight;
            btn_AddDoctor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddDoctor.UseVisualStyleBackColor = false;
            btn_AddDoctor.Visible = false;
            btn_AddDoctor.Click += btn_AddDoctor_Click;
            // 
            // txtBoxDoctorSerachData
            // 
            txtBoxDoctorSerachData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDoctorSerachData.ForeColor = Color.Gray;
            txtBoxDoctorSerachData.Location = new Point(177, 10);
            txtBoxDoctorSerachData.Margin = new Padding(5);
            txtBoxDoctorSerachData.Name = "txtBoxDoctorSerachData";
            txtBoxDoctorSerachData.PlaceholderText = "Search by Name";
            txtBoxDoctorSerachData.Size = new Size(233, 29);
            txtBoxDoctorSerachData.TabIndex = 90;
            txtBoxDoctorSerachData.TextChanged += txtBoxDoctorSerachData_TextChanged;
            // 
            // lbDoctorNameSearch
            // 
            lbDoctorNameSearch.AutoSize = true;
            lbDoctorNameSearch.BackColor = Color.Transparent;
            lbDoctorNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbDoctorNameSearch.Location = new Point(53, 13);
            lbDoctorNameSearch.Name = "lbDoctorNameSearch";
            lbDoctorNameSearch.Size = new Size(116, 21);
            lbDoctorNameSearch.TabIndex = 89;
            lbDoctorNameSearch.Text = "Doctor Name:";
            lbDoctorNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlDoctorDetails
            // 
            pnlDoctorDetails.BackColor = Color.WhiteSmoke;
            pnlDoctorDetails.Controls.Add(pBoxShowConfrimPassword);
            pnlDoctorDetails.Controls.Add(pictureBox10);
            pnlDoctorDetails.Controls.Add(pBoxShowPassword);
            pnlDoctorDetails.Controls.Add(pBoxConfirmPassword);
            pnlDoctorDetails.Controls.Add(pictureBox8);
            pnlDoctorDetails.Controls.Add(pictureBox9);
            pnlDoctorDetails.Controls.Add(pBoxPassword);
            pnlDoctorDetails.Controls.Add(pictureBox6);
            pnlDoctorDetails.Controls.Add(pictureBox4);
            pnlDoctorDetails.Controls.Add(pictureBox3);
            pnlDoctorDetails.Controls.Add(pictureBox2);
            pnlDoctorDetails.Controls.Add(txt_phone);
            pnlDoctorDetails.Controls.Add(lb_Phone);
            pnlDoctorDetails.Controls.Add(txt_Specialization);
            pnlDoctorDetails.Controls.Add(lb_Specialization);
            pnlDoctorDetails.Controls.Add(txt_Lname);
            pnlDoctorDetails.Controls.Add(lb_LastNameDoctor);
            pnlDoctorDetails.Controls.Add(txt_Email);
            pnlDoctorDetails.Controls.Add(lb_DoctorEmail);
            pnlDoctorDetails.Controls.Add(cb_DeptName);
            pnlDoctorDetails.Controls.Add(lb_DeptName);
            pnlDoctorDetails.Controls.Add(txt_confirmPassword);
            pnlDoctorDetails.Controls.Add(lb_confirmPassword);
            pnlDoctorDetails.Controls.Add(txt_Password);
            pnlDoctorDetails.Controls.Add(lb_password);
            pnlDoctorDetails.Controls.Add(txt_Fname);
            pnlDoctorDetails.Controls.Add(lb_Fname);
            pnlDoctorDetails.Controls.Add(txt_username);
            pnlDoctorDetails.Controls.Add(lb_userName);
            pnlDoctorDetails.Location = new Point(12, 388);
            pnlDoctorDetails.Name = "pnlDoctorDetails";
            pnlDoctorDetails.Size = new Size(830, 225);
            pnlDoctorDetails.TabIndex = 91;
            // 
            // pBoxShowConfrimPassword
            // 
            pBoxShowConfrimPassword.BackColor = Color.White;
            pBoxShowConfrimPassword.Image = Properties.Resources.IconShowPassword;
            pBoxShowConfrimPassword.Location = new Point(791, 150);
            pBoxShowConfrimPassword.Name = "pBoxShowConfrimPassword";
            pBoxShowConfrimPassword.Size = new Size(24, 24);
            pBoxShowConfrimPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxShowConfrimPassword.TabIndex = 117;
            pBoxShowConfrimPassword.TabStop = false;
            pBoxShowConfrimPassword.Click += pBoxShowConfrimPassword_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.IconDepartment;
            pictureBox10.Location = new Point(154, 188);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 114;
            pictureBox10.TabStop = false;
            // 
            // pBoxShowPassword
            // 
            pBoxShowPassword.BackColor = Color.White;
            pBoxShowPassword.Image = Properties.Resources.IconShowPassword;
            pBoxShowPassword.Location = new Point(349, 152);
            pBoxShowPassword.Name = "pBoxShowPassword";
            pBoxShowPassword.Size = new Size(24, 24);
            pBoxShowPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxShowPassword.TabIndex = 116;
            pBoxShowPassword.TabStop = false;
            pBoxShowPassword.Click += pBoxShowPassword_Click;
            // 
            // pBoxConfirmPassword
            // 
            pBoxConfirmPassword.Image = Properties.Resources.IconPassword;
            pBoxConfirmPassword.Location = new Point(412, 147);
            pBoxConfirmPassword.Name = "pBoxConfirmPassword";
            pBoxConfirmPassword.Size = new Size(24, 24);
            pBoxConfirmPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxConfirmPassword.TabIndex = 113;
            pBoxConfirmPassword.TabStop = false;
            pBoxConfirmPassword.Visible = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.IconDoctorData;
            pictureBox8.Location = new Point(412, 110);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 112;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.IconPhone;
            pictureBox9.Location = new Point(412, 71);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 111;
            pictureBox9.TabStop = false;
            // 
            // pBoxPassword
            // 
            pBoxPassword.Image = Properties.Resources.IconPassword;
            pBoxPassword.Location = new Point(11, 147);
            pBoxPassword.Name = "pBoxPassword";
            pBoxPassword.Size = new Size(24, 24);
            pBoxPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxPassword.TabIndex = 110;
            pBoxPassword.TabStop = false;
            pBoxPassword.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconEmail;
            pictureBox6.Location = new Point(11, 110);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconUserName;
            pictureBox4.Location = new Point(11, 66);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 108;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconUserName;
            pictureBox3.Location = new Point(412, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 107;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconUserName;
            pictureBox2.Location = new Point(11, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 93;
            pictureBox2.TabStop = false;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.BorderStyle = BorderStyle.FixedSingle;
            txt_phone.Font = new Font("Segoe UI", 12F);
            txt_phone.ForeColor = Color.Black;
            txt_phone.Location = new Point(592, 66);
            txt_phone.Margin = new Padding(5);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(233, 29);
            txt_phone.TabIndex = 95;
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.BackColor = Color.Transparent;
            lb_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Phone.Location = new Point(442, 74);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(63, 21);
            lb_Phone.TabIndex = 106;
            lb_Phone.Text = "Phone:";
            lb_Phone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Specialization
            // 
            txt_Specialization.BackColor = Color.White;
            txt_Specialization.BorderStyle = BorderStyle.FixedSingle;
            txt_Specialization.Font = new Font("Segoe UI", 12F);
            txt_Specialization.ForeColor = Color.Black;
            txt_Specialization.Location = new Point(592, 106);
            txt_Specialization.Margin = new Padding(5);
            txt_Specialization.Name = "txt_Specialization";
            txt_Specialization.Size = new Size(233, 29);
            txt_Specialization.TabIndex = 98;
            // 
            // lb_Specialization
            // 
            lb_Specialization.AutoSize = true;
            lb_Specialization.BackColor = Color.Transparent;
            lb_Specialization.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Specialization.Location = new Point(442, 113);
            lb_Specialization.Name = "lb_Specialization";
            lb_Specialization.Size = new Size(122, 21);
            lb_Specialization.TabIndex = 105;
            lb_Specialization.Text = "Specialization:";
            lb_Specialization.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Lname
            // 
            txt_Lname.BackColor = Color.White;
            txt_Lname.BorderStyle = BorderStyle.FixedSingle;
            txt_Lname.Font = new Font("Segoe UI", 12F);
            txt_Lname.ForeColor = Color.Black;
            txt_Lname.Location = new Point(146, 66);
            txt_Lname.Margin = new Padding(5);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(233, 29);
            txt_Lname.TabIndex = 93;
            // 
            // lb_LastNameDoctor
            // 
            lb_LastNameDoctor.AutoSize = true;
            lb_LastNameDoctor.BackColor = Color.Transparent;
            lb_LastNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_LastNameDoctor.Location = new Point(41, 68);
            lb_LastNameDoctor.Name = "lb_LastNameDoctor";
            lb_LastNameDoctor.Size = new Size(65, 21);
            lb_LastNameDoctor.TabIndex = 104;
            lb_LastNameDoctor.Text = "Lname:";
            lb_LastNameDoctor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.White;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Segoe UI", 12F);
            txt_Email.ForeColor = Color.Black;
            txt_Email.Location = new Point(146, 108);
            txt_Email.Margin = new Padding(5);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(233, 29);
            txt_Email.TabIndex = 96;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.BackColor = Color.Transparent;
            lb_DoctorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DoctorEmail.Location = new Point(41, 108);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(57, 21);
            lb_DoctorEmail.TabIndex = 103;
            lb_DoctorEmail.Text = "Email:";
            lb_DoctorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cb_DeptName
            // 
            cb_DeptName.BackColor = Color.White;
            cb_DeptName.Font = new Font("Segoe UI", 12F);
            cb_DeptName.ForeColor = Color.Black;
            cb_DeptName.FormattingEnabled = true;
            cb_DeptName.Location = new Point(356, 188);
            cb_DeptName.Name = "cb_DeptName";
            cb_DeptName.Size = new Size(233, 29);
            cb_DeptName.TabIndex = 102;
            // 
            // lb_DeptName
            // 
            lb_DeptName.AutoSize = true;
            lb_DeptName.BackColor = Color.Transparent;
            lb_DeptName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DeptName.Location = new Point(184, 191);
            lb_DeptName.Name = "lb_DeptName";
            lb_DeptName.Size = new Size(143, 21);
            lb_DeptName.TabIndex = 100;
            lb_DeptName.Text = "Deprtment Name";
            lb_DeptName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.BackColor = Color.White;
            txt_confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmPassword.Font = new Font("Segoe UI", 12F);
            txt_confirmPassword.ForeColor = Color.Black;
            txt_confirmPassword.Location = new Point(592, 148);
            txt_confirmPassword.Margin = new Padding(5);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(233, 29);
            txt_confirmPassword.TabIndex = 101;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // lb_confirmPassword
            // 
            lb_confirmPassword.AutoSize = true;
            lb_confirmPassword.BackColor = Color.Transparent;
            lb_confirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_confirmPassword.Location = new Point(445, 150);
            lb_confirmPassword.Name = "lb_confirmPassword";
            lb_confirmPassword.Size = new Size(148, 21);
            lb_confirmPassword.TabIndex = 97;
            lb_confirmPassword.Text = "ConfirmPassword:";
            lb_confirmPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.White;
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Font = new Font("Segoe UI", 12F);
            txt_Password.ForeColor = Color.Black;
            txt_Password.Location = new Point(146, 148);
            txt_Password.Margin = new Padding(5);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(233, 29);
            txt_Password.TabIndex = 99;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.BackColor = Color.Transparent;
            lb_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_password.Location = new Point(41, 150);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(86, 21);
            lb_password.TabIndex = 94;
            lb_password.Text = "Password:";
            lb_password.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Fname
            // 
            txt_Fname.BackColor = Color.White;
            txt_Fname.BorderStyle = BorderStyle.FixedSingle;
            txt_Fname.Font = new Font("Segoe UI", 12F);
            txt_Fname.ForeColor = Color.Black;
            txt_Fname.Location = new Point(592, 30);
            txt_Fname.Margin = new Padding(5);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(233, 29);
            txt_Fname.TabIndex = 92;
            // 
            // lb_Fname
            // 
            lb_Fname.AutoSize = true;
            lb_Fname.BackColor = Color.Transparent;
            lb_Fname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Fname.Location = new Point(442, 32);
            lb_Fname.Name = "lb_Fname";
            lb_Fname.Size = new Size(65, 21);
            lb_Fname.TabIndex = 91;
            lb_Fname.Text = "Fname:";
            lb_Fname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.White;
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.ForeColor = Color.Black;
            txt_username.Location = new Point(146, 27);
            txt_username.Margin = new Padding(5);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(233, 29);
            txt_username.TabIndex = 90;
            // 
            // lb_userName
            // 
            lb_userName.AutoSize = true;
            lb_userName.BackColor = Color.Transparent;
            lb_userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_userName.Location = new Point(41, 32);
            lb_userName.Name = "lb_userName";
            lb_userName.Size = new Size(94, 21);
            lb_userName.TabIndex = 89;
            lb_userName.Text = "UserName:";
            lb_userName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconSerachDoctor24;
            pictureBox1.Location = new Point(23, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 92;
            pictureBox1.TabStop = false;
            // 
            // AdminDoctorCRUDOpeartionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(999, 629);
            Controls.Add(pictureBox1);
            Controls.Add(pnlDoctorDetails);
            Controls.Add(txtBoxDoctorSerachData);
            Controls.Add(lbDoctorNameSearch);
            Controls.Add(dgv_AdminDoctors);
            Controls.Add(btn_remove);
            Controls.Add(btn_Update);
            Controls.Add(btn_AddDoctor);
            Name = "AdminDoctorCRUDOpeartionForm";
            Text = "AdminDoctorCRUDOpeartionForm";
            Load += AdminDoctorCRUDOpeartionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminDoctors).EndInit();
            pnlDoctorDetails.ResumeLayout(false);
            pnlDoctorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxShowConfrimPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_AdminDoctors;
        private Button btn_remove;
        private Button btn_Update;
        private Button btn_AddDoctor;
        private TextBox txtBoxDoctorSerachData;
        private Label lbDoctorNameSearch;
        private DataGridViewImageColumn icon;
        private Panel pnlDoctorDetails;
        private TextBox txt_phone;
        private Label lb_Phone;
        private TextBox txt_Specialization;
        private Label lb_Specialization;
        private TextBox txt_Lname;
        private Label lb_LastNameDoctor;
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
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pBoxConfirmPassword;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pBoxPassword;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox10;
        private PictureBox pBoxShowConfrimPassword;
        private PictureBox pBoxShowPassword;
    }
}