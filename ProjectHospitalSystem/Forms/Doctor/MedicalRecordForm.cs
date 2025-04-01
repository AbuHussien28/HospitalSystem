using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Doctor
{
    public partial class MedicalRecordForm : Form
    {
        #region Fields and Constructor
        private HospitalSystemContext _context;
        private int _currentDoctorId;
        public MedicalRecordForm(int doctorId)
        {
            InitializeComponent();
            _context = new HospitalSystemContext();
            _currentDoctorId = doctorId;
        }
        #endregion
        #region Form Events
        private void MedicalRecordForm_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;
            LoadInitialData();
            btnFilter.Visible = true;
            btnReset.Visible = false;
        }
        #endregion
        #region Data Loading Methods
        private void LoadInitialData()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                LoadMedicalRecords(applyFilters: false);
                LoadPatientNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Initialization error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void LoadMedicalRecords(bool applyFilters = true)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dgvMedicalRecords.DataSource = null;
                var doctor = _context.Doctors
                    .Include(d => d.Dept)
                    .FirstOrDefault(d => d.DoctorDetailsId == _currentDoctorId);

                if (doctor?.Dept == null)
                {
                    MessageBox.Show("Doctor department information not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var query = _context.MedicalRecords
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Patient)
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Doctor)
                            .ThenInclude(d => d.Dept)
                    .Where(m => m.Appointments.Doctor.Dept.DeptId == doctor.Dept.DeptId);
                if (applyFilters)
                {
                    if (dtpFromDate.Checked && dtpToDate.Checked)
                    {
                        query = query.Where(m => m.DateOfVist >= dtpFromDate.Value &&
                                               m.DateOfVist <= dtpToDate.Value);
                    }
                    if (cbPatientName.SelectedItem != null &&
                        !string.IsNullOrWhiteSpace(cbPatientName.SelectedItem.ToString()))
                    {
                        var selectedName = cbPatientName.SelectedItem.ToString();
                        query = query.Where(m =>
                            (m.Appointments.Patient.FirstName + " " + m.Appointments.Patient.LastName) == selectedName);
                    }
                }
                var displayData = query
                    .OrderByDescending(m => m.DateOfVist)
                    .Select(m => new
                    {
                        m.MedicalId,
                        PatientName = m.Appointments.Patient.FirstName + " " + m.Appointments.Patient.LastName,
                        VisitDate = m.DateOfVist.ToString("yyyy-MM-dd HH:mm"),
                        m.Diaqnois,
                        Prescription = m.Prescription,
                        DoctorName = m.Appointments.Doctor.User.FName + " " + m.Appointments.Doctor.User.LName,
                        Department = m.Appointments.Doctor.Dept.DeptName,
                        AppointmentTime = m.Appointments.AppointmentDateTime.ToString("yyyy-MM-dd HH:mm")
                    })
                    .ToList();
                if (displayData.Count == 0)
                {
                    MessageBox.Show("Not Medical Record for this Period ");
                    return;
                }
                dgvMedicalRecords.DataSource = displayData;
                FormatDataGridViewColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medical records: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private void FormatDataGridViewColumns()
        {
            if (dgvMedicalRecords.Columns.Count == 0) return;

            dgvMedicalRecords.Columns["MedicalId"].Visible = false;
            dgvMedicalRecords.Columns["Diaqnois"].HeaderText = "Diagnosis";
            dgvMedicalRecords.Columns["VisitDate"].HeaderText = "Visit Date";
            dgvMedicalRecords.Columns["PatientName"].HeaderText = "Patient";
            dgvMedicalRecords.Columns["DoctorName"].HeaderText = "Doctor";
            dgvMedicalRecords.Columns["AppointmentTime"].HeaderText = "Appointment Time";
            dgvMedicalRecords.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }
        private void LoadPatientNames()
        {
            try
            {
                cbPatientName.Items.Clear();
                cbPatientName.Items.Add("");

                var doctor = _context.Doctors
                    .Include(d => d.Dept)
                    .FirstOrDefault(d => d.DoctorDetailsId == _currentDoctorId);

                if (doctor?.Dept == null) return;

                var patientNames = _context.MedicalRecords
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Patient)
                    .Include(m => m.Appointments)
                        .ThenInclude(a => a.Doctor)
                    .Where(m => m.Appointments.Doctor.Dept.DeptId == doctor.Dept.DeptId)
                    .Select(m => m.Appointments.Patient.FirstName + " " + m.Appointments.Patient.LastName)
                    .Distinct()
                    .OrderBy(name => name)
                    .ToList();

                foreach (var name in patientNames)
                {
                    cbPatientName.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patient names: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Button Click Handlers
        private void btnFilter_Click(object sender, EventArgs e) 
        {
            LoadMedicalRecords(applyFilters: true);
            btnFilter.Visible = false;
            btnReset.Visible = true;
        } 
        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;
            cbPatientName.SelectedIndex = -1;
            btnFilter.Visible = true;
            btnReset.Visible = false;
            LoadMedicalRecords(applyFilters: false);

        }
        #endregion

        #region Medical Record Details Handling
        private void ShowMedicalRecordDetails(int medicalId)
        {
            try
            {
                using (var detailForm = new MedicalRecordDetailForm(medicalId))
                {
                    detailForm.ShowDialog();
                    LoadMedicalRecords(applyFilters: true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing details: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvMedicalRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMedicalRecords.Columns[e.ColumnIndex].Name == "btnDetails")
            {
                try
                {
                    var medicalId = (int)dgvMedicalRecords.Rows[e.RowIndex].Cells["MedicalId"].Value;
                    ShowMedicalRecordDetails(medicalId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error accessing record: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Reload Methods

        public void Reload()
        {
            try
            {
                ResetFilters();
                dgvMedicalRecords.DataSource = null;
                LoadInitialData();
                UpdateButtonStates();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to reload data: {ex.Message}",
                          "Error",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
            }
        }

        private void ResetFilters()
        {
            dtpFromDate.Value = DateTime.Now.AddDays(-30);
            dtpToDate.Value = DateTime.Now;
            cbPatientName.SelectedIndex = -1;
            cbPatientName.Text = string.Empty;
            dtpFromDate.Checked = false;
            dtpToDate.Checked = false;
        }

        private void UpdateButtonStates()
        {
            btnFilter.Visible = true;
            btnReset.Visible = false;
        }
        #endregion
    }
}
