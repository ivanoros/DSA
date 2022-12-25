using DSAClassLibrary.Leetcode;

namespace DSAClassLibrary.Test.Leetcode
{
    [TestClass]
    public class RunningSumOf1dArrayTests
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void RunningSumTest(int[] nums, int[] expected)
        {
            var sut = new RunningSumOf1dArray();
            var actual = sut.RunningSum(nums);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void RunningSumNewTest(int[] nums, int[] expected)
        {
            var sut = new RunningSumOf1dArray();
            var actual = sut.RunningSumNew(nums);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void RunningSumUsingSameInputArrayTest(int[] nums, int[] expected)
        {
            var sut = new RunningSumOf1dArray();
            var actual = sut.RunningSumUsingSameInputArray(nums);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
