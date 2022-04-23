using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    [TestClass]
    public class SmallestSubArrayWithAGivenSumTests
    {
        [TestMethod]
        [DataRow(new int[] { 2, 1, 5, 2, 3, 2 }, 7, 2)]
        [DataRow(new int[] { 2, 1, 5, 2, 8 }, 7, 1)]
        [DataRow(new int[] { 3, 4, 1, 1, 6 }, 8, 3)]
        public void FindSmallestContiguousSubaArrayTest(int[] arrItems, int S, int expected)
        {
            var sut = new SmallestSubArrayWithAGivenSum();
            var actual = sut.FindSmallestContiguousSubaArray(arrItems, S);
            Assert.AreEqual(expected, actual);
        }
    }
}
