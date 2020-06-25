using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    public class Tables
    {
        public List<MarhabaDatabase.table> GetTables()
        {
            MarhabaEntities entities = new MarhabaEntities();
            List<MarhabaDatabase.table> tables = entities.tables.ToList();
            
            //return entities.tables.ToList();
            for (int i = 0; i < tables.Count; i++)
            {
                MarhabaDatabase.table tbl = tables[i];
                var chk = entities.pending_order.FirstOrDefault(t => tbl.table_name == t.table_number);
                var chk2 = entities.pending_payment.FirstOrDefault(p=>p.tables == tbl.table_name);
                if (chk != null || chk2!= null)
                    tables.RemoveAt(i);
            }
            return tables;
        }

        public void swap(string tableFrom, string tableTo)
        {
            MarhabaEntities entities = new MarhabaEntities();
            List<pending_order> tablePendingOrdersFrom =
                entities.pending_order.Where(po => po.table_number == tableFrom).ToList();
            for (int i = 0; i < tablePendingOrdersFrom.Count; i++)
            {
                tablePendingOrdersFrom[i].table_number = tableTo;
            }
            var checkPendingTableToDetails = entities.pending_order.FirstOrDefault(p => p.table_number == tableTo);
            if (checkPendingTableToDetails == null)
            {
                for (int i = 0; i < tablePendingOrdersFrom.Count; i++)
                {
                    entities.pending_order.AddOrUpdate(tablePendingOrdersFrom[i]);
                    entities.SaveChanges();
                }
                return;
            }
            List<pending_order> tableToOrders = 
                entities.pending_order.Where(p => p.table_number == tableTo).ToList();
            for (int i = 0; i < tableToOrders.Count; i++)
            {
                tableToOrders[i].table_number = tableFrom;
                entities.pending_order.AddOrUpdate(tableToOrders[i]);
                entities.SaveChanges();
            }
            for (int i = 0; i < tablePendingOrdersFrom.Count; i++)
            {
                entities.pending_order.AddOrUpdate(tablePendingOrdersFrom[i]);
                entities.SaveChanges();
            }
            entities.Dispose();
        }
    }
}
