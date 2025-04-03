using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Models.DTO;
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
    public partial class AdminDepartmentCRUD : Form
    {
        private HospitalSystemContext _context;
        private const int MaxDeptDescLength = 70;
        Department Dept;
        private SqlConnection connection;
        int deptSelectedId;
        public AdminDepartmentCRUD()
        {
            InitializeComponent();
            _context = new HospitalSystemContext();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }
        #region Event handler
        private void AdminDepartmentCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDoctors();
                LoadDepartmentData();
                SetButtonVisibility(isAddMode: true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_DepartmentFeeAdd_Click(object sender, EventArgs e)
        {

            if (!IsDoctorSelected())
            {
                MessageBox.Show("Please choose a managing doctor.");
                cb_DepartmentFDoctorName.Focus();
                return;
            }

            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            int selectedDoctorId = (int)cb_DepartmentFDoctorName.SelectedValue;

            if (!IsFeeValid())
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (_context.Departments.Any(d => d.DoctorMgnId == selectedDoctorId))
            {
                MessageBox.Show($"The selected doctor is already managing another department.",
                    "Doctor Already Assigned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_DepartmentDeptDesc.Text.Length > MaxDeptDescLength)
            {
                MessageBox.Show($"Description is too long. Maximum length is {MaxDeptDescLength} characters.");
                return;
            }
            if (DepartmentNameExists(txt_DepartmentDeptName.Text))
            {
                MessageBox.Show($"Department with name '{txt_DepartmentDeptName.Text}' already exists!",
                    "Duplicate Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //try
            //{
                var newDept = new Department
                {
                    DeptName = txt_DepartmentDeptName.Text,
                    Dept_Desc = txt_DepartmentDeptDesc.Text,
                    DoctorMgnId = selectedDoctorId,
                    FeeAmount =(decimal)nuValueDeptFee.Value
                };

                _context.Departments.Add(newDept);
                _context.SaveChanges();
                LoadDepartmentData();
                ClearFrom();
                MessageBox.Show("Department Added Successfully");

        //}
        //    catch (DbUpdateException dbEx)
        //    {
        //        MessageBox.Show($"Database Update Error: {dbEx.Message}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error adding department: {ex.Message}");
        //    }
        }

        private void btn_DepartmentFeeUpdate_Click(object sender, EventArgs e)
        {
            if (deptSelectedId == 0)
            {
                MessageBox.Show("Please select a department to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsFeeValid())
            {
                MessageBox.Show("Please enter a valid fee amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsDoctorSelected())
            {
                MessageBox.Show("Please choose a managing doctor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedDoctorId = (int)cb_DepartmentFDoctorName.SelectedValue;
            if (_context.Departments.Any(d => d.DoctorMgnId == selectedDoctorId && d.DeptId != deptSelectedId))
            {
                MessageBox.Show("The selected doctor is already managing another department.", "Doctor Already Assigned", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_context.Departments.Any(d => d.DeptName.ToLower() == txt_DepartmentDeptName.Text.ToLower() && d.DeptId != deptSelectedId))
            {
                MessageBox.Show($"A department with the name '{txt_DepartmentDeptName.Text}' already exists.", "Duplicate Department", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var department = _context.Departments.SingleOrDefault(d => d.DeptId == deptSelectedId);
                if (department != null)
                {
                    department.DeptName = txt_DepartmentDeptName.Text;
                    department.Dept_Desc = txt_DepartmentDeptDesc.Text;
                    department.DoctorMgnId = selectedDoctorId;
                    department.FeeAmount =(decimal) nuValueDeptFee.Value;

                    _context.SaveChanges();
                    LoadDepartmentData();
                    ClearFrom();
                    MessageBox.Show("Department updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetButtonVisibility(isAddMode: true);
                }
                else
                {
                    MessageBox.Show("Department not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the department: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_DepartmentFeeRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Department ?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Department dept = _context.Departments.SingleOrDefault(d => d.DeptId == deptSelectedId);
                if (!CanDeleteDepartment(deptSelectedId))
                {
                    MessageBox.Show("Cannot delete department because it has doctors or appointments assigned.",
                        "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dept != null)
                {
                    _context.Departments.Remove(dept);
                    _context.SaveChanges();
                    LoadDepartmentData();
                    ClearFrom();
                    MessageBox.Show($"Delete department: {dept.DeptName} Successfully");
                    SetButtonVisibility(isAddMode: true);
                }
            }
        }
        private async void txtBoxDepartmentSerachData_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBoxDepartmentSerachData.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                await LoadDepartmentData();
                return;
            }

            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString))
                {
                    await connection.OpenAsync();
                    var filteredDoctors = await connection.QueryAsync<DepartmentDTO>(
                        @"SELECT  d.DeptId,d.DeptName,d.Dept_Desc AS DeptDesc,d.FeeAmount,
                            COALESCE(u.FName + ' ' + u.LName, 'Not Assigned') AS ManagingDoctor
                        FROM Departments d
                        LEFT JOIN Doctors dm 
                            ON d.DoctorMgnId = dm.DoctorDetailsId
                        LEFT JOIN Users u 
                            ON dm.UserId = u.UserId
	                        where d.DeptName LIKE '%'+ @SearchText+'%'",
                        new { SearchText = searchText });

                    dgv_Department.DataSource = filteredDoctors.ToList();
                    dgv_Department.Columns["DeptId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading filtered data: {ex.Message}");
            }
        }
        private void dgv_Department_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                deptSelectedId = Convert.ToInt32(dgv_Department.Rows[e.RowIndex].Cells["DeptId"].Value);
                Department department = _context.Departments.SingleOrDefault(d => d.DeptId == deptSelectedId);
                if (department != null)
                {
                    LoadDoctors();
                    txt_DepartmentDeptName.Text = department.DeptName;
                    txt_DepartmentDeptDesc.Text = department.Dept_Desc;
                    nuValueDeptFee.Value =department.FeeAmount;
                    cb_DepartmentFDoctorName.SelectedValue = department.DoctorMgnId ?? -1;

                }
                SetButtonVisibility(isAddMode: false);
            }
        }

        #endregion
        #region Data Loading Methods
        private void LoadDoctors()
        {
            try
            {
                var doctors = connection.Query<dynamic>(@"
            SELECT d.DoctorDetailsId, u.FName + ' ' + u.LName AS FullName 
            FROM Doctors d
            INNER JOIN Users u ON d.UserId = u.UserId
            WHERE d.DoctorDetailsId NOT IN (
                SELECT DISTINCT DoctorMgnId 
                FROM Departments 
                WHERE DoctorMgnId IS NOT NULL
            )
            ORDER BY FullName").ToList();
                if (deptSelectedId != 0)
                {
                    var currentDept = _context.Departments.FirstOrDefault(d => d.DeptId == deptSelectedId);
                    if (currentDept != null && currentDept.DoctorMgnId.HasValue)
                    {
                        var currentManager = connection.QueryFirstOrDefault<dynamic>(@"
                    SELECT d.DoctorDetailsId, u.FName + ' ' + u.LName AS FullName 
                    FROM Doctors d
                    INNER JOIN Users u ON d.UserId = u.UserId
                    WHERE d.DoctorDetailsId = @DoctorId",
                            new { DoctorId = currentDept.DoctorMgnId.Value });

                        if (currentManager != null)
                        {
                            if (!doctors.Any(d => d.DoctorDetailsId == currentManager.DoctorDetailsId))
                            {
                                doctors = new List<dynamic>(doctors) { currentManager }.ToList();
                            }
                        }
                    }
                }

                cb_DepartmentFDoctorName.DataSource = doctors;
                cb_DepartmentFDoctorName.DisplayMember = "FullName";
                cb_DepartmentFDoctorName.ValueMember = "DoctorDetailsId";
                cb_DepartmentFDoctorName.SelectedIndex = -1;
                cb_DepartmentFDoctorName.Text = "Choose Doctor Manager";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task LoadDepartmentData()
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString))
                {
                    await connection.OpenAsync();
                    var departments = await connection.QueryAsync<DepartmentDTO>(@"
                 SELECT  d.DeptId,d.DeptName,d.Dept_Desc AS DeptDesc,d.FeeAmount,
                    COALESCE(u.FName + ' ' + u.LName, 'Not Assigned') AS ManagingDoctor
                FROM Departments d
                LEFT JOIN Doctors dm 
                    ON d.DoctorMgnId = dm.DoctorDetailsId
                LEFT JOIN Users u 
                    ON dm.UserId = u.UserId");
                    dgv_Department.DataSource = departments.ToList();
                    dgv_Department.Columns["DeptId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading department data: {ex.Message}");
            }
        }
        #endregion
        #region Validation Methods
        public bool ValidateInputs() => !string.IsNullOrWhiteSpace(txt_DepartmentDeptName.Text) &&
               !string.IsNullOrWhiteSpace(txt_DepartmentDeptDesc.Text);

        private bool IsFeeValid() => nuValueDeptFee.Value > 0.01m;
        private bool IsDoctorSelected()
        {
            return cb_DepartmentFDoctorName.SelectedIndex != -1 && cb_DepartmentFDoctorName.SelectedValue != null;
        }
        private bool DepartmentNameExists(string deptName) => _context.Departments.Any(d => d.DeptName.ToLower() == deptName.ToLower());
        #endregion
        #region Helper Methods
        private void ClearFrom()
        {
            txt_DepartmentDeptName.Text = txt_DepartmentDeptDesc.Text = txtBoxDepartmentSerachData.Text = string.Empty;
            nuValueDeptFee.Value = 0.01m;
            cb_DepartmentFDoctorName.SelectedIndex = -1;
            cb_DepartmentFDoctorName.Text = "Choose Doctor Manager";
            btn_DepartmentFeeAdd.Visible = true;
            btn_DepartmentFeeUpdate.Visible = false;
            btn_DepartmentFeeRemove.Visible = false;
        }
        private void SetButtonVisibility(bool isAddMode)
        {
            btn_DepartmentFeeAdd.Visible = isAddMode;
            btn_DepartmentFeeUpdate.Visible = !isAddMode;
            btn_DepartmentFeeRemove.Visible = !isAddMode;
        }
        public void Reload()
        {
            ClearFrom();
            LoadDepartmentData();
            LoadDoctors();
        }
        private bool CanDeleteDepartment(int departmentId)
        {
            return !_context.Doctors.Any(d => d.DeptId == departmentId) &&
                   !_context.Appointments.Any(a => a.Doctor.DeptId == departmentId);
        }
        #endregion



    } 
}
