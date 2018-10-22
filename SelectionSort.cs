using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SelectionSort :SortingAlgorithms
    {
        /*Selection Sort
         Start from start of the loop, and check through other elements to find the minimum value.
        After the end of the first iteration, the minimum value is swapped with the current element.
        The iteration then continues from the 2nd element and so on. O(n2)
        Moves the lowest number in the first
        For example: 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15
        Compare  1. 30, 40: No change. As 30 is smaller than 40
         2. Compare 30, 10: Change the lower number index. So now lowest Number index is 2 (2 is the index of element 10)
         3. Then compare 10,87: No change. Similarly no change for 10,90
         4. Then Compare 10,5: 10 is larger than 5. Change the lower number index. 
         So now lowest Number index is 5 (5 is the index of element 5).
         5. Now compare 5 with next elements. Keep repeating. After first iteration lowest number index would be 9(9 is index of 3)
         6. Then change element 3 with ith element. In this change, it will change 3 with 30
         3, 40, 10, 87, 90, 5, 25, 67, 100, 30, 15 */

        public override void selectionSort(int[] arr)
        {
            int lowestNumberIndex;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                lowestNumberIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[j] < arr[lowestNumberIndex])
                    {
                        lowestNumberIndex = j;

                    }

                }

                temp = arr[lowestNumberIndex];
                arr[lowestNumberIndex] = arr[i];
                arr[i] = temp;
            }


        }
    }
}
