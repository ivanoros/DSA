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
        [DataRow("donutsandwafflemakemehungry", "flea", "affle")]
        [DataRow("whoopiepiesmakemyscalegroan", "roam", "myscalegro")]
        [DataRow("coffeeteabiscuits", "cake", "")]
        public void FindMinimumWindowSubstringTest(string input, string substring, string expected)
        {
            var sut = new MinimumWindowSubstring();
            var actual = sut.FindMinimumWindowSubstring(input, substring);
            Assert.AreEqual(expected, actual);
        }
    }
}
