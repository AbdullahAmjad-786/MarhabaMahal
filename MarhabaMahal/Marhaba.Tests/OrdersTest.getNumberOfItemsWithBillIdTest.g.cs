using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarhabaMahal.BLClasses;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace MarhabaMahal.BLClasses.Tests
{
    public partial class OrdersTest
    {

[TestMethod]
[PexGeneratedBy(typeof(OrdersTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void getNumberOfItemsWithBillIdTestThrowsInvalidOperationException38101()
{
    int i;
    Orders s0 = new Orders((string)null);
    i = this.getNumberOfItemsWithBillIdTest(s0, (string)null);
}
    }
}
