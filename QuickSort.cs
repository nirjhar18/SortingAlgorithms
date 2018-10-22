using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort : SortingAlgorithms
    {
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
    * Lomuto partition, Everything on left of pivot should be smaller and on right should be larger
    * Recursively keep doing that 
    *  
    * 
    */

        public override void quickSort(int[] array, int low, int high)
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

            swap(array, low, middle);

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

    }
}
