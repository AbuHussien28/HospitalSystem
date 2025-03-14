using Dapper;
using Microsoft.Data.SqlClient;
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
    public partial class AdminPatientCRUD : Form
    {
        User _user;
        HospitalSystemContext _context;
        SqlConnection con;
        private int _selectedPatientId;
        public AdminPatientCRUD(User user)
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
                SetButtonVisibility(isAddMode: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_AddDoctor_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            if (IsPatientNameExists(txt_Fname.Text, txt_Lname.Text))
            {
                MessageBox.Show("A patient with the same name already exists.", "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var patient = new Patient
            {
                FirstName = txt_Fname.Text,
                LastName = txt_Lname.Text,
                DateOfBirth = dtp_BirthDate.Value,
                MedicalHistory = GetMedicalHistory(),
                Gender = rb_Male.Checked ? "Male" : rb_Female.Checked ? "Female" : "Other",
                Email = txt_Email.Text,
                PhoneNumber = txt_phone.Text,
                Address = txt_Address.Text,
            };

            _context.Patients.Add(patient);
            _context.SaveChanges();
            LoadDataAsync();
            ClearFields();
        }
        private void c_box_otherChronic_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherChronic.Visible = c_box_otherChronic.Checked;
        }

        private void c_box_otherSurgical_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherSurgical.Visible = c_box_otherSurgical.Checked;
        }

        private void c_box_otherInfectious_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherInfectious.Visible = c_box_otherInfectious.Checked;
        }

        private void c_box_otherAllergies_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherAllergies.Visible = c_box_otherAllergies.Checked;
        }

        private void c_box_otherFactors_CheckedChanged(object sender, EventArgs e)
        {
            txt_otherFactor.Visible = c_box_otherFactors.Checked;
        }
        private void dgv_AdminPaitent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Ensure the row index is valid
            if (e.RowIndex < 0 || e.RowIndex >= dgv_AdminPaitent.Rows.Count)
            {
                MessageBox.Show("Please select a valid patient from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Clear the form fields before populating new data
                ClearFields();

                // Get the selected patient ID
                _selectedPatientId = Convert.ToInt32(dgv_AdminPaitent.Rows[e.RowIndex].Cells["PatientId"].Value);

                // Find the patient in the database
                var patient = _context.Patients.SingleOrDefault(n => n.PatientId == _selectedPatientId);

                if (patient != null)
                {
                    // Populate the form with the selected patient's data
                    PopulateFormWithPatientData(patient);

                    // Update button visibility (show Update and Remove buttons)
                    SetButtonVisibility(isAddMode: false);
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
            var patient = _context.Patients.SingleOrDefault(n => n.PatientId == _selectedPatientId);
            if (IsPatientNameExists(txt_Fname.Text, txt_Lname.Text, _selectedPatientId))
            {
                MessageBox.Show("A patient with the same name already exists.", "Duplicate Patient", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (patient != null)
            {
                UpdatePatientData(patient);
                _context.SaveChanges();
                LoadDataAsync();
                ClearFields();
                MessageBox.Show("Updated Done");
                SetButtonVisibility(isAddMode: true);
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
                var patient = _context.Patients.SingleOrDefault(n => n.PatientId == _selectedPatientId);

                if (patient != null)
                {
                    _context.Patients.Remove(patient);
                    _context.SaveChanges();
                    LoadDataAsync();
                    ClearFields();
                    MessageBox.Show("Deleted Done");
                    SetButtonVisibility(isAddMode: true);
                }
                else
                {
                    MessageBox.Show("Patient not found.");
                }

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
                { c_boxChronicMedicatio, "Chronic Medication Use" }
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

            var conditions = medicalHistory.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var condition in conditions)
            {
                var trimmedCondition = condition.Trim();

                if (SetPredefinedCondition(trimmedCondition)) continue;

                SetOtherCondition(trimmedCondition);
            }
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
        private void SetOtherCondition(string condition)
        {
            var otherConditions = new Dictionary<string, Tuple<CheckBox, TextBox>>
            {
                { "[Chronic]", Tuple.Create(c_box_otherChronic, txt_otherChronic) },
                { "[Surgical]", Tuple.Create(c_box_otherSurgical, txt_otherSurgical) },
                { "[Infectious]", Tuple.Create(c_box_otherInfectious, txt_otherInfectious) },
                { "[Allergies]", Tuple.Create(c_box_otherAllergies, txt_otherAllergies) },
                { "[Factors]", Tuple.Create(c_box_otherFactors, txt_otherFactor) }
            };

            foreach (var entry in otherConditions)
            {
                if (condition.StartsWith(entry.Key, StringComparison.OrdinalIgnoreCase))
                {
                    entry.Value.Item1.Checked = true;
                    entry.Value.Item2.Text = condition.Replace(entry.Key, "").Trim();
                    return;
                }
            }

            AssignToFirstAvailableOtherTextbox(condition);
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
            if (string.IsNullOrWhiteSpace(txt_Fname.Text) ||
                string.IsNullOrWhiteSpace(txt_Lname.Text) ||
                string.IsNullOrWhiteSpace(txt_phone.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Address.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtp_BirthDate.Value > DateTime.Today)
            {
                MessageBox.Show("Please select a valid birth date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rb_Male.Checked && !rb_Female.Checked)
            {
                MessageBox.Show("Please select Gender", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool ValidateEmail(string email) => email.Contains("@") && email.Contains(".");
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
        #endregion
        #region Clear Fields
        private void ClearFields()
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is GroupBox groupBox)
                {
                    foreach (var childControl in groupBox.Controls)
                    {
                        if (childControl is TextBox childTextBox)
                        {
                            childTextBox.Clear();
                        }
                        else if (childControl is CheckBox childCheckBox)
                        {
                            childCheckBox.Checked = false;
                        }
                    }
                }
            }

            dtp_BirthDate.Value = DateTime.Today;
            rb_Male.Checked = false;
            rb_Female.Checked = false;
        }
        #endregion
        #region vistbilty
        private void SetButtonVisibility(bool isAddMode)
        {
            btn_AddDoctor.Visible = isAddMode;
            btn_Update.Visible = !isAddMode;
            btn_remove.Visible = !isAddMode;
        }
        #endregion










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
                    var filteredPatients =  connection.Query<Patient>(
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
    }
}
