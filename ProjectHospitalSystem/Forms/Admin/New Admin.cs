using ProjectHospitalSystem.Models;

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class New_Admin : Form
    {
        HospitalSystemContext db;
        public New_Admin()
        {
            InitializeComponent();
            db = new HospitalSystemContext();
        }

        public void getData()
        {

            dgv_admin.DataSource = db.Users.Where(n => n.Role == "Admin").Select(n => new { n.UserId, n.UserName, n.FName, n.LName, n.Email, n.Password, n.Role }).ToList();

            txt_firstName.Text = txt_lastName.Text = txt_email.Text = txt_UserName.Text = txt_password.Text = "";

            dgv_admin.Columns["UserId"].Visible = false;

        }
        private void New_Admin_Load(object sender, EventArgs e)
        {
            dgv_admin.DataSource = db.Users.Where(n => n.Role == "Admin").Select(n => new { n.UserId, n.UserName, n.FName, n.LName, n.Email, n.Role }).ToList();
            dgv_admin.Columns["UserId"].Visible = false;
            btn_delete.Hide();
            btn_update.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var newAdmin = new User()
            {
                FName = txt_firstName.Text,
                LName = txt_lastName.Text,
                Email = txt_email.Text,
                Role = "Admin",
                Password = txt_password.Text,
                UserName = txt_UserName.Text
            };
            db.Users.Add(newAdmin);
            db.SaveChanges();
            getData();
            MessageBox.Show("New Admin Is Added");
        }
        int id;
        private void dgv_admin_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_admin.SelectedRows[0].Cells[0].Value;

            var query = db.Users.FirstOrDefault(n => n.UserId == id);

            txt_firstName.Text = query?.FName;
            txt_lastName.Text = query?.LName;
            txt_email.Text = query?.Email;
            txt_UserName.Text = query?.UserName;

            btn_update.Show();
            btn_delete.Show();
            txt_password.Hide();
            lb_Pasword.Hide();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                id = (int)dgv_admin.SelectedRows[0].Cells[0].Value;

                var query = db.Users.FirstOrDefault(n => n.UserId == id);



                if (query.FName == txt_firstName.Text && query.LName == txt_lastName.Text && query.Email == txt_email.Text && query.UserName == txt_UserName.Text && query.Password == txt_password.Text)
                {
                    MessageBox.Show("You Must Update One Field At Least To Update");
                    return;
                }
                else
                {
                    query.FName = txt_firstName.Text;
                    query.LName = txt_lastName.Text;
                    query.Email = txt_email.Text;
                    query.Password = txt_password.Text;
                    query.UserName = txt_UserName.Text;
                    MessageBox.Show("Data Is Updated");

                    btn_update.Hide();
                    btn_delete.Hide();
                    txt_password.Show();
                    lb_Pasword.Show();
                }
                db.SaveChanges();
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Need To Delete This Admin", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var query = db.Users.FirstOrDefault(n => n.UserId == id);

                if (query != null)
                {
                    db.Remove(query);
                    db.SaveChanges();
                    getData();

                    btn_update.Hide();
                    btn_delete.Hide();
                }

            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }
        public void ClearFileds() 
        {
            txt_firstName.Clear();
            txt_UserName.Clear();
            txt_password.Clear();
            txt_email.Clear();
            txt_lastName.Clear();
            btn_update.Hide();
            btn_delete.Hide();
            txt_password.Show();
            lb_Pasword.Show();
        }
    }
}

