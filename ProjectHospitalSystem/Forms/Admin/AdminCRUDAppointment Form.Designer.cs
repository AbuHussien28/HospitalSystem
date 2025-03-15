namespace ProjectHospitalSystem.Forms.Admin
{
    partial class Appointment_Form
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
            dgv_Appointment = new DataGridView();
            pictureBox1 = new PictureBox();
            lbReceptionsitNameSearch = new Label();
            pnlReceDetails = new Panel();
            lbSelectedAppoinment = new Label();
            dtp_AppoinmnetDate = new DateTimePicker();
            cb_Doctor = new ComboBox();
            cb_Depart = new ComboBox();
            pictureBox4 = new PictureBox();
            pBoxDoctorName = new PictureBox();
            pBoxDeptName = new PictureBox();
            lb_Doctor = new Label();
            lb_DeptName = new Label();
            dtp_FilterDate = new DateTimePicker();
            btn_delete = new Button();
            btn_Update = new Button();
            btn_add = new Button();
            lbBtnFilter = new Label();
            lb_clearFilter = new Label();
            pBoxFilterDate = new PictureBox();
            pBoxClearFilterDate = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Appointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlReceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDoctorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDeptName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxFilterDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBoxClearFilterDate).BeginInit();
            SuspendLayout();
            // 
            // dgv_Appointment
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_Appointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Appointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Appointment.BackgroundColor = Color.White;
            dgv_Appointment.BorderStyle = BorderStyle.None;
            dgv_Appointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_Appointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Appointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Appointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Appointment.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Appointment.EnableHeadersVisualStyles = false;
            dgv_Appointment.Location = new Point(18, 66);
            dgv_Appointment.Name = "dgv_Appointment";
            dgv_Appointment.RowTemplate.Height = 40;
            dgv_Appointment.Size = new Size(723, 205);
            dgv_Appointment.TabIndex = 94;
            dgv_Appointment.RowHeaderMouseDoubleClick += dgv_Appointment_RowHeaderMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconPatBirth;
            pictureBox1.Location = new Point(18, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 99;
            pictureBox1.TabStop = false;
            // 
            // lbReceptionsitNameSearch
            // 
            lbReceptionsitNameSearch.AutoSize = true;
            lbReceptionsitNameSearch.BackColor = Color.Transparent;
            lbReceptionsitNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbReceptionsitNameSearch.Location = new Point(48, 8);
            lbReceptionsitNameSearch.Name = "lbReceptionsitNameSearch";
            lbReceptionsitNameSearch.Size = new Size(156, 21);
            lbReceptionsitNameSearch.TabIndex = 97;
            lbReceptionsitNameSearch.Text = "Appointment Date:";
            lbReceptionsitNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlReceDetails
            // 
            pnlReceDetails.BackColor = Color.WhiteSmoke;
            pnlReceDetails.Controls.Add(lbSelectedAppoinment);
            pnlReceDetails.Controls.Add(dtp_AppoinmnetDate);
            pnlReceDetails.Controls.Add(cb_Doctor);
            pnlReceDetails.Controls.Add(cb_Depart);
            pnlReceDetails.Controls.Add(pictureBox4);
            pnlReceDetails.Controls.Add(pBoxDoctorName);
            pnlReceDetails.Controls.Add(pBoxDeptName);
            pnlReceDetails.Controls.Add(lb_Doctor);
            pnlReceDetails.Controls.Add(lb_DeptName);
            pnlReceDetails.Location = new Point(18, 312);
            pnlReceDetails.Name = "pnlReceDetails";
            pnlReceDetails.Size = new Size(830, 127);
            pnlReceDetails.TabIndex = 103;
            // 
            // lbSelectedAppoinment
            // 
            lbSelectedAppoinment.AutoSize = true;
            lbSelectedAppoinment.BackColor = Color.Transparent;
            lbSelectedAppoinment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbSelectedAppoinment.Location = new Point(41, 66);
            lbSelectedAppoinment.Name = "lbSelectedAppoinment";
            lbSelectedAppoinment.Size = new Size(252, 21);
            lbSelectedAppoinment.TabIndex = 114;
            lbSelectedAppoinment.Text = "Select Appointment Date & Time:";
            lbSelectedAppoinment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtp_AppoinmnetDate
            // 
            dtp_AppoinmnetDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_AppoinmnetDate.Font = new Font("Segoe UI", 12F);
            dtp_AppoinmnetDate.Format = DateTimePickerFormat.Custom;
            dtp_AppoinmnetDate.Location = new Point(299, 64);
            dtp_AppoinmnetDate.Name = "dtp_AppoinmnetDate";
            dtp_AppoinmnetDate.Size = new Size(219, 29);
            dtp_AppoinmnetDate.TabIndex = 113;
            // 
            // cb_Doctor
            // 
            cb_Doctor.BackColor = Color.White;
            cb_Doctor.Font = new Font("Segoe UI", 12F);
            cb_Doctor.ForeColor = Color.Black;
            cb_Doctor.FormattingEnabled = true;
            cb_Doctor.Location = new Point(592, 29);
            cb_Doctor.Name = "cb_Doctor";
            cb_Doctor.Size = new Size(233, 29);
            cb_Doctor.TabIndex = 112;
            // 
            // cb_Depart
            // 
            cb_Depart.BackColor = Color.White;
            cb_Depart.Font = new Font("Segoe UI", 12F);
            cb_Depart.ForeColor = Color.Black;
            cb_Depart.FormattingEnabled = true;
            cb_Depart.Location = new Point(203, 29);
            cb_Depart.Name = "cb_Depart";
            cb_Depart.Size = new Size(233, 29);
            cb_Depart.TabIndex = 104;
            cb_Depart.SelectedValueChanged += cb_Depart_SelectedValueChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconPatBirth;
            pictureBox4.Location = new Point(11, 66);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 108;
            pictureBox4.TabStop = false;
            // 
            // pBoxDoctorName
            // 
            pBoxDoctorName.Image = Properties.Resources.IconDoctorData;
            pBoxDoctorName.Location = new Point(450, 30);
            pBoxDoctorName.Name = "pBoxDoctorName";
            pBoxDoctorName.Size = new Size(24, 24);
            pBoxDoctorName.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxDoctorName.TabIndex = 107;
            pBoxDoctorName.TabStop = false;
            // 
            // pBoxDeptName
            // 
            pBoxDeptName.Image = Properties.Resources.IconDeptName;
            pBoxDeptName.Location = new Point(11, 29);
            pBoxDeptName.Name = "pBoxDeptName";
            pBoxDeptName.Size = new Size(24, 24);
            pBoxDeptName.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxDeptName.TabIndex = 93;
            pBoxDeptName.TabStop = false;
            // 
            // lb_Doctor
            // 
            lb_Doctor.AutoSize = true;
            lb_Doctor.BackColor = Color.Transparent;
            lb_Doctor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_Doctor.Location = new Point(480, 32);
            lb_Doctor.Name = "lb_Doctor";
            lb_Doctor.Size = new Size(116, 21);
            lb_Doctor.TabIndex = 91;
            lb_Doctor.Text = "Doctor Name:";
            lb_Doctor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lb_DeptName
            // 
            lb_DeptName.AutoSize = true;
            lb_DeptName.BackColor = Color.Transparent;
            lb_DeptName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_DeptName.Location = new Point(41, 32);
            lb_DeptName.Name = "lb_DeptName";
            lb_DeptName.Size = new Size(156, 21);
            lb_DeptName.TabIndex = 89;
            lb_DeptName.Text = "Department Name:";
            lb_DeptName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtp_FilterDate
            // 
            dtp_FilterDate.CustomFormat = "yyyy-MM-dd HH:mm";
            dtp_FilterDate.Font = new Font("Segoe UI", 12F);
            dtp_FilterDate.Format = DateTimePickerFormat.Custom;
            dtp_FilterDate.Location = new Point(205, 5);
            dtp_FilterDate.Name = "dtp_FilterDate";
            dtp_FilterDate.Size = new Size(219, 29);
            dtp_FilterDate.TabIndex = 114;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Crimson;
            btn_delete.Cursor = Cursors.No;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.IconRemovedOCTOR;
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(772, 218);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(221, 53);
            btn_delete.TabIndex = 117;
            btn_delete.Text = "Remove Appointment";
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Visible = false;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.DodgerBlue;
            btn_Update.Cursor = Cursors.Hand;
            btn_Update.FlatAppearance.BorderSize = 0;
            btn_Update.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_Update.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.White;
            btn_Update.Image = Properties.Resources.IconUpdateAdmin;
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(772, 142);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(218, 53);
            btn_Update.TabIndex = 116;
            btn_Update.Text = "Update Appointment";
            btn_Update.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Visible = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.LimeGreen;
            btn_add.Cursor = Cursors.Cross;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_add.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.ForeColor = Color.White;
            btn_add.Image = Properties.Resources.IconAddDate;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(772, 66);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(218, 53);
            btn_add.TabIndex = 115;
            btn_add.Text = "Add New Appointment";
            btn_add.TextAlign = ContentAlignment.MiddleRight;
            btn_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Visible = false;
            btn_add.Click += btn_add_Click;
            // 
            // lbBtnFilter
            // 
            lbBtnFilter.AutoSize = true;
            lbBtnFilter.BackColor = Color.Transparent;
            lbBtnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbBtnFilter.Location = new Point(511, 11);
            lbBtnFilter.Name = "lbBtnFilter";
            lbBtnFilter.Size = new Size(49, 21);
            lbBtnFilter.TabIndex = 118;
            lbBtnFilter.Text = "Filter";
            lbBtnFilter.TextAlign = ContentAlignment.MiddleRight;
            lbBtnFilter.Click += lbBtnFilter_Click;
            // 
            // lb_clearFilter
            // 
            lb_clearFilter.AutoSize = true;
            lb_clearFilter.BackColor = Color.Transparent;
            lb_clearFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_clearFilter.Location = new Point(610, 11);
            lb_clearFilter.Name = "lb_clearFilter";
            lb_clearFilter.Size = new Size(92, 21);
            lb_clearFilter.TabIndex = 119;
            lb_clearFilter.Text = "Clear Filter";
            lb_clearFilter.TextAlign = ContentAlignment.MiddleRight;
            lb_clearFilter.Click += lb_clearFilter_Click;
            // 
            // pBoxFilterDate
            // 
            pBoxFilterDate.Image = Properties.Resources.Icon_Filter;
            pBoxFilterDate.Location = new Point(481, 8);
            pBoxFilterDate.Name = "pBoxFilterDate";
            pBoxFilterDate.Size = new Size(24, 24);
            pBoxFilterDate.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxFilterDate.TabIndex = 120;
            pBoxFilterDate.TabStop = false;
            // 
            // pBoxClearFilterDate
            // 
            pBoxClearFilterDate.Image = Properties.Resources.IconUnFilter;
            pBoxClearFilterDate.Location = new Point(580, 8);
            pBoxClearFilterDate.Name = "pBoxClearFilterDate";
            pBoxClearFilterDate.Size = new Size(24, 24);
            pBoxClearFilterDate.SizeMode = PictureBoxSizeMode.AutoSize;
            pBoxClearFilterDate.TabIndex = 121;
            pBoxClearFilterDate.TabStop = false;
            // 
            // Appointment_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1223, 760);
            Controls.Add(pBoxClearFilterDate);
            Controls.Add(pBoxFilterDate);
            Controls.Add(lb_clearFilter);
            Controls.Add(lbBtnFilter);
            Controls.Add(btn_delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_add);
            Controls.Add(dtp_FilterDate);
            Controls.Add(pnlReceDetails);
            Controls.Add(pictureBox1);
            Controls.Add(lbReceptionsitNameSearch);
            Controls.Add(dgv_Appointment);
            Name = "Appointment_Form";
            Text = "Appointment_Form";
            Load += Appointment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Appointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlReceDetails.ResumeLayout(false);
            pnlReceDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDoctorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxDeptName).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxFilterDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBoxClearFilterDate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtp_AppoinmnetDate;
        private ComboBox cb_Depart;
        private ComboBox cb_Doctor;
        private Label lb_Doctor;
        private Button btn_delete;
        private DataGridView dgv_Appointment;
        private PictureBox pictureBox1;
        private Label lbReceptionsitNameSearch;
        private Panel pnlReceDetails;
        private PictureBox pictureBox9;
        private PictureBox pBoxPassword;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pBoxDoctorName;
        private PictureBox pBoxDeptName;
        private TextBox txt_phone;
        private Label lb_Phone;
        private Label lb_LastNameRece;
        private TextBox txt_Email;
        private Label lb_RecEmail;
        private TextBox txt_Password;
        private Label lb_password;
        private TextBox txt_Fname;
        private Label lb_Fname;
        private Label lb_DeptName;
        private Label lbSelectedAppoinment;
        private DateTimePicker dtp_FilterDate;
        private Button btn_remove;
        private Button btn_Update;
        private Button btn_add;
        private Label lbBtnFilter;
        private Label lb_clearFilter;
        private PictureBox pBoxFilterDate;
        private PictureBox pBoxClearFilterDate;
    }
}