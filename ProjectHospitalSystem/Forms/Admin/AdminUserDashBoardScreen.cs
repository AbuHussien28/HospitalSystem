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

namespace ProjectHospitalSystem.Forms.Admin
{
    public partial class AdminUserDashBoardScreen : Form
    {
        User User;
        public AdminUserDashBoardScreen(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void AdminUserDashBoardScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
