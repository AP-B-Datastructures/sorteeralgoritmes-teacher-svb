using System;
using Sort.library;

namespace Sort.tests
{
    [TestClass]
    public class BubbleSort_tests
    {
        [TestMethod]
        public void BubbleSort_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(5, 1, 5, true);
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void BubbleSort_HandlesEmptyArray()
        {
            // Arrange
            int[] input = { };
            int[] expected = { };

            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesAlreadySortedArray()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesReverseSortedArray()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void BubbleSort_HandlesArrayWithDuplicates()
        {
            throw new NotImplementedException();
        }
    }
}