using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void IsNaturalNumberTest()
        {
            Assert.ThrowsException<RomanNumberException>(() => (new RomanNumber(0)));
        }

        [TestMethod()]
        public void AdditionTest()
        {
            var n1 = new RomanNumber(15);
            var n2 = new RomanNumber(21);
            var expected = new RomanNumber(36);
            RomanNumber actual = n1 + n2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void SubstractionTests()
        {
            var n1 = new RomanNumber(21);
            var n2 = new RomanNumber(15);
            var expected = new RomanNumber(6);
            RomanNumber actual = n1 - n2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (n2 - n1));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            var n1 = new RomanNumber(20);
            var n2 = new RomanNumber(5);
            var expected = new RomanNumber(100);
            RomanNumber actual = n1 * n2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void DivisionTests()
        {
            var n1 = new RomanNumber(100);
            var n2 = new RomanNumber(5);
            var expected = new RomanNumber(20);
            RomanNumber actual = n1 / n2;
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Assert.ThrowsException<RomanNumberException>(() => (n2 / n1));
        }

        [TestMethod()]
        public void ToStringFunctionTest()
        {
            RomanNumber n = new RomanNumber(27);
            string expected = "XXVII";
            string actual = n.ToString();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CloneFunctionTests()
        {
            RomanNumber n = new RomanNumber(27);
            RomanNumber expected = new RomanNumber(27);
            RomanNumber clone = (RomanNumber)n.Clone();
            Assert.AreEqual(expected.ToString(), clone.ToString());
            Assert.AreNotSame(expected, clone);
        }

        [TestMethod()]
        public void CompareToFunctionTest()
        {
            RomanNumber n = new RomanNumber(10);
            RomanNumber n1 = new RomanNumber(10);
            const int expected = 0;
            int actual = n.CompareTo(n1);
            Assert.AreEqual(expected, actual);
        }
    }
}