using CodingPatternsLibrary.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingPatternsLibrary.Tests.SlidingWindow
{
    [TestClass]
    public class LongestSubstringWithSameLettersAfterReplacementTests
    {
        [TestMethod]
        [DataRow("aabccbb", 2, 5)]
        [DataRow("abbcb", 1, 4)]
        [DataRow("abccde", 1, 3)]
        public void FindLongestSubstringLengthTest(string input, int K, int expected)
        {
            var slidingWindow = new LongestSubstringWithSameLettersAfterReplacement();
            var actual = slidingWindow.FindLongestSubstringLength(input, K);
            Assert.AreEqual(actual, expected);
        }
    }
}
