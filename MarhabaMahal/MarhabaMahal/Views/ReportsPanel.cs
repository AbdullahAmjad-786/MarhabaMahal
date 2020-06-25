using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaMahal.BLClasses;
using MarhabaMahal.MarhabaDataSetDailyClosingTableAdapters;

namespace MarhabaMahal.Views
{
    public partial class ReportsPanel : UserControl
    {
        public ReportsPanel()
        {
            InitializeComponent();
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            this.closingTableAdapter.Fill(this.marhabaDataSetDailyClosing.closing);
            this.totalForCashClosingTableAdapter.Fill(this.marhabaDataSet1.TotalForCashClosing);
            
            
            this.reportClosing.RefreshReport();
        }

        private void btnClosing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have you Upload the Rims Data?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (MessageBox.Show("Are you sure you want to close?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        Sales sales = new Sales();
                        sales.close();
                        MessageBox.Show("Daily Account Closed", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Following error has occured consult developer\n" + exception.Message,
                            "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    this.reportClosing.RefreshReport();
            }

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DateTime dtFrom = dtTimeFrom.Value;
            DateTime dtTo = dtTimeTo.Value;
            this.billTableAdapter.Fill(this.dateReportDataSet.bill,dtFrom,dtTo);
            this.rptSales.RefreshReport();
        }

        private void ReportsPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void rptSales_Load(object sender, EventArgs e)
        {

        }
    }
}
