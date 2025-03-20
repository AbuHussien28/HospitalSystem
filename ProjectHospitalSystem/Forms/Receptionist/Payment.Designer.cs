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
            label1 = new Label();
            txt_billid = new TextBox();
            pnlReceDetails = new Panel();
            txt_DepartmentFeeAmountFee = new NumericUpDown();
            label2 = new Label();
            cbPaymentMethod = new ComboBox();
            pictureBox6 = new PictureBox();
            lb_DepartmentDeptDescrp = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_pay = new Button();
            pnlReceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txt_DepartmentFeeAmountFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbBillDateFrom
            // 
            lbBillDateFrom.AutoSize = true;
            lbBillDateFrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbBillDateFrom.Location = new Point(333, 94);
            lbBillDateFrom.Name = "lbBillDateFrom";
            lbBillDateFrom.Size = new Size(103, 19);
            lbBillDateFrom.TabIndex = 22;
            lbBillDateFrom.Text = "Payment Date";
            // 
            // dtppayment
            // 
            dtppayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtppayment.Location = new Point(442, 87);
            dtppayment.Name = "dtppayment";
            dtppayment.Size = new Size(272, 29);
            dtppayment.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(51, 93);
            label1.Name = "label1";
            label1.Size = new Size(51, 19);
            label1.TabIndex = 35;
            label1.Text = "Bill Id:";
            // 
            // txt_billid
            // 
            txt_billid.BackColor = Color.FromArgb(254, 251, 244);
            txt_billid.BorderStyle = BorderStyle.None;
            txt_billid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_billid.Location = new Point(108, 93);
            txt_billid.Name = "txt_billid";
            txt_billid.ReadOnly = true;
            txt_billid.Size = new Size(100, 22);
            txt_billid.TabIndex = 36;
            // 
            // pnlReceDetails
            // 
            pnlReceDetails.BackColor = Color.WhiteSmoke;
            pnlReceDetails.Controls.Add(txt_DepartmentFeeAmountFee);
            pnlReceDetails.Controls.Add(label2);
            pnlReceDetails.Controls.Add(cbPaymentMethod);
            pnlReceDetails.Controls.Add(pictureBox6);
            pnlReceDetails.Controls.Add(lb_DepartmentDeptDescrp);
            pnlReceDetails.Controls.Add(pictureBox4);
            pnlReceDetails.Location = new Point(87, 178);
            pnlReceDetails.Name = "pnlReceDetails";
            pnlReceDetails.Size = new Size(494, 134);
            pnlReceDetails.TabIndex = 144;
            // 
            // txt_DepartmentFeeAmountFee
            // 
            txt_DepartmentFeeAmountFee.DecimalPlaces = 2;
            txt_DepartmentFeeAmountFee.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            txt_DepartmentFeeAmountFee.Location = new Point(243, 22);
            txt_DepartmentFeeAmountFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txt_DepartmentFeeAmountFee.Name = "txt_DepartmentFeeAmountFee";
            txt_DepartmentFeeAmountFee.Size = new Size(233, 23);
            txt_DepartmentFeeAmountFee.TabIndex = 146;
            txt_DepartmentFeeAmountFee.ThousandsSeparator = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(45, 22);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 145;
            label2.Text = "Amount Paid (EGP):";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbPaymentMethod
            // 
            cbPaymentMethod.BackColor = Color.White;
            cbPaymentMethod.Font = new Font("Segoe UI", 12F);
            cbPaymentMethod.ForeColor = Color.Black;
            cbPaymentMethod.FormattingEnabled = true;
            cbPaymentMethod.Location = new Point(243, 64);
            cbPaymentMethod.Name = "cbPaymentMethod";
            cbPaymentMethod.Size = new Size(233, 29);
            cbPaymentMethod.TabIndex = 140;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconFeeAmount;
            pictureBox6.Location = new Point(15, 22);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 138;
            pictureBox6.TabStop = false;
            // 
            // lb_DepartmentDeptDescrp
            // 
            lb_DepartmentDeptDescrp.AutoSize = true;
            lb_DepartmentDeptDescrp.BackColor = Color.Transparent;
            lb_DepartmentDeptDescrp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DepartmentDeptDescrp.Location = new Point(45, 67);
            lb_DepartmentDeptDescrp.Name = "lb_DepartmentDeptDescrp";
            lb_DepartmentDeptDescrp.Size = new Size(146, 21);
            lb_DepartmentDeptDescrp.TabIndex = 136;
            lb_DepartmentDeptDescrp.Text = "Payment Method:";
            lb_DepartmentDeptDescrp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconPaymentMethod;
            pictureBox4.Location = new Point(15, 67);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 137;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 29);
            label3.Name = "label3";
            label3.Size = new Size(169, 30);
            label3.TabIndex = 145;
            label3.Text = "Payment Screen";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconPaymentDate;
            pictureBox1.Location = new Point(303, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 147;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconBillId;
            pictureBox2.Location = new Point(21, 92);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 148;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconPaymentScreen;
            pictureBox3.Location = new Point(237, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 149;
            pictureBox3.TabStop = false;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.LimeGreen;
            btn_pay.Cursor = Cursors.Cross;
            btn_pay.FlatAppearance.BorderSize = 0;
            btn_pay.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_pay.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_pay.FlatStyle = FlatStyle.Flat;
            btn_pay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pay.ForeColor = Color.White;
            btn_pay.Image = Properties.Resources.IconPay1;
            btn_pay.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pay.Location = new Point(267, 353);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(110, 53);
            btn_pay.TabIndex = 150;
            btn_pay.Text = "pay";
            btn_pay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Visible = false;
            btn_pay.Click += btn_pay_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(731, 427);
            Controls.Add(btn_pay);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(pnlReceDetails);
            Controls.Add(txt_billid);
            Controls.Add(label1);
            Controls.Add(dtppayment);
            Controls.Add(lbBillDateFrom);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            pnlReceDetails.ResumeLayout(false);
            pnlReceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txt_DepartmentFeeAmountFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbBillDateFrom;
        private DateTimePicker dtppayment;
        private Label label1;
        private TextBox txt_billid;
        private Panel pnlReceDetails;
        private NumericUpDown txt_DepartmentFeeAmountFee;
        private Label label2;
        private ComboBox cbPaymentMethod;
        private PictureBox pictureBox6;
        private Label lb_DepartmentDeptDescrp;
        private PictureBox pictureBox4;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_pay;
    }
}