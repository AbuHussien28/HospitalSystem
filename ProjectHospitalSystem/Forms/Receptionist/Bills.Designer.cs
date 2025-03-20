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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgv_Bills = new DataGridView();
            icon = new DataGridViewImageColumn();
            pnlDoctorDetails = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            txt_doc = new TextBox();
            label1 = new Label();
            txt_total = new TextBox();
            label3 = new Label();
            txt_Due = new TextBox();
            label5 = new Label();
            pictureBox10 = new PictureBox();
            pBoxRemainingBalance = new PictureBox();
            pictureBox8 = new PictureBox();
            pBoxTotalPaid = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            txt_dept = new TextBox();
            lb_Phone = new Label();
            txt_LateFee = new TextBox();
            lb_Specialization = new Label();
            txt_status = new TextBox();
            lb_LastNameDoctor = new Label();
            txt_OAmount = new TextBox();
            lb_DoctorEmail = new Label();
            txt_remain = new TextBox();
            lab_Remain = new Label();
            txt_tolPaid = new TextBox();
            lab_tolPaid = new Label();
            txt_GenDate = new TextBox();
            lb_Fname = new Label();
            txt_pat = new TextBox();
            lb_patientName = new Label();
            cob_searDept = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            cob_patient = new ComboBox();
            pictureBox11 = new PictureBox();
            pictureBox9 = new PictureBox();
            btn_pay = new Button();
            btnExportToWord = new Button();
            pictureBox12 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Bills).BeginInit();
            pnlDoctorDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxRemainingBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxTotalPaid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            SuspendLayout();
            // 
            // dgv_Bills
            // 
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonFace;
            dgv_Bills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgv_Bills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Bills.BackgroundColor = Color.White;
            dgv_Bills.BorderStyle = BorderStyle.None;
            dgv_Bills.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Bills.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_Bills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_Bills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Bills.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgv_Bills.DefaultCellStyle = dataGridViewCellStyle9;
            dgv_Bills.EnableHeadersVisualStyles = false;
            dgv_Bills.Location = new Point(12, 146);
            dgv_Bills.MultiSelect = false;
            dgv_Bills.Name = "dgv_Bills";
            dgv_Bills.RowHeadersVisible = false;
            dgv_Bills.RowTemplate.Height = 40;
            dgv_Bills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Bills.Size = new Size(1307, 307);
            dgv_Bills.TabIndex = 118;
            dgv_Bills.CellContentDoubleClick += dgv_Bills_CellDoubleClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconBill;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // pnlDoctorDetails
            // 
            pnlDoctorDetails.BackColor = Color.WhiteSmoke;
            pnlDoctorDetails.Controls.Add(pictureBox4);
            pnlDoctorDetails.Controls.Add(pictureBox1);
            pnlDoctorDetails.Controls.Add(pictureBox5);
            pnlDoctorDetails.Controls.Add(pictureBox7);
            pnlDoctorDetails.Controls.Add(txt_doc);
            pnlDoctorDetails.Controls.Add(label1);
            pnlDoctorDetails.Controls.Add(txt_total);
            pnlDoctorDetails.Controls.Add(label3);
            pnlDoctorDetails.Controls.Add(txt_Due);
            pnlDoctorDetails.Controls.Add(label5);
            pnlDoctorDetails.Controls.Add(pictureBox10);
            pnlDoctorDetails.Controls.Add(pBoxRemainingBalance);
            pnlDoctorDetails.Controls.Add(pictureBox8);
            pnlDoctorDetails.Controls.Add(pBoxTotalPaid);
            pnlDoctorDetails.Controls.Add(pictureBox6);
            pnlDoctorDetails.Controls.Add(pictureBox3);
            pnlDoctorDetails.Controls.Add(pictureBox2);
            pnlDoctorDetails.Controls.Add(txt_dept);
            pnlDoctorDetails.Controls.Add(lb_Phone);
            pnlDoctorDetails.Controls.Add(txt_LateFee);
            pnlDoctorDetails.Controls.Add(lb_Specialization);
            pnlDoctorDetails.Controls.Add(txt_status);
            pnlDoctorDetails.Controls.Add(lb_LastNameDoctor);
            pnlDoctorDetails.Controls.Add(txt_OAmount);
            pnlDoctorDetails.Controls.Add(lb_DoctorEmail);
            pnlDoctorDetails.Controls.Add(txt_remain);
            pnlDoctorDetails.Controls.Add(lab_Remain);
            pnlDoctorDetails.Controls.Add(txt_tolPaid);
            pnlDoctorDetails.Controls.Add(lab_tolPaid);
            pnlDoctorDetails.Controls.Add(txt_GenDate);
            pnlDoctorDetails.Controls.Add(lb_Fname);
            pnlDoctorDetails.Controls.Add(txt_pat);
            pnlDoctorDetails.Controls.Add(lb_patientName);
            pnlDoctorDetails.Location = new Point(12, 474);
            pnlDoctorDetails.Name = "pnlDoctorDetails";
            pnlDoctorDetails.Size = new Size(1320, 203);
            pnlDoctorDetails.TabIndex = 119;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconRecStatus;
            pictureBox4.Location = new Point(11, 71);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 124;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconDoctorData;
            pictureBox1.Location = new Point(873, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 123;
            pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.IconPaymentMethodAdd;
            pictureBox5.Location = new Point(873, 110);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 122;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.IconDueDate;
            pictureBox7.Location = new Point(873, 29);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(24, 24);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 121;
            pictureBox7.TabStop = false;
            // 
            // txt_doc
            // 
            txt_doc.BackColor = Color.WhiteSmoke;
            txt_doc.BorderStyle = BorderStyle.None;
            txt_doc.Font = new Font("Segoe UI", 12.75F);
            txt_doc.ForeColor = Color.Black;
            txt_doc.Location = new Point(1026, 66);
            txt_doc.Margin = new Padding(5);
            txt_doc.Name = "txt_doc";
            txt_doc.ReadOnly = true;
            txt_doc.Size = new Size(289, 23);
            txt_doc.TabIndex = 117;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(903, 70);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 120;
            label1.Text = "Doctor Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_total
            // 
            txt_total.BackColor = Color.WhiteSmoke;
            txt_total.BorderStyle = BorderStyle.None;
            txt_total.Font = new Font("Segoe UI", 12.75F);
            txt_total.ForeColor = Color.Black;
            txt_total.Location = new Point(1026, 108);
            txt_total.Margin = new Padding(5);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(276, 23);
            txt_total.TabIndex = 118;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(903, 110);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 119;
            label3.Text = "Total Amount:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Due
            // 
            txt_Due.BackColor = Color.WhiteSmoke;
            txt_Due.BorderStyle = BorderStyle.None;
            txt_Due.Font = new Font("Segoe UI", 12.75F);
            txt_Due.ForeColor = Color.Black;
            txt_Due.Location = new Point(1026, 27);
            txt_Due.Margin = new Padding(5);
            txt_Due.Name = "txt_Due";
            txt_Due.ReadOnly = true;
            txt_Due.Size = new Size(255, 23);
            txt_Due.TabIndex = 116;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(903, 29);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 115;
            label5.Text = "Due Date:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.IconDepartment;
            pictureBox10.Location = new Point(429, 74);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 24);
            pictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox10.TabIndex = 114;
            pictureBox10.TabStop = false;
            // 
            // pBoxRemainingBalance
            // 
            pBoxRemainingBalance.Image = Properties.Resources.IconRemaningBlance;
            pBoxRemainingBalance.Location = new Point(429, 147);
            pBoxRemainingBalance.Name = "pBoxRemainingBalance";
            pBoxRemainingBalance.Size = new Size(24, 24);
            pBoxRemainingBalance.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxRemainingBalance.TabIndex = 113;
            pBoxRemainingBalance.TabStop = false;
            pBoxRemainingBalance.Visible = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.IconLateFee;
            pictureBox8.Location = new Point(429, 110);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 112;
            pictureBox8.TabStop = false;
            // 
            // pBoxTotalPaid
            // 
            pBoxTotalPaid.Image = Properties.Resources.IconTotalAmount;
            pBoxTotalPaid.Location = new Point(11, 147);
            pBoxTotalPaid.Name = "pBoxTotalPaid";
            pBoxTotalPaid.Size = new Size(24, 24);
            pBoxTotalPaid.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxTotalPaid.TabIndex = 110;
            pBoxTotalPaid.TabStop = false;
            pBoxTotalPaid.Visible = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IconOrignalAmount;
            pictureBox6.Location = new Point(11, 110);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(24, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 109;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconReceptiGerentedDate;
            pictureBox3.Location = new Point(429, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 107;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconPaientent;
            pictureBox2.Location = new Point(11, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 93;
            pictureBox2.TabStop = false;
            // 
            // txt_dept
            // 
            txt_dept.BackColor = Color.WhiteSmoke;
            txt_dept.BorderStyle = BorderStyle.None;
            txt_dept.Font = new Font("Segoe UI", 12.75F);
            txt_dept.ForeColor = Color.Black;
            txt_dept.Location = new Point(627, 68);
            txt_dept.Margin = new Padding(5);
            txt_dept.Name = "txt_dept";
            txt_dept.ReadOnly = true;
            txt_dept.Size = new Size(233, 23);
            txt_dept.TabIndex = 95;
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.BackColor = Color.Transparent;
            lb_Phone.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Phone.Location = new Point(459, 74);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(156, 21);
            lb_Phone.TabIndex = 106;
            lb_Phone.Text = "Department Name:";
            lb_Phone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_LateFee
            // 
            txt_LateFee.BackColor = Color.WhiteSmoke;
            txt_LateFee.BorderStyle = BorderStyle.None;
            txt_LateFee.Font = new Font("Segoe UI", 12.75F);
            txt_LateFee.ForeColor = Color.Black;
            txt_LateFee.Location = new Point(627, 111);
            txt_LateFee.Margin = new Padding(5);
            txt_LateFee.Name = "txt_LateFee";
            txt_LateFee.ReadOnly = true;
            txt_LateFee.Size = new Size(233, 23);
            txt_LateFee.TabIndex = 98;
            // 
            // lb_Specialization
            // 
            lb_Specialization.AutoSize = true;
            lb_Specialization.BackColor = Color.Transparent;
            lb_Specialization.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Specialization.Location = new Point(459, 113);
            lb_Specialization.Name = "lb_Specialization";
            lb_Specialization.Size = new Size(76, 21);
            lb_Specialization.TabIndex = 105;
            lb_Specialization.Text = "Late Fee:";
            lb_Specialization.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_status
            // 
            txt_status.BackColor = Color.WhiteSmoke;
            txt_status.BorderStyle = BorderStyle.None;
            txt_status.Font = new Font("Segoe UI", 12.75F);
            txt_status.ForeColor = Color.Black;
            txt_status.Location = new Point(184, 71);
            txt_status.Margin = new Padding(5);
            txt_status.Name = "txt_status";
            txt_status.ReadOnly = true;
            txt_status.Size = new Size(233, 23);
            txt_status.TabIndex = 93;
            // 
            // lb_LastNameDoctor
            // 
            lb_LastNameDoctor.AutoSize = true;
            lb_LastNameDoctor.BackColor = Color.Transparent;
            lb_LastNameDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_LastNameDoctor.Location = new Point(41, 68);
            lb_LastNameDoctor.Name = "lb_LastNameDoctor";
            lb_LastNameDoctor.Size = new Size(61, 21);
            lb_LastNameDoctor.TabIndex = 104;
            lb_LastNameDoctor.Text = "Status:";
            lb_LastNameDoctor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_OAmount
            // 
            txt_OAmount.BackColor = Color.WhiteSmoke;
            txt_OAmount.BorderStyle = BorderStyle.None;
            txt_OAmount.Font = new Font("Segoe UI", 12.75F);
            txt_OAmount.ForeColor = Color.Black;
            txt_OAmount.Location = new Point(184, 106);
            txt_OAmount.Margin = new Padding(5);
            txt_OAmount.Name = "txt_OAmount";
            txt_OAmount.ReadOnly = true;
            txt_OAmount.Size = new Size(233, 23);
            txt_OAmount.TabIndex = 96;
            // 
            // lb_DoctorEmail
            // 
            lb_DoctorEmail.AutoSize = true;
            lb_DoctorEmail.BackColor = Color.Transparent;
            lb_DoctorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DoctorEmail.Location = new Point(41, 108);
            lb_DoctorEmail.Name = "lb_DoctorEmail";
            lb_DoctorEmail.Size = new Size(142, 21);
            lb_DoctorEmail.TabIndex = 103;
            lb_DoctorEmail.Text = "Original Amount:";
            lb_DoctorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_remain
            // 
            txt_remain.BackColor = Color.WhiteSmoke;
            txt_remain.BorderStyle = BorderStyle.None;
            txt_remain.Font = new Font("Segoe UI", 12.75F);
            txt_remain.ForeColor = Color.Black;
            txt_remain.Location = new Point(627, 147);
            txt_remain.Margin = new Padding(5);
            txt_remain.Name = "txt_remain";
            txt_remain.ReadOnly = true;
            txt_remain.Size = new Size(233, 23);
            txt_remain.TabIndex = 101;
            // 
            // lab_Remain
            // 
            lab_Remain.AutoSize = true;
            lab_Remain.BackColor = Color.Transparent;
            lab_Remain.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lab_Remain.Location = new Point(462, 150);
            lab_Remain.Name = "lab_Remain";
            lab_Remain.Size = new Size(161, 21);
            lab_Remain.TabIndex = 97;
            lab_Remain.Text = "Remaining Balance:";
            lab_Remain.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_tolPaid
            // 
            txt_tolPaid.BackColor = Color.WhiteSmoke;
            txt_tolPaid.BorderStyle = BorderStyle.None;
            txt_tolPaid.Font = new Font("Segoe UI", 12.75F);
            txt_tolPaid.ForeColor = Color.Black;
            txt_tolPaid.Location = new Point(184, 145);
            txt_tolPaid.Margin = new Padding(5);
            txt_tolPaid.Name = "txt_tolPaid";
            txt_tolPaid.ReadOnly = true;
            txt_tolPaid.Size = new Size(233, 23);
            txt_tolPaid.TabIndex = 99;
            // 
            // lab_tolPaid
            // 
            lab_tolPaid.AutoSize = true;
            lab_tolPaid.BackColor = Color.Transparent;
            lab_tolPaid.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lab_tolPaid.Location = new Point(41, 150);
            lab_tolPaid.Name = "lab_tolPaid";
            lab_tolPaid.Size = new Size(90, 21);
            lab_tolPaid.TabIndex = 94;
            lab_tolPaid.Text = "Total Paid:";
            lab_tolPaid.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_GenDate
            // 
            txt_GenDate.BackColor = Color.WhiteSmoke;
            txt_GenDate.BorderStyle = BorderStyle.None;
            txt_GenDate.Font = new Font("Segoe UI", 12.75F);
            txt_GenDate.ForeColor = Color.Black;
            txt_GenDate.Location = new Point(627, 30);
            txt_GenDate.Margin = new Padding(5);
            txt_GenDate.Name = "txt_GenDate";
            txt_GenDate.ReadOnly = true;
            txt_GenDate.Size = new Size(233, 23);
            txt_GenDate.TabIndex = 92;
            // 
            // lb_Fname
            // 
            lb_Fname.AutoSize = true;
            lb_Fname.BackColor = Color.Transparent;
            lb_Fname.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Fname.Location = new Point(459, 32);
            lb_Fname.Name = "lb_Fname";
            lb_Fname.Size = new Size(124, 21);
            lb_Fname.TabIndex = 91;
            lb_Fname.Text = "Generted Date:";
            lb_Fname.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_pat
            // 
            txt_pat.BackColor = Color.WhiteSmoke;
            txt_pat.BorderStyle = BorderStyle.None;
            txt_pat.Font = new Font("Segoe UI", 12.75F);
            txt_pat.ForeColor = Color.Black;
            txt_pat.Location = new Point(184, 27);
            txt_pat.Margin = new Padding(5);
            txt_pat.Name = "txt_pat";
            txt_pat.ReadOnly = true;
            txt_pat.Size = new Size(233, 23);
            txt_pat.TabIndex = 90;
            // 
            // lb_patientName
            // 
            lb_patientName.AutoSize = true;
            lb_patientName.BackColor = Color.Transparent;
            lb_patientName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_patientName.Location = new Point(41, 32);
            lb_patientName.Name = "lb_patientName";
            lb_patientName.Size = new Size(119, 21);
            lb_patientName.TabIndex = 89;
            lb_patientName.Text = "Patient Name:";
            lb_patientName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cob_searDept
            // 
            cob_searDept.BackColor = Color.White;
            cob_searDept.Font = new Font("Segoe UI", 12F);
            cob_searDept.ForeColor = Color.Black;
            cob_searDept.FormattingEnabled = true;
            cob_searDept.Location = new Point(243, 93);
            cob_searDept.Name = "cob_searDept";
            cob_searDept.Size = new Size(233, 29);
            cob_searDept.TabIndex = 102;
            cob_searDept.SelectedIndexChanged += cob_searDept_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(53, 98);
            label2.Name = "label2";
            label2.Size = new Size(184, 21);
            label2.TabIndex = 124;
            label2.Text = "Search By Department:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(530, 98);
            label6.Name = "label6";
            label6.Size = new Size(197, 21);
            label6.TabIndex = 125;
            label6.Text = "Search By Patient Name:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cob_patient
            // 
            cob_patient.BackColor = Color.White;
            cob_patient.Font = new Font("Segoe UI", 12F);
            cob_patient.ForeColor = Color.Black;
            cob_patient.FormattingEnabled = true;
            cob_patient.Location = new Point(733, 93);
            cob_patient.Name = "cob_patient";
            cob_patient.Size = new Size(233, 29);
            cob_patient.TabIndex = 126;
            cob_patient.SelectedIndexChanged += cob_patient_SelectedIndexChanged_1;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.IconPatientSerach;
            pictureBox11.Location = new Point(500, 98);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(24, 24);
            pictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox11.TabIndex = 128;
            pictureBox11.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.IconSearch;
            pictureBox9.Location = new Point(23, 98);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(24, 24);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 129;
            pictureBox9.TabStop = false;
            // 
            // btn_pay
            // 
            btn_pay.BackColor = Color.LightBlue;
            btn_pay.Cursor = Cursors.Hand;
            btn_pay.FlatStyle = FlatStyle.Flat;
            btn_pay.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn_pay.ForeColor = Color.Black;
            btn_pay.Image = Properties.Resources.IconPay;
            btn_pay.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pay.Location = new Point(983, 81);
            btn_pay.Name = "btn_pay";
            btn_pay.Size = new Size(156, 56);
            btn_pay.TabIndex = 130;
            btn_pay.Text = "Pay a Bill";
            btn_pay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_pay.UseVisualStyleBackColor = false;
            btn_pay.Click += button1_Click;
            // 
            // btnExportToWord
            // 
            btnExportToWord.BackColor = Color.FromArgb(254, 251, 244);
            btnExportToWord.Cursor = Cursors.Hand;
            btnExportToWord.Enabled = false;
            btnExportToWord.FlatAppearance.BorderSize = 0;
            btnExportToWord.FlatStyle = FlatStyle.Flat;
            btnExportToWord.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnExportToWord.ForeColor = Color.Black;
            btnExportToWord.Image = Properties.Resources.IconExportWord;
            btnExportToWord.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportToWord.Location = new Point(1163, 79);
            btnExportToWord.Name = "btnExportToWord";
            btnExportToWord.Size = new Size(156, 56);
            btnExportToWord.TabIndex = 131;
            btnExportToWord.Text = "Save Bill Word";
            btnExportToWord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExportToWord.UseVisualStyleBackColor = false;
            btnExportToWord.Click += btnExportToWord_Click;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.IconBillMange;
            pictureBox12.Location = new Point(462, 33);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(24, 24);
            pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox12.TabIndex = 149;
            pictureBox12.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(486, 30);
            label4.Name = "label4";
            label4.Size = new Size(300, 30);
            label4.TabIndex = 148;
            label4.Text = "Hospital Billing Management";
            // 
            // Bills
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1344, 773);
            Controls.Add(pictureBox12);
            Controls.Add(label4);
            Controls.Add(btnExportToWord);
            Controls.Add(btn_pay);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox11);
            Controls.Add(cob_patient);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(pnlDoctorDetails);
            Controls.Add(dgv_Bills);
            Controls.Add(cob_searDept);
            Name = "Bills";
            Text = "Bills";
            Load += Bills_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Bills).EndInit();
            pnlDoctorDetails.ResumeLayout(false);
            pnlDoctorDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxRemainingBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxTotalPaid).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
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
        private ComboBox cob_patient;
        private TextBox txt_GenDate;
        private TextBox txt_LateFee;
        private TextBox txt_remain;
        private DataGridView dgv_Bills;
        private Panel pnlDoctorDetails;
        private PictureBox pictureBox10;
        private PictureBox pBoxRemainingBalance;
        private PictureBox pictureBox8;
        private PictureBox pBoxTotalPaid;
        private PictureBox pictureBox6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private TextBox txt_phone;
        private Label lb_Phone;
        private TextBox txt_Specialization;
        private Label lb_Specialization;
        private TextBox txt_status;
        private Label lb_LastNameDoctor;
        private TextBox txt_OAmount;
        private Label lb_DoctorEmail;
        private ComboBox cob_searDept;
        private TextBox txt_confirmPassword;
        private Label lab_Remain;
        private TextBox txt_tolPaid;
        private Label lab_tolPaid;
        private TextBox txt_dept;
        private Label lb_Fname;
        private TextBox txt_pat;
        private Label lb_patientName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private TextBox txt_doc;
        private Label label1;
        private TextBox txt_total;
        private Label label3;
        private TextBox txt_Due;
        private Label label5;
        private Label label2;
        private Label label6;
        private PictureBox pictureBox11;
        private PictureBox pictureBox9;
        private PictureBox pictureBox4;
        private DataGridViewImageColumn icon;
        private Button btn_pay;
        private Button btnExportToWord;
        private PictureBox pictureBox12;
    }
}