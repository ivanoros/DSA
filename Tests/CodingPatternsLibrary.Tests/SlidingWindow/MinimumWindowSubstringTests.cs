using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    [TestClass]
    public class MinimumWindowSubstringTests
    {
        [TestMethod]
        [DataRow("ADOBECODEBANC", "ABC", "BANC")]
        [DataRow("BBBBBBABBCBBB", "ABC", "ABBC")]
        public void FindMinimumWindowSubstringTest(string input, string substring, string expected)
        {
            var sut = new MinimumWindowSubstring();
            var actual = sut.FindMinimumWindowSubstring(input, substring);
            Assert.AreEqual(expected, actual);
        }
    }
}
