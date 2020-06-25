using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MarhabaDatabase;
using MarhabaMahal.BLClasses;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using Message = System.Web.Services.Description.Message;

namespace MarhabaMahal.Views
{
    public partial class OrdersPanel : UserControl
    {
        private string username;
        private bool admin;
        public string tempid = "";
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
        public DataGridViewRow ordersRow { get; set; }
        private Orders orders;
        private List<Int64> pendingOrderIds;
        public bool searchBill = false;
        private string searchBillId;
        public string NewId = "";
        public bool chkInfo = false;
        public bool IsServerOn = false;
        public TcpListener tcp;
        int currOrder = 1, totalOrder = 0;
        private void refreshClosingBillList()
        {
            listBoxClosingBillsId.Items.Clear();

            IQueryable<closing_view> closing = orders.getClosingView();
            foreach (closing_view closingView in closing)
            {
                listBoxClosingBillsId.Items.Insert(0, closingView.bill_code);
                //listBoxClosingBillsId.Items.Add(closingView.bill_code);
            }
        }
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

            itemNamePending.Name = "Name";
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

            itemName.Width = 300;
            itemName.ReadOnly = false;
            itemNamePending.Width = 200;


            price.ReadOnly = true;
            price.Name = "Price";
            quantity.ReadOnly = false;
            quantity.Name = "Qty";
            itemTotal.ReadOnly = true;
            itemTotal.Name = "Total";
        }
        public OrdersPanel(string username, bool admin)
        {
            this.username = username;
            this.admin = admin;
            InitializeComponent();
            initializeGridViews();
            orders = new Orders(username);
            pendingOrderIds = new List<Int64>();
            chkId.Checked = false;
            txtNewId.Text = "";
            txtNewId.Enabled = false;
        }

        public class tableItemsDetails
        {
            public string tableNo { get; set; }
            public string rcvd { get; set; }
            public string billId { get; set; }
            public override string ToString()
            {
                return tableNo;
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void setTables()
        {
            Tables tbl = new Tables();
            List<MarhabaDatabase.table> list = tbl.GetTables();
            cmbTableNumbers.Items.Clear();
            foreach (table tblTable in list)
            {
                cmbTableNumbers.Items.Add(tblTable.table_name);
            }
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

        class pendingPaymentItems
        {
            public string tables { get; set; }
            public double payment { get; set; }
            public int id { get; set; }

            public string billId { get; set; }
            public override string ToString()
            {
                return tables;
            }
        }

        private void refreshPendingPayments()
        {
            listPending.Items.Clear();
            IQueryable<pending_payment> pendingPayments = orders.GetPendingPayments();
            foreach (pending_payment pendingPayment in pendingPayments)
            {
                pendingPaymentItems item = new pendingPaymentItems();
                item.tables = pendingPayment.tables;
                item.payment = pendingPayment.total_bill;
                item.id = pendingPayment.id;
                item.billId = pendingPayment.bill_id;
                listPending.Items.Add(item);
            }
        }
        private void OrdersPanel_Load(object sender, EventArgs e)
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

            ordersRow = new DataGridViewRow();
            ordersRow = dataGridViewNewOrders.Rows[0];
            chkGST.Checked = true;
            checkBoxService.Checked = false;
            chkDiscount.Checked = false;
            cmbDiscount.Enabled = false;
            chkId.Checked = false;
            txtNewId.Enabled = false;
            setTables();
            setMenuNames();
            refreshTables();
            if (!admin)
            {
                chkGST.Visible = false;
                checkBoxService.Visible = false;
                chkDiscount.Visible = false;
                cmbDiscount.Visible = false;
                chkId.Visible = false;
                txtNewId.Visible = false;
                txtSearchBillId.Visible = false;
                btnSearch.Visible = false;
                lblSearch.Visible = false;
            }
            refreshPendingPayments();
            refreshClosingBillList();
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


        private void dataGridViewNewOrders_EditingControlShowing(object sender,
            DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.Name == "Name")
            {
                ComboBox cbx = e.Control as ComboBox;
                cbx.DropDownStyle = ComboBoxStyle.DropDown;
                cbx.AutoCompleteSource = AutoCompleteSource.ListItems;
                cbx.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            if (e.Control.Name == "Qty")
            {
                TextBox q = e.Control as TextBox;
                if (q != null)
                {
                    q.Enabled = true;
                }
            }
            if (e.Control.Name == "Code")
            {
                TextBox q = e.Control as TextBox;
                q.CharacterCasing = CharacterCasing.Upper;
            }
            e.Control.Enabled = true;
        }
        private void dataGridViewNewOrders_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
        private void dataGridViewNewOrders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int rowIndex = e.Row.Index;
            double total = Double.Parse(txtTotal.Text);
            double subTotal = Double.Parse(dataGridViewNewOrders.Rows[rowIndex].Cells[itemTotal.Index].Value.ToString());
            total -= subTotal;
            txtTotal.Text = total.ToString();
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
                    throw;
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
        private void placeOrder()
        {
            if (cmbTableNumbers.SelectedItem == null)
            {
                MessageBox.Show("Please select Table for order", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cmbTableNumbers.Select();
                return;
            }
            string tbl = cmbTableNumbers.SelectedItem.ToString();
            bool okay = true;
            if (tbl == "" || tbl == null)
            {
                MessageBox.Show("Please select Table for order", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            for (int i = 0; i < dataGridViewNewOrders.RowCount - 1 && true; i++)
            {
                string code = dataGridViewNewOrders.Rows[i].Cells[itemCode.Index].Value.ToString();
                double qty =
                    double.Parse(dataGridViewNewOrders.Rows[i].Cells[quantity.Index].Value.ToString());
                double itemTotal = double.Parse(dataGridViewNewOrders.Rows[i].Cells[4].Value.ToString());
                string username = this.username;
                // int tableNumber = Int32.Parse(tbl);

                if (!orders.insertPendingOrders(code, qty, itemTotal, username, tbl))
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
            //cmbTableNumbers.Items.Clear();
            //setTables();
            cmbTableNumbers.Select();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            placeOrder();
            cmbTableNumbers.Items.Remove(cmbTableNumbers.SelectedItem);
            if (totalOrder > 1 && currOrder < totalOrder)
            {
                currOrder = currOrder + 1;
                getAutomaticOrder();
            }
            else
                currOrder = 1;
        }

        private void cmbTableNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewNewOrders_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                placeOrder();
                cmbTableNumbers.Items.Remove(cmbTableNumbers.SelectedItem);
            }

        }

        private void cmbTableNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                placeOrder();
            }

        }

        private void refreshTables()
        {
            List<string> pendingTables = orders.getPendingTables();
            tableItemsDetails itemsDetails;
            if (pendingTables == null)
                return;
            listTables.Items.Clear();
            foreach (string pendingTable in pendingTables)
            {
                itemsDetails = new tableItemsDetails();
                itemsDetails.tableNo = pendingTable;
                itemsDetails.rcvd = "";
                listTables.Items.Add(itemsDetails);
            }
        }

        private tableItemsDetails classItem;
        private void btnRefreshTables_Click(object sender, EventArgs e)
        {
            refreshTables();
        }
        private void listTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTables.SelectedItem == null)
                return;
            searchBill = false;
            tableItemsDetails item = listTables.SelectedItem as tableItemsDetails;
            classItem = item;
            dataGridViewPendingOrders.Rows.Clear();
            string table = listTables.SelectedItem.ToString();
            int numberOfOrdersForTable = orders.getNumberOfPendingOrders(table);
            pendingOrderIds.Clear();
            dataGridViewPendingOrders.Rows.Add(numberOfOrdersForTable);
            List<MarhabaDatabase.pending_order> pendingOrders = orders.GetPendingOrders(table);
            //  DataGridViewRow row = dataGridViewPendingOrders.Rows[0].Clone() as DataGridViewRow;
            int index = 0;
            double total = 0.0;
            foreach (pending_order order in pendingOrders)
            {
                //row = new DataGridViewRow();
                dataGridViewPendingOrders.Rows[index].Cells[itemCodePendinding.Index].Value = order.item_code;
                dataGridViewPendingOrders.Rows[index].Cells[itemNamePending.Index].Value = orders.getName(order.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[pricePending.Index].Value = orders.getPrice(order.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[quantityPending.Index].Value = order.qty;
                dataGridViewPendingOrders.Rows[index].Cells[itemTotalPending.Index].Value = order.item_total;
                pendingOrderIds.Add(order.id);
                total += order.item_total;
                index++;
                //dataGridViewPendingOrders.Rows.Add();
                //row.Dispose();
            }
            txtPendingTotal.Text = total.ToString();

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
                dataGridViewPendingOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value =
                    Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[pricePending.Index].Value.ToString()) *
                    Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value.ToString());
                //double t = double.Parse(txtPendingTotal.Text);
                //t += double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                //txtPendingTotal.Text = t.ToString();
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

        private void dataGridViewPendingOrders_Validating(object sender, CancelEventArgs e)
        {

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
            if (e.Control.Name == "Code")
            {
                TextBox q = e.Control as TextBox;
                q.CharacterCasing = CharacterCasing.Upper;
            }
            e.Control.Enabled = true;
        }

        private void dataGridViewPendingOrders_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (searchBill)
            {
                int rowIndex = e.Row.Index;
                double total = Double.Parse(txtPendingTotal.Text);
                double subTotal = Double.Parse(dataGridViewPendingOrders.Rows[rowIndex].Cells[itemTotalPending.Index].Value.ToString());
                total -= subTotal;
                txtPendingTotal.Text = total.ToString();
                string billId = searchBillId;
                searchBill = false;
                double gtotal = Double.Parse(txtGrandTotal.Text);
                string itemCode = dataGridViewPendingOrders.Rows[rowIndex].Cells[itemCodePendinding.Index].Value
                    .ToString();
                orders.removeBillItem(billId, itemCode);
                searchBill = false;
                dataGridViewPendingOrders.Rows.Clear();
                showAfterSearch();
            }
            else
            {
                int rowIndex = e.Row.Index;
                double total = Double.Parse(txtPendingTotal.Text);
                double subTotal = Double.Parse(dataGridViewPendingOrders.Rows[rowIndex].Cells[itemTotalPending.Index].Value.ToString());
                total -= subTotal;
                txtPendingTotal.Text = total.ToString();
                orders.removePendingOrder(pendingOrderIds[rowIndex]);
                pendingOrderIds.Remove(pendingOrderIds[rowIndex]);
            }

        }

        private void dataGridViewPendingOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double t = double.Parse(txtPendingTotal.Text);
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value == null)
                    return;
                else
                {
                    t -= double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value.ToString());
                }
                if (dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value != null)
                {
                    dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value =
                        Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[pricePending.Index].Value.ToString()) *
                        Double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[quantityPending.Index].Value.ToString());

                    t += double.Parse(dataGridViewPendingOrders.Rows[e.RowIndex].Cells[itemTotalPending.Index].Value.ToString());
                    txtPendingTotal.Text = t.ToString();
                }
                double total = 0;
                for (int i = 0; i < dataGridViewPendingOrders.RowCount - 1; i++)
                {
                    if (dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value == null)
                        return;
                    total += Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value.ToString());
                }
                txtPendingTotal.Text = total.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Check if Inputs are Valid\n" + exception.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (searchBill)
            {
                updateOrder();
                return;
            }

            for (int i = 0; i < dataGridViewPendingOrders.RowCount - 1; i++)
            {
                try
                {
                    string code = dataGridViewPendingOrders.Rows[i].Cells[itemCodePendinding.Index].Value.ToString();
                    string name = dataGridViewPendingOrders.Rows[i].Cells[itemNamePending.Index].Value.ToString();
                    double price = Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[pricePending.Index].Value.ToString());
                    double qty = Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[quantityPending.Index].Value.ToString());
                    double total = Double.Parse(dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value.ToString());
                    int tableNumber = Int32.Parse(listTables.SelectedItem.ToString());
                    if (i < pendingOrderIds.Count)
                    {
                        orders.updatePendingOrders(code, qty, total, username, listTables.SelectedItem.ToString(), pendingOrderIds[i]);
                    }
                    else
                    {
                        orders.updatePendingOrders(code, qty, total, username, listTables.SelectedItem.ToString(), -1);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show("Check the following Rows for errors in Inputs\n" +
                        (i + 1).ToString(), "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //orders.updatePendingPayments(listTables.SelectedItem.ToString());
            }
            dataGridViewPendingOrders.Rows.Clear();
        }

        private void txtPendingTotal_TextChanged(object sender, EventArgs e)
        {
              ConfigurationReader configurationReader = new ConfigurationReader();

              txtGST.Text = configurationReader.getGST().ToString();
              txtService.Text = "5";
              double pendingTotal = Double.Parse(txtPendingTotal.Text);
            //  pendingTotal = roundupbyten(pendingTotal);
              double? grandTotal = pendingTotal * configurationReader.getGST();
              grandTotal /= 100;
              grandTotal = pendingTotal + grandTotal;
              grandTotal = roundupbyten(grandTotal);

            if (checkBoxService.Checked)
            {
                double servicecharge = pendingTotal * Convert.ToInt32(txtService.Text);
                servicecharge /= 100;
                grandTotal = grandTotal + servicecharge;
                grandTotal = roundupbyten(grandTotal);
            }
              txtGrandTotal.Text = grandTotal.ToString();
        }

        private void dataGridViewNewOrders_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
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
                    dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemTotal.Index].Value =
                        Double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[price.Index].Value.ToString()) *
                        Double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[quantity.Index].Value.ToString());

                    t += double.Parse(dataGridViewNewOrders.Rows[e.RowIndex].Cells[itemTotal.Index].Value.ToString());
                    t = roundupbyten(t);
                    txtTotal.Text = t.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Please Check Your Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int roundupbyten(int i)
        {
            // return i + (10 - i % 10); <-- logic error. Oops!
            return (int)(Math.Ceiling(i / 10.0d) * 10); // fixed
        }
        public int roundupbyten(double? i)
        {
            int ii = (int)i;
            int remainder = ii % 10;
            if (remainder == 0)
                return ii;
            else
                return ii - remainder;
            //ii += (remainder < 10 / 2) ? -remainder : (10 - remainder);

        }

        public void updateOrder()
        {
            bool billexist = false;
            string tbl = "";
            if(orders.getBillStatus(txtSearchBillId.Text.ToString()))
            {
                billexist = true;
                tbl = orders.getTable(txtSearchBillId.Text.ToString()).ToString();
            }
            if (CheckIfBillExist(txtSearchBillId.Text.ToString()))
            {
                for (int i = 0; i < dataGridViewPendingOrders.RowCount - 1; i++)
                {
                    string itemCode = dataGridViewPendingOrders.Rows[i].Cells[itemCodePendinding.Index].Value.ToString();
                    double qty = double.Parse(dataGridViewPendingOrders.Rows[i].Cells[quantityPending.Index].Value
                        .ToString());
                    double total = double.Parse(dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value
                        .ToString());
                    if (pendingOrderIds.Count > i)
                        orders.updateBillItems(pendingOrderIds[i], searchBillId, itemCode, qty, total, "order");
                    else
                        orders.insertToBillItems(searchBillId, itemCode, qty, total, "order");

                }
            }
            double grandTotal = Double.Parse(txtGrandTotal.Text);
            grandTotal = roundupbyten(grandTotal);
            //double cashRcvd = double.Parse(txtAmountRcvd.Text);
            double totalWithoutGST = double.Parse(txtPendingTotal.Text);
            totalWithoutGST = roundupbyten(totalWithoutGST);
            if (CheckIfBillExist(txtSearchBillId.Text.ToString()))
            {
                orders.updateBill(searchBillId, grandTotal, username, "order", "",totalWithoutGST);
                // add a check to see if entry existed in closing simple update else check 
                //total and if less add a negative value of the difference
                orders.updateClosing(searchBillId, grandTotal, username, "order updated", "");
            }
            dataGridViewPendingOrders.Rows.Clear();
            bool payedStatus = orders.getBillPayedStatus(searchBillId);
            refreshTables();
            bool isNameNumber = false;
            if (chkNameNmbr.Checked)
            {
                isNameNumber = true;
            }
            BillForm billForm;
            if (!admin)
                billForm = new BillForm(grandTotal, tbl, totalWithoutGST, true, searchBillId, username, false, payedStatus, null,isNameNumber,checkBoxService.Checked,chkDiscount.Checked,cmbDiscount.Text, Convert.ToInt32(txtGST.Text));
            else
                billForm = new BillForm(grandTotal, tbl, totalWithoutGST, chkGST.Checked, searchBillId, username, false, payedStatus, null,isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text, Convert.ToInt32(txtGST.Text));

            if (isNameNumber)
                billForm.Show();
            else
                billForm.PrintRecp();
            //chkGST.Checked = true;
            searchBill = false;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
           // btnBill.Enabled = false;
           // if (tempid != listTables.SelectedItem.ToString())
            {
                if (searchBill)
                {
                    updateOrder();
                    return;
                }
                string billId="";
                if (!chkId.Checked)
                {
                    billId += username[0];
                    // tempid = table;
                    billId += DateTime.Now.ToString("yyyyMMddHHmmss");
                }
                else
                {
                    billId = txtNewId.Text.ToString();
                }
                string table = listTables.SelectedItem.ToString();
                for (int i = 0; i < dataGridViewPendingOrders.RowCount - 1; i++)
                {
                    string itemCode = dataGridViewPendingOrders.Rows[i].Cells[itemCodePendinding.Index].Value.ToString();
                    double qty = double.Parse(dataGridViewPendingOrders.Rows[i].Cells[quantityPending.Index].Value
                        .ToString());
                    double total = double.Parse(dataGridViewPendingOrders.Rows[i].Cells[itemTotalPending.Index].Value
                        .ToString());
                    if (table != tempid)
                    {
                        orders.insertToBillItems(billId, itemCode, qty, total, "order");
                        orders.removePendingOrder(pendingOrderIds[i]);
                    }
                }

                double grandTotal = Double.Parse(txtGrandTotal.Text);
                //double cashRcvd = double.Parse(txtAmountRcvd.Text);
                double totalWithoutGST = double.Parse(txtPendingTotal.Text);
                int gst_percent = Convert.ToInt32(txtGST.Text);
                if (table != tempid)
                {
                    orders.insertBill(billId, grandTotal, totalWithoutGST, username, table, "order", "");
                    orders.addPendingPayment(table, grandTotal, billId, gst_percent);
                    orders.insertClosing(billId, grandTotal, username, table, "order", "");
                }
                dataGridViewPendingOrders.Rows.Clear();
                setTables();
                BillForm billForm;
                bool isNameNumber = false;
                if(chkNameNmbr.Checked)
                {
                    isNameNumber = true;
                }
                if (!admin)
                    billForm = new BillForm(grandTotal, table, totalWithoutGST, true, billId, username, false, false, null,isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text,Convert.ToInt32(txtGST.Text));
                else
                    billForm = new BillForm(grandTotal, table, totalWithoutGST, chkGST.Checked, billId, username, false, false, null,isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text, Convert.ToInt32(txtGST.Text));
                if (isNameNumber)
                    billForm.Show();
                else
                    billForm.PrintRecp();
               // chkGST.Checked = true;
                //cmbTableNumbers.Items.Add(table);
                refreshPendingPayments();
                if (listTables.Items.Contains(table))
                    listTables.Items.Remove(table);
                refreshClosingBillList();
                tempid = table;
                if(chkId.Checked)
                {
                    chkId.Checked = false;
                    txtNewId.Text = "";
                    txtNewId.Enabled = false;
                }
            }
        }

        private void chkGST_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkGST.Checked)
            {
                txtGST.Enabled = false;
            }
            else
            {
                //ConfigurationReader configurationReader = new ConfigurationReader();
                //txtGST.Text = configurationReader.getGST().ToString();
                txtGST.Enabled = true;
            }
            CalculateTotal();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void showAfterSearch()
        {
            if (txtSearchBillId.Text == "")
                return;
            dataGridViewPendingOrders.Rows.Clear();
            txtPendingTotal.Text = "0";
            txtGrandTotal.Text = "0";
            string billId = txtSearchBillId.Text;
            searchBillId = billId;
            int numberOfOrdersForTable = orders.getNumberOfItemsWithBillId(billId);
            pendingOrderIds.Clear();
            dataGridViewPendingOrders.Rows.Add(numberOfOrdersForTable);
            IQueryable<MarhabaDatabase.bill_item> billItems = orders.GetBillItems(billId);
            //  DataGridViewRow row = dataGridViewPendingOrders.Rows[0].Clone() as DataGridViewRow;
            int index = 0;
            double total = 0.0;
            foreach (bill_item billItem in billItems)
            {
                //row = new DataGridViewRow();
                dataGridViewPendingOrders.Rows[index].Cells[itemCodePendinding.Index].Value = billItem.item_code;
                dataGridViewPendingOrders.Rows[index].Cells[itemNamePending.Index].Value = orders.getName(billItem.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[pricePending.Index].Value = orders.getPrice(billItem.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[quantityPending.Index].Value = billItem.item_qty;
                dataGridViewPendingOrders.Rows[index].Cells[itemTotalPending.Index].Value = billItem.total_bill;
                pendingOrderIds.Add(billItem.id);
                total += billItem.total_bill;
                index++;
                //dataGridViewPendingOrders.Rows.Add();
                //row.Dispose();
            }
            txtPendingTotal.Text = total.ToString();
            searchBill = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchBillId.Text == "")
                return;
            dataGridViewPendingOrders.Rows.Clear();
            txtPendingTotal.Text = "0";
            txtGrandTotal.Text = "0";
            string billId = txtSearchBillId.Text;
            searchBillId = billId;
            int numberOfOrdersForTable = orders.getNumberOfItemsWithBillId(billId);
            pendingOrderIds.Clear();
            dataGridViewPendingOrders.Rows.Add(numberOfOrdersForTable);
            IQueryable<MarhabaDatabase.bill_item> billItems = orders.GetBillItems(billId);
            //  DataGridViewRow row = dataGridViewPendingOrders.Rows[0].Clone() as DataGridViewRow;
            int index = 0;
            double total = 0.0;
            foreach (bill_item billItem in billItems)
            {
                //row = new DataGridViewRow();
                dataGridViewPendingOrders.Rows[index].Cells[itemCodePendinding.Index].Value = billItem.item_code;
                dataGridViewPendingOrders.Rows[index].Cells[itemNamePending.Index].Value = orders.getName(billItem.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[pricePending.Index].Value = orders.getPrice(billItem.item_code);
                dataGridViewPendingOrders.Rows[index].Cells[quantityPending.Index].Value = billItem.item_qty;
                dataGridViewPendingOrders.Rows[index].Cells[itemTotalPending.Index].Value = billItem.total_bill;
                pendingOrderIds.Add(billItem.id);
                total += billItem.total_bill;
                index++;
                //dataGridViewPendingOrders.Rows.Add();
                //row.Dispose();
            }
            txtPendingTotal.Text = total.ToString();
            searchBill = true;
        }

        private void btnPendingBillsRefresh_Click(object sender, EventArgs e)
        {
            refreshPendingPayments();
            setTables();
        }

        private void listPending_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPending.SelectedItem == null)
                return;
            string table = listPending.SelectedItem.ToString();
            double bi = orders.getPendingPayemnt(table);
            pendingPaymentItems item = (pendingPaymentItems)listPending.SelectedItem;
            lblTotalBill.Text = item.payment.ToString();
        }

        private void btnRcvdDone_Click(object sender, EventArgs e)
        {
            if (listPending.SelectedItem == null)
                return;
            string table = listPending.SelectedItem.ToString();

            pendingPaymentItems item = listPending.SelectedItem as pendingPaymentItems;
            string billId = item.billId;
            BillForm billForm;
            Orders orders = new Orders(this.username);
            double grandTotal = orders.getGrandTotal(billId).Value;
            double totalWithoutGST = Double.Parse(txtPendingTotal.Text);
            int gst_percent = orders.getGstPercent(billId).Value;
           // totalWithoutGST /= 100;
           // totalWithoutGST = grandTotal - totalWithoutGST;
            bool isNameNumber = false;
            if (chkNameNmbr.Checked)
            {
                isNameNumber = true;
            }
            if (!admin)
                billForm = new BillForm(grandTotal, table, totalWithoutGST, true, billId, username, false, true, null,isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text, gst_percent);
            else
                billForm = new BillForm(grandTotal, table, totalWithoutGST, chkGST.Checked, billId, username, false, true, null,isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text, gst_percent);

            if (isNameNumber)
                billForm.Show();
            else
                billForm.PrintRecp();
            orders.removePendingPayments(item.id);
            refreshPendingPayments();
            setTables();
        }

        private void listBoxClosingBillsId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxClosingBillsId.SelectedItem == null)
                return;
            string billId = listBoxClosingBillsId.SelectedItem.ToString();
            string tble = "";
            if (orders.getBillStatus(billId))
                tble = orders.getTable(billId).ToString();

            Clipboard.SetText(billId);
            BillForm billForm;
            tabControl1.SelectedTab = pendingOrders;
            txtSearchBillId.Text = billId;
            btnSearch.Select();
            string gt = orders.getGrandTotal(billId).ToString();
            double grandTotal = Double.Parse(gt);
            ConfigurationReader readre = new ConfigurationReader();
            double? gst = readre.getGST();

            double totalWithoutGST = grandTotal * 16;
            totalWithoutGST /= 100;
            totalWithoutGST = grandTotal - totalWithoutGST;
            bool payedStatus = orders.getBillPayedStatus(billId);
            bool isNameNumber = false;
            if (chkNameNmbr.Checked)
            {
                isNameNumber = true;
            }
            if (!admin)
                billForm = new BillForm(grandTotal, tble, totalWithoutGST, true, billId, username, false, payedStatus, null, isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text, Convert.ToInt32(txtGST.Text));
            else
                billForm = new BillForm(grandTotal, tble, totalWithoutGST, chkGST.Checked, billId, username, false, payedStatus, null,isNameNumber, checkBoxService.Checked, chkDiscount.Checked, cmbDiscount.Text, Convert.ToInt32(txtGST.Text));

            if (isNameNumber)
                billForm.Show();
            else
                billForm.PrintRecp();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefreshNewOrderTables_Click(object sender, EventArgs e)
        {
            setTables();
            if(chkAutomatic.Checked)
                getAutomaticOrder();
        }
        private void btnSwap_Click(object sender, EventArgs e)
        {
            if (listTables.SelectedItem == null)
            {
                return;
            }
            string table = listTables.SelectedItem.ToString();
            TableSwap tableSwap = new TableSwap(table, this);
            tableSwap.Show();
        }

        private void btnUnpaid_Click(object sender, EventArgs e)
        {
            //try
            {
                byte[] encrypted = null;
                Int64 testing = BitConverter.ToInt64(encrypted, 0);
            }
            //catch (Exception exce)
            {
                //  MessageBox.Show(exception)
            }
        }

        private void checkBoxService_CheckedChanged(object sender, EventArgs e)
        {
           /*if (!checkBoxService.Checked)
            {
                txtService.Text = "5";
            }
            else
            {
                txtService.Text = "5";
            }*/
            CalculateTotal();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            IdPassword password = new IdPassword();
            if (chkId.Checked)
            {
                var dialogResult = password.ShowDialog();
               
                if(password.getstatus())
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

        private void CmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        void CalculateTotal()
        {
            double grandtotal = Double.Parse(txtPendingTotal.Text);
            double gst = 0, service = 0, discount = 0;
            if(chkGST.Checked)
            {
                gst = getAmount(txtGST.Text);
            }
            if(checkBoxService.Checked)
            {
                service = getAmount(txtService.Text);
            }
            if(chkDiscount.Checked)
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

        bool CheckIfBillExist(string code)
        {
            bool val = false;
            for(int i=0;i<listBoxClosingBillsId.Items.Count; i++)
            {
                if(code == listBoxClosingBillsId.Items[i].ToString())
                {
                    val = true;
                }
            }
            return val;
        }

        private void ChkAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void getAutomaticOrder()
        {
            int tblnmbr = 0, Total = 0;
            DataTable dtable = new DataTable();
            dtable.Columns.AddRange(new DataColumn[5]
                {
                    new DataColumn(("Sr#"),typeof(string)),
                    new DataColumn(("ProductName"),typeof(string)),
                    new DataColumn(("Quantity"),typeof(string)),
                    new DataColumn(("UPrice"),typeof(string)),
                    new DataColumn(("TPrice"),typeof(string))
                });
            ChangeTcpSettings tcpSettings = new ChangeTcpSettings();
            string output_PATH = @tcpSettings.getPath();
            string data = File.ReadAllText(output_PATH + @"\Order");
            var charsToRemove = new string[] { "\"" };
            string[] norder = data.Split(new string[] { "Table" }, StringSplitOptions.None);
            totalOrder = norder.Length - 1;
            string[] temp1 = norder[currOrder].Split('\n');
            //string[] tbl = temp[0].Split(',');
            //tblnmbr = Convert.ToInt32(tbl[1]);
            int i = 0;
            foreach (string row in norder[currOrder].Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    string setrow = row;
                    foreach (var c in charsToRemove)
                    {
                        setrow = setrow.Replace(c, string.Empty);
                    }
                    string[] temp = setrow.Split(',');
                    if (i == 0)
                    {
                        tblnmbr = Convert.ToInt32(temp[1]);
                    }
                    if (i >= 2 && i < temp1.Length - 6)
                    {
                        dtable.Rows.Add();
                        dtable.Rows[dtable.Rows.Count - 1][0] = temp[0];
                        dtable.Rows[dtable.Rows.Count - 1][1] = temp[1];
                        dtable.Rows[dtable.Rows.Count - 1][2] = temp[2];
                        dtable.Rows[dtable.Rows.Count - 1][3] = temp[3];
                        dtable.Rows[dtable.Rows.Count - 1][4] = temp[4];
                    }
                    if (i == temp1.Length - 3)
                    {
                        Total = Convert.ToInt32(temp[1]);
                    }

                    i++;
                }
            }

            placeAutomaticOrder(dtable, tblnmbr, Total);
        }

        private void placeAutomaticOrder(DataTable data, int tbl, int Total)
        {
            bool okay = true;

            cmbTableNumbers.Text = tbl.ToString();
            cmbTableNumbers.SelectedIndex = cmbTableNumbers.FindStringExact(tbl.ToString());
            //txtTotal.Text = Total.ToString();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                dataGridViewNewOrders.Rows.Add();
                dataGridViewNewOrders.Rows[i].Cells[0].Value = data.Rows[i][0].ToString();
                //dataGridViewNewOrders.Rows[i].Cells[1].Value = data.Rows[i][1].ToString();
                dataGridViewNewOrders.Rows[i].Cells[2].Value = data.Rows[i][3].ToString();
                dataGridViewNewOrders.Rows[i].Cells[3].Value = data.Rows[i][2].ToString();
                dataGridViewNewOrders.Rows[i].Cells[4].Value = data.Rows[i][4].ToString();
            }
        }

        void ReciveFile()
        {
            ChangeTcpSettings tcpSettings = new ChangeTcpSettings();
            int port = tcpSettings.getPort();
            
            Console.WriteLine(">Getting ip");
            if (tcpSettings.getIP() != _getip())
                tcpSettings.setIP(_getip());

            string ip = tcpSettings.getIP();
            Console.WriteLine(">Opening port:" + port);
            TcpListener listener = new TcpListener(IPAddress.Any, 100);//bypass Compiler
            try
            {
                listener = new TcpListener(IPAddress.Parse(ip), port);
            }
            catch
            {
                Console.WriteLine(">ERRROR failed to open port");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine(">Port open");
            Console.WriteLine(">Waiting for connection on");
            Console.WriteLine(">ip  :" + ip);
            Console.WriteLine(">port:" + port);

            //wait for sender
            listener.Start();
            tcp = listener;
            /*while (true)
            {

                if (listener.Pending())
                {
                    break;
                }
            }*/
        }//reciver file from (SendFile) (tcp/ip)

       void listenServer(TcpListener listener)
       {
            ChangeTcpSettings tcpSettings = new ChangeTcpSettings();
            string output_PATH = @tcpSettings.getPath(); //files gotten
            int BytesPerRead = 2048;//bytes to read and then write

            if (listener.Pending())
            {
                //here you receive the file
                using (var client = listener.AcceptTcpClient())
                using (var stream = client.GetStream())
                using (var output = File.Create(output_PATH + @"\Order"))
                {

                    Console.WriteLine(">connected :" + client.Client.LocalEndPoint.ToString());
                    Console.WriteLine(">reciving Data");

                    // read the file in chunks of 1KB (as default)
                    var buffer = new byte[BytesPerRead];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        output.Write(buffer, 0, bytesRead);
                    }
                }
                MessageBox.Show("New Orders Received");
            }
            //else
              //  MessageBox.Show("No Order to receive");
        }

        void stoplistener(TcpListener listener)
        {
            listener.Stop();
        }

        static int Get_port()
        {
            AGEN:
            //Console.Clear();
            Console.WriteLine(">Port?");
            Console.Write("<");
            string input = "2020";
            try
            {
                int port = Int32.Parse(input);
                if (port <= 65534 && port > 1204)
                {
                    return port;
                }
                else goto AGEN;
            }
            catch
            {
                goto AGEN;
            }
        }//gets user input and validates it as a port

        private static string _getip()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }//gets this machine ip

        private void chkAutomatic_CheckedChanged_1(object sender, EventArgs e)
        {
            System.Timers.Timer t = new System.Timers.Timer();
            if (chkAutomatic.Checked)
            {
                IsServerOn = true;
                ReciveFile();
                listenServer(tcp);
                t.Interval = 2000; // In milliseconds
                                   // t.AutoReset = false; // Stops it from repeating
                t.Elapsed += new ElapsedEventHandler(TimerElapsed);
                t.Start();

            }
            else
            {
                IsServerOn = false;
                stoplistener(tcp);
                t.Stop();
            }
        }

        private void txtGST_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            if(IsServerOn)
                listenServer(tcp);
        }
    }
}
