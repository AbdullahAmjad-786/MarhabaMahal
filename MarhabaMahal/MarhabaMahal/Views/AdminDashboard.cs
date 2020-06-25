using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;
using MarhabaMahal.BillEditDataSetTableAdapters;

namespace MarhabaMahal.Views
{
    public partial class AdminDashboard : Form
    {
        private string username;
        private bool type;
        private Login login;
        private TaxData taxData;
        public AdminDashboard(string username, bool type, Login login)
        {
            this.username = username;
            this.type = type;
            this.login = login;
            InitializeComponent();
             taxData = new TaxData();
            
        }

        private void btnAdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button) sender;
            btn.BackColor = Color.Chartreuse;
        }

        private void btnAdminPanel_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            
            btnExit.BackColor = Color.DarkRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            //addItemsPanel.Visible = true;
           
            this.panel1.Controls.Clear();
            ItemsPanel itemsPanel = new ItemsPanel();
            
            this.panel1.Controls.Add(itemsPanel);
            Point location = new Point(0,0);
            itemsPanel.Location = location;
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UserManagement userPanel =  new UserManagement();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userPanel);
            userPanel.Location = new Point(0,0);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            OrdersPanel ordersPanel = new OrdersPanel(username,type);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(ordersPanel);
            ordersPanel.Location =  new Point(0,0);
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryPanel deliveryPanel = new DeliveryPanel(username,type);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(deliveryPanel);
            deliveryPanel.Location = new Point(0,0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login.txtPassword.Text = "";
            login.txtUserName.Text = "";
            login.Show();
        }

        private void btnLogout_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.IndianRed;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //ReportDocument cReportDocument;
            //ReportDocument cryRpt = new ReportDocument();
            ReportsPanel reportsPanel = new ReportsPanel();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(reportsPanel);
            reportsPanel.Location = new Point(0,0);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marhabaDataSetBillItemT.bill_item' table. You can move, or remove it, as needed.
            this.bill_itemTableAdapter1.Fill(this.marhabaDataSetBillItemT.bill_item,"1");
            //BillEditDataSet billEditData = new BillEditDataSet();
            // billEditData.BeginInit();
            //BillEditDataSetTableAdapters.bill_itemTableAdapter tableAdapter = new bill_itemTableAdapter();
            //BillEditDataSet.bill_itemDataTable dataTable = new BillEditDataSet.bill_itemDataTable();
            // tableAdapter.Fill(dataTable,"1");
            // billEditData = dataTable.DataSet as BillEditDataSet;
            // dataGridView1.DataSource = dataTable;
            // dataGridView1.AutoGenerateColumns = true;

            //dataGridView1.DataSource = billEditData;

            //dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(username);
            changePassword.Show();
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            UserDailyReportPanel userDailyReportPanel = new UserDailyReportPanel(username);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userDailyReportPanel);
            userDailyReportPanel.Show();
        }

        private void btnItemsReport_Click(object sender, EventArgs e)
        {
            ItemsReportDaily itemsReportDaily = new ItemsReportDaily();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(itemsReportDaily);
            itemsReportDaily.Show();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            TaxData taxData = new TaxData();
            taxData.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ChangeTcpSettings tcpSettings = new ChangeTcpSettings();
            tcpSettings.Show();
        }
    }
}
