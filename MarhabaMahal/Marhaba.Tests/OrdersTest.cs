// <copyright file="OrdersTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using MarhabaDatabase;
using MarhabaMahal.BLClasses;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarhabaMahal.BLClasses.Tests
{
    /// <summary>This class contains parameterized unit tests for Orders</summary>
    [PexClass(typeof(Orders))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class OrdersTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Orders ConstructorTest(string username)
        {
            Orders target = new Orders(username);
            return target;
            // TODO: add assertions to method OrdersTest.ConstructorTest(String)
        }

        /// <summary>Test stub for GetBillItems(String)</summary>
        [PexMethod]
        public IQueryable<bill_item> GetBillItemsTest([PexAssumeUnderTest]Orders target, string billId)
        {
            IQueryable<bill_item> result = target.GetBillItems(billId);
            return result;
            // TODO: add assertions to method OrdersTest.GetBillItemsTest(Orders, String)
        }

        /// <summary>Test stub for GetPendingDeliveries(String)</summary>
        [PexMethod]
        public IQueryable<pending_deliveries> GetPendingDeliveriesTest([PexAssumeUnderTest]Orders target, string orderId)
        {
            IQueryable<pending_deliveries> result = target.GetPendingDeliveries(orderId);
            return result;
            // TODO: add assertions to method OrdersTest.GetPendingDeliveriesTest(Orders, String)
        }

        /// <summary>Test stub for GetPendingOrdersFromBillItem(String)</summary>
        [PexMethod]
        public IQueryable<bill_item> GetPendingOrdersFromBillItemTest([PexAssumeUnderTest]Orders target, string itemBillId)
        {
            IQueryable<bill_item> result = target.GetPendingOrdersFromBillItem(itemBillId);
            return result;
            // TODO: add assertions to method OrdersTest.GetPendingOrdersFromBillItemTest(Orders, String)
        }

        /// <summary>Test stub for GetPendingOrders(String)</summary>
        [PexMethod]
        public List<pending_order> GetPendingOrdersTest([PexAssumeUnderTest]Orders target, string table)
        {
            List<pending_order> result = target.GetPendingOrders(table);
            return result;
            // TODO: add assertions to method OrdersTest.GetPendingOrdersTest(Orders, String)
        }

        /// <summary>Test stub for GetPendingPayments()</summary>
        [PexMethod]
        public IQueryable<pending_payment> GetPendingPaymentsTest([PexAssumeUnderTest]Orders target)
        {
            IQueryable<pending_payment> result = target.GetPendingPayments();
            return result;
            // TODO: add assertions to method OrdersTest.GetPendingPaymentsTest(Orders)
        }

        /// <summary>Test stub for addPendingPayment(String, Double)</summary>
        [PexMethod]
        public void addPendingPaymentTest(
            [PexAssumeUnderTest]Orders target,
            string table,
            double total
        )
        {
            //target.addPendingPayment(table, total);
            // TODO: add assertions to method OrdersTest.addPendingPaymentTest(Orders, String, Double)
        }

        /// <summary>Test stub for findPhone(String)</summary>
        [PexMethod]
        public bool findPhoneTest([PexAssumeUnderTest]Orders target, string phone)
        {
            bool result = target.findPhone(phone);
            return result;
            // TODO: add assertions to method OrdersTest.findPhoneTest(Orders, String)
        }

        /// <summary>Test stub for getClosingView()</summary>
        [PexMethod]
        public IQueryable<closing_view> getClosingViewTest([PexAssumeUnderTest]Orders target)
        {
            IQueryable<closing_view> result = target.getClosingView();
            return result;
            // TODO: add assertions to method OrdersTest.getClosingViewTest(Orders)
        }

        /// <summary>Test stub for getGrandTotal(String)</summary>
        [PexMethod]
        public double? getGrandTotalTest([PexAssumeUnderTest]Orders target, string billId)
        {
            double? result = target.getGrandTotal(billId);
            return result;
            // TODO: add assertions to method OrdersTest.getGrandTotalTest(Orders, String)
        }

        /// <summary>Test stub for getItemCode(String)</summary>
        [PexMethod]
        public string getItemCodeTest([PexAssumeUnderTest]Orders target, string name)
        {
            string result = target.getItemCode(name);
            return result;
            // TODO: add assertions to method OrdersTest.getItemCodeTest(Orders, String)
        }

        /// <summary>Test stub for getName(String)</summary>
        [PexMethod]
        public string getNameTest([PexAssumeUnderTest]Orders target, string code)
        {
            string result = target.getName(code);
            return result;
            // TODO: add assertions to method OrdersTest.getNameTest(Orders, String)
        }

        /// <summary>Test stub for getNumberOfItemsWithBillId(String)</summary>
        [PexMethod]
        public int getNumberOfItemsWithBillIdTest([PexAssumeUnderTest]Orders target, string billId)
        {
            int result = target.getNumberOfItemsWithBillId(billId);
            return result;
            // TODO: add assertions to method OrdersTest.getNumberOfItemsWithBillIdTest(Orders, String)
        }

        /// <summary>Test stub for getNumberOfPendingDeliveries(String)</summary>
        [PexMethod]
        public int getNumberOfPendingDeliveriesTest([PexAssumeUnderTest]Orders target, string orderId)
        {
            int result = target.getNumberOfPendingDeliveries(orderId);
            return result;
            // TODO: add assertions to method OrdersTest.getNumberOfPendingDeliveriesTest(Orders, String)
        }

        /// <summary>Test stub for getNumberOfPendingOrdersFromBill(String)</summary>
        [PexMethod]
        public int getNumberOfPendingOrdersFromBillTest([PexAssumeUnderTest]Orders target, string itemBillId)
        {
            int result = target.getNumberOfPendingOrdersFromBill(itemBillId);
            return result;
            // TODO: add assertions to method OrdersTest.getNumberOfPendingOrdersFromBillTest(Orders, String)
        }

        /// <summary>Test stub for getNumberOfPendingOrders(String)</summary>
        [PexMethod]
        public int getNumberOfPendingOrdersTest([PexAssumeUnderTest]Orders target, string table)
        {
            int result = target.getNumberOfPendingOrders(table);
            return result;
            // TODO: add assertions to method OrdersTest.getNumberOfPendingOrdersTest(Orders, String)
        }

        /// <summary>Test stub for getPendingDeliveries()</summary>
        [PexMethod]
        public List<pending_deliveries> getPendingDeliveriesTest([PexAssumeUnderTest]Orders target)
        {
            List<pending_deliveries> result = target.getPendingDeliveries();
            return result;
            // TODO: add assertions to method OrdersTest.getPendingDeliveriesTest(Orders)
        }

        /// <summary>Test stub for getPendingPayemnt(String)</summary>
        [PexMethod]
        public double getPendingPayemntTest([PexAssumeUnderTest]Orders target, string table)
        {
            double result = target.getPendingPayemnt(table);
            return result;
            // TODO: add assertions to method OrdersTest.getPendingPayemntTest(Orders, String)
        }

        /// <summary>Test stub for getPendingTables()</summary>
        [PexMethod]
        public List<string> getPendingTablesTest([PexAssumeUnderTest]Orders target)
        {
            List<string> result = target.getPendingTables();
            return result;
            // TODO: add assertions to method OrdersTest.getPendingTablesTest(Orders)
        }

        /// <summary>Test stub for getPrice(String)</summary>
        [PexMethod]
        public double getPriceTest([PexAssumeUnderTest]Orders target, string code)
        {
            double result = target.getPrice(code);
            return result;
            // TODO: add assertions to method OrdersTest.getPriceTest(Orders, String)
        }

        /// <summary>Test stub for insertBill(String, Double, String, String, String, String)</summary>
        [PexMethod]
        public void insertBillTest(
            [PexAssumeUnderTest]Orders target,
            string billId,
            double total,
            string username,
            string table,
            string type,
            string phone
        )
        {
           // target.insertBill(billId, total, username, table, type, phone);
            // TODO: add assertions to method OrdersTest.insertBillTest(Orders, String, Double, String, String, String, String)
        }

        /// <summary>Test stub for insertClosing(String, Double, String, String, String, String)</summary>
        [PexMethod]
        public void insertClosingTest(
            [PexAssumeUnderTest]Orders target,
            string billId,
            double total,
            string username,
            string table,
            string type,
            string phone
        )
        {
            target.insertClosing(billId, total, username, table, type, phone);
            // TODO: add assertions to method OrdersTest.insertClosingTest(Orders, String, Double, String, String, String, String)
        }

        /// <summary>Test stub for insertPendingDelivery(String, Double, Double, String, String, String, String)</summary>
        [PexMethod]
        public bool insertPendingDeliveryTest(
            [PexAssumeUnderTest]Orders target,
            string code,
            double qty,
            double itemTotal,
            string phone,
            string name,
            string address,
            string orderId
        )
        {
            bool result = target.insertPendingDelivery
                              (code, qty, itemTotal, phone, name, address, orderId);
            return result;
            // TODO: add assertions to method OrdersTest.insertPendingDeliveryTest(Orders, String, Double, Double, String, String, String, String)
        }

        /// <summary>Test stub for insertPendingOrders(String, Double, Double, String, String)</summary>
        [PexMethod]
        public bool insertPendingOrdersTest(
            [PexAssumeUnderTest]Orders target,
            string code,
            double qty,
            double total,
            string username,
            string tableNumber
        )
        {
            bool result
               = target.insertPendingOrders(code, qty, total, username, tableNumber);
            return result;
            // TODO: add assertions to method OrdersTest.insertPendingOrdersTest(Orders, String, Double, Double, String, String)
        }

        /// <summary>Test stub for insertToBillItems(String, String, Double, Double, String)</summary>
        [PexMethod]
        public void insertToBillItemsTest(
            [PexAssumeUnderTest]Orders target,
            string billId,
            string itemCode,
            double qty,
            double itemTotal,
            string type
        )
        {
            target.insertToBillItems(billId, itemCode, qty, itemTotal, type);
            // TODO: add assertions to method OrdersTest.insertToBillItemsTest(Orders, String, String, Double, Double, String)
        }

        /// <summary>Test stub for removeBillItem(String, String)</summary>
        [PexMethod]
        public void removeBillItemTest(
            [PexAssumeUnderTest]Orders target,
            string billId,
            string itemCode
        )
        {
            target.removeBillItem(billId, itemCode);
            // TODO: add assertions to method OrdersTest.removeBillItemTest(Orders, String, String)
        }

        /// <summary>Test stub for removePendingDeliveries(Int64)</summary>
        [PexMethod]
        public void removePendingDeliveriesTest([PexAssumeUnderTest]Orders target, long pendingOrderId)
        {
            target.removePendingDeliveries(pendingOrderId);
            // TODO: add assertions to method OrdersTest.removePendingDeliveriesTest(Orders, Int64)
        }

        /// <summary>Test stub for removePendingOrder(Int64)</summary>
        [PexMethod]
        public void removePendingOrderTest([PexAssumeUnderTest]Orders target, long id)
        {
            target.removePendingOrder(id);
            // TODO: add assertions to method OrdersTest.removePendingOrderTest(Orders, Int64)
        }

        /// <summary>Test stub for removePendingPayments(Int32)</summary>
        [PexMethod]
        public void removePendingPaymentsTest([PexAssumeUnderTest]Orders target, int id)
        {
            target.removePendingPayments(id);
            // TODO: add assertions to method OrdersTest.removePendingPaymentsTest(Orders, Int32)
        }

        /// <summary>Test stub for updateBillItems(Int64, String, String, Double, Double, String)</summary>
        [PexMethod]
        public void updateBillItemsTest(
            [PexAssumeUnderTest]Orders target,
            long id,
            string searchBillId,
            string itemCode,
            double qty,
            double total,
            string order
        )
        {
            target.updateBillItems(id, searchBillId, itemCode, qty, total, order);
            // TODO: add assertions to method OrdersTest.updateBillItemsTest(Orders, Int64, String, String, Double, Double, String)
        }

        /// <summary>Test stub for updateBill(String, Double, String, String, String)</summary>
        [PexMethod]
        public void updateBillTest(
            [PexAssumeUnderTest]Orders target,
            string billCode,
            double grandTotal,
            string username,
            string order,
            string empty,
            double totalwithoutgst
        )
        {
            target.updateBill(billCode, grandTotal, username, order, empty,totalwithoutgst);
            // TODO: add assertions to method OrdersTest.updateBillTest(Orders, String, Double, String, String, String)
        }

        /// <summary>Test stub for updateClosing(String, Double, String, String, String)</summary>
        [PexMethod]
        public void updateClosingTest(
            [PexAssumeUnderTest]Orders target,
            string searchBillId,
            double grandTotal,
            string s,
            string orderUpdated,
            string empty
        )
        {
            target.updateClosing(searchBillId, grandTotal, s, orderUpdated, empty);
            // TODO: add assertions to method OrdersTest.updateClosingTest(Orders, String, Double, String, String, String)
        }

        /// <summary>Test stub for updateCreditCard(String)</summary>
        [PexMethod]
        public void updateCreditCardTest([PexAssumeUnderTest]Orders target, string billId)
        {
            target.updateCreditCard(billId);
            // TODO: add assertions to method OrdersTest.updateCreditCardTest(Orders, String)
        }

        /// <summary>Test stub for updatePendingDelivery(String, Double, Double, String, String, Int64)</summary>
        [PexMethod]
        public void updatePendingDeliveryTest(
            [PexAssumeUnderTest]Orders target,
            string code,
            double qty,
            double total,
            string orderId,
            string phone,
            long id
        )
        {
            target.updatePendingDelivery(code, qty, total, orderId, phone, id);
            // TODO: add assertions to method OrdersTest.updatePendingDeliveryTest(Orders, String, Double, Double, String, String, Int64)
        }

        /// <summary>Test stub for updatePendingOrders(String, Double, Double, String, String, Int64)</summary>
        [PexMethod]
        public void updatePendingOrdersTest(
            [PexAssumeUnderTest]Orders target,
            string code,
            double qty,
            double total,
            string username,
            string tableNumber,
            long id
        )
        {
            target.updatePendingOrders(code, qty, total, username, tableNumber, id);
            // TODO: add assertions to method OrdersTest.updatePendingOrdersTest(Orders, String, Double, Double, String, String, Int64)
        }

        /// <summary>Test stub for updatePendingPayments(String)</summary>
        [PexMethod]
        public void updatePendingPaymentsTest([PexAssumeUnderTest]Orders target, string table)
        {
            target.updatePendingPayments(table);
            // TODO: add assertions to method OrdersTest.updatePendingPaymentsTest(Orders, String)
        }
    }
}
