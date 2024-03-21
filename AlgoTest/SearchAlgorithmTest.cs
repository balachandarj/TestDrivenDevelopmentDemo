using NUnit.Framework;

namespace AlgoTest
{
    [TestFixture]
    public class SearchAlgorithmTest
    {
        [TestCase(new int[] { 1, 4, 5, 15, 20, 25, 30 }, 15, 3)]// Number is in middle
        [TestCase(new int[] { 1, 4, 5, 15, 20, 25, 30 }, 1, 0)] // Number is in first
        [TestCase(new int[] { 1, 4, 5, 15, 20, 25, 30 }, 30, 6)] // Number is in last
        [TestCase(new int[] { 1, 4, 5, 15, 20, 25, 30 }, 16, -1)] // Not exist
        public void BinarySearchTest(int[] arr, int n, int expectedResult)
        {
            var searchAlgorithms = new SearchAlgorithms();
            var actualResult = searchAlgorithms.BinarySearch(arr, n);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
