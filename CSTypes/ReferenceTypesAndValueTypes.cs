using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSTypes
{
    public class Invoice
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }

    [TestClass]
    public class ReferenceTypesAndValueTypes
    {
        [TestMethod]
        public void IdentityTest()
        {
            Invoice firstInvoice = new Invoice
            {
                ID = 1,
                Description = "Test",
                Amount = 0.0M
            };

            Invoice secondInvoice = new Invoice
            {
                ID = 1,
                Description = "Test",
                Amount = 0.0M
            };


        }
    }
}
