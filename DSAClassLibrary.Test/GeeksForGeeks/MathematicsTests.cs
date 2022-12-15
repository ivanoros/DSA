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
        public void NumberOfDigitsTest(int num, int expected)
        {
            var cut = new Mathematics();
            var actual = cut.NumberOfDigits(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 2)]
        [DataRow(27, 2)]
        [DataRow(333, 3)]
        [DataRow(985, 3)]
        [DataRow(7410, 4)]
        public void NumberOfDigitsRecursiveTest(int num, int expected)
        {
            var cut = new Mathematics();
            var actual = cut.NumberOfDigitsRecursive(num);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0, 1)]
        [DataRow(1, 1)]
        [DataRow(10, 2)]
        [DataRow(27, 2)]
        [DataRow(333, 3)]
        [DataRow(985, 3)]
        [DataRow(7410, 4)]
        public void NumberOfDigitsLogarithmicTest(int num, int expected)
        {
            var cut = new Mathematics();
            var actual = cut.NumberOfDigitsLogarithmic(num);
            Assert.AreEqual(expected, actual);
        }

    }
}
