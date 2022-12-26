using DSAClassLibrary.Leetcode;

namespace DSAClassLibrary.Test.Leetcode
{
    [TestClass]
    public class FibonacciNumberTest
    {
        [TestMethod]
        [DataRow(2, 1)]
        [DataRow(3, 2)]
        [DataRow(4, 3)]
        public void FibTest(int n, int expected)
        {
            var sut = new FibonacciNumber();
            var actual = sut.Fib(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
