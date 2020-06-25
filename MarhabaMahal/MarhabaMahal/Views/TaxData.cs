using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaMahal.BLClasses;

namespace MarhabaMahal.Views
{
    public partial class TaxData : Form
    {
        public TaxData()
        {
            InitializeComponent();
        }

        private void TaxData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxDataSetClosingTable.closing' table. You can move, or remove it, as needed.
            this.closingTableAdapter.Fill(this.taxDataSetClosingTable.closing);

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            UpdateRowToDatabase();
        }

        private void closingBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //DataRow thisDataRow = ((DataRowView)((BindingSource)sender).Current).Row;
            //if (thisDataRow.RowState == DataRowState.Modified)
            //{
            //    closingTableAdapter.Update(thisDataRow);
            //}
        }

        private void closingBindingSource_PositionChanged(object sender, EventArgs e)
        {
            BindingSource thisBindingSource =
                (BindingSource)sender;
            DataRow ThisDataRow =
                ((DataRowView)thisBindingSource.Current).Row;
            if (ThisDataRow == LastDataRow)
            {
                // we need to avoid to write a datarow to the 
                // database when it is still processed. Otherwise
                // we get a problem with the event handling of 
                //the DataTable.
                throw new ApplicationException("It seems the" +
                                               " PositionChanged event was fired twice for" +
                                               " the same row");
            }

            UpdateRowToDatabase();
            // track the current row for next 
            // PositionChanged event
            LastDataRow = ThisDataRow;
        }
        private DataRow LastDataRow = null;
        private void UpdateRowToDatabase()
        {
            if (LastDataRow != null)
            {
                if (LastDataRow.RowState ==
                    DataRowState.Modified)
                {
                    closingTableAdapter.Update(LastDataRow);
                }
            }
        }

        private void TaxData_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtStartBillId.Text) < dataGridView1.RowCount)
            {
                bool success = true;
                int rows = dataGridView1.RowCount;
                int cols = dataGridView1.ColumnCount;
                int sid = Convert.ToInt32(txtStartBillId.Text) - 1;
                SendDataTax sendDataTax = new SendDataTax();
                int? idToStart = sendDataTax.lastId;
                bool startFromFirst = false;
                if (idToStart == null)
                    startFromFirst = true;
                bool canSend = true;
                bool errorOccured = false;
                int count = 0;
                progressBar.Maximum = rows - sid;
                progressBar.Minimum = 1;
                progressBar.Step = 1;
                

                for (int i = sid; i < dataGridView1.Rows.Count - 1; i++)
                {
                    count++;
                    if (count == rows)
                        break;

                    DataGridViewRow row = dataGridView1.Rows[i];
                    string bill_id = row.Cells[0].Value.ToString();
                    string bill_code = row.Cells[1].Value.ToString();
                    string bill_date = row.Cells[2].Value.ToString();
                    double total_bill = Double.Parse(row.Cells[3].Value.ToString());
                    string table_no = row.Cells[5].Value.ToString();
                    string[] arr = bill_date.Split(' ');
                    string date = arr[0];
                    arr = arr[1].Split(':');
                    string time = arr[0] + ":" + arr[1];
                    if (!startFromFirst)
                    {
                        canSend = false;
                        int? id = Int32.Parse(bill_id);
                        if (id > idToStart)
                        {
                            canSend = true;
                            startFromFirst = true;
                        }
                    }
                    string response = "";
                    if (canSend)
                    {
                        response = sendDataTax.sendData(bill_code, date, time, Int32.Parse(table_no), total_bill);
                        if (response.Contains("success"))
                        {
                            int? id = Int32.Parse(bill_id);
                            ConfigurationReader configurationReader = new ConfigurationReader();
                            configurationReader.updateLastID(id);
                            //progressBar.Value = count;
                            progressBar.PerformStep();
                            progressBar.Refresh();
                        }
                        else
                        {
                            MarhabaDatabase.closing bill = sendDataTax.getBill(Int32.Parse(bill_id));
                            errorOccured = true;
                            //progressBar.Value = count;
                            //progressBar.PerformStep();
                            //progressBar.Refresh();
                            MessageBox.Show("Following Bill Was Not Sent Check Connection\nBill Id:" + bill.bill_code, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        }
                    }
                }

                if (!errorOccured)
                {
                    ConfigurationReader configurationReader = new ConfigurationReader();
                    configurationReader.updateLastID(null);
                }
            }
            else
            {
                MessageBox.Show("Starting index not Correct");
            }

        }
    }
}
