namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class Bills
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dgv_Bills = new DataGridView();
            label10 = new Label();
            txt_total = new TextBox();
            btn_pay = new Button();
            cob_patient = new ComboBox();
            cob_searDept = new ComboBox();
            txt_GenDate = new TextBox();
            txt_Due = new TextBox();
            txt_status = new TextBox();
            txt_OAmount = new TextBox();
            txt_dept = new TextBox();
            txt_LateFee = new TextBox();
            txt_doc = new TextBox();
            lab_tolPaid = new Label();
            lab_Remain = new Label();
            txt_tolPaid = new TextBox();
            txt_remain = new TextBox();
            label11 = new Label();
            txt_pat = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Bills).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 93);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "GenertedDate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 93);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Due Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 140);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 15);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 3;
            label4.Text = "Patient Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 143);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 4;
            label5.Text = "Department Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 188);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 5;
            label6.Text = "Original Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 188);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 6;
            label7.Text = "Late Fee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(496, 190);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 7;
            label8.Text = "Total Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(495, 140);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 8;
            label9.Text = "Doctor Name";
            // 
            // dgv_Bills
            // 
            dgv_Bills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bills.Location = new Point(11, 291);
            dgv_Bills.Name = "dgv_Bills";
            dgv_Bills.Size = new Size(703, 220);
            dgv_Bills.TabIndex = 9;
            dgv_Bills.CellDoubleClick += dgv_Bills_CellDoubleClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 18);
            label10.Name = "label10";
            label10.Size = new Size(124, 15);
            label10.TabIndex = 11;
            label10.Text = "Search By Department";
            // 
            // txt_total
            // 
            txt_total.Location = new Point(600, 185);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(100, 23);
            txt_total.TabIndex = 21;
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(600, 247);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(111, 38);
            btn_pay.TabIndex = 22;
            btn_pay.Text = "Pay a Bill";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += button1_Click;
            // 
            // cob_patient
            // 
            cob_patient.FormattingEnabled = true;
            cob_patient.Location = new Point(430, 12);
            cob_patient.Name = "cob_patient";
            cob_patient.Size = new Size(121, 23);
            cob_patient.TabIndex = 23;
            cob_patient.SelectedIndexChanged += cob_patient_SelectedIndexChanged_1;
            // 
            // cob_searDept
            // 
            cob_searDept.FormattingEnabled = true;
            cob_searDept.Location = new Point(166, 16);
            cob_searDept.Name = "cob_searDept";
            cob_searDept.Size = new Size(121, 23);
            cob_searDept.TabIndex = 24;
            cob_searDept.SelectedIndexChanged += cob_searDept_SelectedIndexChanged;
            // 
            // txt_GenDate
            // 
            txt_GenDate.Location = new Point(361, 93);
            txt_GenDate.Name = "txt_GenDate";
            txt_GenDate.ReadOnly = true;
            txt_GenDate.Size = new Size(100, 23);
            txt_GenDate.TabIndex = 25;
            // 
            // txt_Due
            // 
            txt_Due.Location = new Point(571, 87);
            txt_Due.Name = "txt_Due";
            txt_Due.ReadOnly = true;
            txt_Due.Size = new Size(100, 23);
            txt_Due.TabIndex = 26;
            // 
            // txt_status
            // 
            txt_status.Location = new Point(121, 137);
            txt_status.Name = "txt_status";
            txt_status.ReadOnly = true;
            txt_status.Size = new Size(104, 23);
            txt_status.TabIndex = 27;
            // 
            // txt_OAmount
            // 
            txt_OAmount.Location = new Point(125, 188);
            txt_OAmount.Name = "txt_OAmount";
            txt_OAmount.ReadOnly = true;
            txt_OAmount.Size = new Size(100, 23);
            txt_OAmount.TabIndex = 28;
            // 
            // txt_dept
            // 
            txt_dept.Location = new Point(361, 137);
            txt_dept.Name = "txt_dept";
            txt_dept.ReadOnly = true;
            txt_dept.Size = new Size(100, 23);
            txt_dept.TabIndex = 29;
            // 
            // txt_LateFee
            // 
            txt_LateFee.Location = new Point(346, 187);
            txt_LateFee.Name = "txt_LateFee";
            txt_LateFee.ReadOnly = true;
            txt_LateFee.Size = new Size(100, 23);
            txt_LateFee.TabIndex = 30;
            // 
            // txt_doc
            // 
            txt_doc.Location = new Point(579, 137);
            txt_doc.Name = "txt_doc";
            txt_doc.ReadOnly = true;
            txt_doc.Size = new Size(100, 23);
            txt_doc.TabIndex = 31;
            // 
            // lab_tolPaid
            // 
            lab_tolPaid.AutoSize = true;
            lab_tolPaid.Location = new Point(38, 231);
            lab_tolPaid.Name = "lab_tolPaid";
            lab_tolPaid.Size = new Size(55, 15);
            lab_tolPaid.TabIndex = 32;
            lab_tolPaid.Text = "TotalPaid";
            // 
            // lab_Remain
            // 
            lab_Remain.AutoSize = true;
            lab_Remain.Location = new Point(287, 245);
            lab_Remain.Name = "lab_Remain";
            lab_Remain.Size = new Size(105, 15);
            lab_Remain.TabIndex = 33;
            lab_Remain.Text = "RemainingBalance";
            // 
            // txt_tolPaid
            // 
            txt_tolPaid.Location = new Point(121, 236);
            txt_tolPaid.Name = "txt_tolPaid";
            txt_tolPaid.ReadOnly = true;
            txt_tolPaid.Size = new Size(100, 23);
            txt_tolPaid.TabIndex = 34;
            // 
            // txt_remain
            // 
            txt_remain.Location = new Point(398, 245);
            txt_remain.Name = "txt_remain";
            txt_remain.ReadOnly = true;
            txt_remain.Size = new Size(109, 23);
            txt_remain.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 87);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 36;
            label11.Text = "Patient Name";
            // 
            // txt_pat
            // 
            txt_pat.Location = new Point(125, 90);
            txt_pat.Name = "txt_pat";
            txt_pat.ReadOnly = true;
            txt_pat.Size = new Size(100, 23);
            txt_pat.TabIndex = 37;
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 523);
            Controls.Add(txt_pat);
            Controls.Add(label11);
            Controls.Add(txt_remain);
            Controls.Add(txt_tolPaid);
            Controls.Add(lab_Remain);
            Controls.Add(lab_tolPaid);
            Controls.Add(txt_doc);
            Controls.Add(txt_LateFee);
            Controls.Add(txt_dept);
            Controls.Add(txt_OAmount);
            Controls.Add(txt_status);
            Controls.Add(txt_Due);
            Controls.Add(txt_GenDate);
            Controls.Add(cob_searDept);
            Controls.Add(cob_patient);
            Controls.Add(btn_pay);
            Controls.Add(txt_total);
            Controls.Add(label10);
            Controls.Add(dgv_Bills);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bills";
            Text = "Bills";
            Load += Bills_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Bills).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DataGridView dgv_Bills;
        private ComboBox comboBox1;
        private Label label10;
        private TextBox txt_patient;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox txt_total;
        private Button btn_pay;
        private ComboBox cob_patient;
        private ComboBox cob_searDept;
        private TextBox txt_GenDate;
        private TextBox txt_Due;
        private TextBox txt_status;
        private TextBox txt_OAmount;
        private TextBox txt_dept;
        private TextBox txt_LateFee;
        private TextBox txt_doc;
        private Label lab_tolPaid;
        private Label lab_Remain;
        private TextBox txt_tolPaid;
        private TextBox txt_remain;
        private Label label11;
        private TextBox txt_pat;
    }
}