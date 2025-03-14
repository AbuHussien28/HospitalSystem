namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class DoctorUser
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
            btn_appointment = new Button();
            btn_patient = new Button();
            btn_medicalrecord = new Button();
            btn_profile = new Button();
            btn_home = new Button();
            panel_navbar = new Panel();
            dgv_upcommingAppointmentHomePage = new DataGridView();
            label38 = new Label();
            dgv_patientListHome = new DataGridView();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            panel_HomePage = new Panel();
            panel_profile = new Panel();
            panel5 = new Panel();
            btn_updateProfile = new Button();
            txt_email = new TextBox();
            label24 = new Label();
            txt_specializtion = new TextBox();
            label22 = new Label();
            txt_lastName = new TextBox();
            label21 = new Label();
            btn_editProfile = new Button();
            txt_firstName = new TextBox();
            label20 = new Label();
            pictureBox1 = new PictureBox();
            label19 = new Label();
            panel_medicalrecord = new Panel();
            panel1 = new Panel();
            btn_delete = new Button();
            btn_update = new Button();
            label7 = new Label();
            txt_treatment = new TextBox();
            label6 = new Label();
            txt_labResult = new TextBox();
            label5 = new Label();
            txt_prescription = new TextBox();
            label4 = new Label();
            txt_diaqnois = new TextBox();
            label3 = new Label();
            txt_dateOfVisit = new TextBox();
            cb_patient = new ComboBox();
            btn_add = new Button();
            label2 = new Label();
            panel_Medical_Record_Data = new Panel();
            dgv_medicalrecord = new DataGridView();
            label1 = new Label();
            panel_patient = new Panel();
            panel3 = new Panel();
            btn_ExportWord = new Button();
            btn_ExportExcel = new Button();
            label34 = new Label();
            pictureTwo = new PictureBox();
            label8 = new Label();
            cb_searchitem = new ComboBox();
            dgv_resultofsearch = new DataGridView();
            search_bar = new TextBox();
            panel2 = new Panel();
            btn_word = new Button();
            btn_Qr = new Button();
            labelScan = new Label();
            pictureBox = new PictureBox();
            btn_updatemedicalhistory = new Button();
            txtNamePatient = new Label();
            label17 = new Label();
            txtTreatmentDetails = new TextBox();
            label16 = new Label();
            txtLabResult = new TextBox();
            label15 = new Label();
            txtPrescription = new TextBox();
            label14 = new Label();
            txtDiaqnois = new TextBox();
            label13 = new Label();
            txtMerdicalHistory = new TextBox();
            label12 = new Label();
            txtGender = new TextBox();
            label11 = new Label();
            txtDateOfBirth = new TextBox();
            label10 = new Label();
            label9 = new Label();
            dgv_patientlist = new DataGridView();
            label18 = new Label();
            panel_appointment = new Panel();
            label33 = new Label();
            btn_editstatus = new Button();
            txt_editStatus = new TextBox();
            dgv_appointment = new DataGridView();
            label32 = new Label();
            panel_navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_upcommingAppointmentHomePage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_patientListHome).BeginInit();
            panel_HomePage.SuspendLayout();
            panel_profile.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_medicalrecord.SuspendLayout();
            panel1.SuspendLayout();
            panel_Medical_Record_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_medicalrecord).BeginInit();
            panel_patient.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_resultofsearch).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_patientlist).BeginInit();
            panel_appointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment).BeginInit();
            SuspendLayout();
            // 
            // btn_appointment
            // 
            btn_appointment.Location = new Point(3, 191);
            btn_appointment.Name = "btn_appointment";
            btn_appointment.Size = new Size(164, 32);
            btn_appointment.TabIndex = 4;
            btn_appointment.Text = "Appointment";
            btn_appointment.UseVisualStyleBackColor = true;
            btn_appointment.Click += btn_appointment_Click;
            // 
            // btn_patient
            // 
            btn_patient.Location = new Point(3, 153);
            btn_patient.Name = "btn_patient";
            btn_patient.Size = new Size(164, 32);
            btn_patient.TabIndex = 3;
            btn_patient.Text = "Patient";
            btn_patient.UseVisualStyleBackColor = true;
            btn_patient.Click += btn_patient_Click;
            // 
            // btn_medicalrecord
            // 
            btn_medicalrecord.Location = new Point(3, 115);
            btn_medicalrecord.Name = "btn_medicalrecord";
            btn_medicalrecord.Size = new Size(164, 32);
            btn_medicalrecord.TabIndex = 2;
            btn_medicalrecord.Text = "Medical Record";
            btn_medicalrecord.UseVisualStyleBackColor = true;
            btn_medicalrecord.Click += btn_medicalrecord_Click;
            // 
            // btn_profile
            // 
            btn_profile.Location = new Point(3, 77);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(164, 32);
            btn_profile.TabIndex = 1;
            btn_profile.Text = "Profile";
            btn_profile.UseVisualStyleBackColor = true;
            btn_profile.Click += btn_profile_Click;
            // 
            // btn_home
            // 
            btn_home.Location = new Point(3, 39);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(164, 32);
            btn_home.TabIndex = 0;
            btn_home.Text = "Home";
            btn_home.UseVisualStyleBackColor = true;
            btn_home.Click += btn_home_Click;
            // 
            // panel_navbar
            // 
            panel_navbar.BackColor = Color.Silver;
            panel_navbar.Controls.Add(btn_appointment);
            panel_navbar.Controls.Add(btn_patient);
            panel_navbar.Controls.Add(btn_medicalrecord);
            panel_navbar.Controls.Add(btn_profile);
            panel_navbar.Controls.Add(btn_home);
            panel_navbar.Location = new Point(1, 11);
            panel_navbar.Name = "panel_navbar";
            panel_navbar.Size = new Size(170, 481);
            panel_navbar.TabIndex = 1;
            // 
            // dgv_upcommingAppointmentHomePage
            // 
            dgv_upcommingAppointmentHomePage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_upcommingAppointmentHomePage.Location = new Point(268, 136);
            dgv_upcommingAppointmentHomePage.Name = "dgv_upcommingAppointmentHomePage";
            dgv_upcommingAppointmentHomePage.Size = new Size(503, 150);
            dgv_upcommingAppointmentHomePage.TabIndex = 5;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 15F);
            label38.Location = new Point(268, 88);
            label38.Name = "label38";
            label38.Size = new Size(243, 28);
            label38.TabIndex = 4;
            label38.Text = "Upcomming Appointment";
            // 
            // dgv_patientListHome
            // 
            dgv_patientListHome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patientListHome.Location = new Point(41, 125);
            dgv_patientListHome.Name = "dgv_patientListHome";
            dgv_patientListHome.Size = new Size(158, 161);
            dgv_patientListHome.TabIndex = 3;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 15F);
            label37.Location = new Point(40, 79);
            label37.Name = "label37";
            label37.Size = new Size(106, 28);
            label37.TabIndex = 2;
            label37.Text = "Patient List";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 15F);
            label36.Location = new Point(265, 17);
            label36.Name = "label36";
            label36.Size = new Size(76, 28);
            label36.TabIndex = 1;
            label36.Text = "label36";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 15F);
            label35.Location = new Point(31, 17);
            label35.Name = "label35";
            label35.Size = new Size(228, 28);
            label35.TabIndex = 0;
            label35.Text = "Welcome Home Page Dr:";
            // 
            // panel_HomePage
            // 
            panel_HomePage.Controls.Add(dgv_upcommingAppointmentHomePage);
            panel_HomePage.Controls.Add(label38);
            panel_HomePage.Controls.Add(dgv_patientListHome);
            panel_HomePage.Controls.Add(label37);
            panel_HomePage.Controls.Add(label36);
            panel_HomePage.Controls.Add(label35);
            panel_HomePage.Location = new Point(177, 11);
            panel_HomePage.Name = "panel_HomePage";
            panel_HomePage.Size = new Size(1094, 485);
            panel_HomePage.TabIndex = 7;
            // 
            // panel_profile
            // 
            panel_profile.Controls.Add(panel5);
            panel_profile.Location = new Point(177, 7);
            panel_profile.Name = "panel_profile";
            panel_profile.Size = new Size(1094, 485);
            panel_profile.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btn_updateProfile);
            panel5.Controls.Add(txt_email);
            panel5.Controls.Add(label24);
            panel5.Controls.Add(txt_specializtion);
            panel5.Controls.Add(label22);
            panel5.Controls.Add(txt_lastName);
            panel5.Controls.Add(label21);
            panel5.Controls.Add(btn_editProfile);
            panel5.Controls.Add(txt_firstName);
            panel5.Controls.Add(label20);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(label19);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1088, 233);
            panel5.TabIndex = 6;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.Location = new Point(623, 186);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(138, 30);
            btn_updateProfile.TabIndex = 13;
            btn_updateProfile.Text = "Update";
            btn_updateProfile.UseVisualStyleBackColor = true;
            btn_updateProfile.Click += btn_updateProfile_Click;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(389, 62);
            txt_email.Name = "txt_email";
            txt_email.ReadOnly = true;
            txt_email.Size = new Size(160, 23);
            txt_email.TabIndex = 12;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(326, 65);
            label24.Name = "label24";
            label24.Size = new Size(36, 15);
            label24.TabIndex = 11;
            label24.Text = "Email";
            // 
            // txt_specializtion
            // 
            txt_specializtion.Location = new Point(389, 155);
            txt_specializtion.Name = "txt_specializtion";
            txt_specializtion.ReadOnly = true;
            txt_specializtion.Size = new Size(160, 23);
            txt_specializtion.TabIndex = 8;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(310, 158);
            label22.Name = "label22";
            label22.Size = new Size(73, 15);
            label22.TabIndex = 7;
            label22.Text = "Specializtion";
            // 
            // txt_lastName
            // 
            txt_lastName.Location = new Point(105, 155);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.ReadOnly = true;
            txt_lastName.Size = new Size(100, 23);
            txt_lastName.TabIndex = 6;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(26, 158);
            label21.Name = "label21";
            label21.Size = new Size(63, 15);
            label21.TabIndex = 5;
            label21.Text = "Last Name";
            // 
            // btn_editProfile
            // 
            btn_editProfile.Location = new Point(784, 186);
            btn_editProfile.Name = "btn_editProfile";
            btn_editProfile.Size = new Size(133, 30);
            btn_editProfile.TabIndex = 4;
            btn_editProfile.Text = "Edit Dr_Details";
            btn_editProfile.UseVisualStyleBackColor = true;
            btn_editProfile.Click += btn_editProfile_Click;
            // 
            // txt_firstName
            // 
            txt_firstName.Location = new Point(105, 62);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.ReadOnly = true;
            txt_firstName.Size = new Size(100, 23);
            txt_firstName.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(26, 65);
            label20.Name = "label20";
            label20.Size = new Size(64, 15);
            label20.TabIndex = 2;
            label20.Text = "First Name";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Doctor__2_;
            pictureBox1.Location = new Point(925, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 150);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15F);
            label19.Location = new Point(18, 12);
            label19.Name = "label19";
            label19.Size = new Size(137, 28);
            label19.TabIndex = 0;
            label19.Text = "Doctor Details";
            // 
            // panel_medicalrecord
            // 
            panel_medicalrecord.Controls.Add(panel1);
            panel_medicalrecord.Controls.Add(panel_Medical_Record_Data);
            panel_medicalrecord.Location = new Point(177, 3);
            panel_medicalrecord.Name = "panel_medicalrecord";
            panel_medicalrecord.Size = new Size(1091, 486);
            panel_medicalrecord.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txt_treatment);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_labResult);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_prescription);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_diaqnois);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_dateOfVisit);
            panel1.Controls.Add(cb_patient);
            panel1.Controls.Add(btn_add);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(7, 216);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 266);
            panel1.TabIndex = 2;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(578, 81);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 14;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(643, 27);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 13;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(255, 81);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 12;
            label7.Text = "Patient";
            // 
            // txt_treatment
            // 
            txt_treatment.Location = new Point(359, 26);
            txt_treatment.Name = "txt_treatment";
            txt_treatment.Size = new Size(139, 23);
            txt_treatment.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(255, 30);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 10;
            label6.Text = "Treatment Details";
            // 
            // txt_labResult
            // 
            txt_labResult.Location = new Point(90, 165);
            txt_labResult.Name = "txt_labResult";
            txt_labResult.Size = new Size(139, 23);
            txt_labResult.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 168);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Lab Result";
            // 
            // txt_prescription
            // 
            txt_prescription.Location = new Point(90, 120);
            txt_prescription.Name = "txt_prescription";
            txt_prescription.Size = new Size(139, 23);
            txt_prescription.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 123);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "Prescription";
            // 
            // txt_diaqnois
            // 
            txt_diaqnois.Location = new Point(90, 73);
            txt_diaqnois.Name = "txt_diaqnois";
            txt_diaqnois.Size = new Size(139, 23);
            txt_diaqnois.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 76);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Diaqnois";
            // 
            // txt_dateOfVisit
            // 
            txt_dateOfVisit.Location = new Point(90, 24);
            txt_dateOfVisit.Name = "txt_dateOfVisit";
            txt_dateOfVisit.Size = new Size(139, 23);
            txt_dateOfVisit.TabIndex = 3;
            // 
            // cb_patient
            // 
            cb_patient.FormattingEnabled = true;
            cb_patient.Location = new Point(359, 78);
            cb_patient.Name = "cb_patient";
            cb_patient.Size = new Size(139, 23);
            cb_patient.TabIndex = 2;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(508, 26);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 27);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "DateOfVisit";
            // 
            // panel_Medical_Record_Data
            // 
            panel_Medical_Record_Data.BackColor = Color.Gainsboro;
            panel_Medical_Record_Data.Controls.Add(dgv_medicalrecord);
            panel_Medical_Record_Data.Controls.Add(label1);
            panel_Medical_Record_Data.Location = new Point(8, 4);
            panel_Medical_Record_Data.Name = "panel_Medical_Record_Data";
            panel_Medical_Record_Data.Size = new Size(1080, 207);
            panel_Medical_Record_Data.TabIndex = 1;
            // 
            // dgv_medicalrecord
            // 
            dgv_medicalrecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_medicalrecord.Location = new Point(18, 45);
            dgv_medicalrecord.Name = "dgv_medicalrecord";
            dgv_medicalrecord.Size = new Size(1056, 150);
            dgv_medicalrecord.TabIndex = 1;
            dgv_medicalrecord.RowHeaderMouseDoubleClick += dgv_medicalrecord_RowHeaderMouseDoubleClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(18, 7);
            label1.Name = "label1";
            label1.Size = new Size(197, 28);
            label1.TabIndex = 0;
            label1.Text = "Medical Record Data:";
            // 
            // panel_patient
            // 
            panel_patient.Controls.Add(panel3);
            panel_patient.Controls.Add(panel2);
            panel_patient.Location = new Point(174, 0);
            panel_patient.Name = "panel_patient";
            panel_patient.Size = new Size(1094, 489);
            panel_patient.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(btn_ExportWord);
            panel3.Controls.Add(btn_ExportExcel);
            panel3.Controls.Add(label34);
            panel3.Controls.Add(pictureTwo);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cb_searchitem);
            panel3.Controls.Add(dgv_resultofsearch);
            panel3.Controls.Add(search_bar);
            panel3.Location = new Point(10, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(1078, 263);
            panel3.TabIndex = 2;
            // 
            // btn_ExportWord
            // 
            btn_ExportWord.Location = new Point(733, 112);
            btn_ExportWord.Name = "btn_ExportWord";
            btn_ExportWord.Size = new Size(110, 32);
            btn_ExportWord.TabIndex = 27;
            btn_ExportWord.Text = "Export As Word";
            btn_ExportWord.UseVisualStyleBackColor = true;
            btn_ExportWord.Click += btn_ExportWord_Click;
            // 
            // btn_ExportExcel
            // 
            btn_ExportExcel.Location = new Point(733, 150);
            btn_ExportExcel.Name = "btn_ExportExcel";
            btn_ExportExcel.Size = new Size(110, 32);
            btn_ExportExcel.TabIndex = 26;
            btn_ExportExcel.Text = "Export As Excel";
            btn_ExportExcel.UseVisualStyleBackColor = true;
            btn_ExportExcel.Click += btn_ExportExcel_Click;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(795, 78);
            label34.Name = "label34";
            label34.Size = new Size(48, 15);
            label34.TabIndex = 25;
            label34.Text = "Scan Qr";
            // 
            // pictureTwo
            // 
            pictureTwo.Location = new Point(862, 21);
            pictureTwo.Name = "pictureTwo";
            pictureTwo.Size = new Size(198, 184);
            pictureTwo.TabIndex = 24;
            pictureTwo.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(604, 39);
            label8.Name = "label8";
            label8.Size = new Size(96, 28);
            label8.TabIndex = 3;
            label8.Text = "Search By";
            // 
            // cb_searchitem
            // 
            cb_searchitem.FormattingEnabled = true;
            cb_searchitem.Location = new Point(706, 44);
            cb_searchitem.Name = "cb_searchitem";
            cb_searchitem.Size = new Size(121, 23);
            cb_searchitem.TabIndex = 2;
            // 
            // dgv_resultofsearch
            // 
            dgv_resultofsearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_resultofsearch.Location = new Point(27, 91);
            dgv_resultofsearch.Name = "dgv_resultofsearch";
            dgv_resultofsearch.Size = new Size(571, 150);
            dgv_resultofsearch.TabIndex = 1;
            dgv_resultofsearch.RowHeaderMouseDoubleClick += dgv_resultofsearch_RowHeaderMouseDoubleClick_1;
            // 
            // search_bar
            // 
            search_bar.BorderStyle = BorderStyle.None;
            search_bar.Location = new Point(27, 42);
            search_bar.Multiline = true;
            search_bar.Name = "search_bar";
            search_bar.PlaceholderText = "Enter Your Patient";
            search_bar.Size = new Size(571, 33);
            search_bar.TabIndex = 0;
            search_bar.TextChanged += search_bar_TextChanged_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(btn_word);
            panel2.Controls.Add(btn_Qr);
            panel2.Controls.Add(labelScan);
            panel2.Controls.Add(pictureBox);
            panel2.Controls.Add(btn_updatemedicalhistory);
            panel2.Controls.Add(txtNamePatient);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txtTreatmentDetails);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(txtLabResult);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(txtPrescription);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtDiaqnois);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txtMerdicalHistory);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtGender);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtDateOfBirth);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dgv_patientlist);
            panel2.Controls.Add(label18);
            panel2.Location = new Point(8, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1083, 195);
            panel2.TabIndex = 1;
            // 
            // btn_word
            // 
            btn_word.Location = new Point(765, 115);
            btn_word.Name = "btn_word";
            btn_word.Size = new Size(110, 32);
            btn_word.TabIndex = 23;
            btn_word.Text = "Export As Word";
            btn_word.UseVisualStyleBackColor = true;
            btn_word.Click += btn_word_Click;
            // 
            // btn_Qr
            // 
            btn_Qr.Location = new Point(765, 153);
            btn_Qr.Name = "btn_Qr";
            btn_Qr.Size = new Size(110, 32);
            btn_Qr.TabIndex = 22;
            btn_Qr.Text = "Export As Excel";
            btn_Qr.UseVisualStyleBackColor = true;
            btn_Qr.Click += btn_Qr_Click;
            // 
            // labelScan
            // 
            labelScan.AutoSize = true;
            labelScan.Location = new Point(827, 76);
            labelScan.Name = "labelScan";
            labelScan.Size = new Size(48, 15);
            labelScan.TabIndex = 21;
            labelScan.Text = "Scan Qr";
            labelScan.Click += labelScan_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(881, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(198, 184);
            pictureBox.TabIndex = 20;
            pictureBox.TabStop = false;
            // 
            // btn_updatemedicalhistory
            // 
            btn_updatemedicalhistory.Location = new Point(619, 125);
            btn_updatemedicalhistory.Name = "btn_updatemedicalhistory";
            btn_updatemedicalhistory.Size = new Size(148, 32);
            btn_updatemedicalhistory.TabIndex = 5;
            btn_updatemedicalhistory.Text = "Update Medical History";
            btn_updatemedicalhistory.UseVisualStyleBackColor = true;
            btn_updatemedicalhistory.Click += btn_updatemedicalhistory_Click;
            // 
            // txtNamePatient
            // 
            txtNamePatient.AutoSize = true;
            txtNamePatient.Font = new Font("Segoe UI", 15F);
            txtNamePatient.Location = new Point(752, 0);
            txtNamePatient.Name = "txtNamePatient";
            txtNamePatient.Size = new Size(0, 28);
            txtNamePatient.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F);
            label17.Location = new Point(619, 10);
            label17.Name = "label17";
            label17.Size = new Size(133, 28);
            label17.TabIndex = 18;
            label17.Text = "Patient Name:";
            // 
            // txtTreatmentDetails
            // 
            txtTreatmentDetails.BorderStyle = BorderStyle.None;
            txtTreatmentDetails.Location = new Point(717, 41);
            txtTreatmentDetails.Multiline = true;
            txtTreatmentDetails.Name = "txtTreatmentDetails";
            txtTreatmentDetails.ReadOnly = true;
            txtTreatmentDetails.Size = new Size(117, 32);
            txtTreatmentDetails.TabIndex = 17;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(619, 58);
            label16.Name = "label16";
            label16.Size = new Size(95, 15);
            label16.TabIndex = 16;
            label16.Text = "TreatmentDetails";
            // 
            // txtLabResult
            // 
            txtLabResult.BorderStyle = BorderStyle.None;
            txtLabResult.Location = new Point(717, 94);
            txtLabResult.Multiline = true;
            txtLabResult.Name = "txtLabResult";
            txtLabResult.ReadOnly = true;
            txtLabResult.Size = new Size(117, 22);
            txtLabResult.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(628, 96);
            label15.Name = "label15";
            label15.Size = new Size(58, 15);
            label15.TabIndex = 14;
            label15.Text = "LabResult";
            // 
            // txtPrescription
            // 
            txtPrescription.BorderStyle = BorderStyle.None;
            txtPrescription.Location = new Point(498, 87);
            txtPrescription.Multiline = true;
            txtPrescription.Name = "txtPrescription";
            txtPrescription.ReadOnly = true;
            txtPrescription.Size = new Size(117, 22);
            txtPrescription.TabIndex = 13;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(431, 94);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 12;
            label14.Text = "Prescription ";
            // 
            // txtDiaqnois
            // 
            txtDiaqnois.BorderStyle = BorderStyle.None;
            txtDiaqnois.Location = new Point(498, 47);
            txtDiaqnois.Multiline = true;
            txtDiaqnois.Name = "txtDiaqnois";
            txtDiaqnois.ReadOnly = true;
            txtDiaqnois.Size = new Size(117, 22);
            txtDiaqnois.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(431, 47);
            label13.Name = "label13";
            label13.Size = new Size(56, 15);
            label13.TabIndex = 10;
            label13.Text = "Diaqnois ";
            // 
            // txtMerdicalHistory
            // 
            txtMerdicalHistory.BorderStyle = BorderStyle.None;
            txtMerdicalHistory.Location = new Point(308, 123);
            txtMerdicalHistory.Multiline = true;
            txtMerdicalHistory.Name = "txtMerdicalHistory";
            txtMerdicalHistory.ReadOnly = true;
            txtMerdicalHistory.ScrollBars = ScrollBars.Vertical;
            txtMerdicalHistory.Size = new Size(307, 58);
            txtMerdicalHistory.TabIndex = 9;
            txtMerdicalHistory.DoubleClick += txtMerdicalHistory_DoubleClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(218, 123);
            label12.Name = "label12";
            label12.Size = new Size(90, 15);
            label12.TabIndex = 8;
            label12.Text = "MedicalHistory ";
            // 
            // txtGender
            // 
            txtGender.BorderStyle = BorderStyle.None;
            txtGender.Location = new Point(308, 85);
            txtGender.Multiline = true;
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(117, 22);
            txtGender.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(217, 85);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 6;
            label11.Text = "Gender";
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.Location = new Point(308, 47);
            txtDateOfBirth.Multiline = true;
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.ReadOnly = true;
            txtDateOfBirth.Size = new Size(117, 22);
            txtDateOfBirth.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(217, 47);
            label10.Name = "label10";
            label10.Size = new Size(72, 15);
            label10.TabIndex = 4;
            label10.Text = "DateOfBirth ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(214, 9);
            label9.Name = "label9";
            label9.Size = new Size(136, 28);
            label9.TabIndex = 2;
            label9.Text = "Patient Details";
            // 
            // dgv_patientlist
            // 
            dgv_patientlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patientlist.Location = new Point(15, 37);
            dgv_patientlist.Name = "dgv_patientlist";
            dgv_patientlist.Size = new Size(139, 150);
            dgv_patientlist.TabIndex = 1;
            dgv_patientlist.RowHeaderMouseDoubleClick += dgv_patientlist_RowHeaderMouseDoubleClick;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F);
            label18.Location = new Point(15, 6);
            label18.Name = "label18";
            label18.Size = new Size(139, 28);
            label18.TabIndex = 0;
            label18.Text = "My Patient List";
            // 
            // panel_appointment
            // 
            panel_appointment.Controls.Add(label33);
            panel_appointment.Controls.Add(btn_editstatus);
            panel_appointment.Controls.Add(txt_editStatus);
            panel_appointment.Controls.Add(dgv_appointment);
            panel_appointment.Controls.Add(label32);
            panel_appointment.Location = new Point(174, 0);
            panel_appointment.Name = "panel_appointment";
            panel_appointment.Size = new Size(1132, 496);
            panel_appointment.TabIndex = 24;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 13F);
            label33.Location = new Point(40, 271);
            label33.Name = "label33";
            label33.Size = new Size(60, 25);
            label33.TabIndex = 10;
            label33.Text = "Status";
            // 
            // btn_editstatus
            // 
            btn_editstatus.Location = new Point(391, 274);
            btn_editstatus.Name = "btn_editstatus";
            btn_editstatus.Size = new Size(97, 32);
            btn_editstatus.TabIndex = 9;
            btn_editstatus.Text = "Edit Status";
            btn_editstatus.UseVisualStyleBackColor = true;
            btn_editstatus.Click += btn_editstatus_Click;
            // 
            // txt_editStatus
            // 
            txt_editStatus.Location = new Point(109, 274);
            txt_editStatus.Name = "txt_editStatus";
            txt_editStatus.Size = new Size(100, 23);
            txt_editStatus.TabIndex = 8;
            // 
            // dgv_appointment
            // 
            dgv_appointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointment.Location = new Point(37, 54);
            dgv_appointment.Name = "dgv_appointment";
            dgv_appointment.Size = new Size(541, 184);
            dgv_appointment.TabIndex = 7;
            dgv_appointment.RowHeaderMouseDoubleClick += dgv_appointment_RowHeaderMouseDoubleClick_1;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 15F);
            label32.Location = new Point(31, 17);
            label32.Name = "label32";
            label32.Size = new Size(216, 28);
            label32.TabIndex = 6;
            label32.Text = "Doctor's Appointments";
            // 
            // DoctorUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 504);
            Controls.Add(panel_appointment);
            Controls.Add(panel_patient);
            Controls.Add(panel_medicalrecord);
            Controls.Add(panel_profile);
            Controls.Add(panel_HomePage);
            Controls.Add(panel_navbar);
            Name = "DoctorUser";
            Text = "DoctorUser";
            Load += DoctorUser_Load;
            panel_navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_upcommingAppointmentHomePage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_patientListHome).EndInit();
            panel_HomePage.ResumeLayout(false);
            panel_HomePage.PerformLayout();
            panel_profile.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_medicalrecord.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_Medical_Record_Data.ResumeLayout(false);
            panel_Medical_Record_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_medicalrecord).EndInit();
            panel_patient.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_resultofsearch).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_patientlist).EndInit();
            panel_appointment.ResumeLayout(false);
            panel_appointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_appointment;
        private Button btn_patient;
        private Button btn_medicalrecord;
        private Button btn_profile;
        private Button btn_home;
        private Panel panel_navbar;
        private DataGridView dgv_upcommingAppointmentHomePage;
        private Label label38;
        private DataGridView dgv_patientListHome;
        private Label label37;
        private Label label36;
        private Label label35;
        private Panel panel_HomePage;
        private Panel panel_profile;
        private Panel panel5;
        private Button btn_updateProfile;
        private TextBox txt_email;
        private Label label24;
        private TextBox txt_specializtion;
        private Label label22;
        private TextBox txt_lastName;
        private Label label21;
        private Button btn_editProfile;
        private TextBox txt_firstName;
        private Label label20;
        private PictureBox pictureBox1;
        private Label label19;
        private Panel panel_medicalrecord;
        private Panel panel1;
        private Button btn_delete;
        private Button btn_update;
        private Label label7;
        private TextBox txt_treatment;
        private Label label6;
        private TextBox txt_labResult;
        private Label label5;
        private TextBox txt_prescription;
        private Label label4;
        private TextBox txt_diaqnois;
        private Label label3;
        private TextBox txt_dateOfVisit;
        private ComboBox cb_patient;
        private Button btn_add;
        private Label label2;
        private Panel panel_Medical_Record_Data;
        private DataGridView dgv_medicalrecord;
        private Label label1;
        private Panel panel_patient;
        private Panel panel3;
        private Button btn_ExportWord;
        private Button btn_ExportExcel;
        private Label label34;
        private PictureBox pictureTwo;
        private Label label8;
        private ComboBox cb_searchitem;
        private DataGridView dgv_resultofsearch;
        private TextBox search_bar;
        private Panel panel2;
        private Button btn_word;
        private Button btn_Qr;
        private Label labelScan;
        private PictureBox pictureBox;
        private Button btn_updatemedicalhistory;
        private Label txtNamePatient;
        private Label label17;
        private TextBox txtTreatmentDetails;
        private Label label16;
        private TextBox txtLabResult;
        private Label label15;
        private TextBox txtPrescription;
        private Label label14;
        private TextBox txtDiaqnois;
        private Label label13;
        private TextBox txtMerdicalHistory;
        private Label label12;
        private TextBox txtGender;
        private Label label11;
        private TextBox txtDateOfBirth;
        private Label label10;
        private Label label9;
        private DataGridView dgv_patientlist;
        private Label label18;
        private Panel panel_appointment;
        private Label label33;
        private Button btn_editstatus;
        private TextBox txt_editStatus;
        private DataGridView dgv_appointment;
        private Label label32;
    }
}