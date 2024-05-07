
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleCalc;

namespace SampleCalcTest
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator _calculator = new Calculator();
        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(_calculator.Add(5, 2), 5 + 2);
        }

        [TestMethod]
        public void TestSub()
        {
            Assert.AreEqual(_calculator.Sub(5, 2), 5 - 2);
        }
    }
}
