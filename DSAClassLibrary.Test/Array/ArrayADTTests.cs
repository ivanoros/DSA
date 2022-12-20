using DSAClassLibrary.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAClassLibrary.Test.Array
{
    [TestClass]
    public class ArrayADTTests
    {
        [TestMethod]
        [DataRow(new int[] { 2, 6, 10, 15, 25 }, new int[] { 3, 4, 7, 18, 20 }, new int[] { 2, 3, 4, 6, 7, 10, 15, 18, 20, 25 })]
        public void MergeTest(int[] first, int[] second, int[] expected)
        {
            var sut = new ArrayADT();
            var actual = sut.Merge(first, second);

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UnionTest()
        {
            var A = new int[] { 3, 5, 10, 4, 6 };
            var B = new int[] { 12, 4, 7, 2, 5 };

            var C = new int[] { 3, 5, 10, 4, 6, 12, 7, 2 };

            var sut = new ArrayADT();
            var actual = sut.Union(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 4, 5, 6, 10 }, new int[] { 2, 4, 5, 7, 12 }, new int[] { 2, 3, 4, 5, 6, 7, 10, 12 })]
        [DataRow(new int[] { 2, 6, 10, 15, 25 }, new int[] { 3, 6, 7, 15, 20 }, new int[] { 2, 3, 6, 7, 10, 15, 20, 25 })]
        public void UnionOnSortedTest(int[] first, int[] second, int[] expected)
        {
            var sut = new ArrayADT();
            var actual = sut.UnionOnSorted(first, second);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var A = new int[] { 3, 5, 10, 4, 6 };
            var B = new int[] { 12, 4, 7, 2, 5 };

            var C = new int[] { 5, 4 };

            var sut = new ArrayADT();
            var actual = sut.Intersection(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        public void IntersectionOnSortedTest()
        {
            var A = new int[] { 3, 4, 5, 6, 10 };
            var B = new int[] { 2, 4, 5, 7, 12 };

            var C = new int[] { 4, 5 };

            var sut = new ArrayADT();
            var actual = sut.IntersectionOnSorted(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 5, 10, 4, 6 }, new int[] { 12, 4, 7, 2, 5 }, new int[] { 3, 10, 6 })]
        [DataRow(new int[] { 2, 6, 10, 15, 25}, new int[] { 3, 4, 7, 18, 20 }, new int[] { 2, 6, 10, 15, 25, 3, 4, 7, 18, 20 })]
        public void DifferenceTest(int[] first, int[] second, int[] expected)
        {
            var sut = new ArrayADT();
            var actual = sut.Difference(first, second);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DifferenceOnSortedTest()
        {
            var A = new int[] { 3, 4, 5, 6, 10 };
            var B = new int[] { 2, 4, 5, 7, 12 };

            var C = new int[] { 3, 6,10 };

            var sut = new ArrayADT();
            var actual = sut.DifferenceOnSorted(A, B);

            CollectionAssert.AreEqual(C, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 }, new int[] { 12 })]
        [DataRow(new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 }, new int[] { 10, 13, 14 })]
        public void FindMissingElementTest(int[] array, int[] expected)
        {
            var sut = new ArrayADT();
            var actual = sut.FindMissingElement(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 }, new int[] { 12 })]
        [DataRow(new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 }, new int[] { 10, 13, 14 })]
        public void FindMissingElementWhileTest(int[] array, int[] expected)
        {
            var sut = new ArrayADT();
            var actual = sut.FindMissingElementWhile(array);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(new int[] { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 }, new int[] { 12 })]
        [DataRow(new int[] { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 }, new int[] { 10, 13, 14 })]
        [DataRow(new int[] { 3, 7, 4, 9, 12, 6, 1, 11, 2, 10 }, new int[] { 5, 8})]
        public void FindMissingElementExtraArrayTest(int[] array, int[] expected)
        {
            var sut = new ArrayADT();
            var actual = sut.FindMissingElementExtraArray(array);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
