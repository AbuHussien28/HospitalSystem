namespace ProjectHospitalSystem.Forms.Doctor
{
    partial class HomePageDoctor
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            label35 = new Label();
            dgv_patientListHome = new DataGridView();
            icon = new DataGridViewImageColumn();
            dgv_upcommingAppointmentHomePage = new DataGridView();
            dataGridViewImageColumn1 = new DataGridViewImageColumn();
            dtpFilterDate = new DateTimePicker();
            btnFilter = new Button();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            lbFilterSearch = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_patientListHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_upcommingAppointmentHomePage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label38.Location = new Point(373, 12);
            label38.Name = "label38";
            label38.Size = new Size(263, 32);
            label38.TabIndex = 10;
            label38.Text = "Appointments Doctor";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(45, 135);
            label37.Name = "label37";
            label37.Size = new Size(95, 21);
            label37.TabIndex = 8;
            label37.Text = "Patient List";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label36.Location = new Point(143, 83);
            label36.Name = "label36";
            label36.Size = new Size(47, 25);
            label36.TabIndex = 7;
            label36.Text = "Doc";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label35.Location = new Point(12, 83);
            label35.Name = "label35";
            label35.Size = new Size(125, 25);
            label35.TabIndex = 6;
            label35.Text = "Welcome: Dr";
            // 
            // dgv_patientListHome
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_patientListHome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_patientListHome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_patientListHome.BackgroundColor = Color.FromArgb(254, 251, 244);
            dgv_patientListHome.BorderStyle = BorderStyle.None;
            dgv_patientListHome.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_patientListHome.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_patientListHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_patientListHome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_patientListHome.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_patientListHome.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_patientListHome.EnableHeadersVisualStyles = false;
            dgv_patientListHome.Location = new Point(15, 179);
            dgv_patientListHome.Name = "dgv_patientListHome";
            dgv_patientListHome.RowHeadersVisible = false;
            dgv_patientListHome.RowTemplate.Height = 40;
            dgv_patientListHome.Size = new Size(200, 307);
            dgv_patientListHome.TabIndex = 118;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconPaientent;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // dgv_upcommingAppointmentHomePage
            // 
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonFace;
            dgv_upcommingAppointmentHomePage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgv_upcommingAppointmentHomePage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_upcommingAppointmentHomePage.BackgroundColor = Color.FromArgb(254, 251, 244);
            dgv_upcommingAppointmentHomePage.BorderStyle = BorderStyle.None;
            dgv_upcommingAppointmentHomePage.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_upcommingAppointmentHomePage.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgv_upcommingAppointmentHomePage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgv_upcommingAppointmentHomePage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_upcommingAppointmentHomePage.Columns.AddRange(new DataGridViewColumn[] { dataGridViewImageColumn1 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_upcommingAppointmentHomePage.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_upcommingAppointmentHomePage.EnableHeadersVisualStyles = false;
            dgv_upcommingAppointmentHomePage.Location = new Point(236, 179);
            dgv_upcommingAppointmentHomePage.Name = "dgv_upcommingAppointmentHomePage";
            dgv_upcommingAppointmentHomePage.RowHeadersVisible = false;
            dgv_upcommingAppointmentHomePage.RowTemplate.Height = 40;
            dgv_upcommingAppointmentHomePage.Size = new Size(687, 307);
            dgv_upcommingAppointmentHomePage.TabIndex = 119;
            dgv_upcommingAppointmentHomePage.CellFormatting += dgv_upcommingAppointmentHomePage_CellFormatting;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewImageColumn1.HeaderText = "Icon ";
            dataGridViewImageColumn1.Image = Properties.Resources.IconDoctorAppoiments;
            dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            dataGridViewImageColumn1.Width = 37;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFilterDate.Location = new Point(358, 129);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(255, 29);
            dtpFilterDate.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.LightBlue;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFilter.Image = Properties.Resources.Icon_Filter;
            btnFilter.ImageAlign = ContentAlignment.MiddleRight;
            btnFilter.Location = new Point(641, 120);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(92, 44);
            btnFilter.TabIndex = 2;
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
            btnReset.ImageAlign = ContentAlignment.MiddleRight;
            btnReset.Location = new Point(764, 120);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(92, 44);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Visible = false;
            btnReset.Click += btnReset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.IconPatBirth;
            pictureBox1.Location = new Point(206, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 126;
            pictureBox1.TabStop = false;
            // 
            // lbFilterSearch
            // 
            lbFilterSearch.AutoSize = true;
            lbFilterSearch.BackColor = Color.Transparent;
            lbFilterSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbFilterSearch.Location = new Point(236, 132);
            lbFilterSearch.Name = "lbFilterSearch";
            lbFilterSearch.Size = new Size(116, 21);
            lbFilterSearch.TabIndex = 125;
            lbFilterSearch.Text = "Filter by Date:";
            lbFilterSearch.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IconDoctorAppoiment;
            pictureBox2.Location = new Point(335, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 127;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IconPaientent;
            pictureBox3.Location = new Point(15, 132);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 128;
            pictureBox3.TabStop = false;
            // 
            // HomePageDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(1024, 527);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbFilterSearch);
            Controls.Add(dtpFilterDate);
            Controls.Add(btnFilter);
            Controls.Add(btnReset);
            Controls.Add(dgv_upcommingAppointmentHomePage);
            Controls.Add(dgv_patientListHome);
            Controls.Add(label38);
            Controls.Add(label37);
            Controls.Add(label36);
            Controls.Add(label35);
            Name = "HomePageDoctor";
            Text = "HomePageDoctor";
            Load += HomePageDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_patientListHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_upcommingAppointmentHomePage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private DataGridView dgv_patientListHome;
        private DataGridView dgv_upcommingAppointmentHomePage;
        private DateTimePicker dtpFilterDate;
        private Button btnFilter;
        private Button btnReset;
        private PictureBox pictureBox1;
        private Label lbFilterSearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private DataGridViewImageColumn icon;
        private DataGridViewImageColumn dataGridViewImageColumn1;
    }
}