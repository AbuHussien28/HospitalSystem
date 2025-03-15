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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_AdminReceptionist = new DataGridView();
            icon = new DataGridViewImageColumn();
            pictureBox1 = new PictureBox();
            txtBoxReceptionsitSerachData = new TextBox();
            lbReceptionsitNameSearch = new Label();
            btn_removeReceptionist = new Button();
            btn_UpdateReceptionist = new Button();
            btn_AddReceptionist = new Button();
            lb_userName = new Label();
            txt_username = new TextBox();
            lb_Fname = new Label();
            txt_Fname = new TextBox();
            lb_password = new Label();
            txt_Password = new TextBox();
            lb_confirmPassword = new Label();
            txt_confirmPassword = new TextBox();
            lb_RecEmail = new Label();
            txt_Email = new TextBox();
            lb_LastNameRece = new Label();
            txt_Lname = new TextBox();
            lb_Phone = new Label();
            txt_phone = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pBoxPassword = new PictureBox();
            pictureBox9 = new PictureBox();
            pBoxConfirmPassword = new PictureBox();
            pnlReceDetails = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminReceptionist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxConfirmPassword).BeginInit();
            pnlReceDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_AdminReceptionist
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_AdminReceptionist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_AdminReceptionist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminReceptionist.BackgroundColor = Color.White;
            dgv_AdminReceptionist.BorderStyle = BorderStyle.None;
            dgv_AdminReceptionist.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_AdminReceptionist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_AdminReceptionist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_AdminReceptionist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminReceptionist.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_AdminReceptionist.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_AdminReceptionist.EnableHeadersVisualStyles = false;
            dgv_AdminReceptionist.Location = new Point(9, 49);
            dgv_AdminReceptionist.Name = "dgv_AdminReceptionist";
            dgv_AdminReceptionist.RowHeadersVisible = false;
            dgv_AdminReceptionist.RowTemplate.Height = 40;
            dgv_AdminReceptionist.Size = new Size(962, 307);
            dgv_AdminReceptionist.TabIndex = 93;
            dgv_AdminReceptionist.CellMouseDoubleClick += dgv_AdminReceptionist_CellMouseDoubleClick;
            // 
            // icon
            // 
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconRecepDgv;
            icon.Name = "icon";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconRecepSearch;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 96;
            pictureBox1.TabStop = false;
            // 
            // txtBoxReceptionsitSerachData
            // 
            txtBoxReceptionsitSerachData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxReceptionsitSerachData.ForeColor = Color.Gray;
            txtBoxReceptionsitSerachData.Location = new Point(218, 12);
            txtBoxReceptionsitSerachData.Margin = new Padding(5);
            txtBoxReceptionsitSerachData.Name = "txtBoxReceptionsitSerachData";
            txtBoxReceptionsitSerachData.PlaceholderText = "Search by Name";
            txtBoxReceptionsitSerachData.Size = new Size(233, 29);
            txtBoxReceptionsitSerachData.TabIndex = 95;
            txtBoxReceptionsitSerachData.TextChanged += txtBoxReceptionsitSerachData_TextChanged;
            // 
            // lbReceptionsitNameSearch
            // 
            lbReceptionsitNameSearch.AutoSize = true;
            lbReceptionsitNameSearch.BackColor = Color.Transparent;
            lbReceptionsitNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbReceptionsitNameSearch.Location = new Point(51, 15);
            lbReceptionsitNameSearch.Name = "lbReceptionsitNameSearch";
            lbReceptionsitNameSearch.Size = new Size(159, 21);
            lbReceptionsitNameSearch.TabIndex = 94;
            lbReceptionsitNameSearch.Text = "Receptionsit Name:";
            lbReceptionsitNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_removeReceptionist
            // 
            btn_removeReceptionist.BackColor = Color.Crimson;
            btn_removeReceptionist.Cursor = Cursors.No;
            btn_removeReceptionist.FlatAppearance.BorderSize = 0;
            btn_removeReceptionist.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_removeReceptionist.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_removeReceptionist.FlatStyle = FlatStyle.Flat;
            btn_removeReceptionist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_removeReceptionist.ForeColor = Color.White;
            btn_removeReceptionist.Image = Properties.Resources.IconRemovedOCTOR;
            btn_removeReceptionist.ImageAlign = ContentAlignment.MiddleLeft;
            btn_removeReceptionist.Location = new Point(867, 532);
            btn_removeReceptionist.Name = "btn_removeReceptionist";
            btn_removeReceptionist.Size = new Size(104, 53);
            btn_removeReceptionist.TabIndex = 100;
            btn_removeReceptionist.Text = "Remove";
            btn_removeReceptionist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_removeReceptionist.UseVisualStyleBackColor = false;
            btn_removeReceptionist.Visible = false;
            btn_removeReceptionist.Click += btn_removeReceptionist_Click;
            // 
            // btn_UpdateReceptionist
            // 
            btn_UpdateReceptionist.BackColor = Color.DodgerBlue;
            btn_UpdateReceptionist.Cursor = Cursors.Hand;
            btn_UpdateReceptionist.FlatAppearance.BorderSize = 0;
            btn_UpdateReceptionist.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_UpdateReceptionist.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_UpdateReceptionist.FlatStyle = FlatStyle.Flat;
            btn_UpdateReceptionist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_UpdateReceptionist.ForeColor = Color.White;
            btn_UpdateReceptionist.Image = Properties.Resources.IconUpdateAdmin;
            btn_UpdateReceptionist.ImageAlign = ContentAlignment.MiddleLeft;
            btn_UpdateReceptionist.Location = new Point(867, 471);
            btn_UpdateReceptionist.Name = "btn_UpdateReceptionist";
            btn_UpdateReceptionist.Size = new Size(104, 53);
            btn_UpdateReceptionist.TabIndex = 99;
            btn_UpdateReceptionist.Text = "Update";
            btn_UpdateReceptionist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_UpdateReceptionist.UseVisualStyleBackColor = false;
            btn_UpdateReceptionist.Visible = false;
            btn_UpdateReceptionist.Click += btn_UpdateReceptionist_Click;
            // 
            // btn_AddReceptionist
            // 
            btn_AddReceptionist.BackColor = Color.LimeGreen;
            btn_AddReceptionist.Cursor = Cursors.Cross;
            btn_AddReceptionist.FlatAppearance.BorderSize = 0;
            btn_AddReceptionist.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_AddReceptionist.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_AddReceptionist.FlatStyle = FlatStyle.Flat;
            btn_AddReceptionist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddReceptionist.ForeColor = Color.White;
            btn_AddReceptionist.Image = Properties.Resources.IconRecepAddBtn;
            btn_AddReceptionist.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddReceptionist.Location = new Point(867, 396);
            btn_AddReceptionist.Name = "btn_AddReceptionist";
            btn_AddReceptionist.Size = new Size(104, 53);
            btn_AddReceptionist.TabIndex = 98;
            btn_AddReceptionist.Text = "Add ";
            btn_AddReceptionist.TextAlign = ContentAlignment.MiddleRight;
            btn_AddReceptionist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddReceptionist.UseVisualStyleBackColor = false;
            btn_AddReceptionist.Visible = false;
            btn_AddReceptionist.Click += btn_AddReceptionist_Click;
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
            txt_username.TabIndex = 1;
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
            txt_Fname.TabIndex = 2;
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
            // txt_Password
            // 
            txt_Password.BackColor = Color.White;
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.Font = new Font("Segoe UI", 12F);
            txt_Password.ForeColor = Color.Black;
            txt_Password.Location = new Point(592, 108);
            txt_Password.Margin = new Padding(5);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(233, 29);
            txt_Password.TabIndex = 6;
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
            txt_Email.TabIndex = 5;
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
            txt_Lname.TabIndex = 3;
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
            // pnlReceDetails
            // 
            pnlReceDetails.BackColor = Color.WhiteSmoke;
            pnlReceDetails.Controls.Add(pBoxConfirmPassword);
            pnlReceDetails.Controls.Add(pictureBox9);
            pnlReceDetails.Controls.Add(pBoxPassword);
            pnlReceDetails.Controls.Add(pictureBox6);
            pnlReceDetails.Controls.Add(pictureBox4);
            pnlReceDetails.Controls.Add(pictureBox3);
            pnlReceDetails.Controls.Add(pictureBox2);
            pnlReceDetails.Controls.Add(txt_phone);
            pnlReceDetails.Controls.Add(lb_Phone);
            pnlReceDetails.Controls.Add(txt_Lname);
            pnlReceDetails.Controls.Add(lb_LastNameRece);
            pnlReceDetails.Controls.Add(txt_Email);
            pnlReceDetails.Controls.Add(lb_RecEmail);
            pnlReceDetails.Controls.Add(txt_confirmPassword);
            pnlReceDetails.Controls.Add(lb_confirmPassword);
            pnlReceDetails.Controls.Add(txt_Password);
            pnlReceDetails.Controls.Add(lb_password);
            pnlReceDetails.Controls.Add(txt_Fname);
            pnlReceDetails.Controls.Add(lb_Fname);
            pnlReceDetails.Controls.Add(txt_username);
            pnlReceDetails.Controls.Add(lb_userName);
            pnlReceDetails.Location = new Point(21, 370);
            pnlReceDetails.Name = "pnlReceDetails";
            pnlReceDetails.Size = new Size(830, 200);
            pnlReceDetails.TabIndex = 97;
            // 
            // AdminReceptionsitCRUDOpeartion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1003, 605);
            Controls.Add(btn_removeReceptionist);
            Controls.Add(btn_UpdateReceptionist);
            Controls.Add(btn_AddReceptionist);
            Controls.Add(pnlReceDetails);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxReceptionsitSerachData);
            Controls.Add(lbReceptionsitNameSearch);
            Controls.Add(dgv_AdminReceptionist);
            Name = "AdminReceptionsitCRUDOpeartion";
            Text = "AdminReceptionsitCRUDOpeartion";
            Load += AdminReceptionsitCRUDOpeartion_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminReceptionist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxConfirmPassword).EndInit();
            pnlReceDetails.ResumeLayout(false);
            pnlReceDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxReceptionsitSerachData;
        private DataGridView dgv_AdminReceptionist;
        private PictureBox pictureBox1;
        private Label lbReceptionsitNameSearch;
        private PictureBox pictureBox10;
        private PictureBox pictureBox8;
        private TextBox txt_Specialization;
        private Label lb_Specialization;
        private ComboBox cb_DeptName;
        private Label lb_DeptName;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridViewImageColumn icon;
        private Button btn_removeReceptionist;
        private Button btn_UpdateReceptionist;
        private Button btn_AddReceptionist;
        private Label lb_userName;
        private TextBox txt_username;
        private Label lb_Fname;
        private TextBox txt_Fname;
        private Label lb_password;
        private TextBox txt_Password;
        private Label lb_confirmPassword;
        private TextBox txt_confirmPassword;
        private Label lb_RecEmail;
        private TextBox txt_Email;
        private Label lb_LastNameRece;
        private TextBox txt_Lname;
        private Label lb_Phone;
        private TextBox txt_phone;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pBoxPassword;
        private PictureBox pictureBox9;
        private PictureBox pBoxConfirmPassword;
        private Panel pnlReceDetails;
    }
}