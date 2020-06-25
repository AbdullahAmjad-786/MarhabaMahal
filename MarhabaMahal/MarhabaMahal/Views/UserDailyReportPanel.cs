using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarhabaMahal.Views
{
    public partial class UserDailyReportPanel : UserControl
    {
        private string username;
        public UserDailyReportPanel(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void UserDailyReportPanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDailyReportsDataSet.closing' table. You can move, or remove it, as needed.
            this.closingTableAdapter.Fill(this.userDailyReportsDataSet.closing, username);
            // TODO: This line of code loads data into the 'dailyReportSum.closing' table. You can move, or remove it, as needed.
            this.closingTableAdapter1.Fill(this.dailyReportSum.closing, username);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
