using NUnit.Framework;


namespace SortingMethods.Tests
{
    public class SortingTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InsertionSort()
        {
            int[] items = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };

            Sorting sorting = new Sorting();
            sorting.InsertionSort(items);
            CollectionAssert.AreEqual(sortedArray, items);
        }

        [Test]
        public void QuickSort()
        {
            int[] items = { 5, 4, 3, 2, 1 };
            int[] sortedArray = { 1, 2, 3, 4, 5 };

            Sorting sorting = new Sorting();
            sorting.QuickSort(items);
            CollectionAssert.AreEqual(sortedArray, items);
        }
    }
}