using System;

namespace Sort.library
{
    public class RandomArrayGenerator
    {
        /// <summary>
        /// Generate a list of random numbers 
        /// </summary>
        /// <param name="amount">The size of the list</param>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <param name="unique">No 2 numbers can be the same</param>
        /// <returns>The list with random numbers</returns>
        public static int[] Generate(int amount = 10, int min = 0, int max = 10, bool unique = false)
        {
            //TODO: implement random generator and return the
            //list of random numbers

            int[] result = new int[amount];

            Random rnd = new Random();

            for (int i = 0; i < amount; ++i)
            {
                int newVal = rnd.Next(min, max);

                if (unique == true && amount <= max - min)
                {
                    while (Array.IndexOf(result, newVal) >= 0)
                    {
                        newVal = rnd.Next(min, max);
                    }
                }

                result[i] = newVal;
            }

            return result;
        }
    }
}
