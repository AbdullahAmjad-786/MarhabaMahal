using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarhabaDatabase;

namespace MarhabaMahal.BLClasses
{
    public class Orders
    {
        public string username { get; set; }

        public void updateCreditCard(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var bill = entities.bills.FirstOrDefault(b => b.bill_code == billId);
            var closing = entities.closings.FirstOrDefault(c => c.bill_code == billId);
            if (bill != null && closing!=null)
            {
                bill.payment_type = true;
                closing.payment_type = true;
                entities.bills.AddOrUpdate(bill);
                entities.closings.AddOrUpdate(closing);
            }
            entities.SaveChanges();
            entities.Dispose();
        }
        public bool insertPendingDelivery(string code, double qty, double itemTotal, 
            string phone, string name, string address,string orderId)
        {
            try
            {
                MarhabaEntities entities = new MarhabaEntities();
                pending_deliveries deliveries = new pending_deliveries();
                deliveries.item_code = code;
                deliveries.address = address;
                deliveries.item_total = itemTotal;
                deliveries.name = name;
                deliveries.phone_number = phone;
                deliveries.qty = qty;
                deliveries.username = username;
                deliveries.order_id = orderId;
                entities.pending_deliveries.Add(deliveries);
                entities.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            return false;
        }

        public Orders(string username)
        {
            this.username = username;
        }

        public double getPrice(string code)
        {
            code = code.ToUpper();
            MarhabaEntities entities = new MarhabaEntities();
            var product = entities.items.FirstOrDefault(i => i.item_id == code);
            if(product != null)
                return product.item_price;
            return 0;
        }

        public string getItemCode(string name)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var itemCode = entities.items.FirstOrDefault(i => i.item_name == name);
            return itemCode.item_id;
        }

        public string getName(string code)
        {
            code = code.ToUpper();
            MarhabaEntities entities = new MarhabaEntities();
            var itemCode = entities.items.FirstOrDefault(i => i.item_id == code);
            if (itemCode != null)
                return itemCode.item_name;
            else
                return null;
        }

        public bool insertPendingOrders(string code, double qty, double total, string username, string tableNumber)
        {
            
            try
            {
                MarhabaEntities entities = new MarhabaEntities();
                MarhabaDatabase.pending_order pendingOrder = new pending_order();
                pendingOrder.item_code = code;
                pendingOrder.item_total = total;
                pendingOrder.qty = qty;
                pendingOrder.table_number = tableNumber;
                pendingOrder.username = username;
                entities.pending_order.Add(pendingOrder);
                entities.SaveChanges();
                entities.Dispose();
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            return false;
        }

        public List<string> getPendingTables()
        {
            MarhabaEntities entities = new MarhabaEntities();
            var result = entities.pending_order.Select(t=>t.table_number).Distinct();
            if (result == null)
                return null;
            return result.ToList();
        }

        public int getNumberOfPendingOrders(string table)
        {
            string tbl = table;
            MarhabaEntities entities = new MarhabaEntities();
            var pendinOrders = entities.pending_order.Where(p => p.table_number == tbl);
            if (pendinOrders == null)
                return 0;
            return pendinOrders.Count();
        }

        public int getNumberOfItemsWithBillId(string billId)
        {
            string id = billId;
            MarhabaEntities entities = new MarhabaEntities();
            var orders = entities.bill_item.Where(bi => bi.bill_id == id);
            if (orders == null)
                return 0;
            return  orders.Count();
        }

        public void removePendingOrder(Int64 id)
        {
            MarhabaEntities entities = new MarhabaEntities();
            pending_order order = entities.pending_order.FirstOrDefault(p => p.id == id);
            entities.pending_order.Remove(order);
            entities.SaveChanges();
            entities.Dispose();
        }
        public void updatePendingOrders(string code, double qty, double total, string username, string tableNumber, Int64 id)
        {
           
            MarhabaEntities entities = new MarhabaEntities();
            if (id != -1)
            {
                var order = entities.pending_order.FirstOrDefault(p => p.id == id);
                //entities.pending_order.Remove(order);
                order.item_code = code;
                order.item_total = total;
                order.username = username;
                order.qty = qty;
                order.table_number = tableNumber;
                //entities.pending_order.Add(order);
                entities.pending_order.AddOrUpdate(order);
                entities.SaveChanges();
            }
            else
            {
                pending_order order = new pending_order();
                order.item_code = code;
                order.item_total = total;
                order.username = username;
                order.qty = qty;
                order.table_number = tableNumber;
                entities.pending_order.Add(order);
                entities.SaveChanges();
            }
            entities.Dispose();
        }
        public List<MarhabaDatabase.pending_order> GetPendingOrders(string table)
        {
            MarhabaEntities entities = new MarhabaEntities();
            //entities.Database.CommandTimeout = 980;
            string tbl = table;
            return entities.pending_order.Where(p => p.table_number == tbl).ToList();
        }

        public void insertToBillItems(string billId, string itemCode, 
            double qty, double itemTotal,string type)
        {
            MarhabaEntities entities = new MarhabaEntities();
            MarhabaDatabase.bill_item billItem = new bill_item();
            billItem.bill_id = billId;
            billItem.item_code = itemCode;
            billItem.item_qty = qty;
            billItem.total_bill = itemTotal;
            billItem.type = type;
            entities.bill_item.Add(billItem);
            entities.SaveChanges();
            entities.Dispose();
        }

        public void insertBill(string billId, double total, double totalWithoutGST ,string username, 
            string table,string type,string phone)
        {
            MarhabaEntities entities = new MarhabaEntities();
            MarhabaDatabase.bill dbBill = new bill();
            dbBill.bill_code = billId;
            dbBill.total_bill = total;
            dbBill.user_name = username;
            dbBill.table_no = table;
            dbBill.customer_phone = phone;
            dbBill.payment_type = false;
            dbBill.type = type;
            dbBill.payed = false;
            dbBill.totalWithoutGST = totalWithoutGST;
            DateTime time = DateTime.Now;              // Use current time
            string format = "dd-MM-yyyy";
            dbBill.bill_date = time;
            entities.bills.Add(dbBill);
            entities.SaveChanges();
            entities.Dispose();
        }
        public void insertClosing(string billId, double total, string username,
            string table, string type, string phone)
        {
            MarhabaEntities entities = new MarhabaEntities();
            MarhabaDatabase.closing dbBill = new closing();
            dbBill.bill_code = billId;
            dbBill.total_bill = total;
            dbBill.user_name = username;
            dbBill.table_no = table;
            dbBill.customer_phone = phone;
            dbBill.type = type;
            dbBill.payment_type = false;
            DateTime time = DateTime.Now;              // Use current time
            string format = "dd-MM-yyyy";
            dbBill.bill_date = time;
            entities.closings.Add(dbBill);
            entities.SaveChanges();
            entities.Dispose();
        }

        public List<pending_deliveries> getPendingDeliveries()
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.pending_deliveries.ToList();
        }

        public int getNumberOfPendingDeliveries(string orderId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            int count = entities.pending_deliveries.Where(d => d.order_id == orderId).ToList().Count;
            entities.Dispose();
            return count;
        }

        public IQueryable<pending_deliveries> GetPendingDeliveries(string orderId)
        {
            //throw new NotImplementedException();
            MarhabaEntities entities =  new MarhabaEntities();
            return entities.pending_deliveries.Where(pd=>pd.order_id == orderId);
        }

        public void removePendingDeliveries(Int64 pendingOrderId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            pending_deliveries order = entities.pending_deliveries.FirstOrDefault(pd=>pd.id == pendingOrderId);
            entities.pending_deliveries.Remove(order);
            entities.SaveChanges();
            entities.Dispose();
        }

        public void updatePendingDelivery(string code, double qty, double total, 
            string orderId, string phone, long id)
        {
            //throw new NotImplementedException();
            MarhabaEntities entities = new MarhabaEntities();
            var ch = entities.pending_deliveries.FirstOrDefault(p => p.id == id);
            if (ch != null)
            {
                ch.item_code = code;
                ch.item_total = total;
                ch.username = username;
                ch.qty = qty;
                ch.phone_number = phone;
                entities.pending_deliveries.AddOrUpdate(ch);
            }
            else
            {
                pending_deliveries order = new pending_deliveries();
                order.item_code = code;
                order.item_total = total;
                order.username = username;
                order.qty = qty;
                order.order_id = orderId;
                order.phone_number = phone;
                //entities.pending_deliveries.Remove(order);
                entities.pending_deliveries.Add(order);
            }
            //if (id != -1)
            //{
            //    var order = entities.pending_deliveries.FirstOrDefault(p => p.id == id);
            //    //entities.pending_order.Remove(order);
            //    order.item_code = code;
            //    order.item_total = total;
            //    order.username = username;
            //    order.qty = qty;
            //    order.phone_number = phone;
            //    //entities.pending_order.Add(order);
            //    //entities.pending_deliveries.Remove(order);
            //    entities.pending_deliveries.AddOrUpdate(order);
            //    entities.SaveChanges();
            //}
            //else
            //{
            //    pending_deliveries order = new pending_deliveries();
            //    order.item_code = code;
            //    order.item_total = total;
            //    order.username = username;
            //    order.qty = qty;
            //    order.phone_number = phone;
            //    //entities.pending_deliveries.Remove(order);
            //    entities.pending_deliveries.Add(order);
            //    entities.SaveChanges();
            //}
            entities.SaveChanges();
            entities.Dispose();
        }


        public void removeBillItem(string billId, string itemCode)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var item = entities.bill_item.FirstOrDefault(bi => bi.bill_id == billId && bi.item_code == itemCode);
            entities.bill_item.Remove(item);
            entities.SaveChanges();
            IQueryable<bill_item> billItems = entities.bill_item.Where(bi => bi.bill_id == billId);
            double total = 0.0d;
            foreach (bill_item billItem in billItems)
            {
                total += billItem.total_bill;
            }
            bill Bill = entities.bills.FirstOrDefault(b => b.bill_code == billId);
            Bill.total_bill = total;
            entities.bills.AddOrUpdate(Bill);
            entities.SaveChanges();
            closing Closing = entities.closings.FirstOrDefault(b => b.bill_code == billId);
            Closing.total_bill = total;
            entities.closings.AddOrUpdate(Closing);
            entities.SaveChanges();
        }

        public bool findPhone(string phone)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var found = entities.pending_deliveries.FirstOrDefault(pd => pd.phone_number == phone);
            if (found != null)
                return true;
            else
            {
                return false;
            }
        }

        public IQueryable<bill_item> GetBillItems(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.bill_item.Where(bi => bi.bill_id == billId);
        }

        public void updateBillItems(Int64 id,string searchBillId, 
            string itemCode, double qty, double total, string order)
        {
            if (id == -1)
            {
                MarhabaEntities entities = new MarhabaEntities();
                var billitem = new bill_item();
                billitem.item_code = itemCode;
                billitem.item_qty = qty;
                billitem.total_bill = total;
                billitem.type = order;
                
                entities.bill_item.Add(billitem);

                entities.SaveChanges();
                entities.Dispose();
            }
            else
            {
                MarhabaEntities entities = new MarhabaEntities();
                var billitem = entities.bill_item.FirstOrDefault(i => i.id == id);
                if (billitem != null)
                {
                    billitem.item_code = itemCode;
                    billitem.item_qty = qty;
                    billitem.total_bill = total;
                    billitem.type = order;
                    entities.bill_item.AddOrUpdate(billitem);
                    entities.SaveChanges();
                }
                entities.Dispose();
            }
            
        }

        public void updateBill(string billCode, double grandTotal, string username, string order, string empty,double totalwithoutgst)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var bill = entities.bills.FirstOrDefault(b => b.bill_code == billCode);
            if (bill != null)
            {
                bill.total_bill = grandTotal;
                bill.totalWithoutGST = totalwithoutgst;
                entities.bills.AddOrUpdate(bill);
                entities.SaveChanges();
            }
            entities.Dispose();
        }

        public void updateClosing(string searchBillId, 
            double grandTotal, string s, string orderUpdated, string empty)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var closingAcc = entities.closings.FirstOrDefault(c => c.bill_code == searchBillId);
            if (closingAcc != null)
            {
                closingAcc.total_bill = grandTotal;
                entities.closings.AddOrUpdate(closingAcc);
                entities.SaveChanges();
            }
            else
            {
                closing closingU = new closing();
                var bill = entities.bills.FirstOrDefault(b => b.bill_code == searchBillId);
                if (bill == null)
                    return;
                closingU.total_bill = grandTotal - bill.total_bill;
                closingU.bill_code = searchBillId;
                closingU.bill_date = DateTime.Now;
                closingU.timestamp = DateTime.Now;
                closingU.type = orderUpdated;
                closingU.user_name = s;
                entities.closings.Add(closingU);
                entities.SaveChanges();
            }
            entities.Dispose();
        }

        public int getNumberOfPendingOrdersFromBill(string itemBillId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var b = entities.bill_item.Where(bi => bi.bill_id == itemBillId);
            return b.Count();
        }

        public IQueryable<bill_item> GetPendingOrdersFromBillItem(string itemBillId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.bill_item.Where(bi => bi.bill_id == itemBillId);
        }

        public IQueryable<pending_payment> GetPendingPayments()
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.pending_payment;
        }

        public double getPendingPayemnt(string table)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var pending = entities.pending_payment.FirstOrDefault(pp => pp.tables == table);
            return pending.total_bill;
        }

        public void removePendingPayments(int id)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var pending = entities.pending_payment.FirstOrDefault(p => p.id== id);
            entities.pending_payment.Remove(pending);
            entities.SaveChanges();
            entities.Dispose();
        }

        public void addPendingPayment(string table, double total, string billId, int gst)
        {
            MarhabaEntities entities = new MarhabaEntities();
            pending_payment pendingPayment = new pending_payment();
            pendingPayment.tables = table;
            pendingPayment.total_bill = total;
            pendingPayment.bill_id = billId;
            pendingPayment.gst = gst;
            entities.pending_payment.Add(pendingPayment);
            entities.SaveChanges();
            entities.Dispose();
        }

        public IQueryable<closing_view> getClosingView()
        {
            MarhabaEntities entities = new MarhabaEntities();
            return entities.closing_view;
        }

        public double? getGrandTotal(string billId)
        {
            MarhabaEntities entities= new MarhabaEntities();
            var b = entities.bills.FirstOrDefault(p => p.bill_code == billId);
            return b.total_bill;
        }

        public int? getGstPercent(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var b = entities.pending_payment.FirstOrDefault(p => p.bill_id == billId);
            return b.gst;
        }

        public bool getBillStatus(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var b = entities.bills.FirstOrDefault(p => p.bill_code == billId);
            if (b != null)
                return true;
            else
                return false;
        }

        public int getTable(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var b = entities.bills.FirstOrDefault(p => p.bill_code == billId);
            return Convert.ToInt32(b.table_no);
        }

        public double getTotalWithoutGST(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var b = entities.bills.FirstOrDefault(p => p.bill_code == billId);
            if(b.totalWithoutGST.HasValue)
                return b.totalWithoutGST.Value;
            else
            {
                return 0;
            }
        }

        public void updatePendingPayments(string table)
        {
            MarhabaEntities entities = new MarhabaEntities();
            IQueryable<pending_payment> pending = entities.pending_payment.Where(p => p.tables == table);
            double totalBill = 0d;
            foreach (pending_payment pendingPayment in pending)
            {
                totalBill += pendingPayment.total_bill;
            }
        }

        public bool getBillPayedStatus(string billId)
        {
            MarhabaEntities entities = new MarhabaEntities();
            var dbBill = entities.bills.FirstOrDefault(b => b.bill_code == billId);
            if (dbBill.payed.HasValue)
                return dbBill.payed.Value;
            else
                return false;
        }

        public void setNewId(string nid)
        {
            
        }

    }
        
}
