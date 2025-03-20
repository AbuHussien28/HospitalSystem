namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class HomeRecp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeRecp));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            imageList1 = new ImageList(components);
            timerDt = new System.Windows.Forms.Timer(components);
            panelShowDetails = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pcBoxStatus = new PictureBox();
            lb_AppoimData = new Label();
            pictureBox2 = new PictureBox();
            lb_AppoimTitle = new Label();
            lb_DoctorNameTitle = new Label();
            pictureBox5 = new PictureBox();
            lb_DoctorNameData = new Label();
            lb_PatientNameData = new Label();
            lb_PatientNameTitle = new Label();
            pictureBox4 = new PictureBox();
            lb_PatientStatusData = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            txt_search_pat = new TextBox();
            lbReceptionsitPatientNameSearch = new Label();
            dgv_Appup = new DataGridView();
            icon = new DataGridViewImageColumn();
            btn_newApp = new Button();
            btn_newPaitent = new Button();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            dailyAppointmentsLabel = new Label();
            panelShowDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Appup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "IconBill.png");
            imageList1.Images.SetKeyName(1, "IconDepartments.png");
            imageList1.Images.SetKeyName(2, "IconHome.png");
            imageList1.Images.SetKeyName(3, "IconPaientent.png");
            imageList1.Images.SetKeyName(4, "IconReport.png");
            imageList1.Images.SetKeyName(5, "IconLogout.png");
            imageList1.Images.SetKeyName(6, "IconAppoimnet.png");
            // 
            // panelShowDetails
            // 
            panelShowDetails.BackColor = Color.WhiteSmoke;
            panelShowDetails.Controls.Add(label1);
            panelShowDetails.Controls.Add(pictureBox3);
            panelShowDetails.Controls.Add(pcBoxStatus);
            panelShowDetails.Controls.Add(lb_AppoimData);
            panelShowDetails.Controls.Add(pictureBox2);
            panelShowDetails.Controls.Add(lb_AppoimTitle);
            panelShowDetails.Controls.Add(lb_DoctorNameTitle);
            panelShowDetails.Controls.Add(pictureBox5);
            panelShowDetails.Controls.Add(lb_DoctorNameData);
            panelShowDetails.Controls.Add(lb_PatientNameData);
            panelShowDetails.Controls.Add(lb_PatientNameTitle);
            panelShowDetails.Controls.Add(pictureBox4);
            panelShowDetails.Controls.Add(lb_PatientStatusData);
            panelShowDetails.Controls.Add(label8);
            panelShowDetails.Location = new Point(49, 488);
            panelShowDetails.Name = "panelShowDetails";
            panelShowDetails.Size = new Size(1022, 238);
            panelShowDetails.TabIndex = 121;
            panelShowDetails.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(386, 21);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 113;
            label1.Text = "Appointments Details";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(68, 130);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 109;
            pictureBox3.TabStop = false;
            // 
            // pcBoxStatus
            // 
            pcBoxStatus.Image = Properties.Resources.IconNotFound;
            pcBoxStatus.Location = new Point(745, 131);
            pcBoxStatus.Name = "pcBoxStatus";
            pcBoxStatus.Size = new Size(24, 24);
            pcBoxStatus.SizeMode = PictureBoxSizeMode.AutoSize;
            pcBoxStatus.TabIndex = 112;
            pcBoxStatus.TabStop = false;
            // 
            // lb_AppoimData
            // 
            lb_AppoimData.AutoSize = true;
            lb_AppoimData.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_AppoimData.ForeColor = Color.Black;
            lb_AppoimData.Location = new Point(244, 142);
            lb_AppoimData.Name = "lb_AppoimData";
            lb_AppoimData.Size = new Size(70, 23);
            lb_AppoimData.TabIndex = 105;
            lb_AppoimData.Text = "label5";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconRecPaitData;
            pictureBox2.Location = new Point(68, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 108;
            pictureBox2.TabStop = false;
            // 
            // lb_AppoimTitle
            // 
            lb_AppoimTitle.AutoSize = true;
            lb_AppoimTitle.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_AppoimTitle.ForeColor = Color.Black;
            lb_AppoimTitle.Location = new Point(98, 130);
            lb_AppoimTitle.Name = "lb_AppoimTitle";
            lb_AppoimTitle.Size = new Size(120, 46);
            lb_AppoimTitle.TabIndex = 104;
            lb_AppoimTitle.Text = "Appointment\r\nDate Tme:";
            lb_AppoimTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_DoctorNameTitle
            // 
            lb_DoctorNameTitle.AutoSize = true;
            lb_DoctorNameTitle.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_DoctorNameTitle.ForeColor = Color.Black;
            lb_DoctorNameTitle.Location = new Point(659, 62);
            lb_DoctorNameTitle.Name = "lb_DoctorNameTitle";
            lb_DoctorNameTitle.Size = new Size(130, 23);
            lb_DoctorNameTitle.TabIndex = 102;
            lb_DoctorNameTitle.Text = "Doctor Name:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.IconRecStatus;
            pictureBox5.Location = new Point(629, 130);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 111;
            pictureBox5.TabStop = false;
            // 
            // lb_DoctorNameData
            // 
            lb_DoctorNameData.AutoSize = true;
            lb_DoctorNameData.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_DoctorNameData.ForeColor = Color.Black;
            lb_DoctorNameData.Location = new Point(795, 62);
            lb_DoctorNameData.Name = "lb_DoctorNameData";
            lb_DoctorNameData.Size = new Size(70, 23);
            lb_DoctorNameData.TabIndex = 103;
            lb_DoctorNameData.Text = "label3";
            // 
            // lb_PatientNameData
            // 
            lb_PatientNameData.AutoSize = true;
            lb_PatientNameData.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_PatientNameData.ForeColor = Color.Black;
            lb_PatientNameData.Location = new Point(244, 61);
            lb_PatientNameData.Name = "lb_PatientNameData";
            lb_PatientNameData.Size = new Size(70, 23);
            lb_PatientNameData.TabIndex = 101;
            lb_PatientNameData.Text = "label2";
            // 
            // lb_PatientNameTitle
            // 
            lb_PatientNameTitle.AutoSize = true;
            lb_PatientNameTitle.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_PatientNameTitle.ForeColor = Color.Black;
            lb_PatientNameTitle.Location = new Point(98, 62);
            lb_PatientNameTitle.Name = "lb_PatientNameTitle";
            lb_PatientNameTitle.Size = new Size(140, 23);
            lb_PatientNameTitle.TabIndex = 100;
            lb_PatientNameTitle.Text = "Patient Name:";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconRecDoctor;
            pictureBox4.Location = new Point(629, 61);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 110;
            pictureBox4.TabStop = false;
            // 
            // lb_PatientStatusData
            // 
            lb_PatientStatusData.AutoSize = true;
            lb_PatientStatusData.Font = new Font("Simplified Arabic Fixed", 12F);
            lb_PatientStatusData.ForeColor = Color.Black;
            lb_PatientStatusData.Location = new Point(795, 131);
            lb_PatientStatusData.Name = "lb_PatientStatusData";
            lb_PatientStatusData.Size = new Size(70, 23);
            lb_PatientStatusData.TabIndex = 107;
            lb_PatientStatusData.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Simplified Arabic Fixed", 12F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(659, 130);
            label8.Name = "label8";
            label8.Size = new Size(80, 23);
            label8.TabIndex = 106;
            label8.Text = "Status:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 120;
            pictureBox1.TabStop = false;
            // 
            // txt_search_pat
            // 
            txt_search_pat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_search_pat.ForeColor = Color.Gray;
            txt_search_pat.Location = new Point(200, 92);
            txt_search_pat.Margin = new Padding(5);
            txt_search_pat.Name = "txt_search_pat";
            txt_search_pat.PlaceholderText = "Search by Name";
            txt_search_pat.Size = new Size(233, 29);
            txt_search_pat.TabIndex = 119;
            txt_search_pat.TextChanged += txt_search_pat_TextChanged;
            // 
            // lbReceptionsitPatientNameSearch
            // 
            lbReceptionsitPatientNameSearch.AutoSize = true;
            lbReceptionsitPatientNameSearch.BackColor = Color.Transparent;
            lbReceptionsitPatientNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbReceptionsitPatientNameSearch.Location = new Point(73, 98);
            lbReceptionsitPatientNameSearch.Name = "lbReceptionsitPatientNameSearch";
            lbReceptionsitPatientNameSearch.Size = new Size(119, 21);
            lbReceptionsitPatientNameSearch.TabIndex = 118;
            lbReceptionsitPatientNameSearch.Text = "Patient Name:";
            lbReceptionsitPatientNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgv_Appup
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_Appup.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Appup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Appup.BackgroundColor = Color.White;
            dgv_Appup.BorderStyle = BorderStyle.None;
            dgv_Appup.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Appup.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Appup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Appup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Appup.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Appup.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Appup.EnableHeadersVisualStyles = false;
            dgv_Appup.Location = new Point(30, 158);
            dgv_Appup.Name = "dgv_Appup";
            dgv_Appup.RowHeadersVisible = false;
            dgv_Appup.RowTemplate.Height = 40;
            dgv_Appup.Size = new Size(1041, 307);
            dgv_Appup.TabIndex = 117;
            dgv_Appup.CellContentClick += dgv_Appup_CellContentClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconAppoinmentDgv;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // btn_newApp
            // 
            btn_newApp.BackColor = Color.LightBlue;
            btn_newApp.Cursor = Cursors.Hand;
            btn_newApp.FlatStyle = FlatStyle.Flat;
            btn_newApp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_newApp.ForeColor = Color.Black;
            btn_newApp.Image = Properties.Resources.IconAppoinmentDgv;
            btn_newApp.ImageAlign = ContentAlignment.MiddleLeft;
            btn_newApp.Location = new Point(650, 81);
            btn_newApp.Name = "btn_newApp";
            btn_newApp.Size = new Size(188, 56);
            btn_newApp.TabIndex = 115;
            btn_newApp.Text = "New Appointment";
            btn_newApp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_newApp.UseVisualStyleBackColor = false;
            btn_newApp.Click += btn_newApp_Click;
            // 
            // btn_newPaitent
            // 
            btn_newPaitent.BackColor = Color.LightBlue;
            btn_newPaitent.Cursor = Cursors.Hand;
            btn_newPaitent.FlatStyle = FlatStyle.Flat;
            btn_newPaitent.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_newPaitent.ForeColor = Color.Black;
            btn_newPaitent.Image = Properties.Resources.IconAddPat;
            btn_newPaitent.ImageAlign = ContentAlignment.MiddleLeft;
            btn_newPaitent.Location = new Point(473, 81);
            btn_newPaitent.Name = "btn_newPaitent";
            btn_newPaitent.Size = new Size(156, 56);
            btn_newPaitent.TabIndex = 116;
            btn_newPaitent.Text = "New Patient";
            btn_newPaitent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_newPaitent.UseVisualStyleBackColor = false;
            btn_newPaitent.Click += btn_newPaitent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 24);
            label2.Name = "label2";
            label2.Size = new Size(209, 30);
            label2.TabIndex = 122;
            label2.Text = "Daily Appointments";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconDailyApp;
            pictureBox6.Location = new Point(424, 30);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 123;
            pictureBox6.TabStop = false;
            // 
            // dailyAppointmentsLabel
            // 
            dailyAppointmentsLabel.AutoSize = true;
            dailyAppointmentsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dailyAppointmentsLabel.Location = new Point(898, 95);
            dailyAppointmentsLabel.Name = "dailyAppointmentsLabel";
            dailyAppointmentsLabel.Size = new Size(0, 21);
            dailyAppointmentsLabel.TabIndex = 124;
            // 
            // HomeRecp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1159, 765);
            Controls.Add(dailyAppointmentsLabel);
            Controls.Add(pictureBox6);
            Controls.Add(label2);
            Controls.Add(panelShowDetails);
            Controls.Add(pictureBox1);
            Controls.Add(txt_search_pat);
            Controls.Add(lbReceptionsitPatientNameSearch);
            Controls.Add(dgv_Appup);
            Controls.Add(btn_newApp);
            Controls.Add(btn_newPaitent);
            Name = "HomeRecp";
            Text = "HomeRecp";
            panelShowDetails.ResumeLayout(false);
            panelShowDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcBoxStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Appup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private System.Windows.Forms.Timer timerDt;
        private Panel panelShowDetails;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pcBoxStatus;
        private Label lb_AppoimData;
        private PictureBox pictureBox2;
        private Label lb_AppoimTitle;
        private Label lb_DoctorNameTitle;
        private PictureBox pictureBox5;
        private Label lb_DoctorNameData;
        private Label lb_PatientNameData;
        private Label lb_PatientNameTitle;
        private PictureBox pictureBox4;
        private Label lb_PatientStatusData;
        private Label label8;
        private PictureBox pictureBox1;
        private TextBox txt_search_pat;
        private Label lbReceptionsitPatientNameSearch;
        private DataGridView dgv_Appup;
        private DataGridViewImageColumn icon;
        private Button btn_newApp;
        private Button btn_newPaitent;
        private Label label2;
        private PictureBox pictureBox6;
        private Label dailyAppointmentsLabel;
    }
}