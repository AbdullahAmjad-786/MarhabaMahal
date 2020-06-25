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

namespace MarhabaMahal
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            SqlConnection con = reg.getcon();

            string name ,username,password,confirm_password,ph_no,confirmpass;
            name = txtName.Text;
            username = txtUserName.Text;
            password = txtPassword.Text;
            confirmpass = txtConfirmPassword.Text;
            ph_no = txtPhoneNo.Text;
            con.Open();
            SqlCommand com = reg.getInsertionCommand(con, name,username,password,ph_no);
            int chk = com.ExecuteNonQuery();

            if (chk > 0)
            {
                con.Close();
                MessageBox.Show("Successfully Registered!");
               // LoginForm Login = new LoginForm();
                //Login.Show();
                //this.Close();
            }
            else
            {
                con.Close();
                MessageBox.Show("Problem Registering!");
            }

        }
    }
}
