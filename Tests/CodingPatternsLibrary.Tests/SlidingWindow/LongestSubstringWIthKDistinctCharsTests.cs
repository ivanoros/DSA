using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    [TestClass]
    public class LongestSubstringWIthKDistinctCharsTests
    {
        [TestMethod]
        [DataRow("araaci", 2, 4)]
        [DataRow("araaci", 1, 2)]
        [DataRow("cbbebi", 3, 5)]
        public void FindLongestSubstringWIthKDistinctCharsTest(string input, int K, int expected)
        {
            var sut = new LongestSubstringWIthKDistinctChars();
            var actual = sut.FindLongestSubstringWIthKDistinctChars(input, K);
            Assert.AreEqual(expected, actual);
        }
    }
}
