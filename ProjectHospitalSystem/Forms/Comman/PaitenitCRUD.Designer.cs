namespace ProjectHospitalSystem.Forms.Admin
{
    partial class PaitenitCRUD
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
            rb_Female = new RadioButton();
            rb_Male = new RadioButton();
            dgv_AdminPaitent = new DataGridView();
            icon = new DataGridViewImageColumn();
            pnlReceDetails = new Panel();
            pictureBox11 = new PictureBox();
            label3 = new Label();
            pictureBox10 = new PictureBox();
            pictureBox5 = new PictureBox();
            label2 = new Label();
            lb_Gender = new Label();
            pictureBox1 = new PictureBox();
            lb_DateBirthPaitent = new Label();
            pictureBox9 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_phone = new TextBox();
            label1 = new Label();
            txt_Address = new TextBox();
            lb_AddressPaitnit = new Label();
            txt_Email = new TextBox();
            lb_PaitnEmail = new Label();
            txt_Lname = new TextBox();
            lb_LastNamePaitn = new Label();
            txt_Fname = new TextBox();
            lb_Fname = new Label();
            panel1 = new Panel();
            pictureBox7 = new PictureBox();
            lb_medicalHistory = new Label();
            btn_remove = new Button();
            btn_Update = new Button();
            btn_AddPaitenit = new Button();
            pictureBox8 = new PictureBox();
            txtBoxPatientSerachData = new TextBox();
            lbPatienitNameSearch = new Label();
            gb_SurgicalHistory.SuspendLayout();
            gb_InfectiousDiseases.SuspendLayout();
            gb_AllergieGenetic.SuspendLayout();
            gb_OtherFactor.SuspendLayout();
            gb_ChronicDiseases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaitent).BeginInit();
            pnlReceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
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
            gb_SurgicalHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_SurgicalHistory.Location = new Point(386, 55);
            gb_SurgicalHistory.Name = "gb_SurgicalHistory";
            gb_SurgicalHistory.Size = new Size(363, 203);
            gb_SurgicalHistory.TabIndex = 90;
            gb_SurgicalHistory.TabStop = false;
            gb_SurgicalHistory.Text = "Surgical History";
            // 
            // c_box_otherSurgical
            // 
            c_box_otherSurgical.AutoSize = true;
            c_box_otherSurgical.Font = new Font("Segoe UI", 12F);
            c_box_otherSurgical.Location = new Point(6, 107);
            c_box_otherSurgical.Name = "c_box_otherSurgical";
            c_box_otherSurgical.Size = new Size(69, 25);
            c_box_otherSurgical.TabIndex = 68;
            c_box_otherSurgical.Text = "Other";
            c_box_otherSurgical.UseVisualStyleBackColor = true;
            c_box_otherSurgical.CheckedChanged += c_box_otherSurgical_CheckedChanged;
            // 
            // txt_otherSurgical
            // 
            txt_otherSurgical.Font = new Font("Segoe UI", 12F);
            txt_otherSurgical.Location = new Point(6, 132);
            txt_otherSurgical.Name = "txt_otherSurgical";
            txt_otherSurgical.Size = new Size(233, 29);
            txt_otherSurgical.TabIndex = 69;
            txt_otherSurgical.Visible = false;
            // 
            // c_boxOpenHeartSurgery
            // 
            c_boxOpenHeartSurgery.AutoSize = true;
            c_boxOpenHeartSurgery.Font = new Font("Segoe UI", 12F);
            c_boxOpenHeartSurgery.Location = new Point(6, 32);
            c_boxOpenHeartSurgery.Name = "c_boxOpenHeartSurgery";
            c_boxOpenHeartSurgery.Size = new Size(170, 25);
            c_boxOpenHeartSurgery.TabIndex = 51;
            c_boxOpenHeartSurgery.Text = "Open-Heart Surgery";
            c_boxOpenHeartSurgery.UseVisualStyleBackColor = true;
            // 
            // c_boxEye
            // 
            c_boxEye.AutoSize = true;
            c_boxEye.Font = new Font("Segoe UI", 12F);
            c_boxEye.Location = new Point(6, 82);
            c_boxEye.Name = "c_boxEye";
            c_boxEye.Size = new Size(116, 25);
            c_boxEye.TabIndex = 52;
            c_boxEye.Text = "Eye Surgery ";
            c_boxEye.UseVisualStyleBackColor = true;
            // 
            // c_boxAppendectomy
            // 
            c_boxAppendectomy.AutoSize = true;
            c_boxAppendectomy.Font = new Font("Segoe UI", 12F);
            c_boxAppendectomy.Location = new Point(6, 57);
            c_boxAppendectomy.Name = "c_boxAppendectomy";
            c_boxAppendectomy.Size = new Size(278, 25);
            c_boxAppendectomy.TabIndex = 53;
            c_boxAppendectomy.Text = "Appendectomy (Appendix Removal)";
            c_boxAppendectomy.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(135, 57);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(96, 25);
            checkBox16.TabIndex = 54;
            checkBox16.Text = "Diabetes";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Font = new Font("Segoe UI", 12F);
            checkBox17.Location = new Point(194, 32);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(170, 25);
            checkBox17.TabIndex = 55;
            checkBox17.Text = " Orthopedic Surgery";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // c_boxCosmeticSurgery
            // 
            c_boxCosmeticSurgery.AutoSize = true;
            c_boxCosmeticSurgery.Font = new Font("Segoe UI", 12F);
            c_boxCosmeticSurgery.Location = new Point(194, 82);
            c_boxCosmeticSurgery.Name = "c_boxCosmeticSurgery";
            c_boxCosmeticSurgery.Size = new Size(156, 25);
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
            gb_InfectiousDiseases.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_InfectiousDiseases.Location = new Point(12, 264);
            gb_InfectiousDiseases.Name = "gb_InfectiousDiseases";
            gb_InfectiousDiseases.Size = new Size(353, 211);
            gb_InfectiousDiseases.TabIndex = 93;
            gb_InfectiousDiseases.TabStop = false;
            gb_InfectiousDiseases.Text = "Infectious Diseases:\n\n";
            // 
            // c_box_otherInfectious
            // 
            c_box_otherInfectious.AutoSize = true;
            c_box_otherInfectious.Font = new Font("Segoe UI", 12F);
            c_box_otherInfectious.Location = new Point(6, 122);
            c_box_otherInfectious.Name = "c_box_otherInfectious";
            c_box_otherInfectious.Size = new Size(69, 25);
            c_box_otherInfectious.TabIndex = 68;
            c_box_otherInfectious.Text = "Other";
            c_box_otherInfectious.UseVisualStyleBackColor = true;
            c_box_otherInfectious.CheckedChanged += c_box_otherInfectious_CheckedChanged;
            // 
            // txt_otherInfectious
            // 
            txt_otherInfectious.Font = new Font("Segoe UI", 12F);
            txt_otherInfectious.Location = new Point(6, 153);
            txt_otherInfectious.Name = "txt_otherInfectious";
            txt_otherInfectious.Size = new Size(233, 29);
            txt_otherInfectious.TabIndex = 69;
            txt_otherInfectious.Visible = false;
            // 
            // c_boxHepatitis
            // 
            c_boxHepatitis.AutoSize = true;
            c_boxHepatitis.Font = new Font("Segoe UI", 12F);
            c_boxHepatitis.Location = new Point(6, 32);
            c_boxHepatitis.Name = "c_boxHepatitis";
            c_boxHepatitis.Size = new Size(170, 25);
            c_boxHepatitis.TabIndex = 51;
            c_boxHepatitis.Text = " Hepatitis (A, B, or C)\n";
            c_boxHepatitis.UseVisualStyleBackColor = true;
            // 
            // c_boxTuberculosis
            // 
            c_boxTuberculosis.AutoSize = true;
            c_boxTuberculosis.Font = new Font("Segoe UI", 12F);
            c_boxTuberculosis.Location = new Point(6, 60);
            c_boxTuberculosis.Name = "c_boxTuberculosis";
            c_boxTuberculosis.Size = new Size(151, 25);
            c_boxTuberculosis.TabIndex = 53;
            c_boxTuberculosis.Text = " Tuberculosis (TB)\n";
            c_boxTuberculosis.UseVisualStyleBackColor = true;
            // 
            // c_box_covid19
            // 
            c_box_covid19.AutoSize = true;
            c_box_covid19.Font = new Font("Segoe UI", 12F);
            c_box_covid19.Location = new Point(6, 91);
            c_box_covid19.Name = "c_box_covid19";
            c_box_covid19.Size = new Size(232, 25);
            c_box_covid19.TabIndex = 54;
            c_box_covid19.Text = " Previous COVID-19 Infection\r\n";
            c_box_covid19.UseVisualStyleBackColor = true;
            // 
            // c_boxHIVOrAIDS
            // 
            c_boxHIVOrAIDS.AutoSize = true;
            c_boxHIVOrAIDS.Font = new Font("Segoe UI", 12F);
            c_boxHIVOrAIDS.Location = new Point(194, 32);
            c_boxHIVOrAIDS.Name = "c_boxHIVOrAIDS";
            c_boxHIVOrAIDS.Size = new Size(98, 25);
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
            gb_AllergieGenetic.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_AllergieGenetic.Location = new Point(386, 264);
            gb_AllergieGenetic.Name = "gb_AllergieGenetic";
            gb_AllergieGenetic.Size = new Size(353, 211);
            gb_AllergieGenetic.TabIndex = 91;
            gb_AllergieGenetic.TabStop = false;
            gb_AllergieGenetic.Text = "Allergies & Genetic Conditions:\n\n";
            // 
            // c_box_otherAllergies
            // 
            c_box_otherAllergies.AutoSize = true;
            c_box_otherAllergies.Font = new Font("Segoe UI", 12F);
            c_box_otherAllergies.Location = new Point(6, 122);
            c_box_otherAllergies.Name = "c_box_otherAllergies";
            c_box_otherAllergies.Size = new Size(69, 25);
            c_box_otherAllergies.TabIndex = 68;
            c_box_otherAllergies.Text = "Other";
            c_box_otherAllergies.UseVisualStyleBackColor = true;
            c_box_otherAllergies.CheckedChanged += c_box_otherAllergies_CheckedChanged;
            // 
            // txt_otherAllergies
            // 
            txt_otherAllergies.Font = new Font("Segoe UI", 12F);
            txt_otherAllergies.Location = new Point(6, 153);
            txt_otherAllergies.Name = "txt_otherAllergies";
            txt_otherAllergies.Size = new Size(233, 29);
            txt_otherAllergies.TabIndex = 69;
            txt_otherAllergies.Visible = false;
            // 
            // c_boxDrugAllergies
            // 
            c_boxDrugAllergies.AutoSize = true;
            c_boxDrugAllergies.Font = new Font("Segoe UI", 12F);
            c_boxDrugAllergies.Location = new Point(6, 32);
            c_boxDrugAllergies.Name = "c_boxDrugAllergies";
            c_boxDrugAllergies.Size = new Size(128, 25);
            c_boxDrugAllergies.TabIndex = 51;
            c_boxDrugAllergies.Text = "Drug Allergies";
            c_boxDrugAllergies.UseVisualStyleBackColor = true;
            // 
            // c_boxFoodAllergie
            // 
            c_boxFoodAllergie.AutoSize = true;
            c_boxFoodAllergie.Font = new Font("Segoe UI", 12F);
            c_boxFoodAllergie.Location = new Point(6, 60);
            c_boxFoodAllergie.Name = "c_boxFoodAllergie";
            c_boxFoodAllergie.Size = new Size(132, 25);
            c_boxFoodAllergie.TabIndex = 53;
            c_boxFoodAllergie.Text = " Food Allergies\n";
            c_boxFoodAllergie.UseVisualStyleBackColor = true;
            // 
            // c_boxGeneticDiseases
            // 
            c_boxGeneticDiseases.AutoSize = true;
            c_boxGeneticDiseases.Font = new Font("Segoe UI", 12F);
            c_boxGeneticDiseases.Location = new Point(194, 32);
            c_boxGeneticDiseases.Name = "c_boxGeneticDiseases";
            c_boxGeneticDiseases.Size = new Size(145, 25);
            c_boxGeneticDiseases.TabIndex = 54;
            c_boxGeneticDiseases.Text = "Genetic Diseases";
            c_boxGeneticDiseases.UseVisualStyleBackColor = true;
            // 
            // c_boxDust
            // 
            c_boxDust.AutoSize = true;
            c_boxDust.Font = new Font("Segoe UI", 12F);
            c_boxDust.Location = new Point(6, 91);
            c_boxDust.Name = "c_boxDust";
            c_boxDust.Size = new Size(201, 25);
            c_boxDust.TabIndex = 55;
            c_boxDust.Text = " Dust or Animal Allergies\n";
            c_boxDust.UseVisualStyleBackColor = true;
            // 
            // gb_OtherFactor
            // 
            gb_OtherFactor.Controls.Add(c_box_otherFactors);
            gb_OtherFactor.Controls.Add(txt_otherFactor);
            gb_OtherFactor.Controls.Add(cbox_Smoking);
            gb_OtherFactor.Controls.Add(cb_Alcoho);
            gb_OtherFactor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_OtherFactor.Location = new Point(173, 316);
            gb_OtherFactor.Name = "gb_OtherFactor";
            gb_OtherFactor.Size = new Size(243, 169);
            gb_OtherFactor.TabIndex = 92;
            gb_OtherFactor.TabStop = false;
            // 
            // c_box_otherFactors
            // 
            c_box_otherFactors.AutoSize = true;
            c_box_otherFactors.Font = new Font("Segoe UI", 12F);
            c_box_otherFactors.Location = new Point(6, 83);
            c_box_otherFactors.Name = "c_box_otherFactors";
            c_box_otherFactors.Size = new Size(69, 25);
            c_box_otherFactors.TabIndex = 70;
            c_box_otherFactors.Text = "Other";
            c_box_otherFactors.UseVisualStyleBackColor = true;
            c_box_otherFactors.CheckedChanged += c_box_otherFactors_CheckedChanged;
            // 
            // txt_otherFactor
            // 
            txt_otherFactor.Font = new Font("Segoe UI", 12F);
            txt_otherFactor.Location = new Point(4, 115);
            txt_otherFactor.Name = "txt_otherFactor";
            txt_otherFactor.Size = new Size(233, 29);
            txt_otherFactor.TabIndex = 71;
            txt_otherFactor.Visible = false;
            // 
            // cbox_Smoking
            // 
            cbox_Smoking.AutoSize = true;
            cbox_Smoking.Font = new Font("Segoe UI", 12F);
            cbox_Smoking.Location = new Point(6, 21);
            cbox_Smoking.Name = "cbox_Smoking";
            cbox_Smoking.Size = new Size(91, 25);
            cbox_Smoking.TabIndex = 51;
            cbox_Smoking.Text = "Smoking";
            cbox_Smoking.UseVisualStyleBackColor = true;
            // 
            // cb_Alcoho
            // 
            cb_Alcoho.AutoSize = true;
            cb_Alcoho.Font = new Font("Segoe UI", 12F);
            cb_Alcoho.Location = new Point(6, 52);
            cb_Alcoho.Name = "cb_Alcoho";
            cb_Alcoho.Size = new Size(155, 25);
            cb_Alcoho.TabIndex = 54;
            cb_Alcoho.Text = " Alcohol Addiction\n";
            cb_Alcoho.UseVisualStyleBackColor = true;
            // 
            // c_box_otherChronic
            // 
            c_box_otherChronic.AutoSize = true;
            c_box_otherChronic.Font = new Font("Segoe UI", 12F);
            c_box_otherChronic.Location = new Point(6, 132);
            c_box_otherChronic.Name = "c_box_otherChronic";
            c_box_otherChronic.Size = new Size(69, 25);
            c_box_otherChronic.TabIndex = 56;
            c_box_otherChronic.Text = "Other";
            c_box_otherChronic.UseVisualStyleBackColor = true;
            c_box_otherChronic.CheckedChanged += c_box_otherChronic_CheckedChanged;
            // 
            // txt_otherChronic
            // 
            txt_otherChronic.Font = new Font("Segoe UI", 12F);
            txt_otherChronic.Location = new Point(6, 157);
            txt_otherChronic.Name = "txt_otherChronic";
            txt_otherChronic.Size = new Size(233, 29);
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
            gb_ChronicDiseases.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb_ChronicDiseases.Location = new Point(12, 55);
            gb_ChronicDiseases.Name = "gb_ChronicDiseases";
            gb_ChronicDiseases.Size = new Size(359, 203);
            gb_ChronicDiseases.TabIndex = 89;
            gb_ChronicDiseases.TabStop = false;
            gb_ChronicDiseases.Text = "Chronic Diseases";
            // 
            // cbox_HeartBlood
            // 
            cbox_HeartBlood.AutoSize = true;
            cbox_HeartBlood.Font = new Font("Segoe UI", 12F);
            cbox_HeartBlood.Location = new Point(6, 32);
            cbox_HeartBlood.Name = "cbox_HeartBlood";
            cbox_HeartBlood.Size = new Size(281, 25);
            cbox_HeartBlood.TabIndex = 51;
            cbox_HeartBlood.Text = " High Blood Pressure (Hypertension)\n";
            cbox_HeartBlood.UseVisualStyleBackColor = true;
            // 
            // c_boxRespiratory
            // 
            c_boxRespiratory.AutoSize = true;
            c_boxRespiratory.Font = new Font("Segoe UI", 12F);
            c_boxRespiratory.Location = new Point(6, 107);
            c_boxRespiratory.Name = "c_boxRespiratory";
            c_boxRespiratory.Size = new Size(274, 25);
            c_boxRespiratory.TabIndex = 52;
            c_boxRespiratory.Text = " Respiratory Diseases (e.g., Asthma)\n";
            c_boxRespiratory.UseVisualStyleBackColor = true;
            // 
            // cbox_HeartDisease
            // 
            cbox_HeartDisease.AutoSize = true;
            cbox_HeartDisease.Font = new Font("Segoe UI", 12F);
            cbox_HeartDisease.Location = new Point(6, 57);
            cbox_HeartDisease.Name = "cbox_HeartDisease";
            cbox_HeartDisease.Size = new Size(135, 25);
            cbox_HeartDisease.TabIndex = 53;
            cbox_HeartDisease.Text = " Heart Diseases\n";
            cbox_HeartDisease.UseVisualStyleBackColor = true;
            // 
            // cbox_Diabetes
            // 
            cbox_Diabetes.AutoSize = true;
            cbox_Diabetes.Font = new Font("Segoe UI", 12F);
            cbox_Diabetes.Location = new Point(200, 57);
            cbox_Diabetes.Name = "cbox_Diabetes";
            cbox_Diabetes.Size = new Size(89, 25);
            cbox_Diabetes.TabIndex = 54;
            cbox_Diabetes.Text = "Diabetes";
            cbox_Diabetes.UseVisualStyleBackColor = true;
            // 
            // cbox_Kindey
            // 
            cbox_Kindey.AutoSize = true;
            cbox_Kindey.Font = new Font("Segoe UI", 12F);
            cbox_Kindey.Location = new Point(6, 82);
            cbox_Kindey.Name = "cbox_Kindey";
            cbox_Kindey.Size = new Size(144, 25);
            cbox_Kindey.TabIndex = 55;
            cbox_Kindey.Text = " Kidney Diseases\n";
            cbox_Kindey.UseVisualStyleBackColor = true;
            // 
            // c_boxLiver
            // 
            c_boxLiver.AutoSize = true;
            c_boxLiver.Font = new Font("Segoe UI", 12F);
            c_boxLiver.Location = new Point(200, 82);
            c_boxLiver.Name = "c_boxLiver";
            c_boxLiver.Size = new Size(131, 25);
            c_boxLiver.TabIndex = 56;
            c_boxLiver.Text = " Liver Diseases\n";
            c_boxLiver.UseVisualStyleBackColor = true;
            // 
            // dtp_BirthDate
            // 
            dtp_BirthDate.Font = new Font("Segoe UI", 12F);
            dtp_BirthDate.Location = new Point(173, 250);
            dtp_BirthDate.Name = "dtp_BirthDate";
            dtp_BirthDate.Size = new Size(249, 29);
            dtp_BirthDate.TabIndex = 72;
            // 
            // rb_Female
            // 
            rb_Female.AutoSize = true;
            rb_Female.Font = new Font("Segoe UI", 12F);
            rb_Female.ForeColor = Color.Black;
            rb_Female.Location = new Point(291, 285);
            rb_Female.Name = "rb_Female";
            rb_Female.Size = new Size(78, 25);
            rb_Female.TabIndex = 87;
            rb_Female.TabStop = true;
            rb_Female.Text = "Female";
            rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            rb_Male.AutoSize = true;
            rb_Male.Font = new Font("Segoe UI", 12F);
            rb_Male.ForeColor = Color.Black;
            rb_Male.Location = new Point(201, 285);
            rb_Male.Name = "rb_Male";
            rb_Male.Size = new Size(62, 25);
            rb_Male.TabIndex = 71;
            rb_Male.TabStop = true;
            rb_Male.Text = "Male";
            rb_Male.UseVisualStyleBackColor = true;
            // 
            // dgv_AdminPaitent
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_AdminPaitent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_AdminPaitent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminPaitent.BackgroundColor = Color.White;
            dgv_AdminPaitent.BorderStyle = BorderStyle.None;
            dgv_AdminPaitent.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_AdminPaitent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_AdminPaitent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_AdminPaitent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminPaitent.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_AdminPaitent.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_AdminPaitent.EnableHeadersVisualStyles = false;
            dgv_AdminPaitent.Location = new Point(14, 50);
            dgv_AdminPaitent.Name = "dgv_AdminPaitent";
            dgv_AdminPaitent.RowHeadersVisible = false;
            dgv_AdminPaitent.RowTemplate.Height = 40;
            dgv_AdminPaitent.Size = new Size(1351, 271);
            dgv_AdminPaitent.TabIndex = 96;
            dgv_AdminPaitent.CellMouseDoubleClick += dgv_AdminPaitent_CellMouseDoubleClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconDGVPat;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // pnlReceDetails
            // 
            pnlReceDetails.BackColor = Color.WhiteSmoke;
            pnlReceDetails.Controls.Add(pictureBox11);
            pnlReceDetails.Controls.Add(label3);
            pnlReceDetails.Controls.Add(pictureBox10);
            pnlReceDetails.Controls.Add(pictureBox5);
            pnlReceDetails.Controls.Add(label2);
            pnlReceDetails.Controls.Add(lb_Gender);
            pnlReceDetails.Controls.Add(pictureBox1);
            pnlReceDetails.Controls.Add(lb_DateBirthPaitent);
            pnlReceDetails.Controls.Add(pictureBox9);
            pnlReceDetails.Controls.Add(gb_OtherFactor);
            pnlReceDetails.Controls.Add(pictureBox6);
            pnlReceDetails.Controls.Add(pictureBox4);
            pnlReceDetails.Controls.Add(pictureBox3);
            pnlReceDetails.Controls.Add(pictureBox2);
            pnlReceDetails.Controls.Add(rb_Female);
            pnlReceDetails.Controls.Add(rb_Male);
            pnlReceDetails.Controls.Add(txt_phone);
            pnlReceDetails.Controls.Add(label1);
            pnlReceDetails.Controls.Add(txt_Address);
            pnlReceDetails.Controls.Add(dtp_BirthDate);
            pnlReceDetails.Controls.Add(lb_AddressPaitnit);
            pnlReceDetails.Controls.Add(txt_Email);
            pnlReceDetails.Controls.Add(lb_PaitnEmail);
            pnlReceDetails.Controls.Add(txt_Lname);
            pnlReceDetails.Controls.Add(lb_LastNamePaitn);
            pnlReceDetails.Controls.Add(txt_Fname);
            pnlReceDetails.Controls.Add(lb_Fname);
            pnlReceDetails.Location = new Point(810, 327);
            pnlReceDetails.Name = "pnlReceDetails";
            pnlReceDetails.Size = new Size(444, 500);
            pnlReceDetails.TabIndex = 98;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.IconHeathBeav;
            pictureBox11.Location = new Point(11, 316);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(24, 24);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 120;
            pictureBox11.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(47, 316);
            label3.Name = "label3";
            label3.Size = new Size(129, 42);
            label3.TabIndex = 119;
            label3.Text = "Health-Related \r\nBehaviors:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.IconPatiPersnalData;
            pictureBox10.Location = new Point(143, 18);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 118;
            pictureBox10.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.IconPaitGender;
            pictureBox5.Location = new Point(11, 280);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 115;
            pictureBox5.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(173, 18);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 117;
            label2.Text = "Personal Data";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb_Gender
            // 
            lb_Gender.AutoSize = true;
            lb_Gender.BackColor = Color.Transparent;
            lb_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Gender.Location = new Point(47, 280);
            lb_Gender.Name = "lb_Gender";
            lb_Gender.Size = new Size(70, 21);
            lb_Gender.TabIndex = 114;
            lb_Gender.Text = "Gender:";
            lb_Gender.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconPatBirth;
            pictureBox1.Location = new Point(11, 250);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 113;
            pictureBox1.TabStop = false;
            // 
            // lb_DateBirthPaitent
            // 
            lb_DateBirthPaitent.AutoSize = true;
            lb_DateBirthPaitent.BackColor = Color.Transparent;
            lb_DateBirthPaitent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DateBirthPaitent.Location = new Point(47, 250);
            lb_DateBirthPaitent.Name = "lb_DateBirthPaitent";
            lb_DateBirthPaitent.Size = new Size(105, 21);
            lb_DateBirthPaitent.TabIndex = 112;
            lb_DateBirthPaitent.Text = "DateOfBirth:";
            lb_DateBirthPaitent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.IconPhone;
            pictureBox9.Location = new Point(11, 142);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 111;
            pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconEmail;
            pictureBox6.Location = new Point(11, 220);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconAddressPat;
            pictureBox4.Location = new Point(11, 180);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 108;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconUserName;
            pictureBox3.Location = new Point(11, 110);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 107;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconUserName;
            pictureBox2.Location = new Point(11, 72);
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
            txt_phone.Location = new Point(173, 138);
            txt_phone.Margin = new Padding(5);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(249, 29);
            txt_phone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(43, 143);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 106;
            label1.Text = "Phone:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Address
            // 
            txt_Address.BackColor = Color.White;
            txt_Address.BorderStyle = BorderStyle.FixedSingle;
            txt_Address.Font = new Font("Segoe UI", 12F);
            txt_Address.ForeColor = Color.Black;
            txt_Address.Location = new Point(173, 177);
            txt_Address.Margin = new Padding(5);
            txt_Address.Name = "txt_Address";
            txt_Address.Size = new Size(249, 29);
            txt_Address.TabIndex = 3;
            // 
            // lb_AddressPaitnit
            // 
            lb_AddressPaitnit.AutoSize = true;
            lb_AddressPaitnit.BackColor = Color.Transparent;
            lb_AddressPaitnit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_AddressPaitnit.Location = new Point(43, 182);
            lb_AddressPaitnit.Name = "lb_AddressPaitnit";
            lb_AddressPaitnit.Size = new Size(74, 21);
            lb_AddressPaitnit.TabIndex = 104;
            lb_AddressPaitnit.Text = "Address:";
            lb_AddressPaitnit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.White;
            txt_Email.BorderStyle = BorderStyle.FixedSingle;
            txt_Email.Font = new Font("Segoe UI", 12F);
            txt_Email.ForeColor = Color.Black;
            txt_Email.Location = new Point(173, 213);
            txt_Email.Margin = new Padding(5);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(249, 29);
            txt_Email.TabIndex = 5;
            // 
            // lb_PaitnEmail
            // 
            lb_PaitnEmail.AutoSize = true;
            lb_PaitnEmail.BackColor = Color.Transparent;
            lb_PaitnEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_PaitnEmail.Location = new Point(43, 223);
            lb_PaitnEmail.Name = "lb_PaitnEmail";
            lb_PaitnEmail.Size = new Size(57, 21);
            lb_PaitnEmail.TabIndex = 103;
            lb_PaitnEmail.Text = "Email:";
            lb_PaitnEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Lname
            // 
            txt_Lname.BackColor = Color.White;
            txt_Lname.BorderStyle = BorderStyle.FixedSingle;
            txt_Lname.Font = new Font("Segoe UI", 12F);
            txt_Lname.ForeColor = Color.Black;
            txt_Lname.Location = new Point(173, 102);
            txt_Lname.Margin = new Padding(5);
            txt_Lname.Name = "txt_Lname";
            txt_Lname.Size = new Size(249, 29);
            txt_Lname.TabIndex = 2;
            // 
            // lb_LastNamePaitn
            // 
            lb_LastNamePaitn.AutoSize = true;
            lb_LastNamePaitn.BackColor = Color.Transparent;
            lb_LastNamePaitn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_LastNamePaitn.Location = new Point(41, 110);
            lb_LastNamePaitn.Name = "lb_LastNamePaitn";
            lb_LastNamePaitn.Size = new Size(94, 21);
            lb_LastNamePaitn.TabIndex = 91;
            lb_LastNamePaitn.Text = "Last Name:";
            lb_LastNamePaitn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Fname
            // 
            txt_Fname.BackColor = Color.White;
            txt_Fname.BorderStyle = BorderStyle.FixedSingle;
            txt_Fname.Font = new Font("Segoe UI", 12F);
            txt_Fname.ForeColor = Color.Black;
            txt_Fname.Location = new Point(173, 67);
            txt_Fname.Margin = new Padding(5);
            txt_Fname.Name = "txt_Fname";
            txt_Fname.Size = new Size(249, 29);
            txt_Fname.TabIndex = 1;
            // 
            // lb_Fname
            // 
            lb_Fname.AutoSize = true;
            lb_Fname.BackColor = Color.Transparent;
            lb_Fname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Fname.Location = new Point(41, 75);
            lb_Fname.Name = "lb_Fname";
            lb_Fname.Size = new Size(96, 21);
            lb_Fname.TabIndex = 89;
            lb_Fname.Text = "First Name:";
            lb_Fname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(lb_medicalHistory);
            panel1.Controls.Add(gb_SurgicalHistory);
            panel1.Controls.Add(gb_ChronicDiseases);
            panel1.Controls.Add(gb_InfectiousDiseases);
            panel1.Controls.Add(gb_AllergieGenetic);
            panel1.Location = new Point(14, 327);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 500);
            panel1.TabIndex = 99;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.IconPatiHistoryData;
            pictureBox7.Location = new Point(279, 18);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 116;
            pictureBox7.TabStop = false;
            // 
            // lb_medicalHistory
            // 
            lb_medicalHistory.AutoSize = true;
            lb_medicalHistory.BackColor = Color.Transparent;
            lb_medicalHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_medicalHistory.Location = new Point(309, 18);
            lb_medicalHistory.Name = "lb_medicalHistory";
            lb_medicalHistory.Size = new Size(127, 21);
            lb_medicalHistory.TabIndex = 113;
            lb_medicalHistory.Text = "History Record:";
            lb_medicalHistory.TextAlign = ContentAlignment.MiddleRight;
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
            btn_remove.Location = new Point(1261, 489);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(104, 53);
            btn_remove.TabIndex = 103;
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
            btn_Update.Location = new Point(1261, 415);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(104, 53);
            btn_Update.TabIndex = 102;
            btn_Update.Text = "Update";
            btn_Update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Visible = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_AddPaitenit
            // 
            btn_AddPaitenit.BackColor = Color.LimeGreen;
            btn_AddPaitenit.Cursor = Cursors.Cross;
            btn_AddPaitenit.FlatAppearance.BorderSize = 0;
            btn_AddPaitenit.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_AddPaitenit.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_AddPaitenit.FlatStyle = FlatStyle.Flat;
            btn_AddPaitenit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddPaitenit.ForeColor = Color.White;
            btn_AddPaitenit.Image = Properties.Resources.IconAddPat;
            btn_AddPaitenit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddPaitenit.Location = new Point(1261, 345);
            btn_AddPaitenit.Name = "btn_AddPaitenit";
            btn_AddPaitenit.Size = new Size(104, 53);
            btn_AddPaitenit.TabIndex = 101;
            btn_AddPaitenit.Text = "Add ";
            btn_AddPaitenit.TextAlign = ContentAlignment.MiddleRight;
            btn_AddPaitenit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AddPaitenit.UseVisualStyleBackColor = false;
            btn_AddPaitenit.Visible = false;
            btn_AddPaitenit.Click += btn_AddDoctor_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.IconPatientSerach;
            pictureBox8.Location = new Point(22, 7);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 106;
            pictureBox8.TabStop = false;
            // 
            // txtBoxPatientSerachData
            // 
            txtBoxPatientSerachData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxPatientSerachData.ForeColor = Color.Gray;
            txtBoxPatientSerachData.Location = new Point(179, 7);
            txtBoxPatientSerachData.Margin = new Padding(5);
            txtBoxPatientSerachData.Name = "txtBoxPatientSerachData";
            txtBoxPatientSerachData.PlaceholderText = "Search by Name";
            txtBoxPatientSerachData.Size = new Size(233, 29);
            txtBoxPatientSerachData.TabIndex = 105;
            txtBoxPatientSerachData.TextChanged += txtBoxPatientSerachData_TextChanged;
            // 
            // lbPatienitNameSearch
            // 
            lbPatienitNameSearch.AutoSize = true;
            lbPatienitNameSearch.BackColor = Color.Transparent;
            lbPatienitNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbPatienitNameSearch.Location = new Point(52, 10);
            lbPatienitNameSearch.Name = "lbPatienitNameSearch";
            lbPatienitNameSearch.Size = new Size(119, 21);
            lbPatienitNameSearch.TabIndex = 104;
            lbPatienitNameSearch.Text = "Patient Name:";
            lbPatienitNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PaitenitCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1377, 836);
            Controls.Add(pictureBox8);
            Controls.Add(txtBoxPatientSerachData);
            Controls.Add(lbPatienitNameSearch);
            Controls.Add(btn_remove);
            Controls.Add(btn_Update);
            Controls.Add(btn_AddPaitenit);
            Controls.Add(panel1);
            Controls.Add(pnlReceDetails);
            Controls.Add(dgv_AdminPaitent);
            Name = "PaitenitCRUD";
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
            pnlReceDetails.ResumeLayout(false);
            pnlReceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
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
        private RadioButton rb_Female;
        private RadioButton rb_Male;
        private Label lb_Phone;
        private TextBox txt_Address;
        private Label lb_Address;
        private TextBox txt_Email;
        private Label lb_DoctorEmail;
        private TextBox txtBoxPatientSerachData;
        private DataGridView dgv_AdminPaitent;
        private Panel pnlReceDetails;
        private PictureBox pBoxConfirmPassword;
        private PictureBox pictureBox9;
        private PictureBox pBoxPassword;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txt_phone;
        private Label label1;
        private Label lb_AddressPaitnit;
        private Label lb_PaitnEmail;
        private TextBox txt_confirmPassword;
        private Label lb_confirmPassword;
        private TextBox txt_Password;
        private Label lb_password;
        private TextBox txt_Lname;
        private Label lb_LastNamePaitn;
        private TextBox txt_Fname;
        private Label lb_Fname;
        private PictureBox pictureBox1;
        private Label lb_DateBirthPaitent;
        private PictureBox pictureBox5;
        private Label lb_Gender;
        private Panel panel1;
        private PictureBox pictureBox7;
        private Label lb_medicalHistory;
        private Button btn_remove;
        private Button btn_Update;
        private Button btn_AddPaitenit;
        private PictureBox pictureBox8;
        private TextBox txtBoxDepartmentSerachData;
        private Label lbPatienitNameSearch;
        private PictureBox pictureBox10;
        private Label label2;
        private PictureBox pictureBox11;
        private Label label3;
        private DataGridViewImageColumn icon;
    }
}