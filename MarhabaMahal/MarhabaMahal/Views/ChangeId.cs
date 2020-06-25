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
    public partial class ChangeId : Form
    {
        static string newid;
        public ChangeId()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newid = txtId.Text.ToString();
            OrdersPanel opanel = new OrdersPanel("",false);
            MessageBox.Show("Id Changed Successfully");
            
            this.Hide();
        }

        public string getId()
        {
            return newid;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
        }
    }
}
