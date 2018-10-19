using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SortingAlgorithms
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
        public void bubbleSort(int[] arr)
        {
            int temp;

            for (int i= 0; i < arr.Length - 1; i++)
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

        public void selectionSort(int[] arr)
        {
            int lowestNumberIndex;
            int temp;
            for(int i = 0; i < arr.Length - 1;i++)
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

        /*Merge Sort
        Divides input array in two halves, calls itself for the two halves and then merges the two sorted halves. 
        MergeSort(arr[], l,  r)   O(nlogn)
        If r > l
     1. Find the middle point to divide the array into two halves:  
             middle m = (l+r)/2
     2. Call mergeSort for first half:   
             Call mergeSort(arr, l, m)
     3. Call mergeSort for second half:
             Call mergeSort(arr, m+1, r)
     4. Merge the two halves sorted in step 2 and 3:
             Call merge(arr, l, m, r)

     Example: { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 }
                       /                                  \
          Step 1       v                                    v
             { 30, 40, 10, 87, 90, 5}                         {25, 67, 100, 3, 15}
   Step 2       /                         \                               /         \
        {30,40,10}                        {87,90,5}             Step 14 {25,67,100}  Step 15 {3, 15}
           |     \Step 6           Step 8  /      \                        |
Step 3  {30,40}   {10}                   {87,90}  {5} Step 11
        /     \      \                      |
Step 4 {30}   {40}    \ step 7       Step 9 {87} , {90}    
            |      Merge {30,40}{10}      Step 10 Merge {87,90}   
First Merge {30},{40}       |             Step 12 Merge{87,90,5}              
Step 5     {30,40}     {10,30,40}             {5,87,90}

            Step 13: Merge {10,30,40} {5,87,90}
                        {5,10,30,40,87,90}
            
       https://www.geeksforgeeks.org/wp-content/uploads/Merge-Sort-Tutorial.png
        */
        public void MergeSort(int[] arr,int left,int right)
        {
            if (left < right)
            {

                int middle = (left + right) / 2;

                //Sort first halve
                MergeSort(arr, left, middle);

                //Sort second halve
                MergeSort(arr, middle + 1, right);

                //Merge everything

                Merge(arr, left, middle, right);

            }
        }

        //Function to merge two halves
        public void Merge(int[] arr, int left, int middle, int right)
        {
            // Find sizes of two subarrays 
            // to be merged 
            int subArray1Size = middle - left + 1;
            int subArray2Size = right - middle;

            // Create temp arrays  
            int[] L = new int[subArray1Size];
            int[] R = new int[subArray2Size];

            int i, j;

            // Copy data from left sub array to temp array 
            for (i = 0; i < subArray1Size; ++i)
                L[i] = arr[left + i];

            // Copy data from right sub array to temp array 
            for (j = 0; j < subArray2Size; ++j)
                R[j] = arr[middle + 1 + j];

            // Merge the temp arrays  

            // Initial indexes of first 
            // and second subarrays 
            i = 0;
            j = 0;

            // Initial index of merged 
            // subarry array 
            int k = left;

            //Compare the left most item from left array to left most item of right array
            // If right is smaller, then move the smaller element to position it is being compared with.
            /* For example: Merging {10,30,40} {5,87,90}. i is iterator for left and j is iterator for right
            1. Compare 10 with 5, 5 is smaller. Move 5 to position of 10 in final array and increment j. 
            2. Then Compare 10 with 87, add position of 10 after 5 in final array and increment i. Once you know 10 is smaller than 87, 
            there is no point of comparing 10 with 90.
            3. Compare 30 with 87. We won't compare 30 with 5 because we know 5 is smaller than 10 so it is smaller than 30.
            We will add 30 to final array after 10 so array is looking like {5,10,30,.......
            4. Compare 40 with 87 and do the same thing as above

            */
            while (i < subArray1Size && j < subArray2Size)
            {
                if (L[i] <= R[j])
                {
                    // Move the elements
                    arr[k] = L[i];
                    i++;
                }

                else
                // Move the elements
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements  
            // of L[] if any  
            while (i < subArray1Size)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements 
            // of R[] if any  
            while (j < subArray2Size)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

        }

        public void printArray(int[] arr)
                   {
                       int n = arr.Length;

                       for (int i = 0; i < n; ++i)
                           Console.Write(arr[i] + " ");

                       Console.Write("\n");
                   }

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
        public void insertionSort(int[] arr)
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
                    arr[j+1] = arr[j];
                    j = j - 1;
                }

                //Once the positions are moved,add your value(temp) to correct position.
                arr[j + 1] = temp;

            }
        }

        /* Quick Sort
         * Different ways of implementing Quick Sort
         * Pick first element as pivot.
         * Pick last element as pivot
         * Pick a random element as pivot. 
         * Pick median as pivot.(implemented below)         
         * The worst case occurs when the partition 
         * process always picks greatest or smallest element as pivot.
         * Average Case O(nlogn), Worst Case O(n2)
         * Choose the median of the first, middle and last element of the partition for the pivot 
         * Lomuto partition
         *  
         *  
         * 
         */

        public void quickSort(int[] array,int low, int high)
        {
            int pivotPosition;
            if (low < high)
            {
                pivotPosition = median(array, low, high);
                quickSort(array, low, pivotPosition - 1);
                quickSort(array, pivotPosition + 1, high);
            }

        }

       public void swap(int[] array, int low, int high)
        {
            int temp;

            temp = array[low];
            array[low] = array[high];
            array[high] = temp;

        }
        //medain as pivot

        int median(int[] array, int low, int high)
        {
            int middle = (low + high) / 2, upper = low, lower = high;

            if (array[low] > array[middle])
            {
                swap(array, low, middle);
            }

            if (array[low] > array[high])
            { 
            swap(array, high, low);
            }

            if (array[middle] > array[high])
            {
                swap(array, middle, high);
            }

            swap(array,low,middle);

            return partition(array, low, high);
        }


    public int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        //Heap Sort






        //Bucket Sort

        //Radix Sort

    }
}
