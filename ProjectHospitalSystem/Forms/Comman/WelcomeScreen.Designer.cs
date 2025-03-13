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
            pTitleBox = new Panel();
            pBoxExit = new PictureBox();
            imageList1 = new ImageList(components);
            pBoxShowPassword = new PictureBox();
            txtBoxUserPassword = new TextBox();
            txtBoxUserName = new TextBox();
            lbUserPassword = new MaterialSkin.Controls.MaterialLabel();
            pictureBox2 = new PictureBox();
            lbUserName = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btn_clear = new Button();
            pTitleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // paneLogoHospital
            // 
            paneLogoHospital.Dock = DockStyle.Left;
            paneLogoHospital.Location = new Point(0, 0);
            paneLogoHospital.Name = "paneLogoHospital";
            paneLogoHospital.Size = new Size(311, 534);
            paneLogoHospital.TabIndex = 1;
            // 
            // pTitleBox
            // 
            pTitleBox.Controls.Add(pBoxExit);
            pTitleBox.Location = new Point(3, 0);
            pTitleBox.Name = "pTitleBox";
            pTitleBox.Size = new Size(874, 58);
            pTitleBox.TabIndex = 3;
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
            // pBoxShowPassword
            // 
            pBoxShowPassword.BackColor = Color.White;
            pBoxShowPassword.Image = Properties.Resources.IconShowPassword;
            pBoxShowPassword.Location = new Point(755, 308);
            pBoxShowPassword.Name = "pBoxShowPassword";
            pBoxShowPassword.Size = new Size(24, 24);
            pBoxShowPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxShowPassword.TabIndex = 33;
            pBoxShowPassword.TabStop = false;
            pBoxShowPassword.Click += pBoxShowPassword_Click;
            // 
            // txtBoxUserPassword
            // 
            txtBoxUserPassword.Font = new Font("Segoe UI", 15F);
            txtBoxUserPassword.Location = new Point(490, 303);
            txtBoxUserPassword.Name = "txtBoxUserPassword";
            txtBoxUserPassword.Size = new Size(299, 34);
            txtBoxUserPassword.TabIndex = 32;
            txtBoxUserPassword.UseSystemPasswordChar = true;
            // 
            // txtBoxUserName
            // 
            txtBoxUserName.Font = new Font("Segoe UI", 15F);
            txtBoxUserName.Location = new Point(490, 191);
            txtBoxUserName.Name = "txtBoxUserName";
            txtBoxUserName.Size = new Size(299, 34);
            txtBoxUserName.TabIndex = 30;
            // 
            // lbUserPassword
            // 
            lbUserPassword.AutoSize = true;
            lbUserPassword.Depth = 0;
            lbUserPassword.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbUserPassword.Location = new Point(403, 313);
            lbUserPassword.MouseState = MaterialSkin.MouseState.HOVER;
            lbUserPassword.Name = "lbUserPassword";
            lbUserPassword.Size = new Size(75, 19);
            lbUserPassword.TabIndex = 28;
            lbUserPassword.Text = "Password:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconUserPassword;
            pictureBox2.Location = new Point(372, 308);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Depth = 0;
            lbUserName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbUserName.Location = new Point(403, 204);
            lbUserName.MouseState = MaterialSkin.MouseState.HOVER;
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(78, 19);
            lbUserName.TabIndex = 26;
            lbUserName.Text = "UserName:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconUserName;
            pictureBox1.Location = new Point(372, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(30, 215, 96);
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(35, 253, 113);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 202, 90);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 253, 113);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLogin.Image = Properties.Resources.LoginIconForBtn;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.Location = new Point(509, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 47);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "Login";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Red;
            btn_clear.FlatAppearance.BorderColor = Color.FromArgb(35, 253, 113);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 202, 90);
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(35, 253, 113);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_clear.ForeColor = SystemColors.ButtonFace;
            btn_clear.Image = Properties.Resources.IconClear;
            btn_clear.ImageAlign = ContentAlignment.MiddleLeft;
            btn_clear.Location = new Point(671, 376);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(95, 47);
            btn_clear.TabIndex = 35;
            btn_clear.Text = "Clear ";
            btn_clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // WelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 534);
            ControlBox = false;
            Controls.Add(btn_clear);
            Controls.Add(pBoxShowPassword);
            Controls.Add(txtBoxUserPassword);
            Controls.Add(txtBoxUserName);
            Controls.Add(lbUserPassword);
            Controls.Add(pictureBox2);
            Controls.Add(lbUserName);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(pTitleBox);
            Controls.Add(paneLogoHospital);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeScreen";
            Text = "Form1";
            Load += WelcomeScreen_Load;
            pTitleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBoxExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel paneLogoHospital;
        private Panel pTitleBox;
        private ImageList imageList1;
        private PictureBox pBoxShowPassword;
        private TextBox txtBoxUserPassword;
        private TextBox txtBoxUserName;
        private MaterialSkin.Controls.MaterialLabel lbUserPassword;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel lbUserName;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btn_clear;
        private PictureBox pBoxExit;
    }
}
