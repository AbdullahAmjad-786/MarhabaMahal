using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MarhabaMahal.BLClasses
{
    class Invoice
    {
        public string InvoiceNumber = "";
        public int POSID = 123123;
        public string USIN = "";
        public DateTime DateTime = DateTime.Now;
        public string BuyerPNTN = "";
        public string BuyerCNIC = "";
        public string BuyerName = "";
        public string BuyerPhoneNumber = "";
        public int PaymentMode = 1;
        public double TotalSaleValue = 0;
        public int TotalQuantity = 0;
        public double TotalBillAmount = 0;
        public double TotalTaxCharged = 0;
        public double Discount = 1000;
        public double FurtherTax = 100;
        public int InvoiceType = 1;

        public List<InvoiceItems> Items { get; internal set; }

        public string PrintInvoice(Invoice objinvoice)
        {
            string re = "";
            HttpClient Client = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(objinvoice), Encoding.UTF8,
            "application/json");
            HttpResponseMessage response =
            Client.PostAsync("http://localhost:8524/api/IMSFiscal/GetInvoiceNumberByModel",
            content).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Response from API");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                re = response.Content.ReadAsStringAsync().Result;
            }
            return re;
        }
    }
}
