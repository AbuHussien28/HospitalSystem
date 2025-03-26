namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class MedicalRecordForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtpFromDate = new DateTimePicker();
            dtpToDate = new DateTimePicker();
            btnFilter = new Button();
            btnReset = new Button();
            cbPatientName = new ComboBox();
            dgvMedicalRecords = new DataGridView();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            btnDetails = new DataGridViewButtonColumn();
            lbReceptionsitNameSearch = new Label();
            label4 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicalRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dtpFromDate
            // 
            dtpFromDate.Font = new Font("Segoe UI", 12F);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(248, 10);
            dtpFromDate.Margin = new Padding(4, 3, 4, 3);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(139, 29);
            dtpFromDate.TabIndex = 2;
            // 
            // dtpToDate
            // 
            dtpToDate.Font = new Font("Segoe UI", 12F);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(629, 9);
            dtpToDate.Margin = new Padding(4, 3, 4, 3);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(139, 29);
            dtpToDate.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.LightBlue;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilter.ForeColor = Color.Black;
            btnFilter.Image = Properties.Resources.Icon_Filter;
            btnFilter.ImageAlign = ContentAlignment.MiddleLeft;
            btnFilter.Location = new Point(470, 44);
            btnFilter.Margin = new Padding(4, 3, 4, 3);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(112, 36);
            btnFilter.TabIndex = 5;
            btnFilter.Text = "Filter";
            btnFilter.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Visible = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Crimson;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Image = Properties.Resources.IconUnFilter;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(629, 44);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(112, 36);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // cbPatientName
            // 
            cbPatientName.Font = new Font("Segoe UI", 12F);
            cbPatientName.FormattingEnabled = true;
            cbPatientName.Location = new Point(248, 45);
            cbPatientName.Margin = new Padding(4, 3, 4, 3);
            cbPatientName.Name = "cbPatientName";
            cbPatientName.Size = new Size(139, 29);
            cbPatientName.TabIndex = 8;
            // 
            // dgvMedicalRecords
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgvMedicalRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMedicalRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicalRecords.BackgroundColor = Color.White;
            dgvMedicalRecords.BorderStyle = BorderStyle.None;
            dgvMedicalRecords.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvMedicalRecords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMedicalRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicalRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicalRecords.Columns.AddRange(new DataGridViewColumn[] { dataGridViewImageColumn1, btnDetails });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvMedicalRecords.DefaultCellStyle = dataGridViewCellStyle4;
            dgvMedicalRecords.EnableHeadersVisualStyles = false;
            dgvMedicalRecords.Location = new Point(14, 98);
            dgvMedicalRecords.Name = "dgvMedicalRecords";
            dgvMedicalRecords.RowHeadersVisible = false;
            dgvMedicalRecords.RowTemplate.Height = 40;
            dgvMedicalRecords.Size = new Size(1120, 385);
            dgvMedicalRecords.TabIndex = 118;
            dgvMedicalRecords.CellContentClick += dgvMedicalRecords_CellContentClick;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumn1.HeaderText = "Icon ";
            dataGridViewImageColumn1.Image = Properties.Resources.IconMedical;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Width = 37;
            // 
            // btnDetails
            // 
            btnDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetails.DefaultCellStyle = dataGridViewCellStyle3;
            btnDetails.FlatStyle = FlatStyle.Flat;
            btnDetails.HeaderText = "Actions";
            btnDetails.Name = "btnDetails";
            btnDetails.Text = "View Details";
            btnDetails.UseColumnTextForButtonValue = true;
            btnDetails.Width = 51;
            // 
            // lbReceptionsitNameSearch
            // 
            lbReceptionsitNameSearch.AutoSize = true;
            lbReceptionsitNameSearch.BackColor = Color.Transparent;
            lbReceptionsitNameSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbReceptionsitNameSearch.Location = new Point(42, 14);
            lbReceptionsitNameSearch.Name = "lbReceptionsitNameSearch";
            lbReceptionsitNameSearch.Size = new Size(199, 21);
            lbReceptionsitNameSearch.TabIndex = 119;
            lbReceptionsitNameSearch.Text = "Appointment From Date:";
            lbReceptionsitNameSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(444, 14);
            label4.Name = "label4";
            label4.Size = new Size(178, 21);
            label4.TabIndex = 120;
            label4.Text = "Appointment To Date:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(42, 53);
            label1.Name = "label1";
            label1.Size = new Size(119, 21);
            label1.TabIndex = 121;
            label1.Text = "Patient Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconPatBirth;
            pictureBox1.Location = new Point(12, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 122;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconPatBirth;
            pictureBox2.Location = new Point(415, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 123;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconAddPat;
            pictureBox3.Location = new Point(12, 50);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 124;
            pictureBox3.TabStop = false;
            // 
            // MedicalRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1145, 495);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lbReceptionsitNameSearch);
            Controls.Add(dgvMedicalRecords);
            Controls.Add(cbPatientName);
            Controls.Add(btnReset);
            Controls.Add(btnFilter);
            Controls.Add(dtpToDate);
            Controls.Add(dtpFromDate);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MedicalRecordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medical Records";
            Load += MedicalRecordForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicalRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbPatientName;
        private DataGridView dgvMedicalRecords;
        private Label lbReceptionsitNameSearch;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewButtonColumn btnDetails;
    }

        #endregion
    }
