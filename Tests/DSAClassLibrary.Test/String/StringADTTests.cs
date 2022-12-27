using DSAClassLibrary.String;

namespace DSAClassLibrary.Test.String
{
    [TestClass]
    public class StringADTTests
    {
        StringADT _sut;

        [TestInitialize]
        public void Initialize()
        {
            _sut = new StringADT();
        }

        [TestMethod]
        [DataRow("python", "nohtyp")]
        public void ReverseStringTest(string str, string expected)
        {
            var actual = _sut.ReverseString(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("python", "nohtyp")]
        public void ReverseStringJTest(string str, string expected)
        {
            var actual = _sut.ReverseStringJ(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("python", "nohtyp")]
        public void ReverseStringInPlaceTest(string str, string expected)
        {
            var actual = _sut.ReverseStringInPlace(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("madam", true)]
        public void isPalindrom(string str, bool expected)
        {
            var actual = _sut.isPalindrom(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("finding", "in")]
        public void FindDuplicatesTest(string str, string expected)
        {
            var actual = _sut.FindDuplicates(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("finding", "in")]
        public void FindDuplicatesHashTableTest(string str, string expected)
        {
            var actual = _sut.FindDuplicatesHashTable(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
