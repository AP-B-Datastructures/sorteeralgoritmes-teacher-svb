using System;

namespace Sort.library
{
    public class QuickSort
    {
        public static int[] Sort(int[] input)
        {
            if (input.Length == 0)
            {
                return input;
            }

            return Sort(input, 0, input.Length - 1);

        }

        public static int[] Sort(int[] input, int start, int end)
        {

            if (start < end)
            {
                int pivotIndex = partition(input, start, end);
                Sort(input, start, pivotIndex - 1);
                Sort(input, pivotIndex + 1, end);
            }

            return input;
        }
        
        public static int partition(int[] input, int start, int end)
        {
            // mid = (start + end) / 2
            int mid = (start + end) / 2;

            // swap array[start] and array[mid]
            int swap = input[start];
            input[start] = input[mid];
            input[mid] = swap;

            // pivotIndex = start
            int pivotIndex = start;

            // pivot = array[start]
            int pivot = input[start];

            // scan = start + 1
            int scan = start + 1;

            // while scan <= end
            while (scan <= end)
            {

                // if array[scan] < pivot
                if (input[scan] < pivot)
                {
                    //     pivotIndex = pivotIndex + 1
                    pivotIndex++;

                    //     swap array[pivotIndex] and array[scan]
                    swap = input[pivotIndex];
                    input[pivotIndex] = input[scan];
                    input[scan] = swap;
                }

                // scan ← scan + 1
                scan++;
            }

            // swap array[start] and array[pivotIndex]
            swap = input[start];
            input[start] = input[pivotIndex];
            input[pivotIndex] = swap;

            // return pivotIndex
            return pivotIndex;
        }
    }
}
