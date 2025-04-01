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
    public partial class PaitenitCRUD : Form
    {
        User _user;
        HospitalSystemContext _context;
        SqlConnection con;
        private int _selectedPatientId;
        public PaitenitCRUD(User user)
        {
            InitializeComponent();
            _user = user;
            _context = new HospitalSystemContext();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }
        #region Data Loading and Initialization
        private async Task LoadDataAsync()
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString))
                {
                    await connection.OpenAsync();
                    var patients = await connection.QueryAsync<Patient>(@"
                SELECT p.PatientId, p.FirstName, p.LastName, p.DateOfBirth, p.Gender, p.Email, p.Address, p.MedicalHistory, 
                       p.PhoneNumber 
                FROM Patients p");
                    var result = patients.Select(p => new
                    {
                        p.PatientId,
                        p.FirstName,
                        p.LastName,
                        p.DateOfBirth,
                        p.Gender,
                        p.Email,
                        p.PhoneNumber,
                        p.Address,
                        p.MedicalHistory,
                    }).ToList();

                    dgv_AdminPaitent.DataSource = result;
                    dgv_AdminPaitent.Columns["PatientId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }
        #endregion
        #region Form Population and Gender Handling
        private void PopulateFormWithPatientData(Patient patient)
        {
            txt_Fname.Text = patient.FirstName;
            txt_Lname.Text = patient.LastName;
            txt_Email.Text = patient.Email;
            txt_Address.Text = patient.Address;
            txt_phone.Text = patient.PhoneNumber;
            dtp_BirthDate.Value = patient.DateOfBirth;

            SetGender(patient.Gender);
            SetMedicalHistory(patient.MedicalHistory);
        }
        private void SetGender(string gender)
        {
            rb_Male.Checked = gender == "Male";
            rb_Female.Checked = gender == "Female";
        }
        #endregion
        #region Event Handlers
        private void AdminPatientCRUD_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataAsync();
                SetButtonVisibility(isAddMode: true, _user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_AddDoctor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                if (IsPatientNameExists(txt_Fname.Text.Trim(), txt_Lname.Text.Trim()))
                {
                    MessageBox.Show("A patient with the same name already exists.",
                                  "Duplicate Patient",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var patient = new Patient
                {
                    FirstName = txt_Fname.Text.Trim(),
                    LastName = txt_Lname.Text.Trim(),
                    DateOfBirth = dtp_BirthDate.Value.Date,
                    MedicalHistory = GetMedicalHistory(),
                    Gender = rb_Male.Checked ? "Male" : rb_Female.Checked ? "Female" : "Other",
                    Email = txt_Email.Text.Trim(),
                    PhoneNumber = txt_phone.Text,
                    Address = txt_Address.Text.Trim(),
                };
                _context.Patients.Add(patient);
                _context.SaveChanges();
                LoadDataAsync();
                ClearFields();

                MessageBox.Show("Patient added successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.InnerException}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void c_box_otherChronic_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherChronic.Visible = c_box_otherChronic.Checked;
            if (!c_box_otherChronic.Checked) txt_otherChronic.Clear();
        }

        private void c_box_otherSurgical_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherSurgical.Visible = c_box_otherSurgical.Checked;
            if (!c_box_otherSurgical.Checked) txt_otherSurgical.Clear();
        }
        private void c_box_otherInfectious_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherInfectious.Visible = c_box_otherInfectious.Checked;
            if (!c_box_otherInfectious.Checked) txt_otherInfectious.Clear();
        }
        private void c_box_otherAllergies_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherAllergies.Visible = c_box_otherAllergies.Checked;
            if (!c_box_otherAllergies.Checked) txt_otherAllergies.Clear();
        }
        private void c_box_otherFactors_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherFactor.Visible = c_box_otherFactors.Checked;
            if (!c_box_otherFactors.Checked) txt_otherFactor.Clear();
        }
        private void dgv_AdminPaitent_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv_AdminPaitent.Rows.Count)
            {
                MessageBox.Show("Please select a valid patient from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ClearFields();

                var selectedRow = dgv_AdminPaitent.Rows[e.RowIndex];
                var patientIdCell = selectedRow.Cells["PatientId"];

                if (patientIdCell == null || patientIdCell.Value == null)
                {
                    MessageBox.Show("Patient ID not found in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _selectedPatientId = Convert.ToInt32(patientIdCell.Value);
                var patient = _context.Patients.SingleOrDefault(n => n.PatientId == _selectedPatientId);

                if (patient != null)
                {
                    PopulateFormWithPatientData(patient);
                    SetButtonVisibility(isAddMode: false, _user);
                }
                else
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs()) return;

                var patient = _context.Patients.SingleOrDefault(n => n.PatientId == _selectedPatientId);
                if (patient == null)
                {
                    MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (IsPatientNameExists(txt_Fname.Text, txt_Lname.Text, _selectedPatientId))
                {
                    MessageBox.Show("A patient with the same name already exists.", "Duplicate Patient",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!HasChanges(patient))
                {
                    MessageBox.Show("No changes detected. Update skipped.", "Info",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                UpdatePatientData(patient);
                _context.SaveChanges();
                LoadDataAsync();
                ClearFields();
                MessageBox.Show("Patient updated successfully.", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetButtonVisibility(isAddMode: true, _user);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database error: {dbEx.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating patient: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePatientData(Patient patient)
        {
            patient.FirstName = txt_Fname.Text;
            patient.LastName = txt_Lname.Text;
            patient.DateOfBirth = dtp_BirthDate.Value;
            patient.MedicalHistory = GetMedicalHistory();
            patient.Email = txt_Email.Text;
            patient.Address = txt_Address.Text;
            patient.PhoneNumber = txt_phone.Text;
            patient.Gender = rb_Male.Checked ? "Male" : rb_Female.Checked ? "Female" : "Other";
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this patient?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var patient = _context.Patients.SingleOrDefault(n => n.PatientId == _selectedPatientId);

                    if (patient != null)
                    {
                        _context.Patients.Remove(patient);
                        _context.SaveChanges();
                        MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SetButtonVisibility(isAddMode: true, _user);
                        LoadDataAsync();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (DbUpdateException ex)
                {
                    if (ex.InnerException != null && ex.InnerException.Message.Contains("REFERENCE constraint"))
                    {
                        MessageBox.Show("This patient cannot be deleted because they have associated records (appointments, prescriptions, etc.).",
                                       "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Error deleting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private async void txtBoxPatientSerachData_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtBoxPatientSerachData.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                await LoadDataAsync();
                return;
            }

            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString))
                {
                    await connection.OpenAsync();
                    var filteredPatients = connection.Query<Patient>(
                        @"SELECT p.PatientId, p.FirstName, p.LastName, p.DateOfBirth, p.Gender, p.Email, p.Address, p.MedicalHistory, 
                         p.PhoneNumber 
                        FROM Patients p
						where ( p.FirstName LIKE '%'+@SearchText+'%'OR
						p.LastName LIKE '%' + @SearchText + '%')",
                        new { SearchText = searchText });
                    var result = filteredPatients.Select(p => new
                    {
                        p.PatientId,
                        p.FirstName,
                        p.LastName,
                        p.DateOfBirth,
                        p.Gender,
                        p.Email,
                        p.PhoneNumber,
                        p.Address,
                        p.MedicalHistory,
                    }).ToList();
                    dgv_AdminPaitent.DataSource = result;
                    dgv_AdminPaitent.Columns["PatientId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading filtered data: {ex.Message}");
            }
        }
        #endregion
        #region Medical History Categories
        private string GetMedicalHistory()
        {
            var medicalHistoryList = new List<string>();

            AddPredefinedConditions(medicalHistoryList);
            AddOtherConditions(medicalHistoryList);

            return string.Join(", ", medicalHistoryList);
        }
        private void AddPredefinedConditions(List<string> medicalHistoryList)
        {
            var predefinedConditions = new Dictionary<CheckBox, string>
            {
                { cbox_HeartBlood, "High Blood Pressure (Hypertension)" },
                { cbox_HeartDisease, "Heart Diseases" },
                { cbox_Diabetes, "Diabetes" },
                { cbox_Kindey, "Kidney Diseases" },
                { c_boxLiver, "Liver Diseases" },
                { c_boxRespiratory, "Respiratory Diseases (e.g., Asthma)" },
                { c_boxOpenHeartSurgery, "Open-Heart Surgery" },
                { c_boxAppendectomy, "Appendectomy (Appendix Removal)" },
                { c_boxEye, "Eye Surgery" },
                { c_boxCosmeticSurgery, "Cosmetic Surgery" },
                { checkBox16, "Other Surgery 1" },
                { checkBox17, "Other Surgery 2" },
                { c_boxHepatitis, "Hepatitis (A, B, or C)" },
                { c_boxHIVOrAIDS, "HIV/AIDS" },
                { c_boxTuberculosis, "Tuberculosis (TB)" },
                { c_box_covid19, "Previous COVID-19 Infection" },
                { c_boxDrugAllergies, "Drug Allergies" },
                { c_boxFoodAllergie, "Food Allergies" },
                { c_boxGeneticDiseases, "Genetic Diseases" },
                { c_boxDust, "Dust or Animal Allergies" },
                { cbox_Smoking, "Smoking" },
                { cb_Alcoho, "Alcohol Addiction" },
            };

            foreach (var condition in predefinedConditions)
            {
                if (condition.Key.Checked)
                {
                    medicalHistoryList.Add(condition.Value);
                }
            }
        }
        private void AddOtherConditions(List<string> medicalHistoryList)
        {
            var otherConditions = new Dictionary<CheckBox, Tuple<TextBox, string>>
            {
                { c_box_otherChronic, Tuple.Create(txt_otherChronic, "[Chronic]") },
                { c_box_otherSurgical, Tuple.Create(txt_otherSurgical, "[Surgical]") },
                { c_box_otherInfectious, Tuple.Create(txt_otherInfectious, "[Infectious]") },
                { c_box_otherAllergies, Tuple.Create(txt_otherAllergies, "[Allergies]") },
                { c_box_otherFactors, Tuple.Create(txt_otherFactor, "[Factors]") }
            };

            foreach (var condition in otherConditions)
            {
                if (condition.Key.Checked && !string.IsNullOrWhiteSpace(condition.Value.Item1.Text))
                {
                    medicalHistoryList.Add($"{condition.Value.Item2} {condition.Value.Item1.Text}");
                }
            }
        }
        #endregion
        #region Medical History Categories
        private void SetMedicalHistory(string medicalHistory)
        {
            ResetMedicalHistoryControls();

            if (string.IsNullOrWhiteSpace(medicalHistory))
                return;
            var conditions = medicalHistory.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            var conditionToCheckboxMap = new Dictionary<string, CheckBox>(StringComparer.OrdinalIgnoreCase)
    {
        { "High Blood Pressure (Hypertension)", cbox_HeartBlood },
        { "Heart Diseases", cbox_HeartDisease },
        { "Diabetes", cbox_Diabetes },
        { "Kidney Diseases", cbox_Kindey },
        { "Liver Diseases", c_boxLiver },
        { "Respiratory Diseases (e.g., Asthma)", c_boxRespiratory },
        { "Open-Heart Surgery", c_boxOpenHeartSurgery },
        { "Appendectomy (Appendix Removal)", c_boxAppendectomy },
        { "Eye Surgery", c_boxEye },
        { "Cosmetic Surgery", c_boxCosmeticSurgery },
        { "Other Surgery 1", checkBox16 },
        { "Other Surgery 2", checkBox17 },
        { "Hepatitis (A, B, or C)", c_boxHepatitis },
        { "HIV/AIDS", c_boxHIVOrAIDS },
        { "Tuberculosis (TB)", c_boxTuberculosis },
        { "Previous COVID-19 Infection", c_box_covid19 },
        { "Drug Allergies", c_boxDrugAllergies },
        { "Food Allergies", c_boxFoodAllergie },
        { "Genetic Diseases", c_boxGeneticDiseases },
        { "Dust or Animal Allergies", c_boxDust },
        { "Smoking", cbox_Smoking },
        { "Alcohol Addiction", cb_Alcoho }
    };

            foreach (var condition in conditions)
            {
                if (conditionToCheckboxMap.TryGetValue(condition.Trim(), out CheckBox checkbox))
                {
                    checkbox.Checked = true;
                    continue;
                }
                if (condition.Contains("[Chronic]"))
                {
                    c_box_otherChronic.Checked = true;
                    txt_otherChronic.Text = condition.Replace("[Chronic]", "").Trim();
                    continue;
                }
                if (condition.Contains("[Surgical]"))
                {
                    c_box_otherSurgical.Checked = true;
                    txt_otherSurgical.Text = condition.Replace("[Surgical]", "").Trim();
                    continue;
                }
                if (condition.Contains("[Infectious]"))
                {
                    c_box_otherInfectious.Checked = true;
                    txt_otherInfectious.Text = condition.Replace("[Infectious]", "").Trim();
                    continue;
                }
                if (condition.Contains("[Allergies]"))
                {
                    c_box_otherAllergies.Checked = true;
                    txt_otherAllergies.Text = condition.Replace("[Allergies]", "").Trim();
                    continue;
                }
                if (condition.Contains("[Factors]"))
                {
                    c_box_otherFactors.Checked = true;
                    txt_otherFactor.Text = condition.Replace("[Factors]", "").Trim();
                    continue;
                }
            }
            txt_otherChronic.Visible = c_box_otherChronic.Checked;
            txt_otherSurgical.Visible = c_box_otherSurgical.Checked;
            txt_otherInfectious.Visible = c_box_otherInfectious.Checked;
            txt_otherAllergies.Visible = c_box_otherAllergies.Checked;
            txt_otherFactor.Visible = c_box_otherFactors.Checked;
        }
        private void ResetMedicalHistoryControls()
        {
            foreach (var control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (var childControl in groupBox.Controls)
                    {
                        if (childControl is CheckBox checkBox)
                        {
                            checkBox.Checked = false;
                        }
                        else if (childControl is TextBox textBox && textBox.Name.StartsWith("txt_other"))
                        {
                            textBox.Clear();
                            textBox.Visible = false; 
                        }
                    }
                }
            }
        }
        private bool SetPredefinedCondition(string condition)
        {
            foreach (var control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (var childControl in groupBox.Controls)
                    {
                        if (childControl is CheckBox checkBox && checkBox.Text.Trim() == condition)
                        {
                            checkBox.Checked = true;
                            return true;
                        }
                    }
                }
            }

            return false;
        }
        private void AssignToFirstAvailableOtherTextbox(string condition)
        {
            var otherTextboxes = new[] { txt_otherChronic, txt_otherSurgical, txt_otherInfectious, txt_otherAllergies, txt_otherFactor };
            var otherCheckboxes = new[] { c_box_otherChronic, c_box_otherSurgical, c_box_otherInfectious, c_box_otherAllergies, c_box_otherFactors };

            for (int i = 0; i < otherTextboxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(otherTextboxes[i].Text))
                {
                    otherCheckboxes[i].Checked = true;
                    otherTextboxes[i].Text = condition;
                    return;
                }
            }
        }
        #endregion
        #region  Validate
        private bool ValidateInputs()
        {
            txt_Fname.Text = txt_Fname.Text.Trim();
            txt_Lname.Text = txt_Lname.Text.Trim();
            txt_Email.Text = txt_Email.Text.Trim();
            txt_phone.Text = txt_phone.Text.Trim();
            txt_Address.Text = txt_Address.Text.Trim();

            if (string.IsNullOrWhiteSpace(txt_Fname.Text) || txt_Fname.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid first name (at least 2 characters).",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Fname.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_Lname.Text) || txt_Lname.Text.Length < 2)
            {
                MessageBox.Show("Please enter a valid last name (at least 2 characters).",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Lname.Focus();
                return false;
            }

            if (!ValidateEmail(txt_Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_phone.Text) || !txt_phone.Text.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid phone number (digits only).",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phone.Focus();
                return false;
            }

            if (dtp_BirthDate.Value > DateTime.Today.AddYears(-5) ||
                dtp_BirthDate.Value < DateTime.Today.AddYears(-120))
            {
                MessageBox.Show("Please select a valid birth date (between 5 and 120 years ago).",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_BirthDate.Focus();
                return false;
            }

            if (!rb_Male.Checked && !rb_Female.Checked)
            {
                MessageBox.Show("Please select a gender.",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateCheckBoxGroups())
            {
                MessageBox.Show("Please select at least one option from each medical history category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidateCheckBoxGroups()
        {
            return ValidateCheckBoxGroup(gb_ChronicDiseases) &&
                   ValidateCheckBoxGroup(gb_SurgicalHistory) &&
                   ValidateCheckBoxGroup(gb_InfectiousDiseases) &&
                   ValidateCheckBoxGroup(gb_AllergieGenetic) &&
                   ValidateCheckBoxGroup(gb_OtherFactor);
        }
        private bool ValidateCheckBoxGroup(GroupBox groupBox) => groupBox.Controls.OfType<CheckBox>().Any(checkBox => checkBox.Checked);
        public bool ValidateEmail(string email) 
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email)) return false;

                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email &&
                       email.Contains(".") &&
                       email.IndexOf('@') > 0 &&
                       email.IndexOf('@') < email.LastIndexOf('.');
            }
            catch
            {
                return false;
            }
        }
        private bool IsPatientNameExists(string firstName, string lastName, int? excludePatientId = null)
        {
            var query = _context.Patients
         .Where(p => p.FirstName.ToLower() == firstName.ToLower() &&
                     p.LastName.ToLower() == lastName.ToLower());

            if (excludePatientId.HasValue)
            {
                query = query.Where(p => p.PatientId != excludePatientId.Value);
            }

            return query.Any();
        }
        private bool HasChanges(Patient patient)
        {
            return patient.FirstName != txt_Fname.Text ||
                   patient.LastName != txt_Lname.Text ||
                   patient.DateOfBirth != dtp_BirthDate.Value ||
                   patient.Gender != (rb_Male.Checked ? "Male" : "Female") ||
                   patient.Email != txt_Email.Text ||
                   patient.PhoneNumber != txt_phone.Text ||
                   patient.Address != txt_Address.Text ||
                   HasMedicalHistoryChanged(patient);
        }
        private bool HasMedicalHistoryChanged(Patient patient)
        {
            var currentHistory = GetMedicalHistory();
            if (string.IsNullOrEmpty(patient.MedicalHistory))
                return !string.IsNullOrEmpty(currentHistory);
            if (string.IsNullOrEmpty(currentHistory))
                return !string.IsNullOrEmpty(patient.MedicalHistory);
            var existing = patient.MedicalHistory.Split(',').Select(s => s.Trim()).ToHashSet(StringComparer.OrdinalIgnoreCase);
            var updated = currentHistory.Split(',').Select(s => s.Trim()).ToHashSet(StringComparer.OrdinalIgnoreCase);

            return !existing.SetEquals(updated);
        }
        #endregion
        #region Clear Fields Reload Forms
        private void ClearFields()
        {
            ClearControls(this);

            dtp_BirthDate.Value = DateTime.Today;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            ClearTextBox();
            btn_AddPaitenit.Visible= true;
            btn_Update.Visible = false;
            btn_remove.Visible = false;
        }
        private void ClearControls(Control control)
        {
            if (control is TextBox textBox)
            {
                textBox.Clear();
            }
            else if (control is CheckBox checkBox)
            {
                checkBox.Checked = false;
            }
            foreach (Control childControl in control.Controls)
            {
                ClearControls(childControl);
            }
        }
        private void ClearTextBox() 
        {
            txt_Fname.Clear();
            txt_Lname.Clear();
            txt_phone.Clear();
            txt_Address.Clear();
            txt_Email.Clear();
            txt_otherChronic.Clear();
            txt_otherSurgical.Clear();
            txt_otherInfectious.Clear();
            txt_otherAllergies.Clear();
            txt_otherFactor.Clear();
        }
       
        public void Reload()
        {
            ClearFields();
            LoadDataAsync();
        }

        #endregion
        #region vistbilty
        private void SetButtonVisibility(bool isAddMode,User user)
        {
            btn_AddPaitenit.Visible = isAddMode;
            btn_Update.Visible = !isAddMode;
            btn_remove.Visible = !isAddMode;
            if(user.Role == "Receptionist")
            {
                btn_remove.Visible = false;
            }
        }
#endregion
    }
}
