namespace ProjectHospitalSystem.Reports
{
    partial class Reports_Logging
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
            btn_RepNumberPatient = new Button();
            btn_RepSechedule = new Button();
            btn_RepOutstandPay = new Button();
            btn_RepVistHist = new Button();
            SuspendLayout();
            // 
            // btn_RepNumberPatient
            // 
            btn_RepNumberPatient.Location = new Point(12, 56);
            btn_RepNumberPatient.Name = "btn_RepNumberPatient";
            btn_RepNumberPatient.Size = new Size(253, 81);
            btn_RepNumberPatient.TabIndex = 0;
            btn_RepNumberPatient.Text = "Number of patients per department";
            btn_RepNumberPatient.UseVisualStyleBackColor = true;
            btn_RepNumberPatient.Click += btn_RepNumberPatient_Click;
            // 
            // btn_RepSechedule
            // 
            btn_RepSechedule.Location = new Point(326, 56);
            btn_RepSechedule.Name = "btn_RepSechedule";
            btn_RepSechedule.Size = new Size(251, 81);
            btn_RepSechedule.TabIndex = 1;
            btn_RepSechedule.Text = "Appointment schedules ";
            btn_RepSechedule.UseVisualStyleBackColor = true;
            btn_RepSechedule.Click += btn_RepSechedule_Click;
            // 
            // btn_RepOutstandPay
            // 
            btn_RepOutstandPay.Location = new Point(12, 172);
            btn_RepOutstandPay.Name = "btn_RepOutstandPay";
            btn_RepOutstandPay.Size = new Size(253, 87);
            btn_RepOutstandPay.TabIndex = 2;
            btn_RepOutstandPay.Text = "Outstanding payments ";
            btn_RepOutstandPay.UseVisualStyleBackColor = true;
            btn_RepOutstandPay.Click += btn_RepOutstandPay_Click;
            // 
            // btn_RepVistHist
            // 
            btn_RepVistHist.Location = new Point(326, 172);
            btn_RepVistHist.Name = "btn_RepVistHist";
            btn_RepVistHist.Size = new Size(251, 87);
            btn_RepVistHist.TabIndex = 3;
            btn_RepVistHist.Text = "Patient visit history ";
            btn_RepVistHist.UseVisualStyleBackColor = true;
            btn_RepVistHist.Click += btn_RepVistHist_Click;
            // 
            // Reports_Logging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 373);
            Controls.Add(btn_RepVistHist);
            Controls.Add(btn_RepOutstandPay);
            Controls.Add(btn_RepSechedule);
            Controls.Add(btn_RepNumberPatient);
            Name = "Reports_Logging";
            Text = "Reports_Logging";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_RepNumberPatient;
        private Button btn_RepSechedule;
        private Button btn_RepOutstandPay;
        private Button btn_RepVistHist;
    }
}