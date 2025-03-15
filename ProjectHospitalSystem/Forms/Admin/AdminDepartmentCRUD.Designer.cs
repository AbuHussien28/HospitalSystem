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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            txtBoxDepartmentSerachData = new TextBox();
            lbDepartmentNameSearch = new Label();
            dgv_Department = new DataGridView();
            icon = new DataGridViewImageColumn();
            btn_DepartmentFeeRemove = new Button();
            btn_DepartmentFeeUpdate = new Button();
            btn_DepartmentFeeAdd = new Button();
            lb_DepartmentDeptName = new Label();
            txt_DepartmentDeptName = new TextBox();
            lb_DepartmentDeptDescrp = new Label();
            txt_DepartmentDeptDesc = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            lb_DepartmentFDoctorName = new Label();
            cb_DepartmentFDoctorName = new ComboBox();
            pictureBox10 = new PictureBox();
            pnlReceDetails = new Panel();
            nuValueDeptFee = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Department).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            pnlReceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuValueDeptFee).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconSearch;
            pictureBox1.Location = new Point(21, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 100;
            pictureBox1.TabStop = false;
            // 
            // txtBoxDepartmentSerachData
            // 
            txtBoxDepartmentSerachData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDepartmentSerachData.ForeColor = Color.Gray;
            txtBoxDepartmentSerachData.Location = new Point(218, 14);
            txtBoxDepartmentSerachData.Margin = new Padding(5);
            txtBoxDepartmentSerachData.Name = "txtBoxDepartmentSerachData";
            txtBoxDepartmentSerachData.PlaceholderText = "Search by Name";
            txtBoxDepartmentSerachData.Size = new Size(233, 29);
            txtBoxDepartmentSerachData.TabIndex = 99;
            txtBoxDepartmentSerachData.TextChanged += txtBoxDepartmentSerachData_TextChanged;
            // 
            // lbDepartmentNameSearch
            // 
            lbDepartmentNameSearch.AutoSize = true;
            lbDepartmentNameSearch.BackColor = Color.Transparent;
            lbDepartmentNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbDepartmentNameSearch.Location = new Point(51, 17);
            lbDepartmentNameSearch.Name = "lbDepartmentNameSearch";
            lbDepartmentNameSearch.Size = new Size(150, 21);
            lbDepartmentNameSearch.TabIndex = 98;
            lbDepartmentNameSearch.Text = "Depatment Name:";
            lbDepartmentNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgv_Department
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_Department.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Department.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Department.BackgroundColor = Color.White;
            dgv_Department.BorderStyle = BorderStyle.None;
            dgv_Department.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Department.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Department.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Department.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Department.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Department.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Department.EnableHeadersVisualStyles = false;
            dgv_Department.Location = new Point(16, 68);
            dgv_Department.Name = "dgv_Department";
            dgv_Department.RowHeadersVisible = false;
            dgv_Department.RowTemplate.Height = 40;
            dgv_Department.Size = new Size(390, 218);
            dgv_Department.TabIndex = 102;
            dgv_Department.CellContentClick += dgv_Department_CellContentClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconDeptDgv;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // btn_DepartmentFeeRemove
            // 
            btn_DepartmentFeeRemove.BackColor = Color.Crimson;
            btn_DepartmentFeeRemove.Cursor = Cursors.No;
            btn_DepartmentFeeRemove.FlatAppearance.BorderSize = 0;
            btn_DepartmentFeeRemove.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_DepartmentFeeRemove.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_DepartmentFeeRemove.FlatStyle = FlatStyle.Flat;
            btn_DepartmentFeeRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DepartmentFeeRemove.ForeColor = Color.White;
            btn_DepartmentFeeRemove.Image = Properties.Resources.IconRemovedOCTOR;
            btn_DepartmentFeeRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DepartmentFeeRemove.Location = new Point(919, 213);
            btn_DepartmentFeeRemove.Name = "btn_DepartmentFeeRemove";
            btn_DepartmentFeeRemove.Size = new Size(104, 53);
            btn_DepartmentFeeRemove.TabIndex = 105;
            btn_DepartmentFeeRemove.Text = "Remove";
            btn_DepartmentFeeRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DepartmentFeeRemove.UseVisualStyleBackColor = false;
            btn_DepartmentFeeRemove.Visible = false;
            btn_DepartmentFeeRemove.Click += btn_DepartmentFeeRemove_Click;
            // 
            // btn_DepartmentFeeUpdate
            // 
            btn_DepartmentFeeUpdate.BackColor = Color.DodgerBlue;
            btn_DepartmentFeeUpdate.Cursor = Cursors.Hand;
            btn_DepartmentFeeUpdate.FlatAppearance.BorderSize = 0;
            btn_DepartmentFeeUpdate.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_DepartmentFeeUpdate.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_DepartmentFeeUpdate.FlatStyle = FlatStyle.Flat;
            btn_DepartmentFeeUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DepartmentFeeUpdate.ForeColor = Color.White;
            btn_DepartmentFeeUpdate.Image = Properties.Resources.IconUpdateAdmin;
            btn_DepartmentFeeUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DepartmentFeeUpdate.Location = new Point(919, 144);
            btn_DepartmentFeeUpdate.Name = "btn_DepartmentFeeUpdate";
            btn_DepartmentFeeUpdate.Size = new Size(104, 53);
            btn_DepartmentFeeUpdate.TabIndex = 104;
            btn_DepartmentFeeUpdate.Text = "Update";
            btn_DepartmentFeeUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DepartmentFeeUpdate.UseVisualStyleBackColor = false;
            btn_DepartmentFeeUpdate.Visible = false;
            btn_DepartmentFeeUpdate.Click += btn_DepartmentFeeUpdate_Click;
            // 
            // btn_DepartmentFeeAdd
            // 
            btn_DepartmentFeeAdd.BackColor = Color.LimeGreen;
            btn_DepartmentFeeAdd.Cursor = Cursors.Cross;
            btn_DepartmentFeeAdd.FlatAppearance.BorderSize = 0;
            btn_DepartmentFeeAdd.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_DepartmentFeeAdd.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_DepartmentFeeAdd.FlatStyle = FlatStyle.Flat;
            btn_DepartmentFeeAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_DepartmentFeeAdd.ForeColor = Color.White;
            btn_DepartmentFeeAdd.Image = Properties.Resources.IconAddBtn;
            btn_DepartmentFeeAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DepartmentFeeAdd.Location = new Point(919, 75);
            btn_DepartmentFeeAdd.Name = "btn_DepartmentFeeAdd";
            btn_DepartmentFeeAdd.Size = new Size(104, 53);
            btn_DepartmentFeeAdd.TabIndex = 103;
            btn_DepartmentFeeAdd.Text = "Add ";
            btn_DepartmentFeeAdd.TextAlign = ContentAlignment.MiddleRight;
            btn_DepartmentFeeAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_DepartmentFeeAdd.UseVisualStyleBackColor = false;
            btn_DepartmentFeeAdd.Visible = false;
            btn_DepartmentFeeAdd.Click += btn_DepartmentFeeAdd_Click;
            // 
            // lb_DepartmentDeptName
            // 
            lb_DepartmentDeptName.AutoSize = true;
            lb_DepartmentDeptName.BackColor = Color.Transparent;
            lb_DepartmentDeptName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DepartmentDeptName.Location = new Point(45, 24);
            lb_DepartmentDeptName.Name = "lb_DepartmentDeptName";
            lb_DepartmentDeptName.Size = new Size(97, 21);
            lb_DepartmentDeptName.TabIndex = 133;
            lb_DepartmentDeptName.Text = "DeptName:";
            lb_DepartmentDeptName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_DepartmentDeptName
            // 
            txt_DepartmentDeptName.BackColor = Color.White;
            txt_DepartmentDeptName.BorderStyle = BorderStyle.FixedSingle;
            txt_DepartmentDeptName.Font = new Font("Segoe UI", 12F);
            txt_DepartmentDeptName.ForeColor = Color.Black;
            txt_DepartmentDeptName.Location = new Point(243, 16);
            txt_DepartmentDeptName.Margin = new Padding(5);
            txt_DepartmentDeptName.Name = "txt_DepartmentDeptName";
            txt_DepartmentDeptName.Size = new Size(233, 29);
            txt_DepartmentDeptName.TabIndex = 131;
            // 
            // lb_DepartmentDeptDescrp
            // 
            lb_DepartmentDeptDescrp.AutoSize = true;
            lb_DepartmentDeptDescrp.BackColor = Color.Transparent;
            lb_DepartmentDeptDescrp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DepartmentDeptDescrp.Location = new Point(45, 114);
            lb_DepartmentDeptDescrp.Name = "lb_DepartmentDeptDescrp";
            lb_DepartmentDeptDescrp.Size = new Size(102, 21);
            lb_DepartmentDeptDescrp.TabIndex = 136;
            lb_DepartmentDeptDescrp.Text = "Description:";
            lb_DepartmentDeptDescrp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_DepartmentDeptDesc
            // 
            txt_DepartmentDeptDesc.BackColor = Color.White;
            txt_DepartmentDeptDesc.BorderStyle = BorderStyle.FixedSingle;
            txt_DepartmentDeptDesc.Font = new Font("Segoe UI", 12F);
            txt_DepartmentDeptDesc.ForeColor = Color.Black;
            txt_DepartmentDeptDesc.Location = new Point(243, 112);
            txt_DepartmentDeptDesc.Margin = new Padding(5);
            txt_DepartmentDeptDesc.Name = "txt_DepartmentDeptDesc";
            txt_DepartmentDeptDesc.Size = new Size(233, 29);
            txt_DepartmentDeptDesc.TabIndex = 132;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconDeptName;
            pictureBox2.Location = new Point(15, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 134;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconDeptName1;
            pictureBox4.Location = new Point(15, 114);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 137;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconFeeAmount;
            pictureBox6.Location = new Point(15, 69);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 138;
            pictureBox6.TabStop = false;
            // 
            // lb_DepartmentFDoctorName
            // 
            lb_DepartmentFDoctorName.AutoSize = true;
            lb_DepartmentFDoctorName.BackColor = Color.Transparent;
            lb_DepartmentFDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DepartmentFDoctorName.Location = new Point(45, 151);
            lb_DepartmentFDoctorName.Name = "lb_DepartmentFDoctorName";
            lb_DepartmentFDoctorName.Size = new Size(144, 21);
            lb_DepartmentFDoctorName.TabIndex = 139;
            lb_DepartmentFDoctorName.Text = "Managing Doctor";
            lb_DepartmentFDoctorName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cb_DepartmentFDoctorName
            // 
            cb_DepartmentFDoctorName.BackColor = Color.White;
            cb_DepartmentFDoctorName.Font = new Font("Segoe UI", 12F);
            cb_DepartmentFDoctorName.ForeColor = Color.Black;
            cb_DepartmentFDoctorName.FormattingEnabled = true;
            cb_DepartmentFDoctorName.Location = new Point(243, 151);
            cb_DepartmentFDoctorName.Name = "cb_DepartmentFDoctorName";
            cb_DepartmentFDoctorName.Size = new Size(233, 29);
            cb_DepartmentFDoctorName.TabIndex = 140;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.IconMangerName;
            pictureBox10.Location = new Point(15, 148);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 141;
            pictureBox10.TabStop = false;
            // 
            // pnlReceDetails
            // 
            pnlReceDetails.BackColor = Color.WhiteSmoke;
            pnlReceDetails.Controls.Add(nuValueDeptFee);
            pnlReceDetails.Controls.Add(label1);
            pnlReceDetails.Controls.Add(lb_DepartmentDeptName);
            pnlReceDetails.Controls.Add(pictureBox10);
            pnlReceDetails.Controls.Add(cb_DepartmentFDoctorName);
            pnlReceDetails.Controls.Add(lb_DepartmentFDoctorName);
            pnlReceDetails.Controls.Add(txt_DepartmentDeptName);
            pnlReceDetails.Controls.Add(pictureBox2);
            pnlReceDetails.Controls.Add(txt_DepartmentDeptDesc);
            pnlReceDetails.Controls.Add(pictureBox6);
            pnlReceDetails.Controls.Add(lb_DepartmentDeptDescrp);
            pnlReceDetails.Controls.Add(pictureBox4);
            pnlReceDetails.Location = new Point(419, 75);
            pnlReceDetails.Name = "pnlReceDetails";
            pnlReceDetails.Size = new Size(494, 198);
            pnlReceDetails.TabIndex = 143;
            // 
            // nuValueDeptFee
            // 
            nuValueDeptFee.DecimalPlaces = 2;
            nuValueDeptFee.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nuValueDeptFee.Location = new Point(243, 69);
            nuValueDeptFee.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nuValueDeptFee.Name = "nuValueDeptFee";
            nuValueDeptFee.Size = new Size(233, 23);
            nuValueDeptFee.TabIndex = 146;
            nuValueDeptFee.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(45, 69);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 145;
            label1.Text = "Fee Amount (EGP):";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AdminDepartmentCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1053, 389);
            Controls.Add(pnlReceDetails);
            Controls.Add(btn_DepartmentFeeRemove);
            Controls.Add(btn_DepartmentFeeUpdate);
            Controls.Add(btn_DepartmentFeeAdd);
            Controls.Add(dgv_Department);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxDepartmentSerachData);
            Controls.Add(lbDepartmentNameSearch);
            Name = "AdminDepartmentCRUD";
            Text = "AdminDepartmentCRUD";
            Load += AdminDepartmentCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Department).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            pnlReceDetails.ResumeLayout(false);
            pnlReceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuValueDeptFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_DepartmentFeeRemove;
        private PictureBox pictureBox1;
        private TextBox txtBoxDepartmentSerachData;
        private Label lbDepartmentNameSearch;
        private DataGridView dgv_Department;
        private Button btn_remove;
        private Button btn_DepartmentFeeUpdate;
        private Button btn_DepartmentFeeAdd;
        private DataGridViewImageColumn icon;
        private Label lb_DepartmentDeptName;
        private TextBox txt_DepartmentDeptName;
        private Label lb_DepartmentDeptDescrp;
        private TextBox txt_DepartmentDeptDesc;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private Label lb_DepartmentFDoctorName;
        private ComboBox cb_DepartmentFDoctorName;
        private PictureBox pictureBox10;
        private Panel pnlReceDetails;
        private Label label1;
        private NumericUpDown nuValueDeptFee;
    }
}