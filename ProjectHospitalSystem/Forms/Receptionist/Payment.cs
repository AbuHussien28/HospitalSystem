using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class Payment : Form
    {
        private int billId;
        HospitalSystemContext db; public event Action PaymentCompleted;

        public Payment(int selectedBillId)
        {
            db = new HospitalSystemContext();
            InitializeComponent();
            billId = selectedBillId;
            txt_billid.Text = billId.ToString();
            dtppayment.Value = DateTime.Today;
            dtppayment.Enabled = false;
        }

        private void dtpBillDateTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            var paymentMethods = db.PaymentMethods
                                   .Select(pm => new { pm.paymentMethodId, pm.paymentMethodName })
                                   .ToList();
            var bill = db.Bills.Include(b => b.Payments).FirstOrDefault(b => b.BillId == billId);



            if (bill.Status == BillStatus.Paid)
            {
                btn_pay.Visible = false;
                MessageBox.Show("This bill is already paid in full.", "Payment Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn_pay.Visible = true;
            }


            cbPaymentMethod.DataSource = paymentMethods;
            cbPaymentMethod.DisplayMember = "paymentMethodName";
            cbPaymentMethod.ValueMember = "paymentMethodId";
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txt_DepartmentFeeAmountFee.Text, out decimal amountPaid) || amountPaid <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var bill = db.Bills.Include(b => b.Payments).FirstOrDefault(b => b.BillId == billId);
            if (bill == null)
            {
                MessageBox.Show("Bill not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbPaymentMethod.SelectedValue == null)
            {
                MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(cbPaymentMethod.SelectedValue.ToString(), out int paymentMethodId))
            {
                MessageBox.Show("Invalid payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPaidSoFar = bill.Payments.Sum(p => p.AmountPaid);
            decimal remainingAmount = bill.TotalAmount - totalPaidSoFar; 

            if (amountPaid > remainingAmount)
            {
                MessageBox.Show($"The maximum amount you can pay is {remainingAmount:C}.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProjectHospitalSystem.Models.Payment payment = new ProjectHospitalSystem.Models.Payment
            {
                BillId = billId,
                AmountPaid = amountPaid,
                PaymentDate = DateTime.Today,
                PaymentMethodId = paymentMethodId
            };

            try
            {
                db.payments.Add(payment);
                db.SaveChanges();

                totalPaidSoFar += amountPaid; 

           
                if (totalPaidSoFar >= bill.TotalAmount)
                {
                    bill.Status = BillStatus.Paid;
                }
                else
                {
                    bill.Status = BillStatus.PartiallyPaid;
                }

                db.SaveChanges();

                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PaymentCompleted?.Invoke();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving payment: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
    

