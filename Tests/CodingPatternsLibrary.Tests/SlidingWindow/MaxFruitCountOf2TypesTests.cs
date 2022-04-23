using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    public class MaxFruitCountOf2TypesTests
    {
        [TestMethod]
        [DataRow(new char[] { 'A', 'B', 'C', 'A', 'C' }, 3)]
        [DataRow(new char[] { 'A', 'B', 'C', 'B', 'B', 'C' }, 5)]
        public void FindMaxFruitCountTest(char[] fruits, int expected)
        {
            var sut = new MaxFruitCountOf2Types();
            var actual = sut.FindMaxFruitCount(fruits);
            Assert.AreEqual(expected, actual);
        }
    }
}
