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
    public partial class Add_Items : Form
    {
        public Add_Items()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ItemsHandler reg = new ItemsHandler();
            SqlConnection con = reg.getcon();

            string itemname = null, itemprice = null, qty = null;
            itemname = txtItemName.Text;
            itemprice = txtPrice.Text;
            qty = cmbItemQty.Text;
            con.Open();
            SqlCommand com = reg.getInsertionCommand(con, itemname, itemprice, qty);
            int chk = com.ExecuteNonQuery();

            if (chk > 0)
            {
                con.Close();
                MessageBox.Show("Successfully Added");
                txtItemName.Text = null;
                txtPrice.Text = null;
                cmbItemQty.Text = null;
                // LoginForm Login = new LoginForm();
                //Login.Show();
                //this.Close();
            }
            else
            {
                con.Close();
                MessageBox.Show("Problem Adding");
            }

        }
    }
}
