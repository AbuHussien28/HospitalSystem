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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_AdminPaymentMethod = new DataGridView();
            icon = new DataGridViewImageColumn();
            txt_AdminPaymentMethod = new TextBox();
            lb_AdminPaymentMethod = new Label();
            btn_AdminPaymentMethodRemove = new Button();
            btn_AdminPaymentMethodUpdate = new Button();
            btn_AdminPaymentMethodAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaymentMethod).BeginInit();
            SuspendLayout();
            // 
            // dgv_AdminPaymentMethod
            // 
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dgv_AdminPaymentMethod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_AdminPaymentMethod.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_AdminPaymentMethod.BackgroundColor = Color.White;
            dgv_AdminPaymentMethod.BorderStyle = BorderStyle.None;
            dgv_AdminPaymentMethod.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_AdminPaymentMethod.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(44, 62, 80);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_AdminPaymentMethod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_AdminPaymentMethod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_AdminPaymentMethod.Columns.AddRange(new DataGridViewColumn[] { icon });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_AdminPaymentMethod.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_AdminPaymentMethod.EnableHeadersVisualStyles = false;
            dgv_AdminPaymentMethod.Location = new Point(12, 12);
            dgv_AdminPaymentMethod.Name = "dgv_AdminPaymentMethod";
            dgv_AdminPaymentMethod.RowHeadersVisible = false;
            dgv_AdminPaymentMethod.RowTemplate.Height = 40;
            dgv_AdminPaymentMethod.Size = new Size(252, 283);
            dgv_AdminPaymentMethod.TabIndex = 94;
            dgv_AdminPaymentMethod.CellMouseDoubleClick += dgv_AdminPaymentMethod_CellMouseDoubleClick;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            icon.HeaderText = "Icon ";
            icon.Image = Properties.Resources.IconPaymentMethod;
            icon.Name = "icon";
            icon.Width = 37;
            // 
            // txt_AdminPaymentMethod
            // 
            txt_AdminPaymentMethod.BackColor = Color.White;
            txt_AdminPaymentMethod.BorderStyle = BorderStyle.FixedSingle;
            txt_AdminPaymentMethod.Font = new Font("Segoe UI", 12F);
            txt_AdminPaymentMethod.ForeColor = Color.Black;
            txt_AdminPaymentMethod.Location = new Point(502, 107);
            txt_AdminPaymentMethod.Margin = new Padding(5);
            txt_AdminPaymentMethod.Name = "txt_AdminPaymentMethod";
            txt_AdminPaymentMethod.Size = new Size(233, 29);
            txt_AdminPaymentMethod.TabIndex = 1;
            // 
            // lb_AdminPaymentMethod
            // 
            lb_AdminPaymentMethod.AutoSize = true;
            lb_AdminPaymentMethod.BackColor = Color.Transparent;
            lb_AdminPaymentMethod.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lb_AdminPaymentMethod.Location = new Point(345, 109);
            lb_AdminPaymentMethod.Name = "lb_AdminPaymentMethod";
            lb_AdminPaymentMethod.Size = new Size(149, 21);
            lb_AdminPaymentMethod.TabIndex = 89;
            lb_AdminPaymentMethod.Text = "Payment Services:";
            lb_AdminPaymentMethod.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_AdminPaymentMethodRemove
            // 
            btn_AdminPaymentMethodRemove.BackColor = Color.Crimson;
            btn_AdminPaymentMethodRemove.Cursor = Cursors.No;
            btn_AdminPaymentMethodRemove.FlatAppearance.BorderSize = 0;
            btn_AdminPaymentMethodRemove.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_AdminPaymentMethodRemove.FlatAppearance.MouseOverBackColor = Color.DarkRed;
            btn_AdminPaymentMethodRemove.FlatStyle = FlatStyle.Flat;
            btn_AdminPaymentMethodRemove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdminPaymentMethodRemove.ForeColor = Color.White;
            btn_AdminPaymentMethodRemove.Image = Properties.Resources.IconRemovedOCTOR;
            btn_AdminPaymentMethodRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AdminPaymentMethodRemove.Location = new Point(631, 168);
            btn_AdminPaymentMethodRemove.Name = "btn_AdminPaymentMethodRemove";
            btn_AdminPaymentMethodRemove.Size = new Size(104, 53);
            btn_AdminPaymentMethodRemove.TabIndex = 103;
            btn_AdminPaymentMethodRemove.Text = "Remove";
            btn_AdminPaymentMethodRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AdminPaymentMethodRemove.UseVisualStyleBackColor = false;
            btn_AdminPaymentMethodRemove.Visible = false;
            btn_AdminPaymentMethodRemove.Click += btn_AdminPaymentMethodRemove_Click;
            // 
            // btn_AdminPaymentMethodUpdate
            // 
            btn_AdminPaymentMethodUpdate.BackColor = Color.DodgerBlue;
            btn_AdminPaymentMethodUpdate.Cursor = Cursors.Hand;
            btn_AdminPaymentMethodUpdate.FlatAppearance.BorderSize = 0;
            btn_AdminPaymentMethodUpdate.FlatAppearance.MouseDownBackColor = Color.DodgerBlue;
            btn_AdminPaymentMethodUpdate.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_AdminPaymentMethodUpdate.FlatStyle = FlatStyle.Flat;
            btn_AdminPaymentMethodUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdminPaymentMethodUpdate.ForeColor = Color.White;
            btn_AdminPaymentMethodUpdate.Image = Properties.Resources.IconUpdateAdmin;
            btn_AdminPaymentMethodUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AdminPaymentMethodUpdate.Location = new Point(490, 168);
            btn_AdminPaymentMethodUpdate.Name = "btn_AdminPaymentMethodUpdate";
            btn_AdminPaymentMethodUpdate.Size = new Size(104, 53);
            btn_AdminPaymentMethodUpdate.TabIndex = 102;
            btn_AdminPaymentMethodUpdate.Text = "Update";
            btn_AdminPaymentMethodUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AdminPaymentMethodUpdate.UseVisualStyleBackColor = false;
            btn_AdminPaymentMethodUpdate.Visible = false;
            btn_AdminPaymentMethodUpdate.Click += btn_AdminPaymentMethodUpdate_Click;
            // 
            // btn_AdminPaymentMethodAdd
            // 
            btn_AdminPaymentMethodAdd.BackColor = Color.LimeGreen;
            btn_AdminPaymentMethodAdd.Cursor = Cursors.Cross;
            btn_AdminPaymentMethodAdd.FlatAppearance.BorderSize = 0;
            btn_AdminPaymentMethodAdd.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btn_AdminPaymentMethodAdd.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_AdminPaymentMethodAdd.FlatStyle = FlatStyle.Flat;
            btn_AdminPaymentMethodAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AdminPaymentMethodAdd.ForeColor = Color.White;
            btn_AdminPaymentMethodAdd.Image = Properties.Resources.IconPaymentMethodAdd;
            btn_AdminPaymentMethodAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AdminPaymentMethodAdd.Location = new Point(345, 168);
            btn_AdminPaymentMethodAdd.Name = "btn_AdminPaymentMethodAdd";
            btn_AdminPaymentMethodAdd.Size = new Size(104, 53);
            btn_AdminPaymentMethodAdd.TabIndex = 101;
            btn_AdminPaymentMethodAdd.Text = "Add ";
            btn_AdminPaymentMethodAdd.TextAlign = ContentAlignment.MiddleRight;
            btn_AdminPaymentMethodAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_AdminPaymentMethodAdd.UseVisualStyleBackColor = false;
            btn_AdminPaymentMethodAdd.Visible = false;
            btn_AdminPaymentMethodAdd.Click += btn_AdminPaymentMethodAdd_Click;
            // 
            // AdminPaymentMethod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 251, 244);
            ClientSize = new Size(999, 307);
            Controls.Add(btn_AdminPaymentMethodRemove);
            Controls.Add(btn_AdminPaymentMethodUpdate);
            Controls.Add(btn_AdminPaymentMethodAdd);
            Controls.Add(dgv_AdminPaymentMethod);
            Controls.Add(txt_AdminPaymentMethod);
            Controls.Add(lb_AdminPaymentMethod);
            Name = "AdminPaymentMethod";
            Text = "AdminPaymentMethod";
            Load += AdminPaymentMethod_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_AdminPaymentMethod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv_AdminPaymentMethod;
        private DataGridViewImageColumn icon;
        private TextBox txt_AdminPaymentMethod;
        private Label lb_AdminPaymentMethod;
        private Button btn_AdminPaymentMethodRemove;
        private Button btn_AdminPaymentMethodUpdate;
        private Button btn_AdminPaymentMethodAdd;
    }
}