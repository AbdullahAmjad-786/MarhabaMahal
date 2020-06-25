using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    public class Sales
    {
        public void close()
        {
            MarhabaEntities entities=new MarhabaEntities();
            IEnumerable<closing> closings = entities.closings;
            entities.closings.RemoveRange(closings);
            entities.SaveChanges();
            entities.Dispose();
        }

        public DateTime GetBillDateTime(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var bill = entities.bills.FirstOrDefault(b => b.bill_code == billId);
            entities.Dispose();
            return bill.bill_date;
        }
    }
}
