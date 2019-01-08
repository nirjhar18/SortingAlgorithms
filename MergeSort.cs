using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MergeSort : SortingAlgorithms
    {

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
        public override void mergeSort(int[] arr, int left, int right)
        {
           
                int middle = (left + right) / 2;

                //Sort first halve
                mergeSort(arr, left, middle);

                //Sort second halve
                mergeSort(arr, middle + 1, right);

                //Merge everything

                Merge(arr, left, middle, right);

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
    }
}
