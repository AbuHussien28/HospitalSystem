namespace ProjectHospitalSystem.Reports
{
    partial class Reports_Logging
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
            btn_RepNumberPatient = new Button();
            btn_RepSechedule = new Button();
            btn_RepOutstandPay = new Button();
            btn_RepVistHist = new Button();
            lblTitleReport = new Label();
            pictureBox1 = new PictureBox();
            panelContainer = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btn_RepNumberPatient
            // 
            btn_RepNumberPatient.BackColor = Color.LightBlue;
            btn_RepNumberPatient.Cursor = Cursors.Hand;
            btn_RepNumberPatient.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_RepNumberPatient.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_RepNumberPatient.FlatStyle = FlatStyle.Flat;
            btn_RepNumberPatient.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_RepNumberPatient.ForeColor = Color.Black;
            btn_RepNumberPatient.Image = Properties.Resources.IconReportBtn;
            btn_RepNumberPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RepNumberPatient.Location = new Point(13, 20);
            btn_RepNumberPatient.Name = "btn_RepNumberPatient";
            btn_RepNumberPatient.Size = new Size(250, 80);
            btn_RepNumberPatient.TabIndex = 0;
            btn_RepNumberPatient.Text = "Number of patients per department";
            btn_RepNumberPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_RepNumberPatient.UseVisualStyleBackColor = false;
            btn_RepNumberPatient.Click += btn_RepNumberPatient_Click;
            // 
            // btn_RepSechedule
            // 
            btn_RepSechedule.BackColor = Color.LightGreen;
            btn_RepSechedule.Cursor = Cursors.Hand;
            btn_RepSechedule.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_RepSechedule.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_RepSechedule.FlatStyle = FlatStyle.Flat;
            btn_RepSechedule.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_RepSechedule.ForeColor = Color.Black;
            btn_RepSechedule.Image = Properties.Resources.IconReportBtn;
            btn_RepSechedule.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RepSechedule.Location = new Point(302, 20);
            btn_RepSechedule.Name = "btn_RepSechedule";
            btn_RepSechedule.Size = new Size(250, 80);
            btn_RepSechedule.TabIndex = 1;
            btn_RepSechedule.Text = "Appointment schedules ";
            btn_RepSechedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_RepSechedule.UseVisualStyleBackColor = false;
            btn_RepSechedule.Click += btn_RepSechedule_Click;
            // 
            // btn_RepOutstandPay
            // 
            btn_RepOutstandPay.BackColor = Color.LightCoral;
            btn_RepOutstandPay.Cursor = Cursors.Hand;
            btn_RepOutstandPay.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_RepOutstandPay.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_RepOutstandPay.FlatStyle = FlatStyle.Flat;
            btn_RepOutstandPay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_RepOutstandPay.ForeColor = Color.Black;
            btn_RepOutstandPay.Image = Properties.Resources.IconReportBtn;
            btn_RepOutstandPay.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RepOutstandPay.Location = new Point(13, 131);
            btn_RepOutstandPay.Name = "btn_RepOutstandPay";
            btn_RepOutstandPay.Size = new Size(250, 80);
            btn_RepOutstandPay.TabIndex = 2;
            btn_RepOutstandPay.Text = "Outstanding payments ";
            btn_RepOutstandPay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_RepOutstandPay.UseVisualStyleBackColor = false;
            btn_RepOutstandPay.Click += btn_RepOutstandPay_Click;
            // 
            // btn_RepVistHist
            // 
            btn_RepVistHist.BackColor = Color.LightGray;
            btn_RepVistHist.Cursor = Cursors.Hand;
            btn_RepVistHist.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_RepVistHist.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_RepVistHist.FlatStyle = FlatStyle.Flat;
            btn_RepVistHist.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btn_RepVistHist.ForeColor = Color.Black;
            btn_RepVistHist.Image = Properties.Resources.IconReportBtn;
            btn_RepVistHist.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RepVistHist.Location = new Point(302, 131);
            btn_RepVistHist.Name = "btn_RepVistHist";
            btn_RepVistHist.Size = new Size(250, 80);
            btn_RepVistHist.TabIndex = 3;
            btn_RepVistHist.Text = "Patient visit history ";
            btn_RepVistHist.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_RepVistHist.UseVisualStyleBackColor = false;
            btn_RepVistHist.Click += btn_RepVistHist_Click;
            // 
            // lblTitleReport
            // 
            lblTitleReport.AutoSize = true;
            lblTitleReport.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleReport.ForeColor = Color.DarkBlue;
            lblTitleReport.Location = new Point(53, 11);
            lblTitleReport.Name = "lblTitleReport";
            lblTitleReport.Size = new Size(266, 32);
            lblTitleReport.TabIndex = 4;
            lblTitleReport.Text = "Choose Form Reports ";
            lblTitleReport.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconChooseReport;
            pictureBox1.Location = new Point(23, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.WhiteSmoke;
            panelContainer.BorderStyle = BorderStyle.FixedSingle;
            panelContainer.Controls.Add(btn_RepNumberPatient);
            panelContainer.Controls.Add(btn_RepSechedule);
            panelContainer.Controls.Add(btn_RepOutstandPay);
            panelContainer.Controls.Add(btn_RepVistHist);
            panelContainer.Location = new Point(23, 68);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(10);
            panelContainer.Size = new Size(567, 246);
            panelContainer.TabIndex = 6;
            // 
            // Reports_Logging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(602, 344);
            Controls.Add(panelContainer);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitleReport);
            Name = "Reports_Logging";
            Text = "Reports_Logging";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_RepNumberPatient;
        private Button btn_RepSechedule;
        private Button btn_RepOutstandPay;
        private Button btn_RepVistHist;
        private Label lblTitleReport;
        private PictureBox pictureBox1;
        private Panel panelContainer;
    }
}