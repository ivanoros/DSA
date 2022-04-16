using DSALibrary.Educative.SlidingWindow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSALibrary.Tests.Educative.SlidingWindow
{
    [TestClass]
    public class NoRepeatSubstringTests
    {
        [TestMethod]
        [DataRow("aabccbb", 3)]
        [DataRow("abbbb", 2)]
        [DataRow("abccde", 3)]
        public void FindNoRepeatSubstringTest(string input, int expected)
        {
            var slidingWindow = new NoRepeatSubstring();
            var actual = slidingWindow.FindNoRepeatSubstring(input);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataRow("aabccbb", 3)]
        [DataRow("abbbb", 2)]
        [DataRow("abccde", 3)]
        public void FindNoRepeatSubstringUsingHashSetTest(string input, int expected)
        {
            var slidingWindow = new NoRepeatSubstring();
            var actual = slidingWindow.FindNoRepeatSubstringUsingHashSet(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
