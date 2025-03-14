namespace ProjectHospitalSystem.Forms.Admin
{
    partial class AdminPaymentMethod
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
            lb_close = new Label();
            btn_AdminPaymentMethodRemove = new Button();
            btn_AdminPaymentMethodUpdate = new Button();
            btn_AdminPaymentMethodAdd = new Button();
            txt_AdminPaymentMethod = new TextBox();
            lb_AdminPaymentMethod = new Label();
            dgv_AdminPaymentMethod = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaymentMethod).BeginInit();
            SuspendLayout();
            // 
            // lb_close
            // 
            lb_close.AutoSize = true;
            lb_close.Location = new Point(386, 150);
            lb_close.Name = "lb_close";
            lb_close.Size = new Size(36, 15);
            lb_close.TabIndex = 47;
            lb_close.Text = "Close";
            // 
            // btn_AdminPaymentMethodRemove
            // 
            btn_AdminPaymentMethodRemove.Location = new Point(148, 104);
            btn_AdminPaymentMethodRemove.Name = "btn_AdminPaymentMethodRemove";
            btn_AdminPaymentMethodRemove.Size = new Size(100, 48);
            btn_AdminPaymentMethodRemove.TabIndex = 46;
            btn_AdminPaymentMethodRemove.Text = "Remove";
            btn_AdminPaymentMethodRemove.UseVisualStyleBackColor = true;
            btn_AdminPaymentMethodRemove.Click += btn_AdminPaymentMethodRemove_Click;
            // 
            // btn_AdminPaymentMethodUpdate
            // 
            btn_AdminPaymentMethodUpdate.Location = new Point(207, 50);
            btn_AdminPaymentMethodUpdate.Name = "btn_AdminPaymentMethodUpdate";
            btn_AdminPaymentMethodUpdate.Size = new Size(100, 48);
            btn_AdminPaymentMethodUpdate.TabIndex = 45;
            btn_AdminPaymentMethodUpdate.Text = "Update";
            btn_AdminPaymentMethodUpdate.UseVisualStyleBackColor = true;
            btn_AdminPaymentMethodUpdate.Click += btn_AdminPaymentMethodUpdate_Click;
            // 
            // btn_AdminPaymentMethodAdd
            // 
            btn_AdminPaymentMethodAdd.Location = new Point(81, 50);
            btn_AdminPaymentMethodAdd.Name = "btn_AdminPaymentMethodAdd";
            btn_AdminPaymentMethodAdd.Size = new Size(100, 48);
            btn_AdminPaymentMethodAdd.TabIndex = 44;
            btn_AdminPaymentMethodAdd.Text = "Add";
            btn_AdminPaymentMethodAdd.UseVisualStyleBackColor = true;
            btn_AdminPaymentMethodAdd.Click += btn_AdminPaymentMethodAdd_Click;
            // 
            // txt_AdminPaymentMethod
            // 
            txt_AdminPaymentMethod.Location = new Point(130, 12);
            txt_AdminPaymentMethod.Name = "txt_AdminPaymentMethod";
            txt_AdminPaymentMethod.Size = new Size(177, 23);
            txt_AdminPaymentMethod.TabIndex = 43;
            // 
            // lb_AdminPaymentMethod
            // 
            lb_AdminPaymentMethod.AutoSize = true;
            lb_AdminPaymentMethod.Location = new Point(12, 15);
            lb_AdminPaymentMethod.Name = "lb_AdminPaymentMethod";
            lb_AdminPaymentMethod.Size = new Size(102, 15);
            lb_AdminPaymentMethod.TabIndex = 42;
            lb_AdminPaymentMethod.Text = "Payment Services ";
            // 
            // dgv_AdminPaymentMethod
            // 
            dgv_AdminPaymentMethod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminPaymentMethod.Location = new Point(328, 12);
            dgv_AdminPaymentMethod.Name = "dgv_AdminPaymentMethod";
            dgv_AdminPaymentMethod.Size = new Size(153, 120);
            dgv_AdminPaymentMethod.TabIndex = 41;
            dgv_AdminPaymentMethod.RowHeaderMouseDoubleClick += dgv_AdminPaymentMethod_RowHeaderMouseDoubleClick;
            // 
            // AdminPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 176);
            Controls.Add(lb_close);
            Controls.Add(btn_AdminPaymentMethodRemove);
            Controls.Add(btn_AdminPaymentMethodUpdate);
            Controls.Add(btn_AdminPaymentMethodAdd);
            Controls.Add(txt_AdminPaymentMethod);
            Controls.Add(lb_AdminPaymentMethod);
            Controls.Add(dgv_AdminPaymentMethod);
            Name = "AdminPaymentMethod";
            Text = "AdminPaymentMethod";
            Load += AdminPaymentMethod_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaymentMethod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_close;
        private Button btn_AdminPaymentMethodRemove;
        private Button btn_AdminPaymentMethodUpdate;
        private Button btn_AdminPaymentMethodAdd;
        private TextBox txt_AdminPaymentMethod;
        private Label lb_AdminPaymentMethod;
        private DataGridView dgv_AdminPaymentMethod;
    }
}