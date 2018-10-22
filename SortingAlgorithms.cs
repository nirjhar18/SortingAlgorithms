using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class SortingAlgorithms
    {

        public virtual void bubbleSort(int[] arr) { }

        public virtual void selectionSort(int[] arr) {}

        public virtual void mergeSort(int[] arr, int left, int right) { }

        public virtual void insertionSort(int[] arr){}

        public virtual void quickSort(int[] arr, int low, int high) { }

        public virtual void heapSort(int[] arr) { }

        public void printArray(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

    }
}
