using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using MarhabaDatabase;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace MarhabaMahal.BLClasses
{
    public class SendDataTax
    {
        private string ntn;
        private string branchCode;
        public int? lastId { get; set; }
        private bool fromFirst = true;
        private MarhabaEntities entities;
        public SendDataTax()
        {
           ConfigurationReader configurationReader = new ConfigurationReader();
            ntn = configurationReader.getNTN();
            lastId = configurationReader.getLastId();
            branchCode = configurationReader.getBranchCode();
            if (lastId == null)
                fromFirst = false;
        }

        public string sendData(string bill_code, string date, string time, int table, double totalBill)
        {

            try
            {
                string response = sendToServer(bill_code, date, time, table, totalBill);
                return response;
            }
            catch (Exception e)
            {
                return "ERROR";
            }
            
        }

        private string sendToServer(string billCode, string date, string time, int table, double totalBill)
        {
            
            const string url = "http://rims.punjab.gov.pk/api/databaseupdate/formdata";
            string parameters = "key=" + this.getDailyKey();
            double totalWithoutTax = totalBill * 16;
            totalWithoutTax /= 100.0d;
            totalWithoutTax = totalBill - totalWithoutTax;
            double taxAmount = (totalBill*16)/100.0d;
            string JSON =
                "&data={\"pntn\":\"" + ntn.ToString() + "\",\"branchcode\":\"" + branchCode + "\"," +
                "\"invoice_number\":\"" + billCode + "\"," +
                "\"invoice_date\": \"" + date + "\"," +
                "\"invoice_time\": \"" + time + "\"," +
                "\"discount_percent\": \"0\",\"service_charges_percent\": \"0\"," +
                "\"tax_percent\":\"16\"," +
                "\"table_no\": \"" + table + "\"," +
                "\"phone\": \"00000000\",\"customer_name\":\"UNKNOWN\"," +
                "\"total_invoice_amount\": \"" + totalWithoutTax + "\"," +
                "\"total_tax_amount\": \"" + taxAmount + "\"," +
                "\"total_amount\": \"" + totalBill + "\"," +
                "\"business_date\": \"" + date + " " + time + ":00\"}";

            parameters += JSON;

            WebClient webClient = new WebClient();
            webClient.Headers[HttpRequestHeader.ContentType]= "application/x-www-form-urlencoded";
            string response = webClient.UploadString(url, parameters);
            return response;

        //    return null;//
        }

        private string getDailyKey()
        {
            const string keyUrl = "http://rims.punjab.gov.pk/api/databaseupdate/formkey";
            WebClient client;
            client = new WebClient();
            string responseString = client.DownloadString(keyUrl);
            //JSON json
            var result = JsonConvert.DeserializeObject<dynamic>(responseString);
            return result.key;
        }

        public MarhabaDatabase.closing getBill(int id)
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.closings.FirstOrDefault(w => w.bill_id == id);
        }

    }
}
