using CabInvoiceProgram;

namespace CabInvoiceTest
{
    public class Tests
    {
        CabInvoice cabInvoice;
        [SetUp]

        public void Setup()
        {

        }

        [Test]
        [TestCase(5, 10, 60, CabType.NORMAL_RIDE)]
        [TestCase(5, 10, 95, CabType.PREMIUM_RIDE)]
        [TestCase(0, 10, 95, CabType.NORMAL_RIDE)]
        [TestCase(10, 0, 95, CabType.PREMIUM_RIDE)]
        [TestCase(1, 2, 20, CabType.PREMIUM_RIDE)]

        public void Given_Ride_Details_Returns_TotalFare(double Distance, double Time, double expected, CabType cabType)
        {
            try
            {
                double actual;
                Ride ride = new Ride(Distance, Time, cabType);
                cabInvoice = new CabInvoice();
                actual = cabInvoice.CabInvoiceFare(ride);
                Assert.AreEqual(expected, actual);
            }
            catch (CabInvoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}