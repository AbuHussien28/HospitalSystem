namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class DoctorProfileForm
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
            txt_email = new TextBox();
            txt_specializtion = new TextBox();
            txt_lastName = new TextBox();
            txt_firstName = new TextBox();
            lbFirstName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btn_editProfile = new Button();
            btn_updateProfile = new Button();
            pictureBox8 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pcProfileGender = new PictureBox();
            lbUserName = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcProfileGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.WhiteSmoke;
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Segoe UI", 12F);
            txt_email.Location = new Point(156, 92);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(176, 22);
            txt_email.TabIndex = 24;
            // 
            // txt_specializtion
            // 
            txt_specializtion.BackColor = Color.WhiteSmoke;
            txt_specializtion.BorderStyle = BorderStyle.None;
            txt_specializtion.Font = new Font("Segoe UI", 12F);
            txt_specializtion.Location = new Point(156, 127);
            txt_specializtion.Name = "txt_specializtion";
            txt_specializtion.ReadOnly = true;
            txt_specializtion.Size = new Size(176, 22);
            txt_specializtion.TabIndex = 22;
            // 
            // txt_lastName
            // 
            txt_lastName.BackColor = Color.WhiteSmoke;
            txt_lastName.BorderStyle = BorderStyle.None;
            txt_lastName.Font = new Font("Segoe UI", 12F);
            txt_lastName.Location = new Point(156, 57);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.ReadOnly = true;
            txt_lastName.Size = new Size(176, 22);
            txt_lastName.TabIndex = 20;
            // 
            // txt_firstName
            // 
            txt_firstName.BackColor = Color.WhiteSmoke;
            txt_firstName.BorderStyle = BorderStyle.None;
            txt_firstName.Font = new Font("Segoe UI", 12F);
            txt_firstName.Location = new Point(156, 22);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.ReadOnly = true;
            txt_firstName.Size = new Size(176, 22);
            txt_firstName.TabIndex = 17;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.BackColor = Color.Transparent;
            lbFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbFirstName.Location = new Point(40, 25);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(96, 21);
            lbFirstName.TabIndex = 120;
            lbFirstName.Text = "First Name:";
            lbFirstName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 121;
            label1.Text = "Last Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(40, 95);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 122;
            label2.Text = "Email:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(38, 130);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 123;
            label3.Text = "Specializtion:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btn_editProfile);
            panel1.Controls.Add(btn_updateProfile);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(txt_specializtion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_firstName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_lastName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(lbFirstName);
            panel1.Location = new Point(386, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(355, 256);
            panel1.TabIndex = 124;
            // 
            // btn_editProfile
            // 
            btn_editProfile.BackColor = Color.FromArgb(55, 98, 219);
            btn_editProfile.Cursor = Cursors.Hand;
            btn_editProfile.FlatAppearance.BorderSize = 0;
            btn_editProfile.FlatStyle = FlatStyle.Flat;
            btn_editProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_editProfile.ForeColor = Color.White;
            btn_editProfile.Image = Properties.Resources.IconProfileDetails;
            btn_editProfile.Location = new Point(84, 162);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Size = new Size(112, 43);
            btn_editProfile.TabIndex = 129;
            btn_editProfile.Text = "Edit Details";
            btn_editProfile.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += btn_editProfile_Click;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(55, 98, 219);
            btn_updateProfile.Cursor = Cursors.Hand;
            btn_updateProfile.FlatAppearance.BorderSize = 0;
            btn_updateProfile.FlatStyle = FlatStyle.Flat;
            btn_updateProfile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_updateProfile.ForeColor = Color.White;
            btn_updateProfile.Image = Properties.Resources.IconProfileChange;
            btn_updateProfile.Location = new Point(202, 162);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(114, 43);
            btn_updateProfile.TabIndex = 128;
            btn_updateProfile.Text = "Update Profile";
            btn_updateProfile.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_updateProfile.UseVisualStyleBackColor = false;
            btn_updateProfile.Click += btn_updateProfile_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.IconDoctorData;
            pictureBox8.Location = new Point(10, 127);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 127;
            pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.IconEmail;
            pictureBox5.Location = new Point(10, 92);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 126;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconUserName;
            pictureBox4.Location = new Point(10, 57);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 125;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconUserName;
            pictureBox3.Location = new Point(10, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 124;
            pictureBox3.TabStop = false;
            // 
            // pcProfileGender
            // 
            pcProfileGender.Image = Properties.Resources.IconDoctorProfile1;
            pcProfileGender.Location = new Point(55, 75);
            pcProfileGender.Name = "pcProfileGender";
            pcProfileGender.Size = new Size(256, 256);
            pcProfileGender.SizeMode = PictureBoxSizeMode.AutoSize;
            pcProfileGender.TabIndex = 125;
            pcProfileGender.TabStop = false;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Transparent;
            lbUserName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(290, 19);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(120, 30);
            lbUserName.TabIndex = 127;
            lbUserName.Text = "User Name";
            lbUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconProfileForm;
            pictureBox1.Location = new Point(260, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 130;
            pictureBox1.TabStop = false;
            // 
            // DoctorProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(753, 339);
            Controls.Add(pictureBox1);
            Controls.Add(lbUserName);
            Controls.Add(pcProfileGender);
            Controls.Add(panel1);
            Name = "DoctorProfileForm";
            Text = "Doctor Profile";
            Load += DoctorProfileForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcProfileGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_email;
        private TextBox txt_specializtion;
        private TextBox txt_lastName;
        private TextBox txt_firstName;
        private Label lbFirstName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox pcProfileGender;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lbUserName;
        private PictureBox pictureBox8;
        private Button btn_editProfile;
        private Button btn_updateProfile;
        private PictureBox pictureBox1;
    }
}