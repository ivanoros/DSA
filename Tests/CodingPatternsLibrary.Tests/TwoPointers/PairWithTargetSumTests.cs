using CodingPatternsLibrary.TwoPointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CodingPatternsLibrary.Tests.TwoPointers
{
    [TestClass]
    public class PairWithTargetSumTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 6 }, 6, new int[] { 1, 3 })]
        [DataRow(new int[] { 2, 5, 9, 11 }, 11, new int[] { 0, 2 })]
        public void FindPairTwoPointsTest(int[] arrItems, int targetSum, int[] expected)
        {
            var twoPointers = new PairWithTargetSum();
            var actual = twoPointers.FindPairTwoPoints(arrItems, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 6 }, 6, new int[] { 1, 3 })]
        [DataRow(new int[] { 2, 5, 9, 11 }, 11, new int[] { 0, 2 })]
        public void FindPairUsingDictTest(int[] arrItems, int targetSum, int[] expected)
        {
            var twoPointers = new PairWithTargetSum();
            var actual = twoPointers.FindPairUsingDict(arrItems, targetSum);
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
