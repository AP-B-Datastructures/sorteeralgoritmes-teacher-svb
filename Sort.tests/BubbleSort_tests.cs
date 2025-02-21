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

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesSingleElementArray()
        {
            // Arrange
            int[] input = { 42 };
            int[] expected = { 42 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesAlreadySortedArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void BubbleSort_HandlesReverseSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }

        [DataTestMethod]
        [DataRow(new int[]{ 5, 5, 5, 5, 1 }, new int[]{ 1, 5, 5, 5, 5 })]
        [DataRow(new int[]{ 5, 5, 4, 4, 1 }, new int[]{ 1, 4, 4, 5, 5 })]
        public void BubbleSort_HandlesArrayWithDuplicates(int[] input, int[] expected)
        {
            // Arrange

            // Act
            BubbleSort.Sort(input);

            // Assert
            CollectionAssert.AreEqual(expected, input);
        }
    }
}