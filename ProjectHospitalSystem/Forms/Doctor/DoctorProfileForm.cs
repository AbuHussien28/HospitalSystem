using Dapper;
using Microsoft.EntityFrameworkCore;
using ProjectHospitalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHospitalSystem.Forms.Doctor
{

    public partial class DoctorProfileForm : Form
    {
        HospitalSystemContext db;
        private User _loggedUser;
        SqlConnection con;
        public DoctorProfileForm(User loggedUser)
        {
            InitializeComponent();
            db = new HospitalSystemContext();
            _loggedUser = loggedUser;
        }

        private void DoctorProfileForm_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
            getProfileData();
            lbUserName.Text ="Dr: "+_loggedUser.FName + " " + _loggedUser.LName+" Profile";
        }
        private void getProfileData()
        {
            var query = con.Query("select U.FName,U.LName,Dr.Specialization,U.Email\r\nfrom Users U Inner Join Doctors Dr\r\non U.UserId = Dr.UserId\r\nwhere Dr.DoctorDetailsId = @DoctorId", new { DoctorId = _loggedUser.doctorDetails.DoctorDetailsId }).ToList();
            txt_firstName.Text = query.FirstOrDefault()?.FName;
            txt_lastName.Text = query.FirstOrDefault()?.LName;
            txt_email.Text = query.FirstOrDefault()?.Email;
            txt_specializtion.Text = query.FirstOrDefault()?.Specialization;
            btn_updateProfile.Hide();
            txt_firstName.BorderStyle=txt_lastName.BorderStyle= txt_email.BorderStyle=txt_specializtion.BorderStyle = BorderStyle.None;
        }
        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            txt_firstName.ReadOnly = false;
            txt_lastName.ReadOnly = false;
            txt_email.ReadOnly = false;
            txt_specializtion.ReadOnly = false;
            btn_updateProfile.Show();
            btn_editProfile.Hide();
            txt_firstName.BorderStyle = txt_lastName.BorderStyle = txt_email.BorderStyle = txt_specializtion.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            txt_firstName.ReadOnly = true;
            txt_lastName.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_specializtion.ReadOnly = true;
            btn_updateProfile.Visible = false;
            btn_editProfile.Visible = true;
            txt_firstName.BorderStyle = txt_lastName.BorderStyle = txt_email.BorderStyle = txt_specializtion.BorderStyle = BorderStyle.None;
            try
            {
                using (var context = new HospitalSystemContext())
                {

                    var doctor = context.Doctors
                        .Include(d => d.User)
                        .FirstOrDefault(d => d.DoctorDetailsId == _loggedUser.doctorDetails.DoctorDetailsId);

                    if (doctor == null)
                    {
                        MessageBox.Show("Error: Doctor not found!");
                        return;
                    }

                    var user = doctor.User;

                    if (txt_firstName.Text == user.FName &&
                        txt_lastName.Text == user.LName &&
                        txt_specializtion.Text == doctor.Specialization &&
                        txt_email.Text == user.Email)
                    {
                        MessageBox.Show("Edit at least one field!");
                        return;
                    }

                    using (var transaction = context.Database.BeginTransaction())
                    {
                        bool isUpdated = false;

                        if (txt_email.Text != user.Email || txt_specializtion.Text != doctor.Specialization)
                        {
                            user.Email = txt_email.Text;
                            doctor.Specialization = txt_specializtion.Text;
                            isUpdated = true;
                        }

                        if (txt_firstName.Text != user.FName || txt_lastName.Text != user.LName)
                        {
                            user.FName = txt_firstName.Text;
                            user.LName = txt_lastName.Text;
                            isUpdated = true;
                        }

                        if (isUpdated)
                        {
                            context.SaveChanges();
                            transaction.Commit();
                            MessageBox.Show("User and Doctor information updated successfully!");
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("No record was updated. Please check the provided IDs.");
                        }
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database Update Error: {dbEx.InnerException?.Message ?? dbEx.Message}", "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException invEx)
            {
                MessageBox.Show($"Operation Error: {invEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Reload()
        {
            try
            {
                ResetFormState();
                ClearFormFields();
                LoadProfileData();
                UpdateProfileLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to reload data: {ex.Message}",
              "Error",
              MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }
        }

        private void ResetFormState()
        {
            txt_firstName.ReadOnly = true;
            txt_lastName.ReadOnly = true;
            txt_email.ReadOnly = true;
            txt_specializtion.ReadOnly = true;
            txt_firstName.BorderStyle =
            txt_lastName.BorderStyle =
            txt_email.BorderStyle =
            txt_specializtion.BorderStyle = BorderStyle.None;
            btn_updateProfile.Hide();
            btn_editProfile.Show();
        }

        private void ClearFormFields()
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_specializtion.Clear();
        }

        private void LoadProfileData()
        {
            var query = con.Query(
                @"SELECT U.FName, U.LName, Dr.Specialization, U.Email
          FROM Users U 
          INNER JOIN Doctors Dr ON U.UserId = Dr.UserId
          WHERE Dr.DoctorDetailsId = @DoctorId",
                new { DoctorId = _loggedUser.doctorDetails.DoctorDetailsId })
                .FirstOrDefault();

            if (query != null)
            {
                txt_firstName.Text = query.FName;
                txt_lastName.Text = query.LName;
                txt_email.Text = query.Email;
                txt_specializtion.Text = query.Specialization;
            }
        }

        private void UpdateProfileLabel()
        {
            lbUserName.Text = $"Dr: {_loggedUser.FName} {_loggedUser.LName} Profile";
        }

       
       
    }
}
