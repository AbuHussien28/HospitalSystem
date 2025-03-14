namespace ProjectHospitalSystem.Forms.Admin
{
    partial class AdminDepartmentCRUD
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
            lb_DepartmentFDoctorName = new Label();
            cb_DepartmentFDoctorName = new ComboBox();
            txt_DepartmentDeptDesc = new TextBox();
            lb_DepartmentDeptDescrp = new Label();
            txt_DepartmentDeptName = new TextBox();
            btn_DepartmentFeeRemove = new Button();
            btn_DepartmentFeeUpdate = new Button();
            btn_DepartmentFeeAdd = new Button();
            lb_DepartmentFeeAmountFee = new Label();
            txt_DepartmentFeeAmountFee = new NumericUpDown();
            lb_DepartmentDeptName = new Label();
            dgv_Department = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txt_DepartmentFeeAmountFee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Department).BeginInit();
            SuspendLayout();
            // 
            // lb_DepartmentFDoctorName
            // 
            lb_DepartmentFDoctorName.AutoSize = true;
            lb_DepartmentFDoctorName.Location = new Point(12, 205);
            lb_DepartmentFDoctorName.Name = "lb_DepartmentFDoctorName";
            lb_DepartmentFDoctorName.Size = new Size(100, 15);
            lb_DepartmentFDoctorName.TabIndex = 80;
            lb_DepartmentFDoctorName.Text = "Managing Doctor";
            // 
            // cb_DepartmentFDoctorName
            // 
            cb_DepartmentFDoctorName.FormatString = "choose Doctor Manger";
            cb_DepartmentFDoctorName.FormattingEnabled = true;
            cb_DepartmentFDoctorName.Location = new Point(148, 197);
            cb_DepartmentFDoctorName.Name = "cb_DepartmentFDoctorName";
            cb_DepartmentFDoctorName.Size = new Size(225, 23);
            cb_DepartmentFDoctorName.TabIndex = 72;
            // 
            // txt_DepartmentDeptDesc
            // 
            txt_DepartmentDeptDesc.Location = new Point(149, 129);
            txt_DepartmentDeptDesc.MaxLength = 70;
            txt_DepartmentDeptDesc.Name = "txt_DepartmentDeptDesc";
            txt_DepartmentDeptDesc.Size = new Size(224, 23);
            txt_DepartmentDeptDesc.TabIndex = 70;
            // 
            // lb_DepartmentDeptDescrp
            // 
            lb_DepartmentDeptDescrp.AutoSize = true;
            lb_DepartmentDeptDescrp.Location = new Point(15, 132);
            lb_DepartmentDeptDescrp.Name = "lb_DepartmentDeptDescrp";
            lb_DepartmentDeptDescrp.Size = new Size(67, 15);
            lb_DepartmentDeptDescrp.TabIndex = 79;
            lb_DepartmentDeptDescrp.Text = "Description";
            // 
            // txt_DepartmentDeptName
            // 
            txt_DepartmentDeptName.Location = new Point(148, 100);
            txt_DepartmentDeptName.MaxLength = 50;
            txt_DepartmentDeptName.Name = "txt_DepartmentDeptName";
            txt_DepartmentDeptName.Size = new Size(224, 23);
            txt_DepartmentDeptName.TabIndex = 69;
            // 
            // btn_DepartmentFeeRemove
            // 
            btn_DepartmentFeeRemove.Location = new Point(218, 281);
            btn_DepartmentFeeRemove.Name = "btn_DepartmentFeeRemove";
            btn_DepartmentFeeRemove.Size = new Size(89, 36);
            btn_DepartmentFeeRemove.TabIndex = 78;
            btn_DepartmentFeeRemove.Text = "Remove";
            btn_DepartmentFeeRemove.UseVisualStyleBackColor = true;
            btn_DepartmentFeeRemove.Visible = false;
            btn_DepartmentFeeRemove.Click += btn_DepartmentFeeRemove_Click;
            // 
            // btn_DepartmentFeeUpdate
            // 
            btn_DepartmentFeeUpdate.Location = new Point(269, 239);
            btn_DepartmentFeeUpdate.Name = "btn_DepartmentFeeUpdate";
            btn_DepartmentFeeUpdate.Size = new Size(89, 36);
            btn_DepartmentFeeUpdate.TabIndex = 77;
            btn_DepartmentFeeUpdate.Text = "Update";
            btn_DepartmentFeeUpdate.UseVisualStyleBackColor = true;
            btn_DepartmentFeeUpdate.Visible = false;
            btn_DepartmentFeeUpdate.Click += btn_DepartmentFeeUpdate_Click;
            // 
            // btn_DepartmentFeeAdd
            // 
            btn_DepartmentFeeAdd.Location = new Point(149, 239);
            btn_DepartmentFeeAdd.Name = "btn_DepartmentFeeAdd";
            btn_DepartmentFeeAdd.Size = new Size(89, 36);
            btn_DepartmentFeeAdd.TabIndex = 76;
            btn_DepartmentFeeAdd.Text = "Add";
            btn_DepartmentFeeAdd.UseVisualStyleBackColor = true;
            btn_DepartmentFeeAdd.Visible = false;
            btn_DepartmentFeeAdd.Click += btn_DepartmentFeeAdd_Click;
            // 
            // lb_DepartmentFeeAmountFee
            // 
            lb_DepartmentFeeAmountFee.AutoSize = true;
            lb_DepartmentFeeAmountFee.Location = new Point(12, 170);
            lb_DepartmentFeeAmountFee.Name = "lb_DepartmentFeeAmountFee";
            lb_DepartmentFeeAmountFee.Size = new Size(107, 15);
            lb_DepartmentFeeAmountFee.TabIndex = 75;
            lb_DepartmentFeeAmountFee.Text = "Fee Amount (EGP):";
            // 
            // txt_DepartmentFeeAmountFee
            // 
            txt_DepartmentFeeAmountFee.DecimalPlaces = 2;
            txt_DepartmentFeeAmountFee.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            txt_DepartmentFeeAmountFee.Location = new Point(149, 168);
            txt_DepartmentFeeAmountFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txt_DepartmentFeeAmountFee.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            txt_DepartmentFeeAmountFee.Name = "txt_DepartmentFeeAmountFee";
            txt_DepartmentFeeAmountFee.Size = new Size(224, 23);
            txt_DepartmentFeeAmountFee.TabIndex = 71;
            txt_DepartmentFeeAmountFee.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // lb_DepartmentDeptName
            // 
            lb_DepartmentDeptName.AutoSize = true;
            lb_DepartmentDeptName.Location = new Point(15, 108);
            lb_DepartmentDeptName.Name = "lb_DepartmentDeptName";
            lb_DepartmentDeptName.Size = new Size(64, 15);
            lb_DepartmentDeptName.TabIndex = 74;
            lb_DepartmentDeptName.Text = "DeptName";
            // 
            // dgv_Department
            // 
            dgv_Department.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Department.Location = new Point(390, 103);
            dgv_Department.Name = "dgv_Department";
            dgv_Department.Size = new Size(398, 211);
            dgv_Department.TabIndex = 73;
            dgv_Department.RowHeaderMouseDoubleClick += dgv_Department_RowHeaderMouseDoubleClick;
            // 
            // AdminDepartmentCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_DepartmentFDoctorName);
            Controls.Add(cb_DepartmentFDoctorName);
            Controls.Add(txt_DepartmentDeptDesc);
            Controls.Add(lb_DepartmentDeptDescrp);
            Controls.Add(txt_DepartmentDeptName);
            Controls.Add(btn_DepartmentFeeRemove);
            Controls.Add(btn_DepartmentFeeUpdate);
            Controls.Add(btn_DepartmentFeeAdd);
            Controls.Add(lb_DepartmentFeeAmountFee);
            Controls.Add(txt_DepartmentFeeAmountFee);
            Controls.Add(lb_DepartmentDeptName);
            Controls.Add(dgv_Department);
            Name = "AdminDepartmentCRUD";
            Text = "AdminDepartmentCRUD";
            Load += AdminDepartmentCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)txt_DepartmentFeeAmountFee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Department).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_DepartmentFDoctorName;
        private ComboBox cb_DepartmentFDoctorName;
        private TextBox txt_DepartmentDeptDesc;
        private Label lb_DepartmentDeptDescrp;
        private TextBox txt_DepartmentDeptName;
        private Button btn_DepartmentFeeRemove;
        private Button btn_DepartmentFeeUpdate;
        private Button btn_DepartmentFeeAdd;
        private Label lb_DepartmentFeeAmountFee;
        private NumericUpDown txt_DepartmentFeeAmountFee;
        private Label lb_DepartmentDeptName;
        private DataGridView dgv_Department;
    }
}