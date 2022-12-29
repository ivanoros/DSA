using DSAClassLibrary.GeeksForGeeks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAClassLibrary.Test.GeeksForGeeks
{
    [TestClass]
    public class MathematicsTests
    {
        private Mathematics _sut;

        [TestInitialize]
        public void Initialize()
        {
            _sut = new Mathematics();
        }

        [TestMethod]
        [DataRow(0,1)]
        [DataRow(1, 1)]
        [DataRow(10, 2)]
        [DataRow(27, 2)]
        [DataRow(333, 3)]
        [DataRow(985, 3)]
        [DataRow(7410, 4)]
        [DataRow(9235, 4)]
        [DataRow(38, 2)]
        [DataRow(7, 1)]
        public void NumberOfDigitsTest(int num, int expected)
        {
            var actual = _sut.NumberOfDigits(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 2)]
        [DataRow(27, 2)]
        [DataRow(333, 3)]
        [DataRow(985, 3)]
        [DataRow(7410, 4)]
        [DataRow(9235, 4)]
        [DataRow(38, 2)]
        [DataRow(7, 1)]
        public void NumberOfDigitsRecursiveTest(int num, int expected)
        {
            var actual = _sut.NumberOfDigitsRecursive(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 2)]
        [DataRow(27, 2)]
        [DataRow(333, 3)]
        [DataRow(985, 3)]
        [DataRow(7410, 4)]
        [DataRow(9235, 4)]
        [DataRow(38, 2)]
        [DataRow(7, 1)]
        public void NumberOfDigitsLogarithmicTest(int num, int expected)
        {
            var actual = _sut.NumberOfDigitsLogarithmic(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(78987, true)]
        [DataRow(8668, true)]
        [DataRow(8, true)]
        [DataRow(21, false)]
        [DataRow(367, false)]
        public void IsPalindromTest(int num, bool expectes)
        {
            var actual = _sut.IsPalindrom(num);
            Assert.AreEqual(expectes, actual);
        }

        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        [DataRow(5, 120)]
        public void FactorialTest(int num, int expected)
        {
            var actual = _sut.Factorial(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(2, 2)]
        [DataRow(3, 6)]
        [DataRow(4, 24)]
        [DataRow(5, 120)]
        public void FactorialRecursiveTest(int num, int expected)
        {
            var actual = _sut.FactorialRecursive(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 6, 2)]
        [DataRow(100, 200, 100)]
        [DataRow(7, 13, 1)]
        [DataRow(12, 15, 3)]
        [DataRow(10, 15, 5)]
        public void GreatestCommonDivisorTest(int a, int b, int expected)
        {
            var actual = _sut.GreatestCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 6, 2)]
        [DataRow(100, 200, 100)]
        [DataRow(7, 13, 1)]
        [DataRow(12, 15, 3)]
        [DataRow(10, 15, 5)]
        public void GreatestCommonDivisorEuclideanTest(int a, int b, int expected)
        {
            var actual = _sut.GreatestCommonDivisorEuclidean(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 6, 2)]
        [DataRow(100, 200, 100)]
        [DataRow(7, 13, 1)]
        [DataRow(12, 15, 3)]
        [DataRow(10, 15, 5)]
        public void GreatestCommonDivisorEuclideanOptimizedTest(int a, int b, int expected)
        {
            var actual = _sut.GreatestCommonDivisorEuclideanOptimized(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 6, 12)]
        [DataRow(12, 15, 60)]
        [DataRow(2, 8, 8)]
        [DataRow(3, 7, 21)]
        public void LeastCommonMultipleTest(int a, int b, int expected)
        {
            var actual = _sut.LeastCommonMultiple(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(4, 6, 12)]
        [DataRow(12, 15, 60)]
        [DataRow(2, 8, 8)]
        [DataRow(3, 7, 21)]
        public void LeastCommonMultipleEfficientTest(int a, int b, int expected)
        {
            var actual = _sut.LeastCommonMultipleEfficient(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(13, true)]
        [DataRow(14, false)]
        [DataRow(101, true)]
        public void IsPrimeNumberTest(int n, bool expected)
        {
            var actual = _sut.IsPrimeNumber(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(13, true)]
        [DataRow(14, false)]
        [DataRow(101, true)]
        public void IsPrimeNumberEfficientTest(int n, bool expected)
        {
            var actual = _sut.IsPrimeNumberEfficient(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow(13, true)]
        [DataRow(14, false)]
        [DataRow(101, true)]
        public void IsPrimeNumberMoreEfficientTest(int n, bool expected)
        {
            var actual = _sut.IsPrimeNumberMoreEfficient(n);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(12, new int[] {2, 2, 3})]
        [DataRow(13, new int[] { 13 })]
        [DataRow(315, new int[] { 3, 5, 7 })]
        public void PrimeFactorsTest(int n, int[] expected)
        {
            var actual = _sut.PrimeFactors(n);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
