using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;
using MarhabaMahal.BLClasses;
using Microsoft.VisualBasic;

namespace MarhabaMahal.Views
{
    public partial class BillForm : Form
    {
        public double grandTotal { get; set; }
        public double cashRcvd { get; set; }
        public double change { get; set; }
        private string billId { get; set; }
        public double total { get; set; }
        public bool gst { get; set; }

        public bool ServiceCharge { get; set; }

        public bool Discount { get; set; }
        private string username { get; set; }

        private string discAmount { get; set; }
        int i = 1;
        private IQueryable<MarhabaDatabase.bill_item> billItems;
        private customItem customer;
        private CustomerBills customerBills;
        private bool delivery;
        private bool payed;
        private Sales sales;
        private bool isShowName = false;
        private int gst_percent;
        private string InvoiceNumber;
        private string qr_code;
        private string table { get; set; }
        public BillForm(double grandTotal,string table, double total, 
            bool gst,string billId,string username,bool delivery,bool payed,customItem c,bool showNameNumber,bool serviceCharge,bool discount,string disc, int gst_percent,string InvoiceNumber="NA",string qr_code = "NA")
        {
            this.grandTotal = grandTotal;
            //this.cashRcvd = cashRcvd;
            this.table = table;
            this.cashRcvd = 0.0;
            this.change = cashRcvd - grandTotal;
            this.billId = billId;
            this.total = total;
            this.gst = gst;
            this.ServiceCharge = serviceCharge;
            this.Discount = discount;
            this.discAmount = disc;
            this.username = username;
            this.payed = payed;
            this.delivery = delivery;
            isShowName = showNameNumber;
            this.gst_percent = gst_percent;
            this.InvoiceNumber = InvoiceNumber;
            this.qr_code = qr_code;
            this.customer = c;
            customerBills = new CustomerBills();
            billItems = customerBills.GetBillItems(this.billId);
            sales = new Sales();
            InitializeComponent();
        }

        private void BillForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintRecp();
        }

        public void PrintRecp()
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();
            printDialog.Document = printDocument;
            PaperSize paperSize = new PaperSize();
            paperSize.RawKind = (int)PaperKind.A6;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);
            printDocument.DefaultPageSettings.PaperSize = paperSize;
            printDocument.DefaultPageSettings.Landscape = false;
            printDocument.DefaultPageSettings.Margins = new Margins(2, 2, 2, 2);
            DialogResult result = printDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
            MarhabaEntities entities = new MarhabaEntities();
            var dbBill = entities.bills.FirstOrDefault(b => b.bill_code == this.billId);
            dbBill.payed = this.payed;
            entities.SaveChanges();
            this.Dispose();
        }
      
        private void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            double totalG = grandTotal;
            double cash = cashRcvd;
            double change = this.change;
            int numChars = 0;
            int numLines = 0;
            Graphics graphics = e.Graphics;
            StringFormat stringFormat = new StringFormat();
            Font font = new Font("Courier New", 8,FontStyle.Bold);
            Font headingFont = new Font("Courier New", 18, FontStyle.Bold);
            Font subHeading = new Font("Courier New", 12, FontStyle.Bold);
            float fontHeight = font.GetHeight();
            RectangleF rectangleF = new RectangleF(e.MarginBounds.Left,e.MarginBounds.Top,
                e.MarginBounds.Width,e.MarginBounds.Height);
            SizeF sizeMeasure = new SizeF(e.MarginBounds.Width, 
                e.MarginBounds.Height - font.GetHeight(e.Graphics));
            stringFormat.Trimming = StringTrimming.Word;
            

            ConfigurationReader configurationReader = new ConfigurationReader();
            string ntn = configurationReader.getNTN();


            int startX = 10;
            int startY = 10;
            int offset = 40;
            Bitmap praBitmap;
            Image praImage = Image.FromFile("pra.bmp");
            praBitmap = new Bitmap(praImage);
            Image logoImage = Image.FromFile("logo-s.bmp");

            graphics.DrawImage(logoImage,praImage.Width+60,0,50,60);
            graphics.DrawImage(praImage, new Point(10, 10));
            graphics.DrawString("Marhaba Mahal".PadLeft(10),
                headingFont,new SolidBrush(Color.Black),startX,logoImage.Height-20);
            offset = startY + logoImage.Height-20;
            graphics.DrawString("Authentic Desi Cusine".PadLeft(10),
                subHeading, new SolidBrush(Color.Black), startX, offset+10);
            offset = offset + (int)subHeading.GetHeight();
            graphics.DrawString("NTN:>"+ntn, font
                , new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)subHeading.GetHeight();
            if (this.payed)
            {
                graphics.DrawString("PAID", font
                , new SolidBrush(Color.Black), startX, startY + offset);
            }
            else
            {
                graphics.DrawString("UNPAID", font
                , new SolidBrush(Color.Black), startX, startY + offset);
            }
            

            //logo = bmp;




            offset = offset + (int)subHeading.GetHeight();
            graphics.DrawString("Date&Time:>" +sales.GetBillDateTime(billId),font
                ,new SolidBrush(Color.Black),startX,startY + offset );
            if (isShowName)
            {
                offset = offset + (int)subHeading.GetHeight();
                graphics.DrawString("Name: " + txtName.Text.ToString(), font
                    , new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)subHeading.GetHeight();
                graphics.DrawString("Contact#: " + txtPhone.Text.ToString(), font
                    , new SolidBrush(Color.Black), startX, startY + offset);
            }

            if (!delivery && table != "")
            {
                offset = offset + (int)subHeading.GetHeight();
                graphics.DrawString("Table:>" + table, font
                    , new SolidBrush(Color.Black), startX, startY + offset);
            }
            offset = offset + (int)subHeading.GetHeight();
            if (delivery)
            {
                graphics.DrawString("ORDER ID:>" + billId,
                    font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)font.GetHeight();
                graphics.DrawString("Customer Name:>"+customer.name,font,new SolidBrush(Color.Black),startX,startY+offset );
                offset = offset + (int)font.GetHeight();
                graphics.DrawString("Customer Phone:>" + customer.phone, font, new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + (int)font.GetHeight();
                graphics.DrawString("Address:>", font, new SolidBrush(Color.Black), startX, startY + offset);
                string address = "";
                int n = 0;
                
                for (int i = 0; i < customer.address.Length; i++)
                {
                    address += customer.address.Substring(i, 1);
                    n++;
                    if (n == 37)
                    {
                        n = 0;
                        graphics.DrawString(address, font, new SolidBrush(Color.Black), 
                            startX+ (5 * font.Height), startY + offset);
                        offset = offset + (int)font.GetHeight();
                        address = "";
                    }
                }
                
            }
            else
            {
                graphics.DrawString("BILL ID:>" + billId,
                    font, new SolidBrush(Color.Black), startX, startY + offset);
                //offset = offset + (int)font.GetHeight();
                offset = offset + (int)subHeading.GetHeight();

                if (this.payed)
                {
                    if (this.InvoiceNumber != "NA")
                    {
                        graphics.DrawString("Invoice #:>" + this.InvoiceNumber,
                        font, new SolidBrush(Color.Black), startX, startY + offset);
                        offset = offset + (int)subHeading.GetHeight();
                    }

                   /* if (this.qr_code != "NA")
                    {
                        graphics.DrawString("QR Code:>" + this.qr_code,
                        font, new SolidBrush(Color.Black), startX, startY + offset);
                        offset = offset + (int)font.GetHeight();
                    } */
                }
            }
            
            
            string top = "ID".PadRight(3) + "Item".PadRight(20) +
                         "Qty".PadRight(5) + "U.Pr".PadRight(5) + "T.Pr";
            graphics.DrawString(top,font,new SolidBrush(Color.Black),startX,startY+offset );
            offset = offset + (int)font.GetHeight();
            string line = "";
            double? serviceV = 5 * total;
            serviceV /= 100;
            serviceV = roundupbyten(serviceV);

            foreach (char c in top)
            {
                line += "_";
            }
            graphics.DrawString(line,font,new SolidBrush(Color.Black),startX,startY+offset );
            offset = offset + (int)font.GetHeight();
            e.HasMorePages = false;
            CustomerBills customerBills = new CustomerBills();
            List<bill_item> billArray = billItems.ToList();
            int lineCount = 0;
            for (int loop = i-1; loop <= billItems.Count(); loop++)
            {
                if (loop == billItems.Count())
                {
                    if (ServiceCharge)
                    {
                        string itn = "Service Charges";
                        itn = itn.PadRight(20);
                        string qty = "1";
                        qty = qty.PadRight(5);
                        string uprice = serviceV.ToString();
                        uprice = uprice.PadRight(5);
                        ;
                        string totalprice = serviceV.ToString();
                        string oneBillLine = i.ToString().PadRight(3);
                        oneBillLine += itn + qty + uprice + totalprice;
                        graphics.DrawString(oneBillLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                        offset = offset + (int)font.GetHeight();
                    }
                }
                else
                {
                    bill_item billItem = billArray[loop];
                    string itemName = customerBills.getName(billItem.item_code);
                    string itemName_half = "";
                    int name_length = itemName.Length;
                    if (name_length >= 17)
                    {
                        int rem_length = itemName.Length - 15;
                        itemName_half = itemName.Substring(15, rem_length);
                        itemName = itemName.Substring(0, 15);
                    }

                    itemName = itemName.PadRight(20);
                    //string qty = billItem.item_qty.ToString();
                    string qty = String.Format("{0:0.00}", billItem.item_qty);
                    qty = qty.PadRight(5);
                    string uprice = customerBills.getPrice(billItem.item_code).ToString();
                    uprice = uprice.PadRight(5);
                    string totalprice = billItem.total_bill.ToString();
                    string oneBillLine = i.ToString().PadRight(3);
                    oneBillLine += itemName + qty + uprice + totalprice;
                    graphics.DrawString(oneBillLine, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)font.GetHeight();
                    if (name_length >= 17)
                    {
                        //itemName_half = itemName_half.PadRight(23);
                        graphics.DrawString(itemName_half, font, new SolidBrush(Color.Black), startX + 20, startY + offset);
                        offset = offset + (int)font.GetHeight();
                    }
                    
                }
                i++;
                lineCount++;
                if (lineCount >= 33)
                {
                    //e.HasMorePages = true;
                    //break;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
           
            if (e.HasMorePages == true)
                return;

            double? gstV = gst_percent * total;
            gstV /= 100;
            //double? serviceV = 5 * total;
            //serviceV /= 100;
            double? discV = Double.Parse(discAmount) * total;
            discV /= 100;
            if (this.payed)
            {
                Orders orders = new Orders(username);
                this.total = orders.getTotalWithoutGST(billId);
                gstV = total * gst_percent;
                gstV /= 100;
            }

            offset = offset + 20;

            if (ServiceCharge)
            {
                graphics.DrawString("Total".PadRight(top.Length - 11) + String.Format("Rs. {0:0.00}", total + serviceV),
                    font, new SolidBrush(Color.Black), startX, startY + offset);
            }
            else
                graphics.DrawString("Total".PadRight(top.Length - 11) + String.Format("Rs. {0:0.00}", total),
                    font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 20;
            if (gst)
            {
                graphics.DrawString("GST".PadRight(top.Length - 11) + String.Format("Rs. {0:0.00}", gstV),
                    font, new SolidBrush(Color.Black), startX, startY + offset);

                offset += 20;
            }
            /*if (ServiceCharge)
            {
                graphics.DrawString("Service Charges".PadRight(top.Length - 15) + String.Format("{0:c}", serviceV),
                    font, new SolidBrush(Color.Black), startX, startY + offset);

                offset += 20;
            }*/
            if (Discount)
            {
                graphics.DrawString("Discount".PadRight(top.Length - 11) + String.Format("Rs. {0:0.00}", discV),
                    font, new SolidBrush(Color.Black), startX, startY + offset);

                offset += 20;
            }
            /*if (!gst && !ServiceCharge)
            {
                grandTotal = total;
                roundupbyten(grandTotal);
            }
            else if (!gst)
            {
                grandTotal = total + Convert.ToInt32(serviceV);
                roundupbyten(grandTotal);
            }
            else if (!ServiceCharge)
            {
                grandTotal = total + Convert.ToInt32(gstV);
                roundupbyten(grandTotal);
            }*/

                graphics.DrawString("Total to pay".PadRight(top.Length - 11) + String.Format("Rs. {0:0.00}",
                    grandTotal),
                    new Font("Courier New", 8, FontStyle.Bold),
                    new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 30; //make some room so that the total stands out.
            graphics.DrawString("Cashier:>" + username,
                font, new SolidBrush(Color.Black), startX, startY+offset);
            offset = offset + 10;
            graphics.DrawString(line,
                font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphics.DrawString("It Has Been A Pleasure Serving You",
                font, new SolidBrush(Color.Black), startX+20, startY + offset);
            offset = offset + 10;
            graphics.DrawString("We Hope To See You Again",
                font, new SolidBrush(Color.Black), startX+50, startY + offset);
            offset = offset + 2;
            graphics.DrawString(line,
                font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphics.DrawString("",
                font, new SolidBrush(Color.Black), startX + 30, startY + offset);
            e.HasMorePages = false;
            end:
            int x = 0;
        }

        public int roundupbyten(double? i)
        {

            int ii = (int)i;
            int remainder = ii % 10;
            if (remainder == 0)
                return ii;
            else if (remainder > 5)
                return ii + (10 - remainder);
            else
                return ii - remainder;

            //ii += (remainder < 10 / 2) ? -remainder : (10 - remainder);
            ///return ii;
        }
        private void BillForm_Load(object sender, EventArgs e)
        {
            txtCashRcvd.Text = cashRcvd.ToString();
            lblTotalBill.Text = grandTotal.ToString();
            lblBalance.Text = change.ToString();
            this.AcceptButton = button1;
            this.chkPaymentMode.Checked = false;
            lblBillId.Text = billId;
            if (isShowName)
            {
                lblName.Visible = true;
                txtName.Visible = true;
                lblPhone.Visible = true;
                txtPhone.Visible = true;
            }
            else
            {
                lblName.Visible = false;
                txtName.Visible = false;
                lblPhone.Visible = false;
                txtPhone.Visible = false;
            }
        }

        private void txtCashRcvd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cash = double.Parse(txtCashRcvd.Text);
                lblBalance.Text = (cash - grandTotal).ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkPaymentMode_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaymentMode.Checked)
            {
                Orders orders = new Orders(username);
                orders.updateCreditCard(billId);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }
    }
}
//foreach (bill_item billItem in billItems)
//{
//    //string desc = i.ToString().PadRight(15) + customerBills.getName(billItem.item_code)
//    string itemName = customerBills.getName(billItem.item_code);
//    if (itemName.Length >24)
//    {
//        itemName = itemName.Substring(0,itemName.Length-23);

//    }

//    itemName = itemName.PadRight(25);
//    string qty = billItem.item_qty.ToString();
//    qty = qty.PadRight(5);
//    string uprice = customerBills.getPrice(billItem.item_code).ToString();
//    uprice = uprice.PadRight(10);
//    ;
//    string totalprice = billItem.total_bill.ToString();
//    string oneBillLine = i.ToString().PadRight(3);
//    oneBillLine += itemName + qty + uprice + totalprice;
//    graphics.DrawString(oneBillLine,font,new SolidBrush(Color.Black),startX,startY+offset );
//    offset = offset + (int) font.GetHeight();
//    i++;
//    if (offset >= e.PageSettings.PrintableArea.Height)
//    {
//        e.HasMorePages = true;

//    }
//}