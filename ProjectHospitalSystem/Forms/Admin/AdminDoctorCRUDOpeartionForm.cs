﻿using Dapper;
using ProjectHospitalSystem.Models;
using ProjectHospitalSystem.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class AdminDoctorCRUDOpeartionForm : Form
    {
        User User;
        HospitalSystemContext _context;
        SqlConnection con;
        int DoctorSelectedId;


        public AdminDoctorCRUDOpeartionForm(User user)
        {
            InitializeComponent();
            User = user;
            _context = new HospitalSystemContext();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }
        #region Event Handlers
        private void btn_AddDoctor_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
            if (!ValidateEmail(txt_Email.Text))
            {
                MessageBox.Show("Email Address Not Valid");
                return;
            }
            if (!ValidatePasswordMatch(txt_Password.Text, txt_confirmPassword.Text))
            {
                MessageBox.Show("Password Not Match");
                return;
            }
            User user = new User()
            {
                UserName = txt_username.Text,
                FName = txt_Fname.Text,
                LName = txt_Lname.Text,
                Email = txt_Email.Text,
                PhoneNumber = txt_phone.Text,
                Password = txt_Password.Text,
                ConfirmPassword = txt_confirmPassword.Text,
                Role = "Doctor",
            };
            DoctorDetails doc = new DoctorDetails()
            {
                Specialization = txt_Specialization.Text,
                DeptId = Convert.ToInt32(cb_DeptName.SelectedValue),
                User = user
            };
            _context.Doctors.Add(doc);
            _context.SaveChanges();
            LoadData();

        }
        private void dgv_AdminDoctors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DoctorSelectedId = Convert.ToInt32(dgv_AdminDoctors.Rows[e.RowIndex].Cells["UserId"].Value);
                DoctorDetails doctor = _context.Doctors.Where(n => n.UserId == DoctorSelectedId).SingleOrDefault();
                if (doctor != null)
                {
                    txt_username.Text = doctor.User.UserName.ToString();
                    txt_Fname.Text = doctor.User?.FName.ToString();
                    txt_Lname.Text = doctor.User?.LName;
                    txt_Email.Text = doctor.User?.Email;
                    txt_phone.Text = doctor.User?.PhoneNumber;
                    txt_Specialization.Text = doctor?.Specialization;
                    cb_DeptName.SelectedValue = doctor?.DeptId ?? -1;
                }
                SetButtonVisibility(isAddMode: false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DoctorDetails doctor = _context.Doctors.Where(n => n.UserId == DoctorSelectedId).SingleOrDefault();
            if (doctor != null)
            {
                doctor.User.UserName = txt_username.Text;
                doctor.User.FName = txt_Fname.Text;
                doctor.User.LName = txt_Lname.Text;
                doctor.User.Email = txt_Email.Text;
                doctor.User.PhoneNumber = txt_phone.Text;
                doctor.Specialization = txt_Specialization.Text;
                doctor.DeptId = Convert.ToInt32(cb_DeptName.SelectedValue);
                _context.SaveChanges();
                ResetForm();
                LoadData();
                MessageBox.Show("Updated Done");
                SetButtonVisibility(isAddMode: true);
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {  
                if (MessageBox.Show("are you sure to delete this Doctor", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes) 
                {
                    DoctorDetails doctor = _context.Doctors.Where(n => n.UserId == DoctorSelectedId).SingleOrDefault();
                    if (doctor != null)
                    {
                        _context.Doctors.Remove(doctor);
                        _context.SaveChanges();
                        ResetForm();
                        LoadData();
                        MessageBox.Show("deleted");
                        SetButtonVisibility(isAddMode: true);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AdminDoctorCRUDOpeartionForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetButtonVisibility(isAddMode: true);
        }
        #endregion
        #region Helper Methods
        private async Task LoadData()
        {
            var doctors = await con.QueryAsync<User, DoctorDetails, DoctorInfoDTO>(
                @"SELECT u.UserId, u.UserName, u.FName, u.LName, u.Role, u.Email,
                                u.PhoneNumber,d.Specialization
                                 FROM Doctors d 
                                    INNER JOIN Users u ON d.UserId = u.UserId
                        WHERE u.Role = 'Doctor'", (user, doctor) =>
                {
                    return new DoctorInfoDTO
                    {
                        UserId = user.UserId,
                        UserName = user.UserName,
                        FName = user.FName,
                        LName = user.LName,
                        Role = user.Role,
                        PhoneNumber = user.PhoneNumber,
                        Email = user?.Email,
                        Specialization = doctor.Specialization
                    };
                },
    splitOn: "PhoneNumber,Specialization");
            dgv_AdminDoctors.DataSource = doctors.ToList();
            dgv_AdminDoctors.Columns["UserId"].Visible = false;
            var DeptName = con.Query("Select DeptId,DeptName from Departments").ToList();
            cb_DeptName.DisplayMember = "DeptName";
            cb_DeptName.ValueMember = "DeptId";
            cb_DeptName.DataSource = DeptName;
        }

        private void SetButtonVisibility(bool isAddMode)
        {
            btn_AddDoctor.Visible = isAddMode;
            btn_Update.Visible = !isAddMode;
            btn_remove.Visible = !isAddMode;
        }


        public bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txt_Fname.Text) &&
                       !string.IsNullOrWhiteSpace(txt_Lname.Text) &&
                       !string.IsNullOrWhiteSpace(txt_username.Text) &&
                       !string.IsNullOrWhiteSpace(txt_Password.Text) &&
                       !string.IsNullOrWhiteSpace(txt_confirmPassword.Text) &&
                       !string.IsNullOrWhiteSpace(txt_Specialization.Text) &&
                       !string.IsNullOrWhiteSpace(txt_Email.Text);
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        public bool ValidatePasswordMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }
        private void ResetForm()
        {
            txt_username.Clear();
            txt_Fname.Clear();
            txt_Lname.Clear();
            txt_phone.Clear();
            txt_Email.Clear();
            txt_Specialization.Clear();
        }
        #endregion

    }
}
