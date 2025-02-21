using System;

namespace Sort.library
{
    /// <summary>
    /// This class contains the Bubble sort algorithm.
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Sort the given input (list of integers) in ascending order 
        /// (from smallest to the largest number)
        /// The list is sorted 'in-place' and since an array is passed
        /// 'by-reference' there is no return value
        /// </summary>
        /// <param name="input">list of numbers</param>
        public static void Sort(int[] input)
        {
            /*
            eerst het algoritme vertalen naar eigen woorden:

            we loopen over het niet-gesorteerde deel
            je pakt een element en het volgende element
            je vergelijkt die twee elementen met elkaar
            als A groter is dan B dan verwisselt ge ze
            en anders niet
            blijf dit opnieuw doen tot het niet-gesorteerde deel leeg is

            daarna je eigen woorden vertalen naar pseudo-code:

            for j = array.length; j > 0; --j
                for i = 0 to j
                    var current = array[i]
                    var next = array[i+1]
                    if current > next
                        array[i] = next
                        array[i+1] = current

            en nu is het gemakkelijk om de C# code te schrijven:
            */

            for (int i = input.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    int current = input[j];
                    int next = input[j + 1];
                    if (current > next)
                    {
                        input[j] = next;
                        input[j + 1] = current;
                    }
                }
            }
        }

        /// <summary>
        /// Sort the given list using the adaptive version of the
        /// bubble sort algorithm
        /// </summary>
        /// <param name="input"></param>
        public static void SortAdaptive(int[] input)
        {
            for (int i = input.Length - 1; i > 0; --i)
            {
                bool canStop = true;

                for (int j = 0; j < i; ++j)
                {
                    int current = input[j];
                    int next = input[j + 1];
                    if (current > next)
                    {
                        canStop = false;
                        input[j] = next;
                        input[j + 1] = current;
                    }
                }

                if (canStop == true)
                {
                    break;
                }
            }
        }
    }
}
