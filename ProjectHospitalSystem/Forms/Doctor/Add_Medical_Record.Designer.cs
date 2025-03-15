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
            label1 = new Label();
            txt_Diaqnois = new TextBox();
            txt_prescription = new TextBox();
            label2 = new Label();
            txt_labresult = new TextBox();
            label3 = new Label();
            txt_treatmentDeatis = new TextBox();
            label4 = new Label();
            btn_Add = new Button();
            label5 = new Label();
            patientName = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(40, 85);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Diaqnois";
            // 
            // txt_Diaqnois
            // 
            txt_Diaqnois.Location = new Point(149, 88);
            txt_Diaqnois.Name = "txt_Diaqnois";
            txt_Diaqnois.Size = new Size(100, 23);
            txt_Diaqnois.TabIndex = 1;
            // 
            // txt_prescription
            // 
            txt_prescription.Location = new Point(510, 85);
            txt_prescription.Name = "txt_prescription";
            txt_prescription.Size = new Size(100, 23);
            txt_prescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(302, 86);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 2;
            label2.Text = "Prescription";
            // 
            // txt_labresult
            // 
            txt_labresult.Location = new Point(149, 198);
            txt_labresult.Name = "txt_labresult";
            txt_labresult.Size = new Size(100, 23);
            txt_labresult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(51, 195);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Lab Result";
            // 
            // txt_treatmentDeatis
            // 
            txt_treatmentDeatis.Location = new Point(519, 195);
            txt_treatmentDeatis.Name = "txt_treatmentDeatis";
            txt_treatmentDeatis.Size = new Size(100, 23);
            txt_treatmentDeatis.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(302, 198);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 6;
            label4.Text = "Treatment Details";
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 12F);
            btn_Add.Location = new Point(302, 347);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(105, 36);
            btn_Add.TabIndex = 8;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(383, 20);
            label5.Name = "label5";
            label5.Size = new Size(236, 25);
            label5.TabIndex = 9;
            label5.Text = "Medical Record For Patient:  ";
            // 
            // patientName
            // 
            patientName.AutoSize = true;
            patientName.Font = new Font("Segoe UI", 12F);
            patientName.Location = new Point(639, 21);
            patientName.Name = "patientName";
            patientName.Size = new Size(52, 21);
            patientName.TabIndex = 10;
            patientName.Text = "label6";
            // 
            // Add_Medical_Record
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(patientName);
            Controls.Add(label5);
            Controls.Add(btn_Add);
            Controls.Add(txt_treatmentDeatis);
            Controls.Add(label4);
            Controls.Add(txt_labresult);
            Controls.Add(label3);
            Controls.Add(txt_prescription);
            Controls.Add(label2);
            Controls.Add(txt_Diaqnois);
            Controls.Add(label1);
            Name = "Add_Medical_Record";
            Text = "Add_Medical_Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Diaqnois;
        private TextBox txt_prescription;
        private Label label2;
        private TextBox txt_labresult;
        private Label label3;
        private TextBox txt_treatmentDeatis;
        private Label label4;
        private Button btn_Add;
        private Label label5;
        private Label patientName;
    }
}