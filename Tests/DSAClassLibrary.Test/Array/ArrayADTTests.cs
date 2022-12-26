using DSAClassLibrary.Array;

namespace DSAClassLibrary.Test.Array
{
    [TestClass]
    public class ArrayADTTests
    {
        private ArrayADT _sut;

        [TestInitialize]
        public void Initialize()
        {
            _sut = new ArrayADT();
        }

        [TestMethod]
        [DataRow(new int[] { 2, 6, 10, 15, 25 }, new int[] { 3, 4, 7, 18, 20 }, new int[] { 2, 3, 4, 6, 7, 10, 15, 18, 20, 25 })]
        public void MergeTest(int[] first, int[] second, int[] expected)
        {
            var actual = _sut.Merge(first, second);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UnionTest()
        {
            var A = new int[] { 3, 5, 10, 4, 6 };
            var B = new int[] { 12, 4, 7, 2, 5 };

            var C = new int[] { 3, 5, 10, 4, 6, 12, 7, 2 };

            var actual = _sut.Union(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 4, 5, 6, 10 }, new int[] { 2, 4, 5, 7, 12 }, new int[] { 2, 3, 4, 5, 6, 7, 10, 12 })]
        [DataRow(new int[] { 2, 6, 10, 15, 25 }, new int[] { 3, 6, 7, 15, 20 }, new int[] { 2, 3, 6, 7, 10, 15, 20, 25 })]
        public void UnionOnSortedTest(int[] first, int[] second, int[] expected)
        {
            var actual = _sut.UnionOnSorted(first, second);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var A = new int[] { 3, 5, 10, 4, 6 };
            var B = new int[] { 12, 4, 7, 2, 5 };

            var C = new int[] { 5, 4 };

            var actual = _sut.Intersection(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        public void IntersectionOnSortedTest()
        {
            var A = new int[] { 3, 4, 5, 6, 10 };
            var B = new int[] { 2, 4, 5, 7, 12 };

            var C = new int[] { 4, 5 };

            var actual = _sut.IntersectionOnSorted(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 5, 10, 4, 6 }, new int[] { 12, 4, 7, 2, 5 }, new int[] { 3, 10, 6 })]
        [DataRow(new int[] { 2, 6, 10, 15, 25 }, new int[] { 6, 4, 7, 15, 20 }, new int[] { 2, 10, 25 })]
        public void DifferenceTest(int[] first, int[] second, int[] expected)
        {
            var actual = _sut.Difference(first, second);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DifferenceOnSortedTest()
        {
            var A = new int[] { 3, 4, 5, 6, 10 };
            var B = new int[] { 2, 4, 5, 7, 12 };

            var C = new int[] { 3, 6, 10 };

            var actual = _sut.DifferenceOnSorted(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 }, new int[] { 12 })]
        [DataRow(new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 }, new int[] { 10, 13, 14 })]
        public void FindMissingElementTest(int[] array, int[] expected)
        {
            var actual = _sut.FindMissingElement(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 }, new int[] { 12 })]
        [DataRow(new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 }, new int[] { 10, 13, 14 })]
        public void FindMissingElementWhileTest(int[] array, int[] expected)
        {
            var actual = _sut.FindMissingElementWhile(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 }, new int[] { 12 })]
        [DataRow(new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 }, new int[] { 10, 13, 14 })]
        [DataRow(new int[] { 3, 7, 4, 9, 12, 6, 1, 11, 2, 10 }, new int[] { 5, 8 })]
        public void FindMissingElementExtraArrayTest(int[] array, int[] expected)
        {
            var actual = _sut.FindMissingElementExtraArray(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 6, 8, 8, 10, 12, 15, 15, 15, 20 }, new int[] { 8, 15 })]
        [DataRow(new int[] { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 }, new int[] { 2, 3, 4 })]
        public void FindDuplicatesInSortedArrayTest(int[] array, int[] expected)
        {
            var actual = _sut.FindDuplicatesInSortedArray(array);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindDuplicatesInSortedArrayWithCountTest()
        {
            int[] array = new int[] { 3, 6, 8, 8, 10, 12, 15, 15, 15, 20 };
            var expected = new Dictionary<int, int>
            {
                {8, 2},
                {15, 3}
            };
            var actual = _sut.FindDuplicatesInSortedArrayWithCount(array);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindDuplicatesInSortedArrayWithCountUsingHashingTest()
        {
            int[] array = new int[] { 3, 6, 8, 8, 10, 12, 15, 15, 15, 20 };
            var expected = new Dictionary<int, int>
            {
                {8, 2},
                {15, 3}
            };
            var actual = _sut.FindDuplicatesInSortedArrayWithCountUsingHashing(array);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FindDuplicatesInUnSortedArrayTest()
        {
            int[] array = new int[] { 8, 3, 6, 4, 6, 5, 6, 8, 2, 7 };
            var expected = new Dictionary<int, int>
            {
                {8, 2},
                {6, 3}
            };
            var actual = _sut.FindDuplicatesInUnSortedArray(array);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        [DataRow(new int[] { 6, 3, 8, 10, 16, 7, 5, 2, 9, 14 }, 10, new int[] { 3, 7 })]
        public void FindPairWithSumKQuadraticTest(int[] array, int k, int[] expected)
        {
            var actual = _sut.FindPairWithSumKQuadratic(array, k);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 3, 8, 10, 16, 7, 5, 2, 9, 14 }, 10, new int[] { 3, 7 })]
        public void FindPairWithSumKTest(int[] array, int k, int[] expected)
        {
            var actual = _sut.FindPairWithSumK(array, k);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 1, 3, 4, 5, 6, 8, 9, 10, 12, 14 }, 10, new int[] { 1, 9 })]
        public void FindPairWithSumKInSortedArrayTest(int[] array, int k, int[] expected)
        {
            var actual = _sut.FindPairWithSumKInSortedArray(array, k);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 5, 8, 3, 9, 6, 2, 10, 7, -1, 4 }, new int[] { -1, 10 })]
        public void FindMaxAndMinInSingleScanTest(int[] array, int[] expected)
        {
            var actual = _sut.FindMaxAndMinInSingleScan(array);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
