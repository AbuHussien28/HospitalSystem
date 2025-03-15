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
    public partial class New_Patient : Form
    {
        HospitalSystemContext db;
        public New_Patient()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
        }

        private void New_Patient_Load(object sender, EventArgs e)
        {

        }
        public bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_fname.Text) ||
                string.IsNullOrWhiteSpace(txt_lname.Text) ||
                string.IsNullOrWhiteSpace(txt_phone1.Text) ||
                string.IsNullOrWhiteSpace(txt_email.Text) ||
                string.IsNullOrWhiteSpace(txt_address.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtPicker_BD.Value == null || dtPicker_BD.Value > DateTime.Today)
            {
                MessageBox.Show("Please select a valid birth date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Rbtn_male.Checked && !Rbtn_female.Checked)
            {
                MessageBox.Show("Please select Gender", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!ValidateCheckBoxGroup(gb_InfectiousDiseases) ||
                !ValidateCheckBoxGroup(gb_AllergieGenetic))

            {
                MessageBox.Show("Please select at least one option from each medical history category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private string GetMedicalHistory()
        {
            List<string> medicalHistoryList = new List<string>();

            if (c_boxHepatitis.Checked) medicalHistoryList.Add("Hepatitis (A, B, or C)");
            if (c_boxHIVOrAIDS.Checked) medicalHistoryList.Add("HIV/AIDS");
            if (c_boxTuberculosis.Checked) medicalHistoryList.Add("Tuberculosis (TB)");
            if (c_box_covid19.Checked) medicalHistoryList.Add("Previous COVID-19 Infection");
            if (c_boxDrugAllergies.Checked) medicalHistoryList.Add("Drug Allergies");
            if (c_boxFoodAllergie.Checked) medicalHistoryList.Add("Food Allergies");
            if (c_boxGeneticDiseases.Checked) medicalHistoryList.Add("Genetic Diseases");
            if (c_boxDust.Checked) medicalHistoryList.Add("Dust or Animal Allergies");
            if (c_box_otherInfectious.Checked && !string.IsNullOrWhiteSpace(txt_otherInfectious.Text))
                medicalHistoryList.Add(txt_otherInfectious.Text);
            if (c_box_otherAllergies.Checked && !string.IsNullOrWhiteSpace(txt_otherAllergies.Text))
                medicalHistoryList.Add(txt_otherAllergies.Text);
            return string.Join(", ", medicalHistoryList);
        }
        private void SetMedicalHistory(string medicalHistory)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control c in groupBox.Controls)
                    {
                        if (c is CheckBox checkBox)
                        {
                            checkBox.Checked = false;
                        }
                    }
                }
            }
            string[] conditions = medicalHistory.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string condition in conditions)
            {
                string trimmedCondition = condition.Trim();

                bool found = false;

                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox groupBox)
                    {
                        foreach (Control c in groupBox.Controls)
                        {
                            if (c is CheckBox checkBox && checkBox.Text.Trim() == trimmedCondition)
                            {
                                checkBox.Checked = true;
                                found = true;
                                break;
                            }
                        }
                    }
                }
                if (!found)
                {

                    if (string.IsNullOrWhiteSpace(txt_otherInfectious.Text))
                    {
                        c_box_otherInfectious.Checked = true;
                        txt_otherInfectious.Text = trimmedCondition;
                    }
                    else if (string.IsNullOrWhiteSpace(txt_otherAllergies.Text))
                    {
                        c_box_otherAllergies.Checked = true;
                        txt_otherAllergies.Text = trimmedCondition;
                    }


                }
            }
        }
        private bool ValidateCheckBoxGroup(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        public bool ValidateEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
        private void ClearFields()
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_email.Clear();
            txt_address.Clear();
            txt_phone1.Clear();
            txt_otherInfectious.Clear();
            txt_otherAllergies.Clear();
            dtPicker_BD.Value = DateTime.Today;
            Rbtn_male.Checked = false;
            Rbtn_female.Checked = false;
            ClearMedicalHistory();
        }
        private void ClearMedicalHistory()
        {
            foreach (Control control in gb_AllergieGenetic.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            foreach (Control control in gb_InfectiousDiseases.Controls)
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
                else if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            if (!ValidateEmail(txt_email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = new Patient
            {
                FirstName = txt_fname.Text,
                LastName = txt_lname.Text,
                DateOfBirth = dtPicker_BD.Value,
                MedicalHistory = GetMedicalHistory(),
                Gender = Rbtn_male.Checked ? "Male" : "Female",
                Email = txt_email.Text,
                Address = txt_address.Text,
                PhoneNumber = txt_phone1.Text
            };

            db.Patients.Add(patient);
            db.SaveChanges();
            MessageBox.Show("The patient was added successfully!");
            ClearFields();
        }
    }
}
