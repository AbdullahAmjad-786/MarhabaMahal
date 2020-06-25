using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaMahal.BLClasses;

namespace MarhabaMahal.Views
{
    public partial class UserManagement : UserControl
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            string name = txtNewName.Text;
            string username = txtNewUsername.Text;
            string password = txtNewPassword.Text;
            string userType = cmbNewType.Text;

            if (name == "" || username == "" || password == "" || userType == "")
            {
                MessageBox.Show("All Fields are Required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            UserManagementHandler userManagement = new UserManagementHandler();
            userManagement.addUser(name, username, password, userType);
            MessageBox.Show("User Added", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNewPassword.Text = "";
            txtNewName.Text = "";
            txtNewUsername.Text = "";
            cmbNewType.Refresh();
            txtNewName.Select();
        }
        private void btnUpdateFind_Click(object sender, EventArgs e)
        {
            string username = txtUpdateUsername.Text;
            if (username == "")
            {
                MessageBox.Show("Enter A Username to Find and Update");
                return;
            }
            UserManagementHandler management = new UserManagementHandler();
            var user = management.GetUserInfo(username);
            txtUpdateName.Text = user.name;
            txtUpdatePassword.Text = user.password;
            cmbUpdateUserType.SelectedText = (user.type ? "Admin": "Cashier");
            updateEnable();
        }
        public void updateEnable()
        {
            txtUpdateName.Enabled = true;
            txtUpdatePassword.Enabled = true;
            cmbUpdateUserType.Enabled = true;
            btnUpdate.Enabled = true;
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            txtUpdateName.Enabled = false;
            txtUpdatePassword.Enabled = false;
            cmbUpdateUserType.Enabled = false;
            btnUpdate.Enabled = false;
            txtDelName.Enabled = false;
            txtDelPassword.Enabled = false;
            txtDelUserType.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void btnDelFind_Click(object sender, EventArgs e)
        {
            string username = txtDelUsername.Text;
            if (username == "")
            {
                MessageBox.Show("Enter A Username to Find and Update");
                return;
            }
            UserManagementHandler management = new UserManagementHandler();
            var user = management.GetUserInfo(username);
            txtDelName.Text = user.name;
            txtUpdatePassword.Text = user.password;
            txtDelUserType.Text = (user.type ? "Admin" : "Cashier");
            btnDelete.Enabled = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserManagementHandler userManagement = new UserManagementHandler();
            string name = txtUpdateName.Text;
            string username = txtUpdateUsername.Text;
            string password = txtUpdatePassword.Text;
            string type = cmbUpdateUserType.Text;
            userManagement.editUser(name,username,password,type);
            txtUpdateName.Enabled = false;
            txtUpdatePassword.Text = "";
            txtUpdateName.Text = "";
            txtUpdateUsername.Text = "";
            cmbUpdateUserType.SelectedText = "";
            txtUpdatePassword.Enabled = false;
            cmbUpdateUserType.Enabled = false;
            btnUpdate.Enabled = false;
        }

    }
}
