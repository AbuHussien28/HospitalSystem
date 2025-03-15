namespace ProjectHospitalSystem
{
    partial class WelcomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            paneLogoHospital = new Panel();
            pictureBox3 = new PictureBox();
            pTitleBox = new Panel();
            pictureBox4 = new PictureBox();
            lbTitleScreen = new Label();
            pBoxExit = new PictureBox();
            imageList1 = new ImageList(components);
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtBoxUserName = new TextBox();
            txtBoxUserPassword = new TextBox();
            pBoxShowPassword = new PictureBox();
            btn_clear = new Button();
            lbUserName = new Label();
            lbUserPassword = new Label();
            lbTitleWelcome = new Label();
            lblDateTime = new Label();
            timerDt = new System.Windows.Forms.Timer(components);
            paneLogoHospital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pTitleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).BeginInit();
            SuspendLayout();
            // 
            // paneLogoHospital
            // 
            paneLogoHospital.BackColor = Color.FromArgb(254, 251, 244);
            paneLogoHospital.Controls.Add(pictureBox3);
            paneLogoHospital.Dock = DockStyle.Left;
            paneLogoHospital.Location = new Point(0, 0);
            paneLogoHospital.Name = "paneLogoHospital";
            paneLogoHospital.Size = new Size(344, 391);
            paneLogoHospital.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.LoginImageScreen;
            pictureBox3.Location = new Point(3, 47);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(338, 344);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pTitleBox
            // 
            pTitleBox.BackColor = Color.FromArgb(254, 251, 244);
            pTitleBox.Controls.Add(pictureBox4);
            pTitleBox.Controls.Add(lbTitleScreen);
            pTitleBox.Controls.Add(pBoxExit);
            pTitleBox.Location = new Point(3, 0);
            pTitleBox.Name = "pTitleBox";
            pTitleBox.Size = new Size(878, 58);
            pTitleBox.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconHealth32;
            pictureBox4.Location = new Point(247, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 38;
            pictureBox4.TabStop = false;
            // 
            // lbTitleScreen
            // 
            lbTitleScreen.AutoSize = true;
            lbTitleScreen.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleScreen.ForeColor = Color.FromArgb(0, 51, 102);
            lbTitleScreen.Location = new Point(285, 12);
            lbTitleScreen.Name = "lbTitleScreen";
            lbTitleScreen.Size = new Size(354, 32);
            lbTitleScreen.TabIndex = 37;
            lbTitleScreen.Text = "Hospital Management System";
            // 
            // pBoxExit
            // 
            pBoxExit.Image = Properties.Resources.IconExit128Px;
            pBoxExit.Location = new Point(822, 12);
            pBoxExit.Name = "pBoxExit";
            pBoxExit.Size = new Size(32, 32);
            pBoxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxExit.TabIndex = 36;
            pBoxExit.TabStop = false;
            pBoxExit.Click += pBoxExit_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "LoginIconForBtn.png");
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(54, 201, 95);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(35, 253, 113);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 239, 113);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 253, 113);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(250, 253, 252);
            btnLogin.Image = Properties.Resources.LoginIconForBtn16px;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(576, 267);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(91, 47);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconUserName;
            pictureBox1.Location = new Point(368, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconUserPassword;
            pictureBox2.Location = new Point(368, 223);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.BackColor = Color.LightGray;
            txtBoxUserName.Font = new Font("Segoe UI", 15F);
            txtBoxUserName.Location = new Point(534, 134);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(299, 34);
            txtBoxUserName.TabIndex = 30;
            txtBoxUserName.MouseEnter += txtBoxUserName_MouseEnter;
            txtBoxUserName.MouseLeave += txtBoxUserName_MouseLeave;
            // 
            // txtBoxUserPassword
            // 
            txtBoxUserPassword.BackColor = Color.LightGray;
            txtBoxUserPassword.Font = new Font("Segoe UI", 15F);
            txtBoxUserPassword.Location = new Point(534, 217);
            txtBoxUserPassword.Name = "txtBoxUserPassword";
            txtBoxUserPassword.Size = new Size(299, 34);
            txtBoxUserPassword.TabIndex = 32;
            txtBoxUserPassword.UseSystemPasswordChar = true;
            txtBoxUserPassword.MouseEnter += txtBoxUserPassword_MouseEnter;
            txtBoxUserPassword.MouseLeave += txtBoxUserPassword_MouseLeave;
            // 
            // pBoxShowPassword
            // 
            pBoxShowPassword.BackColor = Color.LightGray;
            pBoxShowPassword.Image = Properties.Resources.IconShowPassword;
            pBoxShowPassword.Location = new Point(799, 223);
            pBoxShowPassword.Name = "pBoxShowPassword";
            pBoxShowPassword.Size = new Size(24, 24);
            pBoxShowPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxShowPassword.TabIndex = 33;
            pBoxShowPassword.TabStop = false;
            pBoxShowPassword.Click += pBoxShowPassword_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(255, 77, 77);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 77, 77);
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(217, 0, 0);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_clear.ForeColor = Color.FromArgb(250, 253, 252);
            btn_clear.Image = Properties.Resources.IconClear16px;
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(709, 267);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(95, 47);
            btn_clear.TabIndex = 35;
            btn_clear.Text = "Clear ";
            btn_clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(398, 144);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(129, 25);
            lbUserName.TabIndex = 36;
            lbUserName.Text = "UserName:";
            // 
            // lbUserPassword
            // 
            lbUserPassword.AutoSize = true;
            lbUserPassword.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
            lbUserPassword.Location = new Point(398, 222);
            lbUserPassword.Name = "lbUserPassword";
            lbUserPassword.Size = new Size(123, 25);
            lbUserPassword.TabIndex = 37;
            lbUserPassword.Text = "Password:";
            // 
            // lbTitleWelcome
            // 
            lbTitleWelcome.AutoSize = true;
            lbTitleWelcome.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitleWelcome.ForeColor = Color.FromArgb(75, 75, 75);
            lbTitleWelcome.Location = new Point(382, 85);
            lbTitleWelcome.Name = "lbTitleWelcome";
            lbTitleWelcome.Size = new Size(402, 29);
            lbTitleWelcome.TabIndex = 39;
            lbTitleWelcome.Text = "Welcome to ITI Hospital System";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(416, 340);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 17);
            lblDateTime.TabIndex = 40;
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timerDt
            // 
            timerDt.Tick += timerDt_Tick;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(178, 164, 146);
            ClientSize = new Size(880, 391);
            ControlBox = false;
            Controls.Add(lblDateTime);
            Controls.Add(lbTitleWelcome);
            Controls.Add(lbUserPassword);
            Controls.Add(lbUserName);
            Controls.Add(btn_clear);
            Controls.Add(pBoxShowPassword);
            Controls.Add(txtBoxUserPassword);
            Controls.Add(txtBoxUserName);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(pTitleBox);
            Controls.Add(paneLogoHospital);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += WelcomeScreen_Load;
            paneLogoHospital.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pTitleBox.ResumeLayout(false);
            pTitleBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel paneLogoHospital;
        private Panel pTitleBox;
        private ImageList imageList1;
        private PictureBox pBoxExit;
        private PictureBox pictureBox3;
        private Button btnLogin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtBoxUserName;
        private TextBox txtBoxUserPassword;
        private PictureBox pBoxShowPassword;
        private Button btn_clear;
        private Label lbUserName;
        private Label lbUserPassword;
        private Label lbTitleScreen;
        private PictureBox pictureBox4;
        private Label lbTitleWelcome;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timerDt;
    }
}
