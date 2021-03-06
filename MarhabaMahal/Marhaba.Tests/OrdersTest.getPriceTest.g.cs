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
[PexRaisedException(typeof(NullReferenceException))]
public void getPriceTestThrowsNullReferenceException21301()
{
    double d;
    Orders s0 = new Orders((string)null);
    d = this.getPriceTest(s0, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(OrdersTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void getPriceTestThrowsInvalidOperationException94301()
{
    double d;
    Orders s0 = new Orders((string)null);
    d = this.getPriceTest(s0, "");
}

[TestMethod]
[PexGeneratedBy(typeof(OrdersTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void getPriceTestThrowsInvalidOperationException89901()
{
    double d;
    Orders s0 = new Orders((string)null);
    d = this.getPriceTest(s0, "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(OrdersTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void getPriceTestThrowsInvalidOperationException38701()
{
    double d;
    Orders s0 = new Orders((string)null);
    d = this.getPriceTest(s0, "h");
}

[TestMethod]
[PexGeneratedBy(typeof(OrdersTest))]
[PexRaisedException(typeof(InvalidOperationException))]
public void getPriceTestThrowsInvalidOperationException81101()
{
    double d;
    Orders s0 = new Orders((string)null);
    d = this.getPriceTest(s0, "\0\0");
}
    }
}
