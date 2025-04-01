namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class DoctorAppointmentToday
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
            pictureBox2 = new PictureBox();
            dgv_appointment = new DataGridView();
            icon = new DataGridViewImageColumn();
            label32 = new Label();
            txt_status = new TextBox();
            lbStatusAppoint = new Label();
            pnlAppoinmentDocDetails = new Panel();
            pictureBox4 = new PictureBox();
            btn_EditMedicalRecord = new Button();
            btn_editstatus = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment).BeginInit();
            pnlAppoinmentDocDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconDoctorAppoiments;
            pictureBox2.Location = new Point(374, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 115;
            pictureBox2.TabStop = false;
            // 
            // dgv_appointment
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_appointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_appointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_appointment.BackgroundColor = Color.FromArgb(254, 251, 244);
            dgv_appointment.BorderStyle = BorderStyle.None;
            dgv_appointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_appointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_appointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_appointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_appointment.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_appointment.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_appointment.EnableHeadersVisualStyles = false;
            dgv_appointment.Location = new Point(24, 104);
            dgv_appointment.Name = "dgv_appointment";
            dgv_appointment.RowHeadersVisible = false;
            dgv_appointment.RowTemplate.Height = 40;
            dgv_appointment.Size = new Size(1020, 191);
            dgv_appointment.TabIndex = 113;
            dgv_appointment.CellDoubleClick += dgv_appointment_CellDoubleClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconDoctordGV;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(404, 58);
            label32.Name = "label32";
            label32.Size = new Size(340, 30);
            label32.TabIndex = 110;
            label32.Text = "Doctor's Appointments for Today";
            // 
            // txt_status
            // 
            txt_status.BackColor = Color.White;
            txt_status.BorderStyle = BorderStyle.FixedSingle;
            txt_status.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_status.ForeColor = Color.Black;
            txt_status.Location = new Point(111, 27);
            txt_status.Margin = new Padding(5);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(222, 29);
            txt_status.TabIndex = 8;
            // 
            // lbStatusAppoint
            // 
            lbStatusAppoint.AutoSize = true;
            lbStatusAppoint.BackColor = Color.Transparent;
            lbStatusAppoint.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbStatusAppoint.Location = new Point(42, 32);
            lbStatusAppoint.Name = "lbStatusAppoint";
            lbStatusAppoint.Size = new Size(61, 21);
            lbStatusAppoint.TabIndex = 103;
            lbStatusAppoint.Text = "Status:";
            lbStatusAppoint.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlAppoinmentDocDetails
            // 
            pnlAppoinmentDocDetails.BackColor = Color.WhiteSmoke;
            pnlAppoinmentDocDetails.Controls.Add(pictureBox4);
            pnlAppoinmentDocDetails.Controls.Add(txt_status);
            pnlAppoinmentDocDetails.Controls.Add(lbStatusAppoint);
            pnlAppoinmentDocDetails.Location = new Point(24, 306);
            pnlAppoinmentDocDetails.Name = "pnlAppoinmentDocDetails";
            pnlAppoinmentDocDetails.Size = new Size(383, 80);
            pnlAppoinmentDocDetails.TabIndex = 114;
            pnlAppoinmentDocDetails.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IconRecStatus;
            pictureBox4.Location = new Point(10, 30);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 108;
            pictureBox4.TabStop = false;
            // 
            // btn_EditMedicalRecord
            // 
            btn_EditMedicalRecord.BackColor = Color.DodgerBlue;
            btn_EditMedicalRecord.FlatAppearance.BorderSize = 0;
            btn_EditMedicalRecord.FlatStyle = FlatStyle.Flat;
            btn_EditMedicalRecord.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btn_EditMedicalRecord.ForeColor = Color.White;
            btn_EditMedicalRecord.Image = Properties.Resources.IconDoctorMedicalRecord;
            btn_EditMedicalRecord.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditMedicalRecord.Location = new Point(846, 316);
            btn_EditMedicalRecord.Name = "btn_EditMedicalRecord";
            btn_EditMedicalRecord.Size = new Size(198, 57);
            btn_EditMedicalRecord.TabIndex = 112;
            btn_EditMedicalRecord.Text = "Edit Patient Record";
            btn_EditMedicalRecord.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_EditMedicalRecord.UseVisualStyleBackColor = false;
            btn_EditMedicalRecord.Visible = false;
            btn_EditMedicalRecord.Click += btn_EditMedicalRecord_Click;
            // 
            // btn_editstatus
            // 
            btn_editstatus.BackColor = Color.DodgerBlue;
            btn_editstatus.Cursor = Cursors.Hand;
            btn_editstatus.FlatAppearance.BorderSize = 0;
            btn_editstatus.FlatStyle = FlatStyle.Flat;
            btn_editstatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_editstatus.ForeColor = Color.White;
            btn_editstatus.Image = Properties.Resources.IconProjectStatus;
            btn_editstatus.ImageAlign = ContentAlignment.MiddleLeft;
            btn_editstatus.Location = new Point(551, 314);
            btn_editstatus.Name = "btn_editstatus";
            btn_editstatus.Size = new Size(213, 61);
            btn_editstatus.TabIndex = 111;
            btn_editstatus.Text = "Update Appointment Status";
            btn_editstatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editstatus.UseVisualStyleBackColor = false;
            btn_editstatus.Visible = false;
            btn_editstatus.Click += btn_editstatus_Click;
            // 
            // DoctorAppointmentToday
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1156, 463);
            Controls.Add(pictureBox2);
            Controls.Add(dgv_appointment);
            Controls.Add(label32);
            Controls.Add(pnlAppoinmentDocDetails);
            Controls.Add(btn_EditMedicalRecord);
            Controls.Add(btn_editstatus);
            Name = "DoctorAppointmentToday";
            Text = "DoctorAppointmentToday";
            Load += DoctorAppointmentToday_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_appointment).EndInit();
            pnlAppoinmentDocDetails.ResumeLayout(false);
            pnlAppoinmentDocDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView dgv_appointment;
        private DataGridViewImageColumn icon;
        private Label label32;
        private TextBox txt_status;
        private Label lbStatusAppoint;
        private Panel pnlAppoinmentDocDetails;
        private PictureBox pictureBox4;
        private Button btn_EditMedicalRecord;
        private Button btn_editstatus;
    }
}