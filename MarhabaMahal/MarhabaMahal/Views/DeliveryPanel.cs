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
    public partial class DeliveryPanel : UserControl
    {
        private List<Int64> pendingOrderIds;
        public DataGridViewTextBoxColumn itemCode { get; set; }
        public DataGridViewComboBoxColumn itemName { get; set; }
        public DataGridViewTextBoxColumn price { get; set; }
        public DataGridViewTextBoxColumn quantity { get; set; }
        public DataGridViewTextBoxColumn itemTotal { get; set; }
        public DataGridViewTextBoxColumn itemCodePendinding { get; set; }
        public DataGridViewComboBoxColumn itemNamePending { get; set; }
        public DataGridViewTextBoxColumn pricePending { get; set; }
        public DataGridViewTextBoxColumn quantityPending { get; set; }
        public DataGridViewTextBoxColumn itemTotalPending { get; set; }
        private Orders orders;
        private string username;
        private bool type;
        public void initializeGridViews()
        {
            itemCode = new DataGridViewTextBoxColumn();
            itemName = new DataGridViewComboBoxColumn();
            price = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            itemTotal = new DataGridViewTextBoxColumn();



            itemCodePendinding = new DataGridViewTextBoxColumn();
            itemNamePending = new DataGridViewComboBoxColumn();
            pricePending = new DataGridViewTextBoxColumn();
            quantityPending = new DataGridViewTextBoxColumn();
            itemTotalPending = new DataGridViewTextBoxColumn();

            itemCode.HeaderText = "Code";
            itemName.HeaderText = "Name";
            price.HeaderText = "Price";
            quantity.HeaderText = "Qty";
            itemTotal.HeaderText = "Total";

            itemCodePendinding.HeaderText = "Code";
            itemNamePending.HeaderText = "Name";
            pricePending.HeaderText = "Price";
            quantityPending.HeaderText = "Qty";
            itemTotalPending.HeaderText = "Total";


            itemCodePendinding.ReadOnly = false;
            itemCodePendinding.Name = "Code";

            itemNamePending.AutoComplete = true;
            itemNamePending.Name = "Name";
            itemNamePending.Sorted = true;
            itemNamePending.ReadOnly = false;

            pricePending.ReadOnly = true;
            pricePending.Name = "Price";
            quantityPending.ReadOnly = false;
            quantityPending.Name = "Qty";
            itemTotalPending.ReadOnly = true;
            itemTotalPending.Name = "Total";

            itemCode.ReadOnly = false;
            itemCode.Name = "Code";

            itemName.AutoComplete = true;
            itemName.Name = "Name";
            itemName.Sorted = true;
            itemName.ReadOnly = false;

            price.ReadOnly = true;
            price.Name = "Price";
            quantity.ReadOnly = false;
            quantity.Name = "Qty";
            itemTotal.ReadOnly = true;
            itemTotal.Name = "Total";
        }
        private void setMenuNames()
        {
            Product p = new Product();

            List<item> items = p.getItemNames();

            foreach (item dbItem in items)
            {
                itemName.Items.Add(dbItem.item_name);
                itemNamePending.Items.Add(dbItem.item_name);
            }
        }
        public DeliveryPanel(string username, bool type)
        {
            InitializeComponent();
            initializeGridViews();
            orders = new Orders(username);
            setMenuNames();
            this.username = username;
            this.type = type;
            pendingOrderIds = new List<long>();
            chkGST.Checked = true;
            chkService.Checked = false;
            chkDiscount.Checked = false;
            cmbDiscount.Enabled = false;
            chkId.Checked = false;
            txtNewId.Enabled = false;
            if (!type)
            {
                chkGST.Visible = false;
                chkService.Visible = false;
                chkDiscount.Visible = false;
                cmbDiscount.Visible = false;
                chkId.Visible = false;
                txtNewId.Visible = false;
            }
        }
        private void DeliveryPanel_Load(object sender, EventArgs e)
        {
            dataGridViewNewOrders.Columns.Add(itemCode);
            dataGridViewNewOrders.Columns.Add(itemName);
            dataGridViewNewOrders.Columns.Add(price);
            dataGridViewNewOrders.Columns.Add(quantity);
            dataGridViewNewOrders.Columns.Add(itemTotal);

            dataGridViewPendingOrders.Columns.Add(itemCodePendinding);
            dataGridViewPendingOrders.Columns.Add(itemNamePending);
            dataGridViewPendingOrders.Columns.Add(pricePending);
            dataGridViewPendingOrders.Columns.Add(quantityPending);
            dataGridViewPendingOrders.Columns.Add(itemTotalPending);

        }
        private void dataGridViewNewOrders_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (e.Control.Name == "Qty")
            {
                TextBox q = e.Control as TextBox;
                if (q != null)
                {
                    q.Enabled = true;
                }
            }
            e.Control.Enabled = true;
        }
        private void dataGridViewNewOrders_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == itemTotal.Index)
            {

            }

            if (e.ColumnIndex == quantity.Index)
            {
                if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dataGridViewNewOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }

        }
        private void dataGridViewNewOrders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                int rowIndex = e.Row.Index;
                double total = Double.Parse(txtTotal.Text);
                double subTotal = Double.Parse(dataGridViewNewOrders.Rows[rowIndex].Cells[itemTotal.Index].Value.ToString());
                total -= subTotal;
                txtTotal.Text = total.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check Your Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void dataGridViewNewOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null || dataGridView.CurrentCell.ColumnIndex != 0
                || dataGridView.CurrentCell.ColumnIndex != 1) return;
            var dataGridViewComboBoxCell = dataGridView.CurrentCell as DataGridViewComboBoxCell;
            if (dataGridViewComboBoxCell != null)
            {
                //Here we move focus to second cell of current row
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[2];
                //Return focus to Combobox cell
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[dataGridView.CurrentCell.ColumnIndex];
                //Initiate Edit mode
                dataGridView.BeginEdit(true);
                return;
            }
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1];
            dataGridView.BeginEdit(true);

        }
        private void dataGridViewNewOrders_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                placeOrder();
            }
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            placeOrder();
        }
        private void placeOrder()
        {
            string orderId = "";
            orderId += username[0];
            orderId += DateTime.Now.ToString("yyyyMMddHHmmss");
            if (txtPhone.Text == null || txtPhone.Text == "")
            {
                MessageBox.Show("Please Enter a number to place order", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtPhone.Select();
                return;
            }
            string phone = txtPhone.Text;
            string name = txtName.Text;
            string address = txtAddress.Text;
            bool okay = true;
            for (int i = 0; i < dataGridViewNewOrders.RowCount - 1 && true; i++)
            {
                string code = dataGridViewNewOrders.Rows[i].Cells[itemCode.Index].Value.ToString();
                double qty =
                    double.Parse(dataGridViewNewOrders.Rows[i].Cells[quantity.Index].Value.ToString());
                double itemTotal = double.Parse(dataGridViewNewOrders.Rows[i].Cells[4].Value.ToString());
                //string username = "ali";

                if (!orders.insertPendingDelivery(code, qty, itemTotal, phone,name,address,orderId))
                {
                    okay = MessageBox.Show(
                               "Problem while adding this Order:>" + code + "\nItem Name:>" +
                               orders.getName(code) + "Press Cancel to " +
                               "Stop Orders or Okay to add Next Items",
                               "Error", MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Asterisk) == DialogResult.OK;
                    if (!okay)
                        return;

                }
            }
            dataGridViewNewOrders.Rows.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtName.Select();
            //cmbTableNumbers.Items.Clear();
            //setTables();
            //cmbTableNumbers.Select();
        }
        private void dataGridViewNewOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == itemName.Index)
            {
                if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value == null)
                {
                    return;
                }
                string code = dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value.ToString();
                string name = orders.getName(code);
                dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemName.Index].Value = name;
            }
            if (e.ColumnIndex == itemTotal.Index)
            {
                if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value == null)
                    return;

                if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value == null)
                {
                    dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value = 1;
                }
                try
                {
                    dataGridViewNewOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                        Double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[price.Index].Value.ToString()) *
                        Double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value.ToString());
                    double t = double.Parse(txtTotal.Text);
                    t += double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    txtTotal.Text = t.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Enter Valid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            if (e.ColumnIndex < price.Index)
            {
                string code = null;
                if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value != null)
                    code = dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value.ToString();
                if (code == null)
                {
                    return;
                }
                double dbPrice = orders.getPrice(code);
                dataGridViewNewOrders.Rows[e.RowIndex].Cells[price.Index].Value = dbPrice;
            }
            if (e.ColumnIndex == price.Index)
            {
                string code = null;
                if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value != null)
                    code = dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value.ToString();
                if (code == null)
                {
                    if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemName.Index].Value == null)
                        return;
                    string name = dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemName.Index].Value.ToString();
                    if (name == "" || name == null)
                    {
                        dataGridViewNewOrders.BeginEdit(false);
                        MessageBox.Show("Please Select or Add Name or Code",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridViewNewOrders.Rows[e.RowIndex].Cells[0].Selected = true;
                        dataGridViewNewOrders.BeginEdit(true);
                        return;
                    }
                    code = orders.getItemCode(name);

                    dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemCode.Index].Value = code;
                }
                double dbPrice = orders.getPrice(code);
                dataGridViewNewOrders.Rows[e.RowIndex].Cells[price.Index].Value = dbPrice;
            }
            if (e.ColumnIndex == quantity.Index && dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value == null)
            {
                dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value = 1;
            }

        }
        private void dataGridViewNewOrders_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            double t = double.Parse(txtTotal.Text);
            if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemTotal.Index].Value == null)
                return;
            else
            {
                t -= double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemTotal.Index].Value.ToString());
            }
            if (dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value != null)
            {
                try
                {
                    dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemTotal.Index].Value =
                        Double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[price.Index].Value.ToString()) *
                        Double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value.ToString());

                    t += double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemTotal.Index].Value.ToString());
                    txtTotal.Text = t.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Enter Valid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshTables_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();
            
            List<MarhabaDatabase.pending_deliveries> pendingDeliveriese = orders.getPendingDeliveries();
            string id = "";
            foreach (pending_deliveries pendingDeliveries in pendingDeliveriese)
            {
                if (pendingDeliveries.order_id == id)
                    continue;
                customItem item = new customItem(pendingDeliveries.phone_number,pendingDeliveries.address,
                    pendingDeliveries.name,pendingDeliveries.order_id);
                listOrders.Items.Add(item);
                id = pendingDeliveries.order_id;
            }
        }

        private void listOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOrders.SelectedItem == null)
                return;
            dataGridViewPendingOrders.Rows.Clear();
            selectedPhone = listOrders.SelectedItem as customItem;
            customItem item = listOrders.SelectedItem as customItem;
            int numberOfItemsForOrder = orders.getNumberOfPendingDeliveries(item.orderId);
            recCount = numberOfItemsForOrder;
            dataGridViewPendingOrders.Rows.Add(numberOfItemsForOrder);
            IQueryable<MarhabaDatabase.pending_deliveries> pendingDeliveries = 
                orders.GetPendingDeliveries(item.orderId);
            int index = 0;
            double? total = 0.0;
            foreach (pending_deliveries deliveries in pendingDeliveries)
            {
                dataGridViewPendingOrders.Rows[index].Cells[itemCodePendinding.Index].Value = deliveries.item_code;
                dataGridViewPendingOrders.Rows[index].Cells[itemNamePending.Index].Value = orders.getName(deliveries.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[pricePending.Index].Value = orders.getPrice(deliveries.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[quantityPending.Index].Value = deliveries.qty;
                dataGridViewPendingOrders.Rows[index].Cells[itemTotalPending.Index].Value = deliveries.item_total;
                pendingOrderIds.Add(deliveries.id);
                total += deliveries.item_total;
                index++;
            }
            txtPendingTotal.Text = total.ToString();
            ConfigurationReader configurationReader=new ConfigurationReader();

            txtGST.Text = configurationReader.getGST().ToString();
            double? gtotal = total * configurationReader.getGST();
            gtotal = gtotal / 100;
            gtotal = total + gtotal;
            txtGrandTotal.Text = gtotal.ToString();
            //listOrders.Items.Clear();
        }

        private void dataGridViewPendingOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double t = double.Parse(txtPendingTotal.Text);
            if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value == null)
                return;
            else
            {
                try
                {
                    t -= double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value
                        .ToString());
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Enter Valid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value != null)
            {
                try
                {
                    dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value =
                        Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[pricePending.Index].Value.ToString()) *
                        Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value.ToString());

                    t += double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value.ToString());
                    txtPendingTotal.Text = t.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Enter Valid Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewPendingOrders_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.Name == "Qty")
            {
                TextBox q = e.Control as TextBox;
                if (q != null)
                {
                    q.Enabled = true;
                }
            }
            e.Control.Enabled = true;
        }

        private void dataGridViewPendingOrders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rowIndex = e.Row.Index;
            double total = Double.Parse(txtPendingTotal.Text);
            double subTotal = Double.Parse(dataGridViewPendingOrders.Rows[rowIndex].Cells[itemTotalPending.Index].Value.ToString());
            total -= subTotal;
            txtPendingTotal.Text = total.ToString();
            orders.removePendingDeliveries(pendingOrderIds[rowIndex]);
            pendingOrderIds.Remove(pendingOrderIds[rowIndex]);
        }

        private void dataGridViewPendingOrders_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null || dataGridView.CurrentCell.ColumnIndex != 0
                || dataGridView.CurrentCell.ColumnIndex != 1) return;
            var dataGridViewComboBoxCell = dataGridView.CurrentCell as DataGridViewComboBoxCell;
            if (dataGridViewComboBoxCell != null)
            {
                //Here we move focus to second cell of current row
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[2];
                //Return focus to Combobox cell
                dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[dataGridView.CurrentCell.ColumnIndex];
                //Initiate Edit mode
                dataGridView.BeginEdit(true);
                return;
            }
            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1];
            dataGridView.BeginEdit(true);
        }

        private void dataGridViewPendingOrders_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == itemNamePending.Index)
            {
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value == null)
                {
                    return;
                }
                string code = dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value.ToString();
                string name = orders.getName(code);
                dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemNamePending.Index].Value = name;
            }
            if (e.ColumnIndex == itemTotalPending.Index)
            {
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value == null)
                    return;

                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value == null)
                {
                    dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value = 1;
                }
                try
                {
                    dataGridViewPendingOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                        Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[pricePending.Index].Value.ToString()) *
                        Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value.ToString());
                    double t = double.Parse(txtPendingTotal.Text);
                    t += double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    txtPendingTotal.Text = t.ToString();
                    double? gst;
                    ConfigurationReader configurationReader = new ConfigurationReader();
                    gst = configurationReader.getGST();
                    double? grandTotal = ((t * gst) / 100) + t;
                    txtGrandTotal.Text = grandTotal.ToString();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Enter Valid Inputs\n" + exception.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
              
            }
            if (e.ColumnIndex < pricePending.Index)
            {
                string code = null;
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value != null)
                    code = dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value.ToString();
                if (code == null)
                {
                    return;
                }
                double dbPrice = orders.getPrice(code);
                dataGridViewPendingOrders.Rows[e.RowIndex].Cells[pricePending.Index].Value = dbPrice;
            }

            if (e.ColumnIndex == pricePending.Index)
            {
                string code = null;
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value != null)
                    code = dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value.ToString();
                if (code == null)
                {
                    string name = dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemNamePending.Index].Value.ToString();
                    if (name == "" || name == null)
                    {
                        dataGridViewPendingOrders.BeginEdit(false);
                        MessageBox.Show("Please Select or Add Name or Code",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridViewPendingOrders.Rows[e.RowIndex].Cells[0].Selected = true;
                        dataGridViewPendingOrders.BeginEdit(true);
                        return;
                    }
                    code = orders.getItemCode(name);

                    dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemCodePendinding.Index].Value = code;
                }
                double dbPrice = orders.getPrice(code);
                dataGridViewPendingOrders.Rows[e.RowIndex].Cells[pricePending.Index].Value = dbPrice;
            }
            if (e.ColumnIndex == quantityPending.Index && dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value == null)
            {
                dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value = 1;
            }
        }

        private void dataGridViewPendingOrders_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == itemTotalPending.Index)
            {

            }

            if (e.ColumnIndex == quantityPending.Index)
            {
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    dataGridViewPendingOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                }
            }
        }

        private customItem selectedPhone;
        private int recCount = 0;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridViewPendingOrders.RowCount - 1; i++)
            {
                try
                {
                    string code = dataGridViewPendingOrders.Rows[i].Cells[itemCodePendinding.Index].Value.ToString();
                    string name = dataGridViewPendingOrders.Rows[i].Cells[itemNamePending.Index].Value.ToString();
                    double price = Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[pricePending.Index].Value.ToString());
                    double qty = Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[quantityPending.Index].Value.ToString());
                    double total = Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value.ToString());
                    string phone = selectedPhone.phone;
                    if (i < pendingOrderIds.Count)
                    {
                        orders.updatePendingDelivery(code, qty, total, selectedPhone.orderId, phone, pendingOrderIds[i]);
                    }
                    else
                    {
                        orders.updatePendingDelivery(code, qty, total, selectedPhone.orderId, phone, -1);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error with following order\n" +
                                    dataGridViewPendingOrders.Rows[i].Cells[itemCodePendinding.Index].Value.ToString(),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            dataGridViewPendingOrders.Rows.Clear();
        }

        private void chkGST_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkGST.Checked)
            {
                txtGST.Text = "";
            }
            else
            {
                ConfigurationReader configurationReader = new ConfigurationReader();
                txtGST.Text = configurationReader.getGST().ToString();
            }
            CalculateTotal();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            customItem item = listOrders.SelectedItem as customItem;
            string orderId;
            if (!chkId.Checked)
            {
                orderId = item.orderId;
            }
            else
            {
                orderId = txtNewId.Text.ToString();
            }
            for (int i = 0; i < dataGridViewPendingOrders.RowCount - 1; i++)
            {
                string itemCode = dataGridViewPendingOrders.Rows[i].Cells[itemCodePendinding.Index].Value.ToString();
                double qty = double.Parse(dataGridViewPendingOrders.Rows[i].Cells[quantityPending.Index].Value
                    .ToString());
                double total = double.Parse(dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value
                    .ToString());
                orders.insertToBillItems(orderId, itemCode, qty, total,"delivery");
                orders.removePendingDeliveries(pendingOrderIds[i]);
            }
            double grandTotal = Double.Parse(txtGrandTotal.Text);
            //double cashRcvd = double.Parse(txtAmountRcvd.Text);
            double totalWithoutGST = double.Parse(txtPendingTotal.Text);
            orders.insertBill(orderId, grandTotal,totalWithoutGST, username, "", "delivery",item.phone);
            orders.insertClosing(orderId, grandTotal, username, "", "delivery", item.phone);
            Customer customer=new Customer();
            customer.addCustomer(item);
            dataGridViewPendingOrders.Rows.Clear();
            refreshOrders();
            bool isNameNumber = false;
            if (MessageBox.Show("Do you want to add Name and Number?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                isNameNumber = true;
            }
            BillForm billForm;
            if (!type)
                billForm = new BillForm(grandTotal, item.phone, totalWithoutGST, true, orderId, username, true,false,item,isNameNumber,chkService.Checked, chkDiscount.Checked, cmbDiscount.Text, Convert.ToInt32(txtGST.Text));
            else
                billForm = new BillForm(grandTotal, item.phone, totalWithoutGST, chkGST.Checked, orderId, username, true, false, item,isNameNumber,chkService.Checked, chkDiscount.Checked, cmbDiscount.Text, Convert.ToInt32(txtGST.Text));
            billForm.Show();
           // chkGST.Checked = true;
            listOrders.Items.Remove(item);
            if (chkId.Checked)
            {
                chkId.Checked = false;
                txtNewId.Text = "";
                txtNewId.Enabled = false;
            }
        }

        private void refreshOrders()
        {
            
        }

        private void txtPendingTotal_TextChanged(object sender, EventArgs e)
        {
            ConfigurationReader configurationReader = new ConfigurationReader();

            txtGST.Text = configurationReader.getGST().ToString();
            txtService.Text = "5";
            double pendingTotal = Double.Parse(txtPendingTotal.Text);
            double? grandTotal = pendingTotal * configurationReader.getGST();
            grandTotal /= 100;
            grandTotal = pendingTotal + grandTotal;
            grandTotal = roundupbyten(grandTotal);
            if (chkService.Checked)
            {
                double servicecharge = pendingTotal * Convert.ToInt32(txtService.Text);
                servicecharge /= 100;
                grandTotal = grandTotal + servicecharge;
                grandTotal = roundupbyten(grandTotal);
            }

            txtGrandTotal.Text = grandTotal.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phone = txtPhoneSearch.Text;
            bool found = orders.findPhone(phone);
            if (found)
            {
                int i = listOrders.Items.IndexOf(phone);
                if (i >= 0)
                    listOrders.SetSelected(i, true);
                else
                {
                    MessageBox.Show("Refresh Orders List", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Order with this Number", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ChkService_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkService.Checked)
            {
                txtService.Text = "";
            }
            else
            {
                txtService.Text = "5";
            }
            CalculateTotal();
        }

        public int roundupbyten(double? i)
        {

            int ii = (int)i;
            int remainder = ii % 10;
            if (remainder == 0)
                return ii;
            else
                return ii - remainder;
            // ii += (remainder < 10 / 2) ? -remainder : (10 - remainder);
            // return ii;
        }

        private void CmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        void CalculateTotal()
        {
            double grandtotal = Double.Parse(txtPendingTotal.Text);
            double gst = 0, service = 0, discount = 0;
            if (chkGST.Checked)
            {
                gst = getAmount(txtGST.Text);
            }
            if (chkService.Checked)
            {
                service = getAmount(txtService.Text);
            }
            if (chkDiscount.Checked)
            {
                discount = getAmount(cmbDiscount.Text);
            }
            grandtotal = grandtotal + gst + service - discount;
            grandtotal = roundupbyten(grandtotal);
            txtGrandTotal.Text = grandtotal.ToString();
        }

        double getAmount(string value)
        {
            double grandtotal = Double.Parse(txtPendingTotal.Text);
            double amount = Double.Parse(txtPendingTotal.Text) * Double.Parse(value);
            amount /= 100;
            return amount;
        }

        private void ChkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkDiscount.Checked)
            {
                cmbDiscount.Enabled = false;
            }
            else
            {
                cmbDiscount.Enabled = true;
            }
            CalculateTotal();
        }

        private void ChkId_CheckedChanged(object sender, EventArgs e)
        {
            IdPassword password = new IdPassword();
            if (chkId.Checked)
            {
                var dialogResult = password.ShowDialog();

                if (password.getstatus())
                {
                    txtNewId.Enabled = true;
                }
            }
            else
            {
                chkId.Checked = false;
                txtNewId.Text = "";
                txtNewId.Enabled = false;
            }
        }
    }

    public class customItem
    {
        public string phone, address, name, orderId;
        public customItem(string phone, string address, string name, string orderId)
        {
            this.phone = phone;
            this.address = address;
            this.name = name;
            this.orderId = orderId;
        }

        public override string ToString()
        {
            return phone;
        }

        public override bool Equals(object obj)
        {
            ;
            if (obj.ToString() == this.phone)
                return true;
            return false;
        }
    }
}
