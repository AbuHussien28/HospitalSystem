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
            label1 = new Label();
            dgv_Appointment = new DataGridView();
            btn_add = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            cb_Depart = new ComboBox();
            cb_Doctor = new ComboBox();
            label5 = new Label();
            btn_Update = new Button();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Appointment).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Appointment";
            // 
            // dgv_Appointment
            // 
            dgv_Appointment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Appointment.Location = new Point(12, 99);
            dgv_Appointment.Name = "dgv_Appointment";
            dgv_Appointment.Size = new Size(567, 150);
            dgv_Appointment.TabIndex = 1;
            dgv_Appointment.RowHeaderMouseDoubleClick += dgv_Appointment_RowHeaderMouseDoubleClick;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(479, 401);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 330);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 3;
            label2.Text = "Appointment Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(134, 324);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.Value = new DateTime(2025, 3, 15, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 285);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 8;
            label4.Text = "Department";
            // 
            // cb_Depart
            // 
            cb_Depart.FormattingEnabled = true;
            cb_Depart.Location = new Point(94, 277);
            cb_Depart.Name = "cb_Depart";
            cb_Depart.Size = new Size(121, 23);
            cb_Depart.TabIndex = 9;
            cb_Depart.SelectedValueChanged += cb_Depart_SelectedValueChanged;
            // 
            // cb_Doctor
            // 
            cb_Doctor.FormattingEnabled = true;
            cb_Doctor.Location = new Point(324, 282);
            cb_Doctor.Name = "cb_Doctor";
            cb_Doctor.Size = new Size(121, 23);
            cb_Doctor.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 285);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 10;
            label5.Text = "Doctor";
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(571, 401);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(75, 23);
            btn_Update.TabIndex = 12;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(681, 402);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // Appointment_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_delete);
            Controls.Add(btn_Update);
            Controls.Add(cb_Doctor);
            Controls.Add(label5);
            Controls.Add(cb_Depart);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(btn_add);
            Controls.Add(dgv_Appointment);
            Controls.Add(label1);
            Name = "Appointment_Form";
            Text = "Appointment_Form";
            Load += Appointment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Appointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_Appointment;
        private Button btn_add;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox cb_Depart;
        private ComboBox cb_Doctor;
        private Label label5;
        private Button btn_Update;
        private Button btn_delete;
    }
}