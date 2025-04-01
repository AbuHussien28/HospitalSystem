using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class AdminPaymentMethod : Form
    {
        private HospitalSystemContext _context;
        int selectedPaymentMethodId;
        private SqlConnection SqlConnection;
        public AdminPaymentMethod()
        {
            InitializeComponent();
            _context = new HospitalSystemContext();
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }
        #region Form Load and Initialization
        private void AdminPaymentMethod_Load(object sender, EventArgs e)
        {
            SetButtonVisibility(true);
            LoadPaymentMethods();
        }
        #endregion
        #region Data Loading and Binding
        private void LoadPaymentMethods()
        {
            var getPaymentMethods = SqlConnection.Query<PaymentMethod>("SELECT * FROM PaymentMethods");
            dgv_AdminPaymentMethod.DataSource = getPaymentMethods.ToList();
            dgv_AdminPaymentMethod.Columns["paymentMethodId"].Visible = false;
            dgv_AdminPaymentMethod.Columns["Payments"].Visible = false;
        }
        #endregion
        #region Helper Method
        private void SetButtonVisibility(bool isAddMode)
        {
            btn_AdminPaymentMethodAdd.Visible = isAddMode;
            btn_AdminPaymentMethodUpdate.Visible = !isAddMode;
            btn_AdminPaymentMethodRemove.Visible = !isAddMode;
        }
        public void Reload()
        {
            txt_AdminPaymentMethod.Text = "";
            LoadPaymentMethods();
            SetButtonVisibility(true);
        }

        #endregion
        #region Event Handler
        private void btn_AdminPaymentMethodAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_AdminPaymentMethod.Text))
            {
                MessageBox.Show("Please enter a payment method name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (paymentMethodNameExists(txt_AdminPaymentMethod.Text))
            {
                MessageBox.Show($"Payment Method with name '{txt_AdminPaymentMethod.Text}' already exists!",
                "Duplicate Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PaymentMethod newPaymentMethod = new PaymentMethod
            {
                paymentMethodName = txt_AdminPaymentMethod.Text
            };
            _context.PaymentMethods.Add(newPaymentMethod);
            _context.SaveChanges();
            LoadPaymentMethods();
            txt_AdminPaymentMethod.Text = "";
            MessageBox.Show($"Added new PaymentMethod: {newPaymentMethod.paymentMethodName} Success");
        }
        private void btn_AdminPaymentMethodUpdate_Click(object sender, EventArgs e)
        {
            PaymentMethod updatedSelectedPaymentMethod = _context.PaymentMethods
                .Where(n => n.paymentMethodId == selectedPaymentMethodId)
                .FirstOrDefault();

            if (updatedSelectedPaymentMethod != null)
            {
                if (updatedSelectedPaymentMethod.paymentMethodName == txt_AdminPaymentMethod.Text)
                {
                    MessageBox.Show("No changes detected. Update skipped.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (_context.PaymentMethods.Any(p => p.paymentMethodName.ToLower() == txt_AdminPaymentMethod.Text.ToLower() && p.paymentMethodId != selectedPaymentMethodId))
                {
                    MessageBox.Show($"Payment Method with name '{txt_AdminPaymentMethod.Text}' already exists!",
                        "Duplicate Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                updatedSelectedPaymentMethod.paymentMethodName = txt_AdminPaymentMethod.Text;
                _context.SaveChanges();
                LoadPaymentMethods();
                txt_AdminPaymentMethod.Text = "";
                MessageBox.Show($"Updated PaymentMethod: {updatedSelectedPaymentMethod.paymentMethodName} Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetButtonVisibility(true);
            }
            else
            {
                MessageBox.Show("Payment Method not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_AdminPaymentMethodRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedPaymentMethodId == 0)
                {
                    MessageBox.Show("Please select a payment method to delete.",
                        "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var paymentMethodToDelete = _context.PaymentMethods
                    .FirstOrDefault(p => p.paymentMethodId == selectedPaymentMethodId);

                if (paymentMethodToDelete == null)
                {
                    MessageBox.Show("Payment method not found.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool isUsedInPayments = _context.payments
                    .Any(p => p.PaymentMethodId == selectedPaymentMethodId);

                if (isUsedInPayments)
                {
                    MessageBox.Show($"Cannot delete '{paymentMethodToDelete.paymentMethodName}' because it's being used in existing payments.",
                        "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the payment method: {paymentMethodToDelete.paymentMethodName}?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    _context.PaymentMethods.Remove(paymentMethodToDelete);
                    _context.SaveChanges();
                    LoadPaymentMethods();
                    txt_AdminPaymentMethod.Clear();
                    SetButtonVisibility(true);

                    MessageBox.Show($"Payment method '{paymentMethodToDelete.paymentMethodName}' was deleted successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException dbEx)
            {
                string errorMessage = dbEx.InnerException != null
                    ? dbEx.InnerException.Message
                    : dbEx.Message;

                MessageBox.Show($"Database error while deleting payment method:\n{errorMessage}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgv_AdminPaymentMethod_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedPaymentMethodId = Convert.ToInt32(dgv_AdminPaymentMethod.Rows[e.RowIndex].Cells["paymentMethodId"].Value);
            PaymentMethod selectedPayment = _context.PaymentMethods.Where(n => n.paymentMethodId == selectedPaymentMethodId).FirstOrDefault();
            if (selectedPayment != null)
                txt_AdminPaymentMethod.Text = selectedPayment.paymentMethodName;
            SetButtonVisibility(false);
        }
        #endregion
        #region Validation
        private bool paymentMethodNameExists(string paymentMethodName) => _context.PaymentMethods.Any(p => p.paymentMethodName.ToLower() == paymentMethodName.ToLower());
        #endregion
    }
}
