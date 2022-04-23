using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    [TestClass]
    public class MaxSumSubArrayOfSizeKTests
    {
        [TestMethod]
        [DataRow(new int[] { 2, 1, 5, 1, 3, 2 }, 3, 9)]
        [DataRow(new int[] { 2, 3, 4, 1, 5 }, 2, 7)]
        public void FindMaxSumSubArrayTest(int[] arrItems, int k, int expected)
        {
            var sut = new MaxSumSubArrayOfSizeK();
            var actual = sut.FindMaxSumSubArray(arrItems, k);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 1, 5, 1, 3, 2 }, 3, 9)]
        [DataRow(new int[] { 2, 3, 4, 1, 5 }, 2, 7)]
        public void FindBruteForceTest(int[] arrItems, int k, int expected)
        {
            var sut = new MaxSumSubArrayOfSizeK();
            var actual = sut.FindBruteForce(arrItems, k);
            Assert.AreEqual(expected, actual);
        }
    }
}
