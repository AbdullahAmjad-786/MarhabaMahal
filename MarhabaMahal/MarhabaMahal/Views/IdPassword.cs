using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarhabaMahal.Views
{
    public partial class IdPassword : Form
    {
        string pass;
        ChangeId id = new ChangeId();
        bool status = false;

        public IdPassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (CheckPassword())
            {
                status = true;
            }
            else
            {
                MessageBox.Show("Password not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckPassword()
        {
            if (txtPass.Text == "Admin123")
            {
                this.Hide();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool getstatus()
        {
            return status;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
        }

        public ChangeId getId()
        {
            return id;
        }
    }
}
