using CabInvoiceProblem;
using NUnit.Framework;

namespace CabInvoiceTest
{
    public class Tests
    {

        [Test]
        public void InputInInteger_ShouldReturn_TotalFair()
        {
            CabInvoiceGenerator invoice = new CabInvoiceGenerator(RideType.NORMAL);
            double result = invoice.calculateFair(15, 5);
            Assert.AreEqual(result, 250);
        }
    }
}