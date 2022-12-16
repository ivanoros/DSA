using DSAClassLibrary.GeeksForGeeks;
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
            var sut = new Mathematics();
            var actual = sut.NumberOfDigits(num);
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
            var sut = new Mathematics();
            var actual = sut.NumberOfDigitsRecursive(num);
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
            var sut = new Mathematics();
            var actual = sut.NumberOfDigitsLogarithmic(num);
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
            var sut = new Mathematics();
            var actual = sut.IsPalindrom(num);
            Assert.AreEqual(expectes, actual);
        }
    }
}
