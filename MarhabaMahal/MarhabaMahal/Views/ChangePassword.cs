using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;

namespace MarhabaMahal.Views
{
    public partial class ChangePassword : Form
    {
        private string username;
        public ChangePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUpdatePassword;
        }
        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (txtOld.Text == "")
            {
                return;
            }
            if(txtConfirmPassword.Text == "")
                return;
            if (txtNewPassword.Text == "")
                return;
            string old = txtOld.Text;
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Password Do Not Match", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            string newPassword = txtNewPassword.Text;
            MarhabaEntities entities = new MarhabaEntities();
            var user = entities.user_info.FirstOrDefault(u => u.user_name == username);
            if (user == null)
                return;
            if (user.password != old)
            {
                MessageBox.Show("Password Is not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.password = newPassword;
            entities.user_info.AddOrUpdate(user);
            entities.SaveChanges();
            MessageBox.Show("Password Updated", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
