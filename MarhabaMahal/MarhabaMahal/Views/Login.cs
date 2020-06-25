using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaMahal.BLClasses;
using MarhabaMahal.Views;

namespace MarhabaMahal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            BLClasses.LoginHandler login = new LoginHandler();
            if (login.verifyUserLogin(username, password))
            {
                if (login.typeOfUser(username))
                {
                    AdminDashboard adminDashboard =new AdminDashboard(username,true,this);
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    UserDashboard userDashboard = new UserDashboard(username,false,this);
                    userDashboard.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a valid username and Password", "Invalid Username or Password",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
