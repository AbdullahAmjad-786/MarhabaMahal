using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    class ItemsHandler
    {
        public SqlConnection getcon()
        {
            Connection co = new Connection();
            return co.getConnection();
        }

        public SqlCommand getInsertionCommand(SqlConnection con, string itemname, string itemprice, string qty)
        {
            
            string query = "INSERT INTO item (item_id,item_name,item_price,item_qty) VALUES ('" + 3 + "','" + itemname + "','" + itemprice + "','" + qty + "')";
            SqlCommand com = new SqlCommand(query, con);
            return com;
        }

        public void insetItem(string name, double price, double qty, string type, string code)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var chk = entities.items.FirstOrDefault(i => i.item_id == code);
            if (chk != null)
            {
                MessageBox.Show("The ItemCode You Have Entered Already Exists for another item\nWith" +
                                "Item Name:>" + chk.item_name, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            item dbItem = new item();
            dbItem.item_id = code;
            dbItem.item_name = name;
            dbItem.item_price = price;
            dbItem.item_qty = qty.ToString();
            dbItem.item_type = type;
            entities.items.Add(dbItem);
            entities.SaveChanges();
            entities.Dispose();
            MessageBox.Show("Item Added", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public item getItem(string code)
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.items.FirstOrDefault(i => i.item_id == code);
        }

        public void updateItem(string name, double price, string qty, string type, string code)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var chk = entities.items.FirstOrDefault(i => i.item_id == code);
            
            item dbItem = chk;
            //dbItem.item_id = code;
            dbItem.item_name = name;
            dbItem.item_price = price;
            dbItem.item_qty = qty.ToString();
            dbItem.item_type = type;
            entities.items.AddOrUpdate(dbItem);
            entities.SaveChanges();
            entities.Dispose();
        }

        public void delItem(string itemCode)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var item = entities.items.FirstOrDefault(i => i.item_id == itemCode);
            if (item != null)
            {
                entities.items.Remove(item);
                entities.SaveChanges();
                
            }
            entities.Dispose();
        }
    }
}
