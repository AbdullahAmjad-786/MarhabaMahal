using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaMahal.BLClasses;

namespace MarhabaMahal.Views
{
    public partial class TableSwap : Form
    {
        private string tableFrom;
        private OrdersPanel ordersPanel;
        public TableSwap(string tableFrom,OrdersPanel panel)
        {
            InitializeComponent();
            this.tableFrom = tableFrom;
            this.ordersPanel = panel;
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string tableTo = txtTable.Text;
            if (tableTo == "")
            {
                MessageBox.Show("Please Enter A table Number to Swap with", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            Tables tables = new Tables();
            tables.swap(tableFrom,tableTo);
            this.ordersPanel.setTables();
            this.Dispose();
        }

    
    }
}
