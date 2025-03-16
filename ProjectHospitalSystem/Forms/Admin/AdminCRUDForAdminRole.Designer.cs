namespace ProjectHospitalSystem.Forms.Admin
{
    partial class New_Admin
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
            dgv_admin = new DataGridView();
            icon = new DataGridViewImageColumn();
            pnlReceDetails = new Panel();
            pBoxShowConfrimPassword = new PictureBox();
            pBoxShowPassword = new PictureBox();
            pBoxConfirmPassword = new PictureBox();
            pictureBox9 = new PictureBox();
            pBoxPassword = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_phone = new TextBox();
            lb_Phone = new Label();
            txt_lastName = new TextBox();
            lb_LastNameRece = new Label();
            txt_email = new TextBox();
            lb_RecEmail = new Label();
            txt_confirmPassword = new TextBox();
            lb_confirmPassword = new Label();
            txt_password = new TextBox();
            lb_password = new Label();
            txt_firstName = new TextBox();
            lb_Fname = new Label();
            txt_UserName = new TextBox();
            lb_userName = new Label();
            btn_delete = new Button();
            btn_update = new Button();
            btn_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_admin).BeginInit();
            pnlReceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxShowConfrimPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxConfirmPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgv_admin
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_admin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_admin.BackgroundColor = Color.White;
            dgv_admin.BorderStyle = BorderStyle.None;
            dgv_admin.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_admin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_admin.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_admin.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_admin.EnableHeadersVisualStyles = false;
            dgv_admin.Location = new Point(12, 12);
            dgv_admin.Name = "dgv_admin";
            dgv_admin.RowHeadersVisible = false;
            dgv_admin.RowTemplate.Height = 40;
            dgv_admin.Size = new Size(861, 189);
            dgv_admin.TabIndex = 94;
            dgv_admin.CellMouseDoubleClick += dgv_admin_CellMouseDoubleClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconAdminDgv;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // pnlReceDetails
            // 
            pnlReceDetails.BackColor = Color.WhiteSmoke;
            pnlReceDetails.Controls.Add(pBoxShowConfrimPassword);
            pnlReceDetails.Controls.Add(pBoxShowPassword);
            pnlReceDetails.Controls.Add(pBoxConfirmPassword);
            pnlReceDetails.Controls.Add(pictureBox9);
            pnlReceDetails.Controls.Add(pBoxPassword);
            pnlReceDetails.Controls.Add(pictureBox6);
            pnlReceDetails.Controls.Add(pictureBox4);
            pnlReceDetails.Controls.Add(pictureBox3);
            pnlReceDetails.Controls.Add(pictureBox2);
            pnlReceDetails.Controls.Add(txt_phone);
            pnlReceDetails.Controls.Add(lb_Phone);
            pnlReceDetails.Controls.Add(txt_lastName);
            pnlReceDetails.Controls.Add(lb_LastNameRece);
            pnlReceDetails.Controls.Add(txt_email);
            pnlReceDetails.Controls.Add(lb_RecEmail);
            pnlReceDetails.Controls.Add(txt_confirmPassword);
            pnlReceDetails.Controls.Add(lb_confirmPassword);
            pnlReceDetails.Controls.Add(txt_password);
            pnlReceDetails.Controls.Add(lb_password);
            pnlReceDetails.Controls.Add(txt_firstName);
            pnlReceDetails.Controls.Add(lb_Fname);
            pnlReceDetails.Controls.Add(txt_UserName);
            pnlReceDetails.Controls.Add(lb_userName);
            pnlReceDetails.Location = new Point(12, 221);
            pnlReceDetails.Name = "pnlReceDetails";
            pnlReceDetails.Size = new Size(861, 200);
            pnlReceDetails.TabIndex = 98;
            // 
            // pBoxShowConfrimPassword
            // 
            pBoxShowConfrimPassword.BackColor = Color.White;
            pBoxShowConfrimPassword.Image = Properties.Resources.IconShowPassword;
            pBoxShowConfrimPassword.Location = new Point(592, 158);
            pBoxShowConfrimPassword.Name = "pBoxShowConfrimPassword";
            pBoxShowConfrimPassword.Size = new Size(24, 24);
            pBoxShowConfrimPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxShowConfrimPassword.TabIndex = 115;
            pBoxShowConfrimPassword.TabStop = false;
            pBoxShowConfrimPassword.Click += pBoxShowConfrimPassword_Click;
            // 
            // pBoxShowPassword
            // 
            pBoxShowPassword.BackColor = Color.White;
            pBoxShowPassword.Image = Properties.Resources.IconShowPassword;
            pBoxShowPassword.Location = new Point(792, 110);
            pBoxShowPassword.Name = "pBoxShowPassword";
            pBoxShowPassword.Size = new Size(24, 24);
            pBoxShowPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxShowPassword.TabIndex = 114;
            pBoxShowPassword.TabStop = false;
            pBoxShowPassword.Click += pBoxShowPassword_Click;
            // 
            // pBoxConfirmPassword
            // 
            pBoxConfirmPassword.Image = Properties.Resources.IconPassword;
            pBoxConfirmPassword.Location = new Point(202, 155);
            pBoxConfirmPassword.Name = "pBoxConfirmPassword";
            pBoxConfirmPassword.Size = new Size(24, 24);
            pBoxConfirmPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxConfirmPassword.TabIndex = 113;
            pBoxConfirmPassword.TabStop = false;
            pBoxConfirmPassword.Visible = false;
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
            pBoxPassword.Location = new Point(412, 107);
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
            txt_phone.TabIndex = 4;
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
            // txt_lastName
            // 
            txt_lastName.BackColor = Color.White;
            txt_lastName.BorderStyle = BorderStyle.FixedSingle;
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.ForeColor = Color.Black;
            txt_lastName.Location = new Point(146, 66);
            txt_lastName.Margin = new Padding(5);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(233, 29);
            txt_lastName.TabIndex = 3;
            // 
            // lb_LastNameRece
            // 
            lb_LastNameRece.AutoSize = true;
            lb_LastNameRece.BackColor = Color.Transparent;
            lb_LastNameRece.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_LastNameRece.Location = new Point(41, 68);
            lb_LastNameRece.Name = "lb_LastNameRece";
            lb_LastNameRece.Size = new Size(65, 21);
            lb_LastNameRece.TabIndex = 104;
            lb_LastNameRece.Text = "Lname:";
            lb_LastNameRece.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.BorderStyle = BorderStyle.FixedSingle;
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.ForeColor = Color.Black;
            txt_email.Location = new Point(146, 108);
            txt_email.Margin = new Padding(5);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(233, 29);
            txt_email.TabIndex = 5;
            // 
            // lb_RecEmail
            // 
            lb_RecEmail.AutoSize = true;
            lb_RecEmail.BackColor = Color.Transparent;
            lb_RecEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_RecEmail.Location = new Point(41, 108);
            lb_RecEmail.Name = "lb_RecEmail";
            lb_RecEmail.Size = new Size(57, 21);
            lb_RecEmail.TabIndex = 103;
            lb_RecEmail.Text = "Email:";
            lb_RecEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.BackColor = Color.White;
            txt_confirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txt_confirmPassword.Font = new Font("Segoe UI", 12F);
            txt_confirmPassword.ForeColor = Color.Black;
            txt_confirmPassword.Location = new Point(391, 156);
            txt_confirmPassword.Margin = new Padding(5);
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Size = new Size(233, 29);
            txt_confirmPassword.TabIndex = 7;
            txt_confirmPassword.UseSystemPasswordChar = true;
            // 
            // lb_confirmPassword
            // 
            lb_confirmPassword.AutoSize = true;
            lb_confirmPassword.BackColor = Color.Transparent;
            lb_confirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_confirmPassword.Location = new Point(235, 158);
            lb_confirmPassword.Name = "lb_confirmPassword";
            lb_confirmPassword.Size = new Size(148, 21);
            lb_confirmPassword.TabIndex = 97;
            lb_confirmPassword.Text = "ConfirmPassword:";
            lb_confirmPassword.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.White;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Segoe UI", 12F);
            txt_password.ForeColor = Color.Black;
            txt_password.Location = new Point(592, 108);
            txt_password.Margin = new Padding(5);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(233, 29);
            txt_password.TabIndex = 6;
            txt_password.UseSystemPasswordChar = true;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.BackColor = Color.Transparent;
            lb_password.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_password.Location = new Point(442, 110);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(86, 21);
            lb_password.TabIndex = 94;
            lb_password.Text = "Password:";
            lb_password.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_firstName
            // 
            txt_firstName.BackColor = Color.White;
            txt_firstName.BorderStyle = BorderStyle.FixedSingle;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.ForeColor = Color.Black;
            txt_firstName.Location = new Point(592, 30);
            txt_firstName.Margin = new Padding(5);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(233, 29);
            txt_firstName.TabIndex = 2;
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
            // txt_UserName
            // 
            txt_UserName.BackColor = Color.White;
            txt_UserName.BorderStyle = BorderStyle.FixedSingle;
            txt_UserName.Font = new Font("Segoe UI", 12F);
            txt_UserName.ForeColor = Color.Black;
            txt_UserName.Location = new Point(146, 27);
            txt_UserName.Margin = new Padding(5);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(233, 29);
            txt_UserName.TabIndex = 1;
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
            btn_delete.Image = Properties.Resources.IconRemovedOCTOR;
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(893, 148);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(104, 53);
            btn_delete.TabIndex = 103;
            btn_delete.Text = "Remove";
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Visible = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.DodgerBlue;
            btn_update.Cursor = Cursors.Hand;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_update.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.White;
            btn_update.Image = Properties.Resources.IconUpdateAdmin;
            btn_update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update.Location = new Point(893, 84);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(104, 53);
            btn_update.TabIndex = 102;
            btn_update.Text = "Update";
            btn_update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Visible = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.LimeGreen;
            btn_Add.Cursor = Cursors.Cross;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_Add.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.White;
            btn_Add.Image = Properties.Resources.IconAdminAddBtn;
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(893, 12);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(104, 53);
            btn_Add.TabIndex = 101;
            btn_Add.Text = "Add ";
            btn_Add.TextAlign = ContentAlignment.MiddleRight;
            btn_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Visible = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // New_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1007, 439);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_Add);
            Controls.Add(pnlReceDetails);
            Controls.Add(dgv_admin);
            Name = "New_Admin";
            Text = "Admin CRUD";
            Load += New_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_admin).EndInit();
            pnlReceDetails.ResumeLayout(false);
            pnlReceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxShowConfrimPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxConfirmPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_update;
        private Button btn_delete;
        private DataGridView dgv_admin;
        private Panel pnlReceDetails;
        private PictureBox pBoxShowConfrimPassword;
        private PictureBox pBoxShowPassword;
        private PictureBox pBoxConfirmPassword;
        private PictureBox pictureBox9;
        private PictureBox pBoxPassword;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txt_phone;
        private Label lb_Phone;
        private TextBox txt_lastName;
        private Label lb_LastNameRece;
        private TextBox txt_email;
        private Label lb_RecEmail;
        private TextBox txt_confirmPassword;
        private Label lb_confirmPassword;
        private TextBox txt_password;
        private Label lb_password;
        private TextBox txt_firstName;
        private Label lb_Fname;
        private TextBox txt_UserName;
        private Label lb_userName;
        private Button btn_removeReceptionist;
        private Button btn_UpdateReceptionist;
        private Button btn_Add;
        private DataGridViewImageColumn icon;
    }
}