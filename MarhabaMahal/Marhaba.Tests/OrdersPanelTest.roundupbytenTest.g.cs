using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MarhabaMahal.Views;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace MarhabaMahal.Views.Tests
{
    public partial class OrdersPanelTest
    {

[TestMethod]
[PexGeneratedBy(typeof(OrdersPanelTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void roundupbytenTest01()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      OrdersPanel ordersPanel;
      int i;
      ordersPanel = new OrdersPanel((string)null, false);
      ordersPanel.searchBill = false;
      ordersPanel.ordersRow = (DataGridViewRow)null;
      ((UserControl)ordersPanel).AutoValidate = AutoValidate.Disable;
      ((UserControl)ordersPanel).BorderStyle = BorderStyle.None;
      ((ContainerControl)ordersPanel).ActiveControl = (Control)null;
      ((ScrollableControl)ordersPanel).AutoScrollPosition = default(Point);
      ((Control)ordersPanel).Site = (ISite)null;
      ((Control)ordersPanel).TabIndex = 0;
      disposables.Add((IDisposable)ordersPanel);
      i = this.roundupbytenTest(ordersPanel, new double?(0));
      disposables.Dispose();
    }
}
    }
}
