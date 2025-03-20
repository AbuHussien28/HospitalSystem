using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ProjectHospitalSystem.Forms.Receptionist.Services;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static DevExpress.XtraBars.Painters.PrimitivesPainterWindowsXP;

namespace ProjectHospitalSystem.Forms.Receptionist
{
    public partial class Bills : Form
    {
        HospitalSystemContext db;
        ExportToWordData exportWord ;

        public Bills()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            exportWord = new ExportToWordData(db);
        }

        private void UpdateLateFees()
        {
            var overdueBills = db.Bills
                .Where(b => b.Status == BillStatus.unPaid && b.DueDate < DateTime.Now)
                .ToList();

            foreach (var bill in overdueBills)
            {
                if (bill.LateFee == null || bill.LateFee == 0)
                {
                    bill.LateFee = bill.OriginalAmount * 0.1m;
                }
                bill.Status = BillStatus.Expired;
            }

            db.SaveChanges();
        }

        private void LoadBills()
        {
            var bills = db.Bills
                .Select(b => new
                {
                    b.BillId,
                    PatientName = b.Patient.FullName,
                    GeneratedDate = b.GenertedDate,
                    b.DueDate,
                    Department = b.Department.DeptName,
                    Doctor = b.Appointment.Doctor.User.FName + " " + b.Appointment.Doctor.User.LName,
                    b.Status,
                    b.OriginalAmount,
                    b.LateFee,
                    b.TotalAmount,
                    TotalPaid = b.Payments.Sum(p => p.AmountPaid),
                    RemainingBalance = b.TotalAmount - b.Payments.Sum(p => p.AmountPaid)
                })
                .ToList();

            dgv_Bills.DataSource = bills;
            dgv_Bills.Columns["BillId"].Visible = false;
        }

        private void LoadDepartments()
        {
            var departments = db.Departments
                                .OrderBy(d => d.DeptName)
                                .Select(d => new { d.DeptId, d.DeptName })
                                .ToList();

            cob_searDept.DataSource = departments;
            cob_searDept.DisplayMember = "DeptName";
            cob_searDept.ValueMember = "DeptId";
            cob_searDept.SelectedIndex = -1;
        }

        private void LoadPatientsByDepartment()
        {
            if (cob_searDept.SelectedIndex != -1)
            {
                if (cob_searDept.SelectedValue is int selectedDeptId)
                {
                    var patients = db.Patients
                        .Where(p => p.Appointment.Any(a => a.Doctor.DeptId == selectedDeptId))
                        .Select(p => new { p.PatientId, p.FullName })
                        .Distinct()
                        .ToList();

                    if (patients.Count == 0)
                    {
                        MessageBox.Show("No patients found for the selected department.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cob_patient.DataSource = null;
                    }
                    else
                    {
                        cob_patient.DataSource = patients;
                        cob_patient.DisplayMember = "FullName";
                        cob_patient.ValueMember = "PatientId";
                        cob_patient.SelectedIndex = -1;
                    }
                }
            }
            else
            {
                LoadAllPatients();
            }

        }

        private void LoadAllPatients()
        {
            var allPatients = db.Patients
         .Select(p => new { p.PatientId, p.FullName })
         .ToList();

            if (allPatients.Count == 0)
            {
                MessageBox.Show("No patients found in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cob_patient.DataSource = null;
            }
            else
            {
                cob_patient.DataSource = allPatients;
                cob_patient.DisplayMember = "FullName";
                cob_patient.ValueMember = "PatientId";
                cob_patient.SelectedIndex = -1;
            }
        }

        private void LoadBillsByFilters()
        {
            var query = db.Bills.AsQueryable();


            if (cob_patient.SelectedIndex != -1 && cob_patient.SelectedValue != null)
            {
                if (int.TryParse(cob_patient.SelectedValue.ToString(), out int selectedPatientId))
                {

                    query = query.Where(b => b.PatientId == selectedPatientId);
                }
            }

            var filteredBills = query
                .Select(b => new
                {
                    b.BillId,
                    PatientName = b.Patient.FullName,
                    Department = b.Department.DeptName,
                    Doctor = b.Appointment.Doctor.User.FName + " " + b.Appointment.Doctor.User.LName,
                    b.OriginalAmount,
                    b.LateFee,
                    b.TotalAmount,
                    GeneratedDate = b.GenertedDate,
                    DueDate = b.DueDate,
                    b.Status,
                    TotalPaid = b.Payments.Sum(p => p.AmountPaid),
                    RemainingBalance = b.TotalAmount - b.Payments.Sum(p => p.AmountPaid)
                })
                .ToList();


            dgv_Bills.DataSource = filteredBills;
            dgv_Bills.Columns["BillId"].Visible = false;
            //dgv_Bills.Refresh();

        }
        public void LoadBillsData()
        {
            using (var db = new HospitalSystemContext())
            {
                dgv_Bills.DataSource = db.Bills
                    .Select(b => new
                    {
                        b.BillId,
                        PatientName = b.Patient.FullName,
                        Department = b.Department.DeptName,
                        Doctor = b.Appointment.Doctor.User.FName + " " + b.Appointment.Doctor.User.LName,
                        GeneratedDate = b.GenertedDate,
                        DueDate = b.DueDate,
                        b.OriginalAmount,
                        b.LateFee,
                        b.TotalAmount,
                        TotalPaid = b.Payments.Sum(p => p.AmountPaid),
                        RemainingBalance = b.TotalAmount - b.Payments.Sum(p => p.AmountPaid),
                        b.Status
                    })
                    .ToList();
                dgv_Bills.Columns["BillId"].Visible = false;
            }
        }
        private void Bills_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            UpdateLateFees();
            LoadBills();
            LoadAllPatients();
        }

        private void cob_searDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatientsByDepartment();
            LoadBillsByFilters();
        }
        private void cob_patient_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadBillsByFilters();
        }

        private void dgv_Bills_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv_Bills.Rows[e.RowIndex] != null)
            {
                DataGridViewRow row = dgv_Bills.Rows[e.RowIndex];

                string status = row.Cells["Status"]?.Value?.ToString() ?? "";
                txt_dept.Text = row.Cells["Department"]?.Value?.ToString() ?? "";
                txt_doc.Text = row.Cells["Doctor"]?.Value?.ToString() ?? "";
                txt_pat.Text = row.Cells["PatientName"]?.Value?.ToString() ?? "";
                txt_OAmount.Text = row.Cells["OriginalAmount"]?.Value?.ToString() ?? "";
                txt_LateFee.Text = row.Cells["LateFee"]?.Value?.ToString() ?? "";
                txt_total.Text = row.Cells["TotalAmount"]?.Value?.ToString() ?? "";
                txt_GenDate.Text = row.Cells["GeneratedDate"]?.Value?.ToString() ?? "";
                txt_Due.Text = row.Cells["DueDate"]?.Value?.ToString() ?? "";
                txt_tolPaid.Text = row.Cells["TotalPaid"]?.Value?.ToString() ?? "";
                txt_remain.Text = row.Cells["RemainingBalance"]?.Value?.ToString() ?? "";
                txt_status.Text = status;

                bool isPartiallyPaid = status.Equals("PartiallyPaid", StringComparison.OrdinalIgnoreCase);

                lab_tolPaid.Visible = isPartiallyPaid;
                txt_tolPaid.Visible = isPartiallyPaid;
                lab_Remain.Visible = isPartiallyPaid;
                txt_remain.Visible = isPartiallyPaid;
                pBoxRemainingBalance.Visible = isPartiallyPaid;
                pBoxTotalPaid.Visible = isPartiallyPaid;
                btnExportToWord.Enabled = true;

                if (isPartiallyPaid)
                {
                    txt_tolPaid.Text = row.Cells["TotalPaid"]?.Value?.ToString() ?? "";
                    txt_remain.Text = row.Cells["RemainingBalance"]?.Value?.ToString() ?? "";
                }
                else
                {
                    txt_tolPaid.Text = "";
                    txt_remain.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgv_Bills.SelectedRows.Count > 0)
            {
                int billId = Convert.ToInt32(dgv_Bills.SelectedRows[0].Cells["BillId"].Value);
                string status = dgv_Bills.SelectedRows[0].Cells["Status"].Value.ToString();

                if (status == "Paid")
                {
                    MessageBox.Show("This bill has already been paid.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Payment paymentForm = new Payment(billId);
                paymentForm.PaymentCompleted += () => LoadBillsData();
                paymentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a bill first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ResetForm()
        {
            txt_dept.Text = string.Empty;
            txt_doc.Text = string.Empty;
            txt_pat.Text = string.Empty;
            txt_OAmount.Text = string.Empty;
            txt_LateFee.Text = string.Empty;
            txt_total.Text = string.Empty;
            txt_GenDate.Text = string.Empty;
            txt_Due.Text = string.Empty;
            txt_status.Text = string.Empty;
            txt_tolPaid.Text = string.Empty;
            txt_remain.Text = string.Empty;
            lab_tolPaid.Visible = false;
            txt_tolPaid.Visible = false;
            lab_Remain.Visible = false;
            txt_remain.Visible = false;
            pBoxRemainingBalance.Visible = false;
            pBoxTotalPaid.Visible = false;
            cob_searDept.SelectedIndex = -1;
            cob_patient.SelectedIndex = -1;
            LoadDepartments();
            LoadAllPatients();
            LoadBills();
        }
        public void Reload() => ResetForm();

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dgv_Bills.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a bill to export.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int billId = Convert.ToInt32(dgv_Bills.SelectedRows[0].Cells["BillId"].Value);
                var selectedBill = db.Bills.FirstOrDefault(b => b.BillId == billId);

                if (selectedBill == null)
                {
                    MessageBox.Show("Selected bill not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Word Document (*.docx)|*.docx",
                    Title = "Export Bill to Word"
                };

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                string filePath = saveFileDialog.FileName;
                exportWord.ExportBillToWord(selectedBill, filePath);
                MessageBox.Show("Bill exported to Word successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

