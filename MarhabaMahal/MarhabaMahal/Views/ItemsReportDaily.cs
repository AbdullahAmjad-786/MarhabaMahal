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
    public partial class ItemsReportDaily : UserControl
    {
        public ItemsReportDaily()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ItemsReportDaily_Load(object sender, EventArgs e)
        {
            this.itemClosingViewTableAdapter.Fill(this.marhabaDataSet4.ItemClosingView);
            this.reportViewer1.RefreshReport();
        }
    }
}
