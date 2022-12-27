using DSAClassLibrary.Leetcode;

namespace DSAClassLibrary.Test.Leetcode
{
    [TestClass]
    public class ShuffleArrayTest
    {
        [TestMethod]
        [DataRow(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [DataRow(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [DataRow(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 })]
        public void ShuffleTest(int[] nums, int n, int[] expected)
        {
            var sut = new ShuffleArray();
            var actual = sut.Shuffle(nums, n);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 5, 1, 3, 4, 7 }, 3, new int[] { 2, 3, 5, 4, 1, 7 })]
        [DataRow(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4, new int[] { 1, 4, 2, 3, 3, 2, 4, 1 })]
        [DataRow(new int[] { 1, 1, 2, 2 }, 2, new int[] { 1, 2, 1, 2 })]
        public void ShuffleIandJTest(int[] nums, int n, int[] expected)
        {
            var sut = new ShuffleArray();
            var actual = sut.ShuffleIandJ(nums, n);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
