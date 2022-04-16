using DSALibrary.Educative.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSALibrary.Tests.Educative.SlidingWindow
{
    [TestClass]
    public class LongestSubarrayWithOnesAfterReplacementTests
    {
        [TestMethod]
        [DataRow(new int[] { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 1 }, 2, 6)]
        [DataRow(new int[] { 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 1 }, 3, 9)]
        public void FindNoRepeatSubstringTest(int[] arrItems, int K, int expected)
        {
            var slidingWindow = new LongestSubarrayWithOnesAfterReplacement();
            var actual = slidingWindow.FindLongestSubarray(arrItems, K);
            Assert.AreEqual(expected, actual);
        }
    }
}
