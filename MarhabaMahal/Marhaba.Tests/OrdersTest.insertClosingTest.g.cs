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
public void insertClosingTestThrowsInvalidOperationException53001()
{
    Orders s0 = new Orders((string)null);
    this.insertClosingTest
        (s0, (string)null, 0, (string)null, (string)null, (string)null, (string)null);
}
    }
}
