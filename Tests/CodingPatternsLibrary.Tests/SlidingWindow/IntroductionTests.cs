using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    [TestClass]
    public class IntroductionTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 }, 5, new double[] { 2.2, 2.8, 2.4, 3.6, 2.8 })]
        public void FindAverageOfContiguousSubArraysTests(int[] nums, int K, double[] expected)
        {
            var sut = new Introduction();
            var actual = sut.FindAverageOfContiguousSubArrays(nums, K);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
