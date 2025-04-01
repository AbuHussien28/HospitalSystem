using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class New_Admin : Form
    {
        private HospitalSystemContext db;
        private int _selectedId;
        public New_Admin()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
        }
        #region Form Events
        private void New_Admin_Load(object sender, EventArgs e)
        {
            LoadAdminData();
            btn_delete.Hide();
            btn_update.Hide();
        }
        private void dgv_admin_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_admin.Rows.Count)
            {
                if (dgv_admin.Columns.Contains("UserId"))
                {
                    _selectedId = (int)dgv_admin.Rows[e.RowIndex].Cells["UserId"].Value;
                    LoadSelectedAdminData(_selectedId);
                }
                else
                    MessageBox.Show("UserId column not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please select a valid row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region Button Events   
        private void btn_Add_Click(object sender, EventArgs e) => AddNewAdmin();
        private void btn_update_Click(object sender, EventArgs e) => UpdateAdmin();
        private void btn_delete_Click(object sender, EventArgs e) => DeleteAdmin();
        private void pBoxShowPassword_Click(object sender, EventArgs e) => TogglePasswordVisibility();
        private void pBoxShowConfrimPassword_Click(object sender, EventArgs e) => ToggleConfrimPasswordVisibility();
        #endregion
        #region Data Methods
        private void LoadAdminData()
        {
            dgv_admin.DataSource = db.Users
              .Where(n => n.Role == "Admin")
              .Select(n => new { n.UserId, n.UserName, n.FName, n.LName, n.Email, n.PhoneNumber, n.Role })
              .ToList();
            dgv_admin.Columns["UserId"].Visible = false;
            ClearFileds();
        }
        private void LoadSelectedAdminData(int userId)
        {
            var query = db.Users.FirstOrDefault(n => n.UserId == userId);
            if (query != null)
            {
                txt_firstName.Text = query.FName;
                txt_lastName.Text = query.LName;
                txt_email.Text = query.Email;
                txt_phone.Text = query.PhoneNumber;
                txt_UserName.Text = query.UserName;
                btn_update.Show();
                btn_delete.Show();
                btn_Add.Hide();
                txt_password.Hide();
                lb_password.Hide();
                txt_confirmPassword.Hide();
                lb_confirmPassword.Hide();
                pBoxPassword.Hide();
                pBoxConfirmPassword.Hide();
                pBoxShowPassword.Hide();
                pBoxShowConfrimPassword.Hide();
            }
        }

        private void AddNewAdmin()
        {
            if (ValidateInputs())
            {
                if (txt_password.Text != txt_confirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newAdmin = new User()
                {
                    FName = txt_firstName.Text,
                    LName = txt_lastName.Text,
                    Email = txt_email.Text,
                    PhoneNumber = txt_phone.Text,
                    Role = "Admin",
                    UserName = txt_UserName.Text,
                    Password = txt_password.Text
                };
                db.Users.Add(newAdmin);
                db.SaveChanges();
                LoadAdminData();
                MessageBox.Show("New Admin Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateAdmin()
        {
            try
            {
                if (_selectedId <= 0)
                {
                    MessageBox.Show("Please select an admin to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var query = db.Users.FirstOrDefault(n => n.UserId == _selectedId);
                if (query == null)
                {
                    MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (query.FName == txt_firstName.Text && query.LName == txt_lastName.Text &&
                    query.Email == txt_email.Text && query.PhoneNumber == txt_phone.Text &&
                    query.UserName == txt_UserName.Text)
                {
                    MessageBox.Show("You must update at least one field.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                query.FName = txt_firstName.Text;
                query.LName = txt_lastName.Text;
                query.Email = txt_email.Text;
                query.PhoneNumber = txt_phone.Text;
                query.UserName = txt_UserName.Text;
                db.SaveChanges();
                LoadAdminData();
                MessageBox.Show("Admin Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_update.Hide();
                btn_delete.Hide();
                txt_password.Show();
                lb_password.Show();
                txt_confirmPassword.Show();
                lb_confirmPassword.Show();
                pBoxPassword.Show();
                pBoxConfirmPassword.Show();
                pBoxShowPassword.Show();
                pBoxShowConfrimPassword.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteAdmin()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("Please select an admin to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this admin?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var query = db.Users.FirstOrDefault(n => n.UserId == _selectedId);
                if (query != null)
                {
                    db.Users.Remove(query);
                    db.SaveChanges();
                    LoadAdminData();
                    btn_update.Hide();
                    btn_delete.Hide();
                    MessageBox.Show("Admin Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Admin not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region Helper Methods
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_firstName.Text) ||
                 string.IsNullOrWhiteSpace(txt_lastName.Text) ||
                 string.IsNullOrWhiteSpace(txt_email.Text) ||
                 string.IsNullOrWhiteSpace(txt_phone.Text) ||
                 string.IsNullOrWhiteSpace(txt_UserName.Text) ||
                 string.IsNullOrWhiteSpace(txt_password.Text) ||
                 string.IsNullOrWhiteSpace(txt_confirmPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!ValidateEmail(txt_email.Text))
            {
                MessageBox.Show("Email Address Not Valid");
                return false;
            }
            if (txt_password.Text != txt_confirmPassword.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void TogglePasswordVisibility()
        {
            if (txt_password.UseSystemPasswordChar)
            {
                pBoxShowPassword.Image = Properties.Resources.IconUnShowPassword;
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                pBoxShowPassword.Image = Properties.Resources.IconShowPassword;
                txt_password.UseSystemPasswordChar = true;
            }
        }
        public bool ValidateEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
        private void ToggleConfrimPasswordVisibility()
        {
            if (txt_confirmPassword.UseSystemPasswordChar)
            {
                pBoxShowConfrimPassword.Image = Properties.Resources.IconUnShowPassword;
                txt_confirmPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pBoxShowConfrimPassword.Image = Properties.Resources.IconShowPassword;
                txt_confirmPassword.UseSystemPasswordChar = true;
            }
        }
        public void ClearFileds()
        {
            txt_firstName.Clear();
            txt_lastName.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            txt_UserName.Clear();
            txt_password.Clear();
            txt_confirmPassword.Clear();
            btn_update.Hide();
            btn_delete.Hide();
            txt_password.Show();
            lb_password.Show();
            txt_confirmPassword.Show();
            lb_confirmPassword.Show();
            pBoxPassword.Show();
            pBoxConfirmPassword.Show();
            pBoxShowPassword.Show();
            pBoxShowConfrimPassword.Show();
            btn_Add.Show();

        }

        public void Reload()
        {
            LoadAdminData();
            ClearFileds();
        }
        #endregion



    }
}

