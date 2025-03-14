namespace ProjectHospitalSystem.Forms.Admin
{
    partial class AdminPatientCRUD
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
            gb_SurgicalHistory = new GroupBox();
            c_box_otherSurgical = new CheckBox();
            txt_otherSurgical = new TextBox();
            c_boxOpenHeartSurgery = new CheckBox();
            c_boxEye = new CheckBox();
            c_boxAppendectomy = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            c_boxCosmeticSurgery = new CheckBox();
            gb_InfectiousDiseases = new GroupBox();
            c_box_otherInfectious = new CheckBox();
            txt_otherInfectious = new TextBox();
            c_boxHepatitis = new CheckBox();
            c_boxTuberculosis = new CheckBox();
            c_box_covid19 = new CheckBox();
            c_boxHIVOrAIDS = new CheckBox();
            gb_AllergieGenetic = new GroupBox();
            c_box_otherAllergies = new CheckBox();
            txt_otherAllergies = new TextBox();
            c_boxDrugAllergies = new CheckBox();
            c_boxFoodAllergie = new CheckBox();
            c_boxGeneticDiseases = new CheckBox();
            c_boxDust = new CheckBox();
            gb_OtherFactor = new GroupBox();
            c_box_otherFactors = new CheckBox();
            txt_otherFactor = new TextBox();
            cbox_Smoking = new CheckBox();
            c_boxChronicMedicatio = new CheckBox();
            cb_Alcoho = new CheckBox();
            c_box_otherChronic = new CheckBox();
            txt_otherChronic = new TextBox();
            gb_ChronicDiseases = new GroupBox();
            cbox_HeartBlood = new CheckBox();
            c_boxRespiratory = new CheckBox();
            cbox_HeartDisease = new CheckBox();
            cbox_Diabetes = new CheckBox();
            cbox_Kindey = new CheckBox();
            c_boxLiver = new CheckBox();
            dtp_BirthDate = new DateTimePicker();
            lb_DateBirthPaitent = new Label();
            rb_Female = new RadioButton();
            rb_Male = new RadioButton();
            lb_Gender = new Label();
            txt_phone = new TextBox();
            lb_Phone = new Label();
            txt_Address = new TextBox();
            lb_Address = new Label();
            txt_Lname = new TextBox();
            lb_LastNameDoctor = new Label();
            lb_close = new Label();
            dgv_AdminPaitent = new DataGridView();
            btn_remove = new Button();
            btn_Update = new Button();
            btn_AddDoctor = new Button();
            txt_Email = new TextBox();
            lb_DoctorEmail = new Label();
            lb_medicalHistory = new Label();
            txt_Fname = new TextBox();
            lb_Fname = new Label();
            gb_SurgicalHistory.SuspendLayout();
            gb_InfectiousDiseases.SuspendLayout();
            gb_AllergieGenetic.SuspendLayout();
            gb_OtherFactor.SuspendLayout();
            gb_ChronicDiseases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaitent).BeginInit();
            SuspendLayout();
            // 
            // gb_SurgicalHistory
            // 
            gb_SurgicalHistory.Controls.Add(c_box_otherSurgical);
            gb_SurgicalHistory.Controls.Add(txt_otherSurgical);
            gb_SurgicalHistory.Controls.Add(c_boxOpenHeartSurgery);
            gb_SurgicalHistory.Controls.Add(c_boxEye);
            gb_SurgicalHistory.Controls.Add(c_boxAppendectomy);
            gb_SurgicalHistory.Controls.Add(checkBox16);
            gb_SurgicalHistory.Controls.Add(checkBox17);
            gb_SurgicalHistory.Controls.Add(c_boxCosmeticSurgery);
            gb_SurgicalHistory.Location = new Point(487, 332);
            gb_SurgicalHistory.Name = "gb_SurgicalHistory";
            gb_SurgicalHistory.Size = new Size(291, 188);
            gb_SurgicalHistory.TabIndex = 90;
            gb_SurgicalHistory.TabStop = false;
            gb_SurgicalHistory.Text = "Surgical History";
            // 
            // c_box_otherSurgical
            // 
            c_box_otherSurgical.AutoSize = true;
            c_box_otherSurgical.Location = new Point(6, 107);
            c_box_otherSurgical.Name = "c_box_otherSurgical";
            c_box_otherSurgical.Size = new Size(56, 19);
            c_box_otherSurgical.TabIndex = 68;
            c_box_otherSurgical.Text = "Other";
            c_box_otherSurgical.UseVisualStyleBackColor = true;
            c_box_otherSurgical.CheckedChanged += c_box_otherSurgical_CheckedChanged;
            // 
            // txt_otherSurgical
            // 
            txt_otherSurgical.Location = new Point(6, 132);
            txt_otherSurgical.Name = "txt_otherSurgical";
            txt_otherSurgical.Size = new Size(233, 23);
            txt_otherSurgical.TabIndex = 69;
            txt_otherSurgical.Visible = false;
            // 
            // c_boxOpenHeartSurgery
            // 
            c_boxOpenHeartSurgery.AutoSize = true;
            c_boxOpenHeartSurgery.Location = new Point(6, 32);
            c_boxOpenHeartSurgery.Name = "c_boxOpenHeartSurgery";
            c_boxOpenHeartSurgery.Size = new Size(132, 19);
            c_boxOpenHeartSurgery.TabIndex = 51;
            c_boxOpenHeartSurgery.Text = "Open-Heart Surgery";
            c_boxOpenHeartSurgery.UseVisualStyleBackColor = true;
            // 
            // c_boxEye
            // 
            c_boxEye.AutoSize = true;
            c_boxEye.Location = new Point(6, 82);
            c_boxEye.Name = "c_boxEye";
            c_boxEye.Size = new Size(90, 19);
            c_boxEye.TabIndex = 52;
            c_boxEye.Text = "Eye Surgery ";
            c_boxEye.UseVisualStyleBackColor = true;
            // 
            // c_boxAppendectomy
            // 
            c_boxAppendectomy.AutoSize = true;
            c_boxAppendectomy.Location = new Point(6, 57);
            c_boxAppendectomy.Name = "c_boxAppendectomy";
            c_boxAppendectomy.Size = new Size(219, 19);
            c_boxAppendectomy.TabIndex = 53;
            c_boxAppendectomy.Text = "Appendectomy (Appendix Removal)";
            c_boxAppendectomy.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(135, 57);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(71, 19);
            checkBox16.TabIndex = 54;
            checkBox16.Text = "Diabetes";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(139, 32);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(132, 19);
            checkBox17.TabIndex = 55;
            checkBox17.Text = " Orthopedic Surgery";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // c_boxCosmeticSurgery
            // 
            c_boxCosmeticSurgery.AutoSize = true;
            c_boxCosmeticSurgery.Location = new Point(135, 82);
            c_boxCosmeticSurgery.Name = "c_boxCosmeticSurgery";
            c_boxCosmeticSurgery.Size = new Size(122, 19);
            c_boxCosmeticSurgery.TabIndex = 56;
            c_boxCosmeticSurgery.Text = " Cosmetic Surgery";
            c_boxCosmeticSurgery.UseVisualStyleBackColor = true;
            // 
            // gb_InfectiousDiseases
            // 
            gb_InfectiousDiseases.Controls.Add(c_box_otherInfectious);
            gb_InfectiousDiseases.Controls.Add(txt_otherInfectious);
            gb_InfectiousDiseases.Controls.Add(c_boxHepatitis);
            gb_InfectiousDiseases.Controls.Add(c_boxTuberculosis);
            gb_InfectiousDiseases.Controls.Add(c_box_covid19);
            gb_InfectiousDiseases.Controls.Add(c_boxHIVOrAIDS);
            gb_InfectiousDiseases.Location = new Point(800, 349);
            gb_InfectiousDiseases.Name = "gb_InfectiousDiseases";
            gb_InfectiousDiseases.Size = new Size(366, 171);
            gb_InfectiousDiseases.TabIndex = 93;
            gb_InfectiousDiseases.TabStop = false;
            gb_InfectiousDiseases.Text = "Infectious Diseases:\n\n";
            // 
            // c_box_otherInfectious
            // 
            c_box_otherInfectious.AutoSize = true;
            c_box_otherInfectious.Location = new Point(6, 82);
            c_box_otherInfectious.Name = "c_box_otherInfectious";
            c_box_otherInfectious.Size = new Size(56, 19);
            c_box_otherInfectious.TabIndex = 68;
            c_box_otherInfectious.Text = "Other";
            c_box_otherInfectious.UseVisualStyleBackColor = true;
            c_box_otherInfectious.CheckedChanged += c_box_otherInfectious_CheckedChanged;
            // 
            // txt_otherInfectious
            // 
            txt_otherInfectious.Location = new Point(6, 107);
            txt_otherInfectious.Name = "txt_otherInfectious";
            txt_otherInfectious.Size = new Size(233, 23);
            txt_otherInfectious.TabIndex = 69;
            txt_otherInfectious.Visible = false;
            // 
            // c_boxHepatitis
            // 
            c_boxHepatitis.AutoSize = true;
            c_boxHepatitis.Location = new Point(6, 32);
            c_boxHepatitis.Name = "c_boxHepatitis";
            c_boxHepatitis.Size = new Size(136, 19);
            c_boxHepatitis.TabIndex = 51;
            c_boxHepatitis.Text = " Hepatitis (A, B, or C)\n";
            c_boxHepatitis.UseVisualStyleBackColor = true;
            // 
            // c_boxTuberculosis
            // 
            c_boxTuberculosis.AutoSize = true;
            c_boxTuberculosis.Location = new Point(6, 57);
            c_boxTuberculosis.Name = "c_boxTuberculosis";
            c_boxTuberculosis.Size = new Size(119, 19);
            c_boxTuberculosis.TabIndex = 53;
            c_boxTuberculosis.Text = " Tuberculosis (TB)\n";
            c_boxTuberculosis.UseVisualStyleBackColor = true;
            // 
            // c_box_covid19
            // 
            c_box_covid19.AutoSize = true;
            c_box_covid19.Location = new Point(148, 57);
            c_box_covid19.Name = "c_box_covid19";
            c_box_covid19.Size = new Size(179, 19);
            c_box_covid19.TabIndex = 54;
            c_box_covid19.Text = " Previous COVID-19 Infection\r\n";
            c_box_covid19.UseVisualStyleBackColor = true;
            // 
            // c_boxHIVOrAIDS
            // 
            c_boxHIVOrAIDS.AutoSize = true;
            c_boxHIVOrAIDS.Location = new Point(148, 32);
            c_boxHIVOrAIDS.Name = "c_boxHIVOrAIDS";
            c_boxHIVOrAIDS.Size = new Size(78, 19);
            c_boxHIVOrAIDS.TabIndex = 55;
            c_boxHIVOrAIDS.Text = " HIV/AIDS\n";
            c_boxHIVOrAIDS.UseVisualStyleBackColor = true;
            // 
            // gb_AllergieGenetic
            // 
            gb_AllergieGenetic.Controls.Add(c_box_otherAllergies);
            gb_AllergieGenetic.Controls.Add(txt_otherAllergies);
            gb_AllergieGenetic.Controls.Add(c_boxDrugAllergies);
            gb_AllergieGenetic.Controls.Add(c_boxFoodAllergie);
            gb_AllergieGenetic.Controls.Add(c_boxGeneticDiseases);
            gb_AllergieGenetic.Controls.Add(c_boxDust);
            gb_AllergieGenetic.Location = new Point(151, 540);
            gb_AllergieGenetic.Name = "gb_AllergieGenetic";
            gb_AllergieGenetic.Size = new Size(330, 163);
            gb_AllergieGenetic.TabIndex = 91;
            gb_AllergieGenetic.TabStop = false;
            gb_AllergieGenetic.Text = "Allergies & Genetic Conditions:\n\n";
            // 
            // c_box_otherAllergies
            // 
            c_box_otherAllergies.AutoSize = true;
            c_box_otherAllergies.Location = new Point(6, 82);
            c_box_otherAllergies.Name = "c_box_otherAllergies";
            c_box_otherAllergies.Size = new Size(56, 19);
            c_box_otherAllergies.TabIndex = 68;
            c_box_otherAllergies.Text = "Other";
            c_box_otherAllergies.UseVisualStyleBackColor = true;
            c_box_otherAllergies.CheckedChanged += c_box_otherAllergies_CheckedChanged;
            // 
            // txt_otherAllergies
            // 
            txt_otherAllergies.Location = new Point(6, 107);
            txt_otherAllergies.Name = "txt_otherAllergies";
            txt_otherAllergies.Size = new Size(233, 23);
            txt_otherAllergies.TabIndex = 69;
            txt_otherAllergies.Visible = false;
            // 
            // c_boxDrugAllergies
            // 
            c_boxDrugAllergies.AutoSize = true;
            c_boxDrugAllergies.Location = new Point(6, 32);
            c_boxDrugAllergies.Name = "c_boxDrugAllergies";
            c_boxDrugAllergies.Size = new Size(100, 19);
            c_boxDrugAllergies.TabIndex = 51;
            c_boxDrugAllergies.Text = "Drug Allergies";
            c_boxDrugAllergies.UseVisualStyleBackColor = true;
            // 
            // c_boxFoodAllergie
            // 
            c_boxFoodAllergie.AutoSize = true;
            c_boxFoodAllergie.Location = new Point(6, 57);
            c_boxFoodAllergie.Name = "c_boxFoodAllergie";
            c_boxFoodAllergie.Size = new Size(104, 19);
            c_boxFoodAllergie.TabIndex = 53;
            c_boxFoodAllergie.Text = " Food Allergies\n";
            c_boxFoodAllergie.UseVisualStyleBackColor = true;
            // 
            // c_boxGeneticDiseases
            // 
            c_boxGeneticDiseases.AutoSize = true;
            c_boxGeneticDiseases.Location = new Point(147, 32);
            c_boxGeneticDiseases.Name = "c_boxGeneticDiseases";
            c_boxGeneticDiseases.Size = new Size(113, 19);
            c_boxGeneticDiseases.TabIndex = 54;
            c_boxGeneticDiseases.Text = "Genetic Diseases";
            c_boxGeneticDiseases.UseVisualStyleBackColor = true;
            // 
            // c_boxDust
            // 
            c_boxDust.AutoSize = true;
            c_boxDust.Location = new Point(147, 57);
            c_boxDust.Name = "c_boxDust";
            c_boxDust.Size = new Size(156, 19);
            c_boxDust.TabIndex = 55;
            c_boxDust.Text = " Dust or Animal Allergies\n";
            c_boxDust.UseVisualStyleBackColor = true;
            // 
            // gb_OtherFactor
            // 
            gb_OtherFactor.Controls.Add(c_box_otherFactors);
            gb_OtherFactor.Controls.Add(txt_otherFactor);
            gb_OtherFactor.Controls.Add(cbox_Smoking);
            gb_OtherFactor.Controls.Add(c_boxChronicMedicatio);
            gb_OtherFactor.Controls.Add(cb_Alcoho);
            gb_OtherFactor.Location = new Point(487, 540);
            gb_OtherFactor.Name = "gb_OtherFactor";
            gb_OtherFactor.Size = new Size(327, 163);
            gb_OtherFactor.TabIndex = 92;
            gb_OtherFactor.TabStop = false;
            gb_OtherFactor.Text = "Other Factors:\n\n";
            // 
            // c_box_otherFactors
            // 
            c_box_otherFactors.AutoSize = true;
            c_box_otherFactors.Location = new Point(6, 82);
            c_box_otherFactors.Name = "c_box_otherFactors";
            c_box_otherFactors.Size = new Size(56, 19);
            c_box_otherFactors.TabIndex = 70;
            c_box_otherFactors.Text = "Other";
            c_box_otherFactors.UseVisualStyleBackColor = true;
            c_box_otherFactors.CheckedChanged += c_box_otherFactors_CheckedChanged;
            // 
            // txt_otherFactor
            // 
            txt_otherFactor.Location = new Point(6, 107);
            txt_otherFactor.Name = "txt_otherFactor";
            txt_otherFactor.Size = new Size(233, 23);
            txt_otherFactor.TabIndex = 71;
            txt_otherFactor.Visible = false;
            // 
            // cbox_Smoking
            // 
            cbox_Smoking.AutoSize = true;
            cbox_Smoking.Location = new Point(6, 32);
            cbox_Smoking.Name = "cbox_Smoking";
            cbox_Smoking.Size = new Size(73, 19);
            cbox_Smoking.TabIndex = 51;
            cbox_Smoking.Text = "Smoking";
            cbox_Smoking.UseVisualStyleBackColor = true;
            // 
            // c_boxChronicMedicatio
            // 
            c_boxChronicMedicatio.AutoSize = true;
            c_boxChronicMedicatio.Location = new Point(6, 57);
            c_boxChronicMedicatio.Name = "c_boxChronicMedicatio";
            c_boxChronicMedicatio.Size = new Size(156, 19);
            c_boxChronicMedicatio.TabIndex = 53;
            c_boxChronicMedicatio.Text = " Chronic Medication Use\n";
            c_boxChronicMedicatio.UseVisualStyleBackColor = true;
            // 
            // cb_Alcoho
            // 
            cb_Alcoho.AutoSize = true;
            cb_Alcoho.Location = new Point(166, 32);
            cb_Alcoho.Name = "cb_Alcoho";
            cb_Alcoho.Size = new Size(125, 19);
            cb_Alcoho.TabIndex = 54;
            cb_Alcoho.Text = " Alcohol Addiction\n";
            cb_Alcoho.UseVisualStyleBackColor = true;
            // 
            // c_box_otherChronic
            // 
            c_box_otherChronic.AutoSize = true;
            c_box_otherChronic.Location = new Point(6, 132);
            c_box_otherChronic.Name = "c_box_otherChronic";
            c_box_otherChronic.Size = new Size(56, 19);
            c_box_otherChronic.TabIndex = 56;
            c_box_otherChronic.Text = "Other";
            c_box_otherChronic.UseVisualStyleBackColor = true;
            c_box_otherChronic.CheckedChanged += c_box_otherChronic_CheckedChanged;
            // 
            // txt_otherChronic
            // 
            txt_otherChronic.Location = new Point(6, 157);
            txt_otherChronic.Name = "txt_otherChronic";
            txt_otherChronic.Size = new Size(233, 23);
            txt_otherChronic.TabIndex = 67;
            txt_otherChronic.Visible = false;
            // 
            // gb_ChronicDiseases
            // 
            gb_ChronicDiseases.Controls.Add(c_box_otherChronic);
            gb_ChronicDiseases.Controls.Add(txt_otherChronic);
            gb_ChronicDiseases.Controls.Add(cbox_HeartBlood);
            gb_ChronicDiseases.Controls.Add(c_boxRespiratory);
            gb_ChronicDiseases.Controls.Add(cbox_HeartDisease);
            gb_ChronicDiseases.Controls.Add(cbox_Diabetes);
            gb_ChronicDiseases.Controls.Add(cbox_Kindey);
            gb_ChronicDiseases.Controls.Add(c_boxLiver);
            gb_ChronicDiseases.Location = new Point(154, 317);
            gb_ChronicDiseases.Name = "gb_ChronicDiseases";
            gb_ChronicDiseases.Size = new Size(327, 203);
            gb_ChronicDiseases.TabIndex = 89;
            gb_ChronicDiseases.TabStop = false;
            gb_ChronicDiseases.Text = "Chronic Diseases";
            // 
            // cbox_HeartBlood
            // 
            cbox_HeartBlood.AutoSize = true;
            cbox_HeartBlood.Location = new Point(6, 32);
            cbox_HeartBlood.Name = "cbox_HeartBlood";
            cbox_HeartBlood.Size = new Size(218, 19);
            cbox_HeartBlood.TabIndex = 51;
            cbox_HeartBlood.Text = " High Blood Pressure (Hypertension)\n";
            cbox_HeartBlood.UseVisualStyleBackColor = true;
            // 
            // c_boxRespiratory
            // 
            c_boxRespiratory.AutoSize = true;
            c_boxRespiratory.Location = new Point(6, 107);
            c_boxRespiratory.Name = "c_boxRespiratory";
            c_boxRespiratory.Size = new Size(212, 19);
            c_boxRespiratory.TabIndex = 52;
            c_boxRespiratory.Text = " Respiratory Diseases (e.g., Asthma)\n";
            c_boxRespiratory.UseVisualStyleBackColor = true;
            // 
            // cbox_HeartDisease
            // 
            cbox_HeartDisease.AutoSize = true;
            cbox_HeartDisease.Location = new Point(6, 57);
            cbox_HeartDisease.Name = "cbox_HeartDisease";
            cbox_HeartDisease.Size = new Size(105, 19);
            cbox_HeartDisease.TabIndex = 53;
            cbox_HeartDisease.Text = " Heart Diseases\n";
            cbox_HeartDisease.UseVisualStyleBackColor = true;
            // 
            // cbox_Diabetes
            // 
            cbox_Diabetes.AutoSize = true;
            cbox_Diabetes.Location = new Point(147, 57);
            cbox_Diabetes.Name = "cbox_Diabetes";
            cbox_Diabetes.Size = new Size(71, 19);
            cbox_Diabetes.TabIndex = 54;
            cbox_Diabetes.Text = "Diabetes";
            cbox_Diabetes.UseVisualStyleBackColor = true;
            // 
            // cbox_Kindey
            // 
            cbox_Kindey.AutoSize = true;
            cbox_Kindey.Location = new Point(6, 82);
            cbox_Kindey.Name = "cbox_Kindey";
            cbox_Kindey.Size = new Size(112, 19);
            cbox_Kindey.TabIndex = 55;
            cbox_Kindey.Text = " Kidney Diseases\n";
            cbox_Kindey.UseVisualStyleBackColor = true;
            // 
            // c_boxLiver
            // 
            c_boxLiver.AutoSize = true;
            c_boxLiver.Location = new Point(147, 82);
            c_boxLiver.Name = "c_boxLiver";
            c_boxLiver.Size = new Size(101, 19);
            c_boxLiver.TabIndex = 56;
            c_boxLiver.Text = " Liver Diseases\n";
            c_boxLiver.UseVisualStyleBackColor = true;
            // 
            // dtp_BirthDate
            // 
            dtp_BirthDate.Location = new Point(171, 176);
            dtp_BirthDate.Name = "dtp_BirthDate";
            dtp_BirthDate.Size = new Size(231, 23);
            dtp_BirthDate.TabIndex = 72;
            // 
            // lb_DateBirthPaitent
            // 
            lb_DateBirthPaitent.AutoSize = true;
            lb_DateBirthPaitent.Location = new Point(66, 184);
            lb_DateBirthPaitent.Name = "lb_DateBirthPaitent";
            lb_DateBirthPaitent.Size = new Size(75, 15);
            lb_DateBirthPaitent.TabIndex = 88;
            lb_DateBirthPaitent.Text = "DateOfBirth::";
            // 
            // rb_Female
            // 
            rb_Female.AutoSize = true;
            rb_Female.Location = new Point(303, 150);
            rb_Female.Name = "rb_Female";
            rb_Female.Size = new Size(63, 19);
            rb_Female.TabIndex = 87;
            rb_Female.TabStop = true;
            rb_Female.Text = "Female";
            rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            rb_Male.AutoSize = true;
            rb_Male.Location = new Point(213, 150);
            rb_Male.Name = "rb_Male";
            rb_Male.Size = new Size(51, 19);
            rb_Male.TabIndex = 71;
            rb_Male.TabStop = true;
            rb_Male.Text = "Male";
            rb_Male.UseVisualStyleBackColor = true;
            // 
            // lb_Gender
            // 
            lb_Gender.AutoSize = true;
            lb_Gender.Location = new Point(66, 152);
            lb_Gender.Name = "lb_Gender";
            lb_Gender.Size = new Size(45, 15);
            lb_Gender.TabIndex = 86;
            lb_Gender.Text = "Gender";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(169, 112);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(233, 23);
            txt_phone.TabIndex = 70;
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.Location = new Point(66, 115);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(44, 15);
            lb_Phone.TabIndex = 85;
            lb_Phone.Text = "Phone:";
            // 
            // txt_Address
            // 
            txt_Address.Location = new Point(169, 255);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(233, 23);
            txt_Address.TabIndex = 74;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Location = new Point(66, 258);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(52, 15);
            lb_Address.TabIndex = 84;
            lb_Address.Text = "Address:";
            // 
            // txt_Lname
            // 
            txt_Lname.Location = new Point(169, 67);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(233, 23);
            txt_Lname.TabIndex = 69;
            // 
            // lb_LastNameDoctor
            // 
            lb_LastNameDoctor.AutoSize = true;
            lb_LastNameDoctor.Location = new Point(66, 75);
            lb_LastNameDoctor.Name = "lb_LastNameDoctor";
            lb_LastNameDoctor.Size = new Size(46, 15);
            lb_LastNameDoctor.TabIndex = 83;
            lb_LastNameDoctor.Text = "Lname:";
            // 
            // lb_close
            // 
            lb_close.AutoSize = true;
            lb_close.Location = new Point(1253, 332);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(36, 15);
            lb_close.TabIndex = 82;
            lb_close.Text = "Close";
            // 
            // dgv_AdminPaitent
            // 
            dgv_AdminPaitent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminPaitent.Location = new Point(487, 12);
            dgv_AdminPaitent.Name = "dgv_AdminPaitent";
            dgv_AdminPaitent.Size = new Size(728, 288);
            dgv_AdminPaitent.TabIndex = 81;
            dgv_AdminPaitent.RowHeaderMouseDoubleClick += dgv_AdminPaitent_RowHeaderMouseDoubleClick;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(903, 631);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(105, 53);
            btn_remove.TabIndex = 80;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(968, 560);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(105, 53);
            btn_Update.TabIndex = 79;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_AddDoctor
            // 
            btn_AddDoctor.Location = new Point(837, 560);
            btn_AddDoctor.Name = "btn_AddDoctor";
            btn_AddDoctor.Size = new Size(105, 53);
            btn_AddDoctor.TabIndex = 78;
            btn_AddDoctor.Text = "Add ";
            btn_AddDoctor.UseVisualStyleBackColor = true;
            btn_AddDoctor.Click += btn_AddDoctor_Click;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(169, 220);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(233, 23);
            txt_Email.TabIndex = 73;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.Location = new Point(66, 224);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(39, 15);
            lb_DoctorEmail.TabIndex = 77;
            lb_DoctorEmail.Text = "Email:";
            // 
            // lb_medicalHistory
            // 
            lb_medicalHistory.AutoSize = true;
            lb_medicalHistory.Location = new Point(50, 308);
            lb_medicalHistory.Name = "lb_medicalHistory";
            lb_medicalHistory.Size = new Size(91, 15);
            lb_medicalHistory.TabIndex = 76;
            lb_medicalHistory.Text = "History Record :";
            // 
            // txt_Fname
            // 
            txt_Fname.Location = new Point(169, 30);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(233, 23);
            txt_Fname.TabIndex = 68;
            // 
            // lb_Fname
            // 
            lb_Fname.AutoSize = true;
            lb_Fname.Location = new Point(66, 33);
            lb_Fname.Name = "lb_Fname";
            lb_Fname.Size = new Size(46, 15);
            lb_Fname.TabIndex = 75;
            lb_Fname.Text = "Fname:";
            // 
            // AdminPatientCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 775);
            Controls.Add(gb_SurgicalHistory);
            Controls.Add(gb_InfectiousDiseases);
            Controls.Add(gb_AllergieGenetic);
            Controls.Add(gb_OtherFactor);
            Controls.Add(gb_ChronicDiseases);
            Controls.Add(dtp_BirthDate);
            Controls.Add(lb_DateBirthPaitent);
            Controls.Add(rb_Female);
            Controls.Add(rb_Male);
            Controls.Add(lb_Gender);
            Controls.Add(txt_phone);
            Controls.Add(lb_Phone);
            Controls.Add(txt_Address);
            Controls.Add(lb_Address);
            Controls.Add(txt_Lname);
            Controls.Add(lb_LastNameDoctor);
            Controls.Add(lb_close);
            Controls.Add(dgv_AdminPaitent);
            Controls.Add(btn_remove);
            Controls.Add(btn_Update);
            Controls.Add(btn_AddDoctor);
            Controls.Add(txt_Email);
            Controls.Add(lb_DoctorEmail);
            Controls.Add(lb_medicalHistory);
            Controls.Add(txt_Fname);
            Controls.Add(lb_Fname);
            Name = "AdminPatientCRUD";
            Text = "AdminPatientCRUD";
            Load += AdminPatientCRUD_Load;
            gb_SurgicalHistory.ResumeLayout(false);
            gb_SurgicalHistory.PerformLayout();
            gb_InfectiousDiseases.ResumeLayout(false);
            gb_InfectiousDiseases.PerformLayout();
            gb_AllergieGenetic.ResumeLayout(false);
            gb_AllergieGenetic.PerformLayout();
            gb_OtherFactor.ResumeLayout(false);
            gb_OtherFactor.PerformLayout();
            gb_ChronicDiseases.ResumeLayout(false);
            gb_ChronicDiseases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaitent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_SurgicalHistory;
        private CheckBox c_box_otherSurgical;
        private TextBox txt_otherSurgical;
        private CheckBox c_boxOpenHeartSurgery;
        private CheckBox c_boxEye;
        private CheckBox c_boxAppendectomy;
        private CheckBox checkBox16;
        private CheckBox checkBox17;
        private CheckBox c_boxCosmeticSurgery;
        private GroupBox gb_InfectiousDiseases;
        private CheckBox c_box_otherInfectious;
        private TextBox txt_otherInfectious;
        private CheckBox c_boxHepatitis;
        private CheckBox c_boxTuberculosis;
        private CheckBox c_box_covid19;
        private CheckBox c_boxHIVOrAIDS;
        private GroupBox gb_AllergieGenetic;
        private CheckBox c_box_otherAllergies;
        private TextBox txt_otherAllergies;
        private CheckBox c_boxDrugAllergies;
        private CheckBox c_boxFoodAllergie;
        private CheckBox c_boxGeneticDiseases;
        private CheckBox c_boxDust;
        private GroupBox gb_OtherFactor;
        private CheckBox c_box_otherFactors;
        private TextBox txt_otherFactor;
        private CheckBox cbox_Smoking;
        private CheckBox c_boxChronicMedicatio;
        private CheckBox cb_Alcoho;
        private CheckBox c_box_otherChronic;
        private TextBox txt_otherChronic;
        private GroupBox gb_ChronicDiseases;
        private CheckBox cbox_HeartBlood;
        private CheckBox c_boxRespiratory;
        private CheckBox cbox_HeartDisease;
        private CheckBox cbox_Diabetes;
        private CheckBox cbox_Kindey;
        private CheckBox c_boxLiver;
        private DateTimePicker dtp_BirthDate;
        private Label lb_DateBirthPaitent;
        private RadioButton rb_Female;
        private RadioButton rb_Male;
        private Label lb_Gender;
        private TextBox txt_phone;
        private Label lb_Phone;
        private TextBox txt_Address;
        private Label lb_Address;
        private TextBox txt_Lname;
        private Label lb_LastNameDoctor;
        private Label lb_close;
        private DataGridView dgv_AdminPaitent;
        private Button btn_remove;
        private Button btn_Update;
        private Button btn_AddDoctor;
        private TextBox txt_Email;
        private Label lb_DoctorEmail;
        private Label lb_medicalHistory;
        private TextBox txt_Fname;
        private Label lb_Fname;
    }
}