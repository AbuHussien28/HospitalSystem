namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class Edit_Medical_Record
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
            patientName = new Label();
            label5 = new Label();
            btn_Update = new Button();
            txt_treatmentDeatis = new TextBox();
            label4 = new Label();
            txt_labresult = new TextBox();
            label3 = new Label();
            txt_prescription = new TextBox();
            label2 = new Label();
            txt_Diaqnois = new TextBox();
            label1 = new Label();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // patientName
            // 
            patientName.AutoSize = true;
            patientName.Font = new Font("Segoe UI", 12F);
            patientName.Location = new Point(674, 45);
            patientName.Name = "patientName";
            patientName.Size = new Size(52, 21);
            patientName.TabIndex = 21;
            patientName.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(418, 44);
            label5.Name = "label5";
            label5.Size = new Size(236, 25);
            label5.TabIndex = 20;
            label5.Text = "Medical Record For Patient:  ";
            // 
            // btn_Update
            // 
            btn_Update.Font = new Font("Segoe UI", 12F);
            btn_Update.Location = new Point(337, 371);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(105, 36);
            btn_Update.TabIndex = 19;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_treatmentDeatis
            // 
            txt_treatmentDeatis.Location = new Point(554, 219);
            txt_treatmentDeatis.Name = "txt_treatmentDeatis";
            txt_treatmentDeatis.Size = new Size(100, 23);
            txt_treatmentDeatis.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(337, 222);
            label4.Name = "label4";
            label4.Size = new Size(148, 25);
            label4.TabIndex = 17;
            label4.Text = "Treatment Details";
            // 
            // txt_labresult
            // 
            txt_labresult.Location = new Point(184, 222);
            txt_labresult.Name = "txt_labresult";
            txt_labresult.Size = new Size(100, 23);
            txt_labresult.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(86, 219);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 15;
            label3.Text = "Lab Result";
            // 
            // txt_prescription
            // 
            txt_prescription.Location = new Point(545, 109);
            txt_prescription.Name = "txt_prescription";
            txt_prescription.Size = new Size(100, 23);
            txt_prescription.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(337, 110);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 13;
            label2.Text = "Prescription";
            // 
            // txt_Diaqnois
            // 
            txt_Diaqnois.Location = new Point(184, 112);
            txt_Diaqnois.Name = "txt_Diaqnois";
            txt_Diaqnois.Size = new Size(100, 23);
            txt_Diaqnois.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(75, 109);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 11;
            label1.Text = "Diaqnois";
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 12F);
            btn_delete.Location = new Point(554, 371);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(105, 36);
            btn_delete.TabIndex = 22;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Edit_Medical_Record
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(patientName);
            Controls.Add(label5);
            Controls.Add(btn_Update);
            Controls.Add(txt_treatmentDeatis);
            Controls.Add(label4);
            Controls.Add(txt_labresult);
            Controls.Add(label3);
            Controls.Add(txt_prescription);
            Controls.Add(label2);
            Controls.Add(txt_Diaqnois);
            Controls.Add(label1);
            Name = "Edit_Medical_Record";
            Text = "Edit_Medical_Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label patientName;
        private Label label5;
        private Button btn_Update;
        private TextBox txt_treatmentDeatis;
        private Label label4;
        private TextBox txt_labresult;
        private Label label3;
        private TextBox txt_prescription;
        private Label label2;
        private TextBox txt_Diaqnois;
        private Label label1;
        private Button btn_delete;
    }
}