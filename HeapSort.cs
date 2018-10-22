using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    /*Heap Sort
      * A Binary Heap is a Complete Binary Tree where items are stored in a special order such that value
      * in a parent node is greater(or smaller) than the values in its two children nodes.The former is called 
      * as max heap and the latter is called min heap.The heap can be represented by binary tree or array.
      * Since a Binary Heap is a Complete Binary Tree, it can be easily represented as array and array based
      * representation is space efficient. If the parent node is stored at index I, the left child can be
      * calculated by 2 * I + 1 and right child by 2 * I + 2 (assuming the indexing starts at 0).Complexity O(nlogn)
      * Step 1 is to create a binary heap in an array.
      * For example: Array: {6,5,3,1,8,7,2,4}
      *                            6
                                 /   \
                               5      3
                              /  \
                             1    8
      * As 8 is larger than 5, we will swap 5 with 8 so tree will look like the following:
      *                          6
                                /  \
                               8     3
                              /  \
                             1    5
     * As 8 is larger than 6, we will swap 6 with 8 so tree will look like the following:
                                 8
                                /  \
                               6    3
                              /  \
                             1    5
     * Then we keep going
     *                       
                                 8
                                /  \
                             6       3
                           /  \     /
                         1    5    7
     * Then swap 7 and 3 and add 2 and 4 and then swap 1 with 4 as 4 is larger than 2
     *                           8
                                /  \
                             6       7
                           /  \     / \ 
                         1    5    3   2
                        /
                      4
     *
                                 8
                                /  \
                             6       7
                           /  \     / \ 
                         4    5    3   2
                        /
                      1
     * Step 2: Once heap structure is created, we will start sorting 
     * Array looks like {8,6,7,4,5,3,2,1}
     * Swap 8 and 1 so 8 number is sorted and tree will look like:
     *                            1
                                /  \
                             6       7
                           /  \     / \ 
                         4    5    3   2

                      8: Sorted, Array: {1,6,7,4,5,3,2,8}

     * As 7 is larger than 1, swap 1 with 7, 3 is larger than 1 so 1 will be swapped with 3 so tree will look like:
     *                           7
                                /  \
                             6       3
                           /  \     / \ 
                         4    5    1   2
      * Now swap 2 with 7, 7 is sorted
      *                          2
                                /  \
                             6       3
                           /  \     / 
                         4    5    1   
       * As 6 is larger than 2, 2 will be swapped with 6 and then with 5
       *                          6
                                /  \
                             5       3
                           /  \     / 
                         4    2    1   

     */
    class HeapSort : SortingAlgorithms
    {
    
        public override void heapSort(int[] arr)
        {
            int n = arr.Length;

            //Make sure array satisfies the condition of binary heap
            heapify(arr, n);

            //After heapify, swap the first and last element and then run heapify again.
            for(int i = n-1; i > 0; i--)
            {
                swap(arr, 0, i);
                heapify(arr, i);

            }

        }

        public void heapify(int[] arr, int n)
        {
            /* Lets build a heap, loop through an array and recursively make sure 
             * tree is always a binary tree. Root's value is larger its left or right child
             * If you are swapping the elements, heapify function starts over again to make sure 
             * it is correct. You can use if or while loop
             * 
            */
            for (int i = 0; i < n - 1; i++)
            {
                int left = 2 * i + 1;
                int right = 2 * i + 2;

                if (left < n)
                {
                    //Or While arr[i] < arr[left])
                    if (arr[i] < arr[left])
                    {
                        swap(arr, i, left);
                        heapify(arr, n);
                    }
                }
                if (right < n)
                {
                    //Or While arr[i] < arr[right])
                    if (arr[i] < arr[right])
                    {
                        swap(arr, i, right);
                        heapify(arr, n);
                    }
                }

            }
        }

        public void swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp;

            temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;

        }


    }
}
