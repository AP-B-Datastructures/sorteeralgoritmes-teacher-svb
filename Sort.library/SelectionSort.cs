using System;

namespace Sort.library
{
    public class SelectionSort
    {
        // Selection sort voor integers
        public static void Sort(int[] input)
        {

            /*
            // de start index van het niet-gesorteerde deel
            startIndex = 0

            while startIndex < mijnLijst.length - 1
                // vind de kleinste waarde
                smallestIndex = startIndex
                for i of mijnLijst
                    if mijnLijst[i] < mijnLijst[smallestIndex]
                        smallestIndex = i
                    endif
                endfor
                
                // wissel de eerste niet-gesorteerde waarde met de kleinste waarde
                smallestValue = mijnLijst[smallestIndex]
                mijnLijst[smallestIndex] = mijnLijst[startIndex]
                mijnLijst[startIndex] = smallestValue
                
                // verhoog de startIndex van de niet-gesorteerde lijst
                startIndex++
            endWhile

            */

            // de start index van het niet-gesorteerde deel
            int unsortedIndex = 0;

            while (unsortedIndex < input.Length - 1)
            {
                // vind de kleinste waarde
                int smallestIndex = unsortedIndex;
                for (int i = 0; i < input.Length; ++i)
                {
                    if (input[i] < input[smallestIndex])
                    {
                        smallestIndex = i;
                    }
                }

                // wissel de eerste niet-gesorteerde waarde met de kleinste waarde
                int smallestValue = input[smallestIndex];
                input[smallestIndex] = input[unsortedIndex];
                input[unsortedIndex] = smallestValue;

                // verhoog de startIndex van de niet-gesorteerde lijst
                unsortedIndex++;
            }
        }

        // Selection sort voor strings
        public static void Sort(string[] input)
        {
            // de start index van het niet-gesorteerde deel
            int unsortedIndex = 0;

            while (unsortedIndex < input.Length - 1)
            {
                // vind de kleinste waarde
                int smallestIndex = unsortedIndex;
                for (int i = 0; i < input.Length; ++i)
                {
                    if (input[i].CompareTo(input[smallestIndex]) < 0)
                    {
                        smallestIndex = i;
                    }
                }

                // wissel de eerste niet-gesorteerde waarde met de kleinste waarde
                string smallestValue = input[smallestIndex];
                input[smallestIndex] = input[unsortedIndex];
                input[unsortedIndex] = smallestValue;

                // verhoog de startIndex van de niet-gesorteerde lijst
                unsortedIndex++;
            }
        }
    }
}
