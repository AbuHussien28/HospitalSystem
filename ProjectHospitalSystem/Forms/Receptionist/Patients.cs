using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class Patients : Form
    {
        int userid1; HospitalSystemContext db;
        private int PaientSelectedId;
       
        public Patients(int uid)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            userid1 = uid;
         
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void LoadData()
        {
            var patients = db.Patients.ToList();

            var result = patients.Select(p => new
            {
                p.PatientId,
                p.FirstName,
                p.LastName,
                p.DateOfBirth,
                p.Gender,
                p.Email,
                p.Address,
                p.MedicalHistory,
                PhoneNumber = p.PhoneNumber
            }).ToList();

            dgv_patientdata.DataSource = result;
            dgv_patientdata.Columns["PatientId"].Visible = false;
        }
        private void SearchPatient()
        {
            string searchText = txt_searchPat.Text.Trim();
            var searchResults = db.Patients.Where(p => p.FirstName.StartsWith(searchText) ||
                            p.PhoneNumber.StartsWith(searchText))

                .Select(p => new
                {
                    p.PatientId,
                    p.FirstName,
                    p.LastName,
                    p.Email,
                    DateOfBirth = p.DateOfBirth.ToShortDateString(),
                    p.Gender,
                    p.Address,
                    Phones = p.PhoneNumber
                })
                .ToList();

            dgv_patientdata.DataSource = searchResults;
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

        private void txt_searchPat_TextChanged(object sender, EventArgs e)
        {
            SearchPatient();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchPatient();
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
            LoadData();
            ClearFields();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var patient = db.Patients.FirstOrDefault(n => n.PatientId == PaientSelectedId);
            if (patient != null)
            {
                patient.FirstName = txt_fname.Text;
                patient.LastName = txt_lname.Text;
                patient.DateOfBirth = dtPicker_BD.Value;
                patient.MedicalHistory = GetMedicalHistory();
                patient.Email = txt_email.Text;
                patient.Address = txt_address.Text;
                patient.PhoneNumber = txt_phone1.Text;
                patient.Gender = Rbtn_male.Checked ? "Male" : "Female";

                db.SaveChanges();
                LoadData();
                ClearFields();
                MessageBox.Show("Updated Successfully");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this patient?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var patient = db.Patients.FirstOrDefault(n => n.PatientId == PaientSelectedId);
                if (patient != null)
                {
                    db.Patients.Remove(patient);
                    db.SaveChanges();
                    LoadData();
                    ClearFields();
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Patient Not Found");
                }
            }
        }

        private void dgv_patientdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClearFields();
                PaientSelectedId = Convert.ToInt32(dgv_patientdata.SelectedRows[0].Cells["PatientId"].Value);
                Patient patient = db.Patients.FirstOrDefault(n => n.PatientId == PaientSelectedId);

                if (patient != null)
                {
                    txt_fname.Text = patient.FirstName;
                    txt_lname.Text = patient.LastName;
                    txt_email.Text = patient.Email;
                    txt_address.Text = patient.Address;
                    txt_phone1.Text = patient.PhoneNumber;
                    dtPicker_BD.Value = patient.DateOfBirth;
                    if (patient.Gender == "Male")
                        Rbtn_male.Checked = true;
                    else
                        Rbtn_female.Checked = true;

                    string medicalHistory = patient?.MedicalHistory;
                    
                    SetMedicalHistory(patient.MedicalHistory);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
