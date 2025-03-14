namespace ProjectHospitalSystem.Forms.Receptionist
{
    partial class Payment
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
            lbBillDateFrom = new Label();
            dtppayment = new DateTimePicker();
            lbAmountPaid = new Label();
            txt_DepartmentFeeAmountFee = new NumericUpDown();
            label6 = new Label();
            cbPaymentMethod = new ComboBox();
            btn_pay = new Button();
            label1 = new Label();
            txt_billid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txt_DepartmentFeeAmountFee).BeginInit();
            SuspendLayout();
            // 
            // lbBillDateFrom
            // 
            lbBillDateFrom.AutoSize = true;
            lbBillDateFrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbBillDateFrom.Location = new Point(231, 22);
            lbBillDateFrom.Name = "lbBillDateFrom";
            lbBillDateFrom.Size = new Size(103, 19);
            lbBillDateFrom.TabIndex = 22;
            lbBillDateFrom.Text = "Payment Date";
            // 
            // dtppayment
            // 
            dtppayment.Location = new Point(340, 21);
            dtppayment.Name = "dtppayment";
            dtppayment.Size = new Size(116, 23);
            dtppayment.TabIndex = 23;
            // 
            // lbAmountPaid
            // 
            lbAmountPaid.AutoSize = true;
            lbAmountPaid.Location = new Point(34, 115);
            lbAmountPaid.Name = "lbAmountPaid";
            lbAmountPaid.Size = new Size(112, 15);
            lbAmountPaid.TabIndex = 30;
            lbAmountPaid.Text = "Amount Paid (EGP):";
            // 
            // txt_DepartmentFeeAmountFee
            // 
            txt_DepartmentFeeAmountFee.DecimalPlaces = 2;
            txt_DepartmentFeeAmountFee.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            txt_DepartmentFeeAmountFee.Location = new Point(182, 107);
            txt_DepartmentFeeAmountFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txt_DepartmentFeeAmountFee.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            txt_DepartmentFeeAmountFee.Name = "txt_DepartmentFeeAmountFee";
            txt_DepartmentFeeAmountFee.Size = new Size(206, 23);
            txt_DepartmentFeeAmountFee.TabIndex = 31;
            txt_DepartmentFeeAmountFee.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 159);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 32;
            label6.Text = "Payment Method";
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(172, 151);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(206, 23);
            cbPaymentMethod.TabIndex = 33;
            // 
            // btn_pay
            // 
            btn_pay.Location = new Point(121, 201);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(110, 43);
            btn_pay.TabIndex = 34;
            btn_pay.Text = "Pay ";
            btn_pay.UseVisualStyleBackColor = true;
            btn_pay.Click += btn_pay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 35;
            label1.Text = "Bill Id";
            // 
            // txt_billid
            // 
            txt_billid.Location = new Point(65, 21);
            txt_billid.Name = "txt_billid";
            txt_billid.ReadOnly = true;
            txt_billid.Size = new Size(100, 23);
            txt_billid.TabIndex = 36;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 285);
            Controls.Add(txt_billid);
            Controls.Add(label1);
            Controls.Add(btn_pay);
            Controls.Add(cbPaymentMethod);
            Controls.Add(label6);
            Controls.Add(txt_DepartmentFeeAmountFee);
            Controls.Add(lbAmountPaid);
            Controls.Add(dtppayment);
            Controls.Add(lbBillDateFrom);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)txt_DepartmentFeeAmountFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbBillDateFrom;
        private DateTimePicker dtppayment;
        private Label lbAmountPaid;
        private NumericUpDown txt_DepartmentFeeAmountFee;
        private Label label6;
        private ComboBox cbPaymentMethod;
        private Button btn_pay;
        private Label label1;
        private TextBox txt_billid;
    }
}