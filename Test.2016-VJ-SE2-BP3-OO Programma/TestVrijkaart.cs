using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2016_VJ_SE2_BP3_OO_Programma;
using _2016_VJ_SE2_BP3_OO_Programma.Betaalwijze;

namespace Test._2016_VJ_SE2_BP3_OO_Programma
{
    [TestClass]
    public class TestVrijkaart
    {
        [TestMethod]
        public void TestBedrag()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(1,0), new Time(2,0));
            Assert.AreEqual(0, vrijkaart.Bedrag);
        }

        [TestMethod]
        public void TestBetaald()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(1, 0), new Time(2, 0));
            Assert.IsTrue(vrijkaart.Betaald);
        }

        [TestMethod]
        public void TestSameDay()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(Days.Monday, 1, 0), new Time(Days.Monday, 2, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigVertrekException))]
        public void TestEarlierSameDay()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(Days.Monday, 2, 0), new Time(Days.Monday, 1, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigVertrekException))]
        public void TestEarlierEarlierDay()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(Days.Tuesday, 2, 0), new Time(Days.Monday, 1, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigVertrekException))]
        public void TestLaterDay()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(Days.Monday, 1, 0), new Time(Days.Tuesday, 2, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(OngeldigVertrekException))]
        public void TestEarlierDay()
        {
            Vrijkaart vrijkaart = new Vrijkaart();
            vrijkaart.VoltooiBetaling(new Time(Days.Tuesday, 1, 0), new Time(Days.Monday, 2, 0));
        }
    }
}
