using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarhabaMahal.BLClasses
{
    class InvoiceItems
    {
        public string ItemCode = "";
        public string ItemName = "";
        public double Quantity = 0;
        public double TotalAmount = 0;
        public double SaleValue = 0;
        public double TaxCharged = 0;
        public int TaxRate = 16;
        public string PCTCode = "";
        public int FurtherTax = 20;
        public int InvoiceType = 1;
        public int Discount = 500;
    }
}
