using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;
using MarhabaMahal.BLClasses;

namespace MarhabaMahal.Views
{
    public partial class ItemsPanel : UserControl
    {
        public ItemsPanel()
        {
            InitializeComponent();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            string itemCode = "";
            string[] arr = itemName.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                    itemCode += arr[i].ElementAt(0);
            }
            txtItemCode.Text = itemCode;
        }

        private void txtItemName_TextChanged_1(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            string itemCode = "";
            
            string[] arr = itemName.Split(new char[] {' ','.'});
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    itemCode += arr[i].ElementAt(0);
                }
            }
            
            txtItemCode.Text = itemCode;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                string name = txtItemName.Text;
                double price = Double.Parse(txtPrice.Text);
                double qty = Double.Parse(txtQuantity.Text);
                string type = (comboBox1.Text);
                string code = txtItemCode.Text;
                ItemsHandler itemsHandler = new ItemsHandler();
                itemsHandler.insetItem(name, price, qty, type, code);
                txtItemCode.Text = "";
                comboBox1.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                txtItemName.Text = "";
                txtItemName.Select();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Enter Valid Information\n" + exception.Message, 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnUpdateFind_Click(object sender, EventArgs e)
        {
            if (txtUpdateItemCode.Text == "")
                return;
            string code = txtUpdateItemCode.Text;
            ItemsHandler itemsHandler = new ItemsHandler();

            item dbItem = itemsHandler.getItem(code);
            if (dbItem != null)
            {
                txtUpdateItemName.Text = dbItem.item_name;
                txtUpdatePrice.Text = dbItem.item_price.ToString();
                txtUpdateQuantity.Text = dbItem.item_qty.ToString();
                txtUpdateType.Text = dbItem.item_type;
                txtUpdateItemName.Enabled = true;
                txtUpdatePrice.Enabled = true;
                txtUpdateQuantity.Enabled = true;
                txtUpdateType.Enabled = true;
                txtItemCode.Enabled = false;
                btnUpdateFind.Enabled = false;
                btnUpdateClear.Visible = true;
                btnUpdate.Visible = true;
            }
            else
            {
                MessageBox.Show("Item Not Found", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdateClear_Click(object sender, EventArgs e)
        {
            txtUpdateItemName.Text = "";
            txtUpdatePrice.Text = "";
            txtUpdateQuantity.Text = "";
            txtUpdateType.Text = "";
            txtUpdateItemName.Enabled = false;
            txtUpdatePrice.Enabled = false;
            txtUpdateQuantity.Enabled = false;
            txtUpdateType.Enabled = false;
            txtItemCode.Enabled = true;
            txtItemCode.Text = "";
            txtItemCode.Select();
            btnUpdateFind.Enabled = true;
            btnUpdateClear.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtUpdateItemName.Text;
            double price = Double.Parse(txtUpdatePrice.Text);
            string qty = (txtUpdateQuantity.Text);
            string type = (txtUpdateType.Text);
            string code = txtUpdateItemCode.Text;
            ItemsHandler itemsHandler = new ItemsHandler();
            itemsHandler.updateItem(name,price,qty,type,code);
            txtUpdateItemName.Text = "";
            txtUpdatePrice.Text = "";
            txtUpdateQuantity.Text = "";
            txtUpdateType.Text = "";
            txtUpdateItemName.Enabled = false;
            txtUpdatePrice.Enabled = false;
            txtUpdateQuantity.Enabled = false;
            txtUpdateType.Enabled = false;
            txtItemCode.Enabled = true;
            txtItemCode.Text = "";
            txtItemCode.Select();
            btnUpdateFind.Enabled = true;
            btnUpdateClear.Visible = false;
        }

        private void btnDelFind_Click(object sender, EventArgs e)
        {
            if (txtDelItemCode.Text == "")
                return;
            string code = txtDelItemCode.Text;
            ItemsHandler itemsHandler = new ItemsHandler();

            item dbItem = itemsHandler.getItem(code);
            if (dbItem != null)
            {
                if (dbItem.item_id == txtDelItemCode.Text)
                {
                    txtDelItemName.Text = dbItem.item_name;
                    btnDelClear.Visible = true;
                    btnDelete.Visible = true;
                }
                else
                {
                    MessageBox.Show("Item Not Found", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Item Not Found", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string itemCode = txtItemCode.Text;
            ItemsHandler itemsHandler = new ItemsHandler();
            itemsHandler.delItem(itemCode);
            txtDelItemName.Enabled = false;
            btnDelClear.Visible = false;
            btnDelete.Visible = false;
        }

        private void btnDelClear_Click(object sender, EventArgs e)
        {
            txtDelItemCode.Text = "";
            txtDelItemName.Text = "";
            btnDelClear.Visible = false;
            txtDelItemCode.Select();
        }
    }
}
