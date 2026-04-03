using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using Tk_v16;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCurrent()
        {
            Assert.AreEqual(Calc.current(13.37 * 9 /* Конгениально */, 13.37), 9, 0.001);
            Assert.AreEqual(Calc.current(100500 * 1, 1), 100500, 0.001);
            Assert.AreEqual(Calc.current(123 * 456, 456), 123, 0.001);
            Assert.ThrowsException<Exception>(() => Calc.current(-1, 0));
            Assert.ThrowsException<Exception>(() => Calc.current(0, 0));
        }
        [TestMethod]
        public void TestMethodResistance()
        {
            Assert.AreEqual(Calc.resistance(13.37, 13.37 * 9), 9, 0.001);
            Assert.AreEqual(Calc.resistance(1, 100500 * 1), 100500, 0.001);
            Assert.AreEqual(Calc.resistance(456, 123 * 456), 123, 0.001);
            Assert.ThrowsException<Exception>(() => Calc.resistance(-1, 0));
            Assert.ThrowsException<Exception>(() => Calc.resistance(0, 0));
        }
        [TestMethod]
        public void TestMethodVoltage()
        {
            Assert.AreEqual(Calc.voltage(13.37 / 9, 9), 13.37, 0.001);
            Assert.AreEqual(Calc.voltage(100500 / 1, 1), 100500, 0.001);
            Assert.AreEqual(Calc.voltage(123 / 10.0, 100), 1230, 0.001);
            Assert.ThrowsException<Exception>(() => Calc.voltage(-1, 0));
        }
    }
}
