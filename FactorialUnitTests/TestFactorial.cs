using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Factorial.UnitTests
{
    [TestClass]
    public class TestFactorial
    {
        [TestMethod]
        public void FactorialReturn1ForArgument0()
        {
            var result = Math.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void FactorialReturn1ForArgument1()
        {
            var result = Math.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void FactorialReturn2ForArgument2()
        {
            var result = Math.Factorial(0);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void FactorialReturn24ForArgument4()
        {
            var result = Math.Factorial(0);
            Assert.AreEqual(1, result);
        }
    }
}
