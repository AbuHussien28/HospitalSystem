namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class Add_Medical_Record
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
            txt_Diaqnois = new TextBox();
            txt_prescription = new TextBox();
            txt_labresult = new TextBox();
            txt_treatmentDeatis = new TextBox();
            btn_Add = new Button();
            patientName = new Label();
            doctorName = new Label();
            patientAge = new Label();
            deptName = new Label();
            patientDateVisit = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // txt_Diaqnois
            // 
            txt_Diaqnois.BackColor = Color.FromArgb(254, 251, 244);
            txt_Diaqnois.Cursor = Cursors.Hand;
            txt_Diaqnois.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Diaqnois.ForeColor = Color.FromArgb(22, 33, 68);
            txt_Diaqnois.Location = new Point(278, 262);
            txt_Diaqnois.Name = "txt_Diaqnois";
            txt_Diaqnois.Size = new Size(147, 29);
            txt_Diaqnois.TabIndex = 1;
            // 
            // txt_prescription
            // 
            txt_prescription.BackColor = Color.FromArgb(254, 251, 244);
            txt_prescription.BorderStyle = BorderStyle.None;
            txt_prescription.Cursor = Cursors.Hand;
            txt_prescription.Font = new Font("Segoe UI", 12F);
            txt_prescription.ForeColor = Color.FromArgb(22, 33, 68);
            txt_prescription.Location = new Point(85, 407);
            txt_prescription.Multiline = true;
            txt_prescription.Name = "txt_prescription";
            txt_prescription.Size = new Size(437, 537);
            txt_prescription.TabIndex = 3;
            // 
            // txt_labresult
            // 
            txt_labresult.BackColor = Color.FromArgb(254, 251, 244);
            txt_labresult.Cursor = Cursors.Hand;
            txt_labresult.Font = new Font("Segoe UI", 12F);
            txt_labresult.ForeColor = Color.FromArgb(22, 33, 68);
            txt_labresult.Location = new Point(833, 218);
            txt_labresult.Name = "txt_labresult";
            txt_labresult.Size = new Size(125, 29);
            txt_labresult.TabIndex = 5;
            // 
            // txt_treatmentDeatis
            // 
            txt_treatmentDeatis.BackColor = Color.FromArgb(254, 251, 244);
            txt_treatmentDeatis.BorderStyle = BorderStyle.None;
            txt_treatmentDeatis.Cursor = Cursors.Hand;
            txt_treatmentDeatis.Font = new Font("Segoe UI", 12F);
            txt_treatmentDeatis.ForeColor = Color.FromArgb(22, 33, 68);
            txt_treatmentDeatis.Location = new Point(610, 407);
            txt_treatmentDeatis.Multiline = true;
            txt_treatmentDeatis.Name = "txt_treatmentDeatis";
            txt_treatmentDeatis.Size = new Size(392, 537);
            txt_treatmentDeatis.TabIndex = 7;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.FromArgb(29, 53, 87);
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Add.ForeColor = Color.FromArgb(254, 251, 244);
            btn_Add.Image = Properties.Resources.IconAddMecical;
            btn_Add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Add.Location = new Point(518, 970);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(105, 36);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // patientName
            // 
            patientName.AutoSize = true;
            patientName.BackColor = Color.FromArgb(254, 251, 244);
            patientName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            patientName.ForeColor = Color.FromArgb(22, 33, 68);
            patientName.Location = new Point(278, 144);
            patientName.Name = "patientName";
            patientName.Size = new Size(64, 25);
            patientName.TabIndex = 10;
            patientName.Text = "Name";
            // 
            // doctorName
            // 
            doctorName.AutoSize = true;
            doctorName.BackColor = Color.FromArgb(254, 251, 244);
            doctorName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            doctorName.ForeColor = Color.FromArgb(22, 33, 68);
            doctorName.Location = new Point(843, 143);
            doctorName.Name = "doctorName";
            doctorName.Size = new Size(79, 25);
            doctorName.TabIndex = 12;
            doctorName.Text = " Doctor";
            // 
            // patientAge
            // 
            patientAge.AutoSize = true;
            patientAge.BackColor = Color.FromArgb(254, 251, 244);
            patientAge.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            patientAge.ForeColor = Color.FromArgb(22, 33, 68);
            patientAge.Location = new Point(278, 181);
            patientAge.Name = "patientAge";
            patientAge.Size = new Size(47, 25);
            patientAge.TabIndex = 13;
            patientAge.Text = "Age";
            // 
            // deptName
            // 
            deptName.AutoSize = true;
            deptName.BackColor = Color.FromArgb(254, 251, 244);
            deptName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            deptName.ForeColor = Color.FromArgb(22, 33, 68);
            deptName.Location = new Point(833, 181);
            deptName.Name = "deptName";
            deptName.Size = new Size(55, 25);
            deptName.TabIndex = 14;
            deptName.Text = "Dept";
            // 
            // patientDateVisit
            // 
            patientDateVisit.AutoSize = true;
            patientDateVisit.BackColor = Color.FromArgb(254, 251, 244);
            patientDateVisit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            patientDateVisit.ForeColor = Color.FromArgb(22, 33, 68);
            patientDateVisit.Location = new Point(278, 222);
            patientDateVisit.Name = "patientDateVisit";
            patientDateVisit.Size = new Size(53, 25);
            patientDateVisit.TabIndex = 15;
            patientDateVisit.Text = "Date";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ITIMedicalRecordAdd;
            pictureBox1.Location = new Point(20, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1080, 1080);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconDoctorData;
            pictureBox2.Location = new Point(599, 144);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconDoctorData;
            pictureBox3.Location = new Point(599, 182);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconLabResult;
            pictureBox4.Location = new Point(599, 223);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.IconPaientent;
            pictureBox5.Location = new Point(30, 144);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconAgePait;
            pictureBox6.Location = new Point(30, 181);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.IconPatBirth;
            pictureBox7.Location = new Point(30, 223);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 21;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.IconDignoPait;
            pictureBox8.Location = new Point(30, 267);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 22;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.IconPrescription;
            pictureBox9.Location = new Point(122, 345);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 23;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.IconTreatments;
            pictureBox10.Location = new Point(610, 345);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 24;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.IconMedical;
            pictureBox11.Location = new Point(378, 35);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(24, 24);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 25;
            pictureBox11.TabStop = false;
            // 
            // Add_Medical_Record
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1110, 1061);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(patientDateVisit);
            Controls.Add(deptName);
            Controls.Add(patientAge);
            Controls.Add(doctorName);
            Controls.Add(patientName);
            Controls.Add(btn_Add);
            Controls.Add(txt_treatmentDeatis);
            Controls.Add(txt_labresult);
            Controls.Add(txt_prescription);
            Controls.Add(txt_Diaqnois);
            Controls.Add(pictureBox1);
            Name = "Add_Medical_Record";
            Text = "Add_Medical_Record";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_Diaqnois;
        private TextBox txt_prescription;
        private TextBox txt_labresult;
        private TextBox txt_treatmentDeatis;
        private Button btn_Add;
        private Label patientName;
        private Label doctorName;
        private Label patientAge;
        private Label deptName;
        private Label patientDateVisit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
    }
}