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
    public partial class UserDashboard : Form
    {
        private string username;
        private bool type;
        private Login login;
        public UserDashboard(string username, bool type, Login login)
        {
            InitializeComponent();
            this.username = username;
            this.type = type;
            this.login = login;
            ordersPanel    = new OrdersPanel(username, type);
            //InitializeComponent();
        }

        private OrdersPanel ordersPanel;
        private void btnAdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Chartreuse;
        }

        private void btnAdminPanel_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
        }
        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            btnExit.BackColor = Color.DarkRed;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Black;
        }
        private void btnLogout_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.IndianRed;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login.txtPassword.Text = "";
            login.txtUserName.Text = "";
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ordersPanel.Location = new Point(0,0);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(ordersPanel);
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            DeliveryPanel deliveryPanel = new DeliveryPanel(username, type);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(deliveryPanel);
            deliveryPanel.Location = new Point(0, 0);
            deliveryPanel.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(username);
            changePassword.Show();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            UserDailyReportPanel userDailyReportPanel = new UserDailyReportPanel(username);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(userDailyReportPanel);
            userDailyReportPanel.Show();

        }
    }
}
