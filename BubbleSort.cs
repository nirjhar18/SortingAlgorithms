using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BubbleSort : SortingAlgorithms
    {
        /*Bubble Sort
       Worst-case and average complexity both О(n2), where n is the number of items being sorted.
       Compares adjacent elements in a loop and swaps them if they are not in order.
       Moves the highest number in the end first
       For example: 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15
       Compare  1. 30, 40: No change 
        2. Compare 40, 10: Change positions of 10 and 40 so array is now 30, 10, 40, 87, 90, 5, 25, 67, 100, 3, 15
        3. Then compare 40,87: No change. Similarly no change for 87,90
        4. Then Compare 90,5: 90 is larger than 5. Interchange the positions 30, 10, 40, 87, 5, 90, 25, 67, 100, 3, 15
        Keep repeating. After first iteration the array would be
        30, 10, 40, 87, 5,25,67, 90, 3, 15,100  */
        public override void bubbleSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                    }
                }

            }

        }
    }
}
