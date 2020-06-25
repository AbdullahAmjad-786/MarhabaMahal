using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;
using MarhabaMahal.Views;

namespace MarhabaMahal.BLClasses
{
    public class Customer
    {
        
        public Customer()
        {
            
        }

        public void addCustomer(customItem customerItem)
        {
            MarhabaEntities entities = new MarhabaEntities();
            MarhabaDatabase.customer customer = entities.customers.FirstOrDefault(p => p.phone == customerItem.phone);
            if (customer == null)
            {
              MarhabaDatabase.customer dbCustomer = new customer();
                dbCustomer.name = customerItem.name;
                dbCustomer.address = customerItem.address;
                dbCustomer.phone = customerItem.phone;
                entities.customers.Add(dbCustomer);
                entities.SaveChanges();
                entities.Dispose();
            }
        }
        
    }
}
