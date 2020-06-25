using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    public class Product
    {
        public List<MarhabaDatabase.item> getItemNames()
        {
            MarhabaDatabase.MarhabaEntities entities = new MarhabaEntities();
            return entities.items.ToList();
        }
    }
}
