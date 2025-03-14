using DevExpress.XtraPrinting.Native;
using MaterialSkin;
using MaterialSkin.Controls;
using ProjectHospitalSystem.Forms.Admin;
using ProjectHospitalSystem.Forms.Doctor;
using ProjectHospitalSystem.Forms.Receptionist;
using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem
{
    public partial class WelcomeScreen : Form
    {
        HospitalSystemContext _context;
        public WelcomeScreen()
        {
            InitializeComponent();
            _context = new HospitalSystemContext();

        }
        #region Event Handlers
        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxUserName.Text.Trim();
            string password = txtBoxUserPassword.Text.Trim();
            try
            {
                ValidateLogin(username, password);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
            finally
            {
                ClearInputFields();
            }
        }
        private void pBoxShowPassword_Click(object sender, EventArgs e) => TogglePasswordVisibility();
        private void pBoxExit_Click(object sender, EventArgs e) => this.Close();
        private void btn_clear_Click(object sender, EventArgs e) => ClearInputFields();

        #endregion

        #region Helper Methods
        private void ValidateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                ShowErrorMessage("Please Enter Username");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                ShowErrorMessage("Please Enter Password");
                return;
            }
            var user = _context.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
            if (user == null)
            {
                ShowErrorMessage("Username or Password is incorrect");
                return;
            }
            NavigateToDashboard(user);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ClearInputFields()
        {
            txtBoxUserName.Clear();
            txtBoxUserPassword.Clear();
        }
        private void TogglePasswordVisibility()
        {
            if (txtBoxUserPassword.UseSystemPasswordChar)
            {
                pBoxShowPassword.Image = Properties.Resources.IconUnShowPassword;
                txtBoxUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pBoxShowPassword.Image = Properties.Resources.IconShowPassword;
                txtBoxUserPassword.UseSystemPasswordChar = true;
            }
        }
        private void NavigateToDashboard(User user)
        {
            switch (user.Role)
            {
                case "Admin":
                    var adminDashboard = new AdminUserDashBoardScreen(user);
                    adminDashboard.Show();
                    this.Hide();
                    break;

                case "Doctor":
                   var doctorDashboard = new DoctorUser(user);
                    doctorDashboard.Show();
                    break;

                case "Receptionist":
                    var receptionistDashboard = new Dashboard1(user.UserId);
                    receptionistDashboard.Show();
                    break;

                default:
                    MessageBox.Show("Unknown Role");
                    break;
            }
        }
        #endregion




        private void lbUserPassword_Click(object sender, EventArgs e)
        {
   
        }
    }
}
