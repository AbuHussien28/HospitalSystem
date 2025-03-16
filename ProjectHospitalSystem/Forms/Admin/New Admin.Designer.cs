namespace ProjectHospitalSystem.Forms.Admin
{
    partial class New_Admin
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
            dgv_admin = new DataGridView();
            btn_update = new Button();
            btn_Add = new Button();
            btn_delete = new Button();
            label2 = new Label();
            txt_firstName = new TextBox();
            txt_lastName = new TextBox();
            label3 = new Label();
            txt_email = new TextBox();
            label4 = new Label();
            txt_password = new TextBox();
            lb_Pasword = new Label();
            txt_UserName = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_admin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(50, 27);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Admin_List";
            // 
            // dgv_admin
            // 
            dgv_admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_admin.Location = new Point(50, 72);
            dgv_admin.Name = "dgv_admin";
            dgv_admin.Size = new Size(498, 150);
            dgv_admin.TabIndex = 1;
            dgv_admin.RowHeaderMouseDoubleClick += dgv_admin_RowHeaderMouseDoubleClick;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(447, 365);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(338, 365);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 23);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(572, 365);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 4;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 241);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            // 
            // txt_firstName
            // 
            txt_firstName.Location = new Point(169, 242);
            txt_firstName.Name = "txt_firstName";
            txt_firstName.Size = new Size(100, 23);
            txt_firstName.TabIndex = 6;
            // 
            // txt_lastName
            // 
            txt_lastName.Location = new Point(169, 299);
            txt_lastName.Name = "txt_lastName";
            txt_lastName.Size = new Size(100, 23);
            txt_lastName.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 298);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Last Name";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(395, 242);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(100, 23);
            txt_email.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(314, 245);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(395, 299);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(100, 23);
            txt_password.TabIndex = 12;
            // 
            // lb_Pasword
            // 
            lb_Pasword.AutoSize = true;
            lb_Pasword.Location = new Point(314, 307);
            lb_Pasword.Name = "lb_Pasword";
            lb_Pasword.Size = new Size(57, 15);
            lb_Pasword.TabIndex = 11;
            lb_Pasword.Text = "Password";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(169, 353);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(100, 23);
            txt_UserName.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 352);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "User Name";
            // 
            // New_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_UserName);
            Controls.Add(label6);
            Controls.Add(txt_password);
            Controls.Add(lb_Pasword);
            Controls.Add(txt_email);
            Controls.Add(label4);
            Controls.Add(txt_lastName);
            Controls.Add(label3);
            Controls.Add(txt_firstName);
            Controls.Add(label2);
            Controls.Add(btn_delete);
            Controls.Add(btn_Add);
            Controls.Add(btn_update);
            Controls.Add(dgv_admin);
            Controls.Add(label1);
            Name = "New_Admin";
            Text = "New_Admin";
            Load += New_Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_admin;
        private Button btn_update;
        private Button btn_Add;
        private Button btn_delete;
        private Label label2;
        private TextBox txt_firstName;
        private TextBox txt_lastName;
        private Label label3;
        private TextBox txt_email;
        private Label label4;
        private TextBox txt_password;
        private Label lb_Pasword;
        private TextBox txt_UserName;
        private Label label6;
    }
}