using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceTestCase
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            double expected = 25;
            double distance = 2.0;
            int time = 5;

            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);

            double fare = invoice.calculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 80;
            double distance = 4.0;
            int time = 10;

            InvoiceGenerator invoice1 = new InvoiceGenerator(RideType.PREMIUM);

            double fare1 = invoice1.calculateFare(distance, time);

            Assert.AreEqual(expected, fare1);
        }


    }
}
