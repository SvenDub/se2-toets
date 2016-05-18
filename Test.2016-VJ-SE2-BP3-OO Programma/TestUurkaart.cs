using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2016_VJ_SE2_BP3_OO_Programma;
using _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze;

namespace Test._2016_VJ_SE2_BP3_OO_Programma
{
    [TestClass]
    public class TestUurkaart
    {
        private Garage _garage;

        [TestInitialize]
        public void SetUp()
        {
            _garage = new Garage();
            _garage.LaadConfiguratie(@"..\..\..\2016-VJ-SE2-BP3-OO Programma\configuraties\configuratie_01.txt");
        }

        [TestMethod]
        public void TestBetaald()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(1, 0), new Time(2, 0));
            Assert.IsTrue(uurkaart.Betaald);
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigVertrekException))]
        public void TestEarlierSameDay()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 2, 0), new Time(Days.Monday, 1, 0));
        }

        [TestMethod]
        public void TestEarlierEarlierDay()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Tuesday, 2, 0), new Time(Days.Monday, 1, 0));
        }

        [TestMethod]
        public void Test0Minutes()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 0));
            Assert.AreEqual(_garage.UurPrijs/4, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test1Minute()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 1));
            Assert.AreEqual(_garage.UurPrijs/4, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test15Minutes()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 15));
            Assert.AreEqual(_garage.UurPrijs/2, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test16Minutes()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 16));
            Assert.AreEqual(_garage.UurPrijs/2, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test1Hour()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 10, 0));
            Assert.AreEqual(_garage.UurPrijs*1.25, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test2Hours()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 11, 0));
            Assert.AreEqual(_garage.UurPrijs*2.25, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test24Hours()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Tuesday, 9, 0));
            Assert.AreEqual(_garage.UurPrijs*24.25 + _garage.UurPrijs*25, uurkaart.Bedrag);
        }

        [TestMethod]
        public void Test51Hours()
        {
            Uurkaart uurkaart = new Uurkaart(_garage);
            uurkaart.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Wednesday, 12, 0));
            Assert.AreEqual(_garage.UurPrijs*51.25 + _garage.UurPrijs*25, uurkaart.Bedrag);
        }
    }
}