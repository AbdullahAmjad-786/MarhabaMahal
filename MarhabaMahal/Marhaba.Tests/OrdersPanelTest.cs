using System;
using MarhabaMahal.Views;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarhabaMahal.Views.Tests
{
    /// <summary>This class contains parameterized unit tests for OrdersPanel</summary>
    [TestClass]
    [PexClass(typeof(OrdersPanel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OrdersPanelTest
    {

        /// <summary>Test stub for roundupbyten(Nullable`1&lt;Double&gt;)</summary>
        [PexMethod]
        public int roundupbytenTest([PexAssumeUnderTest]OrdersPanel target, double? i)
        {
            int result = target.roundupbyten(i);
            return result;
            // TODO: add assertions to method OrdersPanelTest.roundupbytenTest(OrdersPanel, Nullable`1<Double>)
        }
    }
}
