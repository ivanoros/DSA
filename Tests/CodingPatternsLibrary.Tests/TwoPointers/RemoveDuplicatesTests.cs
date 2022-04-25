using CodingPatternsLibrary.TwoPointers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CodingPatternsLibrary.Tests.TwoPointers
{
    [TestClass]
    public class RemoveDuplicatesTests
    {
        [TestMethod]
        [DataRow(new int[] { 2, 3, 3, 3, 6, 9, 9 }, 4)]
        [DataRow(new int[] { 2, 2, 2, 11 }, 2)]
        [DataRow(new int[] { 1, 1, 1, 3, 5, 5, 7 }, 4)]
        public void RemoveTest(int[] arrItems, int expected)
        {
            var twoPointers = new RemoveDuplicates();
            var actual = twoPointers.Remove(arrItems);
            Assert.AreEqual(expected, actual);
        }
    }
}
