using Dapper;
using ProjectHospitalSystem.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class AdminReceptionsitCRUDOpeartion : Form
    {
        User User;
        HospitalSystemContext _context;
        SqlConnection con;
        private int _selectedReceptionistId;
        public AdminReceptionsitCRUDOpeartion(User user)
        {
            InitializeComponent();
            User = user;
            _context = new HospitalSystemContext();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Hospital"].ConnectionString);
        }

        private void AdminReceptionsitCRUDOpeartion_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                SetButtonAndTxtPasswordVisibility(isAddMode: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region Event Handlers
        private void btn_AddReceptionist_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                string username = txt_username.Text.Trim();

                if (!IsUsernameUnique(username))
                {
                    MessageBox.Show("This username already exists! Please choose a different username.",
                                   "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_username.Focus();
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
                    Role = "Receptionist",
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                LoadData();
                ResetForm();
                MessageBox.Show("Receptionist added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetButtonAndTxtPasswordVisibility(isAddMode: true);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void dgv_AdminReceptionist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                _selectedReceptionistId = Convert.ToInt32(dgv_AdminReceptionist.Rows[e.RowIndex].Cells["UserId"].Value);
                var user = _context.Users.FirstOrDefault(n => n.UserId == _selectedReceptionistId);

                if (user != null)
                {
                    txt_username.Text = user.UserName ?? string.Empty;
                    txt_Fname.Text = user.FName ?? string.Empty;
                    txt_Lname.Text = user.LName ?? string.Empty;
                    txt_Email.Text = user.Email ?? string.Empty;
                    txt_phone.Text = user.PhoneNumber ?? string.Empty;
                    SetButtonAndTxtPasswordVisibility(isAddMode: false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting receptionist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_UpdateReceptionist_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsForUpdate())
                return;

            try
            {
                string username = txt_username.Text.Trim();
                var user = _context.Users.FirstOrDefault(n => n.UserId == _selectedReceptionistId);

                if (user != null)
                {
                    if (!IsUsernameUnique(username, _selectedReceptionistId))
                    {
                        MessageBox.Show("This username already exists! Please choose a different username.",
                                      "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_username.Focus();
                        return;
                    }

                    user.UserName = username;
                    user.FName = txt_Fname.Text.Trim();
                    user.LName = txt_Lname.Text.Trim();
                    user.Email = txt_Email.Text.Trim();
                    user.PhoneNumber = txt_phone.Text.Trim();
                    _context.SaveChanges();
                    LoadData();
                    ResetForm();
                    MessageBox.Show("Receptionist updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetButtonAndTxtPasswordVisibility(isAddMode: true);
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"Error updating receptionist: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_removeReceptionist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this Receptionist", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                User user = _context.Users.Where(n => n.UserId == _selectedReceptionistId).SingleOrDefault();
                if (user != null)
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    ResetForm();
                    LoadData();
                    MessageBox.Show("Receptionist deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetButtonAndTxtPasswordVisibility(isAddMode: true);
                }
            }
        }
        #endregion

        #region  Helper Methods
        private void LoadData()
        {
            var Receptionist = con.Query<User>(@"SELECT  u.UserId, u.UserName, u.FName, u.LName, u.Role,u.Email, u.PhoneNumber from Users u
                    WHERE u.Role = 'Receptionist'");
            var result = Receptionist.Select(u => new
            {
                u.UserId,
                u.UserName,
                u.FName,
                u.LName,
                u.Role,
                u.Email,
                u.PhoneNumber
            }).ToList();
            dgv_AdminReceptionist.DataSource = result;
            dgv_AdminReceptionist.Columns["UserId"].Visible = false;
        }
        private bool ValidateForm()
        {
            if (!ValidateInputs())
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateEmail(txt_Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }

            if (!ValidatePasswordMatch(txt_Password.Text, txt_confirmPassword.Text))
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputsForUpdate()
        {
            if (string.IsNullOrWhiteSpace(txt_Fname.Text) ||
                string.IsNullOrWhiteSpace(txt_Lname.Text) ||
                string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!ValidateEmail(txt_Email.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Email.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputs()
        {
            return !string.IsNullOrWhiteSpace(txt_Fname.Text) &&
                   !string.IsNullOrWhiteSpace(txt_Lname.Text) &&
                   !string.IsNullOrWhiteSpace(txt_username.Text) &&
                   !string.IsNullOrWhiteSpace(txt_Password.Text) &&
                   !string.IsNullOrWhiteSpace(txt_confirmPassword.Text) &&
                   !string.IsNullOrWhiteSpace(txt_Email.Text);
        }
        private void SetButtonAndTxtPasswordVisibility(bool isAddMode)
        {
            btn_AddReceptionist.Visible = isAddMode;
            btn_UpdateReceptionist.Visible = !isAddMode;
            btn_removeReceptionist.Visible = !isAddMode;
            txt_Password.Visible=isAddMode;
            txt_confirmPassword.Visible = isAddMode;
            lb_password.Visible = isAddMode;
            lb_confirmPassword.Visible = isAddMode;
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
        }
        private bool IsUsernameUnique(string username, int? currentUserId = null)
        {
            if (currentUserId.HasValue)
                return !_context.Users.Any(u => u.UserName == username && u.UserId != currentUserId.Value);
            return !_context.Users.Any(u => u.UserName == username);
        }
        #endregion
    }
}
