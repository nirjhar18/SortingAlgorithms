using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{

    /* Insertion Sort
     * Insertion sort is of order O(n2)
     *  Insertion sort takes an element from the list and places it in the correct location in the list. 
     *  In my comments: "You" is the value you are  comparing. Temp value  
     *  For example:  { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };  
     *  1. Compare 40 with 30, No change
     *  2. Compare 40 and 10, 10 is lower than 40 so value of temp will be 10. We will change the value of 10 to 40
     *  array will look like { 30, 40, 40, 87, 90, 5, 25, 67, 100, 3, 15 }, temp is 10. Then compare 10 with 30, 
     *  as 10 is smaller than 30, second element will be changed to 30 so array will be
     *  { 30, 30, 40, 87, 90, 5, 25, 67, 100, 3, 15}. As there is nothing else to compare, first 30 will be replaced 
     *  by 10 so array will be { 10, 30, 40, 87, 90, 5, 25, 67, 100, 3, 15}
     *  3. Then 87 will be compared with 40. No change
     *  4. 90 with 87 and no change
     *  5. Then 5 will be compared with 90. Temp value is 5. As 5 is smaller than 90, value of arr[5] = 90 and 5 will
     *  be compared will values before 90 till it reaches its correct location
     */
    class InsertionSort : SortingAlgorithms
    {
        public override void insertionSort(int[] arr)
        {

            int j;
            //Start the loop with second element in array
            for (int i = 1; i < arr.Length; i++)
            {
                //Item to be compared
                int temp = arr[i];
                //You need to compare an item before you so we are using j to keep track of that
                j = i - 1;

                //If the item before you is larger than your value(temp) 
                //Then make the value of larger item to your value. Also, go one item before that and repeat the cycle
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                //Once the positions are moved,add your value(temp) to correct position.
                arr[j + 1] = temp;

            }
        }
    }
}
