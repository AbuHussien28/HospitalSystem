namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class Patients
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
            groupBox1 = new GroupBox();
            lab_fname = new Label();
            txt_fname = new TextBox();
            lab_lname = new Label();
            txt_lname = new TextBox();
            lab_phone = new Label();
            lab_email = new Label();
            txt_phone1 = new TextBox();
            txt_email = new TextBox();
            lab_DateBirth = new Label();
            dtPicker_BD = new DateTimePicker();
            lab_address = new Label();
            Rbtn_male = new RadioButton();
            Rbtn_female = new RadioButton();
            txt_address = new TextBox();
            lab_gender = new Label();
            groupBox2 = new GroupBox();
            gb_AllergieGenetic = new GroupBox();
            c_box_otherAllergies = new CheckBox();
            txt_otherAllergies = new TextBox();
            c_boxDrugAllergies = new CheckBox();
            c_boxFoodAllergie = new CheckBox();
            c_boxGeneticDiseases = new CheckBox();
            c_boxDust = new CheckBox();
            gb_InfectiousDiseases = new GroupBox();
            c_box_otherInfectious = new CheckBox();
            txt_otherInfectious = new TextBox();
            c_boxHepatitis = new CheckBox();
            c_boxTuberculosis = new CheckBox();
            c_box_covid19 = new CheckBox();
            c_boxHIVOrAIDS = new CheckBox();
            dgv_patientdata = new DataGridView();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            txt_searchPat = new TextBox();
            btn_search = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gb_AllergieGenetic.SuspendLayout();
            gb_InfectiousDiseases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_patientdata).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lab_fname);
            groupBox1.Controls.Add(txt_fname);
            groupBox1.Controls.Add(lab_lname);
            groupBox1.Controls.Add(txt_lname);
            groupBox1.Controls.Add(lab_phone);
            groupBox1.Controls.Add(lab_email);
            groupBox1.Controls.Add(txt_phone1);
            groupBox1.Controls.Add(txt_email);
            groupBox1.Controls.Add(lab_DateBirth);
            groupBox1.Controls.Add(dtPicker_BD);
            groupBox1.Controls.Add(lab_address);
            groupBox1.Controls.Add(Rbtn_male);
            groupBox1.Controls.Add(Rbtn_female);
            groupBox1.Controls.Add(txt_address);
            groupBox1.Controls.Add(lab_gender);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(773, 144);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lab_fname
            // 
            lab_fname.AutoSize = true;
            lab_fname.Location = new Point(29, 26);
            lab_fname.Name = "lab_fname";
            lab_fname.Size = new Size(67, 15);
            lab_fname.TabIndex = 1;
            lab_fname.Text = "First Name";
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(121, 23);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(177, 23);
            txt_fname.TabIndex = 8;
            // 
            // lab_lname
            // 
            lab_lname.AutoSize = true;
            lab_lname.Location = new Point(29, 58);
            lab_lname.Name = "lab_lname";
            lab_lname.Size = new Size(65, 15);
            lab_lname.TabIndex = 2;
            lab_lname.Text = "Last Name";
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(121, 58);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(177, 23);
            txt_lname.TabIndex = 9;
            // 
            // lab_phone
            // 
            lab_phone.AutoSize = true;
            lab_phone.Location = new Point(323, 34);
            lab_phone.Name = "lab_phone";
            lab_phone.Size = new Size(91, 15);
            lab_phone.TabIndex = 7;
            lab_phone.Text = "Phone Number";
            // 
            // lab_email
            // 
            lab_email.AutoSize = true;
            lab_email.Location = new Point(343, 66);
            lab_email.Name = "lab_email";
            lab_email.Size = new Size(36, 15);
            lab_email.TabIndex = 5;
            lab_email.Text = "Email";
            // 
            // txt_phone1
            // 
            txt_phone1.Location = new Point(438, 31);
            txt_phone1.Name = "txt_phone1";
            txt_phone1.Size = new Size(160, 23);
            txt_phone1.TabIndex = 12;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(438, 63);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(160, 23);
            txt_email.TabIndex = 10;
            // 
            // lab_DateBirth
            // 
            lab_DateBirth.AutoSize = true;
            lab_DateBirth.Location = new Point(22, 92);
            lab_DateBirth.Name = "lab_DateBirth";
            lab_DateBirth.Size = new Size(77, 15);
            lab_DateBirth.TabIndex = 3;
            lab_DateBirth.Text = "Date Of Bith";
            // 
            // dtPicker_BD
            // 
            dtPicker_BD.Location = new Point(121, 92);
            dtPicker_BD.Name = "dtPicker_BD";
            dtPicker_BD.Size = new Size(172, 23);
            dtPicker_BD.TabIndex = 14;
            // 
            // lab_address
            // 
            lab_address.AutoSize = true;
            lab_address.Location = new Point(343, 92);
            lab_address.Name = "lab_address";
            lab_address.Size = new Size(51, 15);
            lab_address.TabIndex = 6;
            lab_address.Text = "Address";
            // 
            // Rbtn_male
            // 
            Rbtn_male.AutoSize = true;
            Rbtn_male.Location = new Point(536, 123);
            Rbtn_male.Name = "Rbtn_male";
            Rbtn_male.Size = new Size(52, 19);
            Rbtn_male.TabIndex = 15;
            Rbtn_male.TabStop = true;
            Rbtn_male.Text = "male";
            Rbtn_male.UseVisualStyleBackColor = true;
            // 
            // Rbtn_female
            // 
            Rbtn_female.AutoSize = true;
            Rbtn_female.Location = new Point(451, 122);
            Rbtn_female.Name = "Rbtn_female";
            Rbtn_female.Size = new Size(64, 19);
            Rbtn_female.TabIndex = 16;
            Rbtn_female.TabStop = true;
            Rbtn_female.Text = "female";
            Rbtn_female.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(438, 92);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(160, 23);
            txt_address.TabIndex = 11;
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.Location = new Point(343, 124);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(49, 15);
            lab_gender.TabIndex = 4;
            lab_gender.Text = "Gender";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(gb_AllergieGenetic);
            groupBox2.Controls.Add(gb_InfectiousDiseases);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(9, 172);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(679, 152);
            groupBox2.TabIndex = 71;
            groupBox2.TabStop = false;
            groupBox2.Text = "Medical History";
            // 
            // gb_AllergieGenetic
            // 
            gb_AllergieGenetic.Controls.Add(c_box_otherAllergies);
            gb_AllergieGenetic.Controls.Add(txt_otherAllergies);
            gb_AllergieGenetic.Controls.Add(c_boxDrugAllergies);
            gb_AllergieGenetic.Controls.Add(c_boxFoodAllergie);
            gb_AllergieGenetic.Controls.Add(c_boxGeneticDiseases);
            gb_AllergieGenetic.Controls.Add(c_boxDust);
            gb_AllergieGenetic.Location = new Point(6, 22);
            gb_AllergieGenetic.Name = "gb_AllergieGenetic";
            gb_AllergieGenetic.Size = new Size(302, 116);
            gb_AllergieGenetic.TabIndex = 69;
            gb_AllergieGenetic.TabStop = false;
            gb_AllergieGenetic.Text = "Allergies & Genetic Conditions:\n\n";
            // 
            // c_box_otherAllergies
            // 
            c_box_otherAllergies.AutoSize = true;
            c_box_otherAllergies.Location = new Point(6, 82);
            c_box_otherAllergies.Name = "c_box_otherAllergies";
            c_box_otherAllergies.Size = new Size(59, 19);
            c_box_otherAllergies.TabIndex = 68;
            c_box_otherAllergies.Text = "Other";
            c_box_otherAllergies.UseVisualStyleBackColor = true;
            // 
            // txt_otherAllergies
            // 
            txt_otherAllergies.Location = new Point(91, 80);
            txt_otherAllergies.Name = "txt_otherAllergies";
            txt_otherAllergies.Size = new Size(200, 23);
            txt_otherAllergies.TabIndex = 69;
            txt_otherAllergies.Visible = false;
            // 
            // c_boxDrugAllergies
            // 
            c_boxDrugAllergies.AutoSize = true;
            c_boxDrugAllergies.Location = new Point(6, 32);
            c_boxDrugAllergies.Name = "c_boxDrugAllergies";
            c_boxDrugAllergies.Size = new Size(105, 19);
            c_boxDrugAllergies.TabIndex = 51;
            c_boxDrugAllergies.Text = "Drug Allergies";
            c_boxDrugAllergies.UseVisualStyleBackColor = true;
            // 
            // c_boxFoodAllergie
            // 
            c_boxFoodAllergie.AutoSize = true;
            c_boxFoodAllergie.Location = new Point(6, 57);
            c_boxFoodAllergie.Name = "c_boxFoodAllergie";
            c_boxFoodAllergie.Size = new Size(107, 19);
            c_boxFoodAllergie.TabIndex = 53;
            c_boxFoodAllergie.Text = " Food Allergies\n";
            c_boxFoodAllergie.UseVisualStyleBackColor = true;
            // 
            // c_boxGeneticDiseases
            // 
            c_boxGeneticDiseases.AutoSize = true;
            c_boxGeneticDiseases.Location = new Point(135, 32);
            c_boxGeneticDiseases.Name = "c_boxGeneticDiseases";
            c_boxGeneticDiseases.Size = new Size(120, 19);
            c_boxGeneticDiseases.TabIndex = 54;
            c_boxGeneticDiseases.Text = "Genetic Diseases";
            c_boxGeneticDiseases.UseVisualStyleBackColor = true;
            // 
            // c_boxDust
            // 
            c_boxDust.AutoSize = true;
            c_boxDust.Location = new Point(135, 57);
            c_boxDust.Name = "c_boxDust";
            c_boxDust.Size = new Size(162, 19);
            c_boxDust.TabIndex = 55;
            c_boxDust.Text = " Dust or Animal Allergies\n";
            c_boxDust.UseVisualStyleBackColor = true;
            // 
            // gb_InfectiousDiseases
            // 
            gb_InfectiousDiseases.Controls.Add(c_box_otherInfectious);
            gb_InfectiousDiseases.Controls.Add(txt_otherInfectious);
            gb_InfectiousDiseases.Controls.Add(c_boxHepatitis);
            gb_InfectiousDiseases.Controls.Add(c_boxTuberculosis);
            gb_InfectiousDiseases.Controls.Add(c_box_covid19);
            gb_InfectiousDiseases.Controls.Add(c_boxHIVOrAIDS);
            gb_InfectiousDiseases.Location = new Point(343, 22);
            gb_InfectiousDiseases.Name = "gb_InfectiousDiseases";
            gb_InfectiousDiseases.Size = new Size(269, 116);
            gb_InfectiousDiseases.TabIndex = 68;
            gb_InfectiousDiseases.TabStop = false;
            gb_InfectiousDiseases.Text = "Infectious Diseases:\n\n";
            // 
            // c_box_otherInfectious
            // 
            c_box_otherInfectious.AutoSize = true;
            c_box_otherInfectious.Location = new Point(6, 72);
            c_box_otherInfectious.Name = "c_box_otherInfectious";
            c_box_otherInfectious.Size = new Size(59, 19);
            c_box_otherInfectious.TabIndex = 68;
            c_box_otherInfectious.Text = "Other";
            c_box_otherInfectious.UseVisualStyleBackColor = true;
            // 
            // txt_otherInfectious
            // 
            txt_otherInfectious.Location = new Point(81, 72);
            txt_otherInfectious.Name = "txt_otherInfectious";
            txt_otherInfectious.Size = new Size(179, 23);
            txt_otherInfectious.TabIndex = 69;
            txt_otherInfectious.Visible = false;
            // 
            // c_boxHepatitis
            // 
            c_boxHepatitis.AutoSize = true;
            c_boxHepatitis.Location = new Point(6, 22);
            c_boxHepatitis.Name = "c_boxHepatitis";
            c_boxHepatitis.Size = new Size(140, 19);
            c_boxHepatitis.TabIndex = 51;
            c_boxHepatitis.Text = " Hepatitis (A, B, or C)\n";
            c_boxHepatitis.UseVisualStyleBackColor = true;
            // 
            // c_boxTuberculosis
            // 
            c_boxTuberculosis.AutoSize = true;
            c_boxTuberculosis.Location = new Point(6, 47);
            c_boxTuberculosis.Name = "c_boxTuberculosis";
            c_boxTuberculosis.Size = new Size(123, 19);
            c_boxTuberculosis.TabIndex = 53;
            c_boxTuberculosis.Text = " Tuberculosis (TB)\n";
            c_boxTuberculosis.UseVisualStyleBackColor = true;
            // 
            // c_box_covid19
            // 
            c_box_covid19.AutoSize = true;
            c_box_covid19.Location = new Point(94, 47);
            c_box_covid19.Name = "c_box_covid19";
            c_box_covid19.Size = new Size(190, 19);
            c_box_covid19.TabIndex = 54;
            c_box_covid19.Text = " Previous COVID-19 Infection\r\n";
            c_box_covid19.UseVisualStyleBackColor = true;
            // 
            // c_boxHIVOrAIDS
            // 
            c_boxHIVOrAIDS.AutoSize = true;
            c_boxHIVOrAIDS.Location = new Point(148, 22);
            c_boxHIVOrAIDS.Name = "c_boxHIVOrAIDS";
            c_boxHIVOrAIDS.Size = new Size(83, 19);
            c_boxHIVOrAIDS.TabIndex = 55;
            c_boxHIVOrAIDS.Text = " HIV/AIDS\n";
            c_boxHIVOrAIDS.UseVisualStyleBackColor = true;
            // 
            // dgv_patientdata
            // 
            dgv_patientdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patientdata.Location = new Point(9, 398);
            dgv_patientdata.Name = "dgv_patientdata";
            dgv_patientdata.Size = new Size(824, 218);
            dgv_patientdata.TabIndex = 72;
            dgv_patientdata.CellDoubleClick += dgv_patientdata_CellDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(106, 330);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 49);
            btn_add.TabIndex = 73;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(251, 330);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(100, 45);
            btn_update.TabIndex = 74;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(398, 334);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(100, 45);
            btn_delete.TabIndex = 75;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txt_searchPat
            // 
            txt_searchPat.Location = new Point(525, 342);
            txt_searchPat.Name = "txt_searchPat";
            txt_searchPat.Size = new Size(173, 23);
            txt_searchPat.TabIndex = 76;
            txt_searchPat.TextChanged += txt_searchPat_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(714, 341);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(27, 23);
            btn_search.TabIndex = 77;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 632);
            Controls.Add(btn_search);
            Controls.Add(txt_searchPat);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(dgv_patientdata);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Patients";
            Text = "Patients";
            Load += Patients_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            gb_AllergieGenetic.ResumeLayout(false);
            gb_AllergieGenetic.PerformLayout();
            gb_InfectiousDiseases.ResumeLayout(false);
            gb_InfectiousDiseases.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_patientdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lab_fname;
        private TextBox txt_fname;
        private Label lab_lname;
        private TextBox txt_lname;
        private Label lab_phone;
        private Label lab_email;
        private TextBox txt_phone1;
        private TextBox txt_email;
        private Label lab_DateBirth;
        private DateTimePicker dtPicker_BD;
        private Label lab_address;
        private RadioButton Rbtn_male;
        private RadioButton Rbtn_female;
        private TextBox txt_address;
        private Label lab_gender;
        private GroupBox groupBox2;
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
        private DataGridView dgv_patientdata;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private TextBox txt_searchPat;
        private Button btn_search;
    }
}