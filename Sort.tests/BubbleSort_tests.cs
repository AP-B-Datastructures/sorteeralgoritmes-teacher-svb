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
            int[] input = {5, 1, 3, 2, 4};
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_SortsLargeArrayInAscendingOrder()
        {
            // Arrange
            int[] input = RandomArrayGenerator.Generate(1000, 1, 100000, false);

            // Act
            BubbleSort.Sort(input);

            // Assert
            for (int i = 0; i < input.Length - 1; i++)
            {
                Assert.IsTrue(input[i] <= input[i+1]);
            }
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