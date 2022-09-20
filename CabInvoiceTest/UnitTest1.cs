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
        [Test]
        public void Given_Multiple_Ride_Details_Returns_TotalFare()
        {
            try
            {
                Ride[] ride = { new Ride(5, 10, CabType.NORMAL_RIDE), new Ride(5, 10, CabType.PREMIUM_RIDE) };

                cabInvoice = new CabInvoice();

                double actual = cabInvoice.CabInvoiceFare(ride);
                double total = 155;
                Assert.AreEqual(total, actual);
            }
            catch (CabInvoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Test]
        public void Given_Dist_Time_RideStyle_Return_AvarageFare_For_Multiple_Ride()
        {
            try
            {
                //Assembly
                cabInvoice = new CabInvoice();
                Ride[] ride = { new Ride(5, 10, CabType.NORMAL_RIDE), new Ride(10, 5, CabType.PREMIUM_RIDE) };
                EnhancedInvoiceWithAvarageFare Expected = new EnhancedInvoiceWithAvarageFare(2, 220);
                ///Act
                object ActualFare = cabInvoice.CalculateAvarageFare(ride);
                ///Assert
                Assert.AreEqual(ActualFare, Expected);
            }
            catch (CabInvoiceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}