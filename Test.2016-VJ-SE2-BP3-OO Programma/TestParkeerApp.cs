using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2016_VJ_SE2_BP3_OO_Programma;
using _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze;

namespace Test._2016_VJ_SE2_BP3_OO_Programma
{
    [TestClass]
    public class TestParkeerApp
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
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(1, 0), new Time(2, 0));
            Assert.IsTrue(parkeerApp.Betaald);
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigVertrekException))]
        public void TestEarlierSameDay()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 2, 0), new Time(Days.Monday, 1, 0));
        }

        [TestMethod]
        public void TestEarlierEarlierDay()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Tuesday, 2, 0), new Time(Days.Monday, 1, 0));
        }

        [TestMethod]
        public void Test0Minutes()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 0));
            Assert.AreEqual(0, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test1Minute()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 1));
            Assert.AreEqual(_garage.UurPrijs/60, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test15Minutes()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 15));
            Assert.AreEqual(_garage.UurPrijs/4, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test16Minutes()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 9, 16));
            Assert.AreEqual(_garage.UurPrijs*16/60d, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test1Hour()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 10, 0));
            Assert.AreEqual(_garage.UurPrijs, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test2Hours()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Monday, 11, 0));
            Assert.AreEqual(_garage.UurPrijs*2, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test24Hours()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Tuesday, 9, 0));
            Assert.AreEqual(_garage.UurPrijs*24 + _garage.UurPrijs*25, parkeerApp.Bedrag);
        }

        [TestMethod]
        public void Test51Hours()
        {
            ParkeerApp parkeerApp = new ParkeerApp(_garage);
            parkeerApp.VoltooiBetaling(new Time(Days.Monday, 9, 0), new Time(Days.Wednesday, 12, 0));
            Assert.AreEqual(_garage.UurPrijs*51 + _garage.UurPrijs*25, parkeerApp.Bedrag);
        }
    }
}