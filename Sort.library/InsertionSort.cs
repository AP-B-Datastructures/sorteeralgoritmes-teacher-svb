using System;

namespace Sort.library
{
    public class InsertionSort
    {
        public static void Sort(int[] input)
        {
            /*
            // de start index van het niet-gesorteerde deel
            startIndex = 1

            while startIndex < mijnLijst.length
                key = mijnLijst[startIndex]
                
                for i = startIndex; i >= 0; --i
                    if i > 0 AND key < mijnLijst[i-1]
                        mijnLijst[i] = mijnLijst[i-1]
                    else
                        mijnLijst[i] = key
                        break
                    endif
                endfor
                
                startIndex++
            endwhile
            
            */

            int unsortedIndex = 1;

            while (unsortedIndex < input.Length)
            {
                int key = input[unsortedIndex];

                for (int i = unsortedIndex; i >= 0; --i)
                {
                    if (i > 0 && key < input[i - 1])
                    {
                        input[i] = input[i - 1];
                    }
                    else
                    {
                        input[i] = key;
                        break;
                    }
                }
                unsortedIndex++;
            }
        }
    }
}
