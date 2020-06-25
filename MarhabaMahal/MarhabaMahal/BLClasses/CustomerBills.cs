using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    class CustomerBills
    {
        public IQueryable<MarhabaDatabase.bill_item> GetBillItems(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();

            return entities.bill_item.Where(b=>b.bill_id == billId);
        }
        public string getName(string code)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var itemCode = entities.items.FirstOrDefault(i => i.item_id == code);
            if (itemCode != null)
                return itemCode.item_name;
            else
                return null;
        }
        public double getPrice(string code)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var product = entities.items.FirstOrDefault(i => i.item_id == code);
            if (product != null)
                return product.item_price;
            return 0;
        }
    }
}
