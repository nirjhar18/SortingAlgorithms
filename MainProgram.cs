﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            int[] sortArray = { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };
            SortingAlgorithms sortArrayClass = new SortingAlgorithms();

            Console.WriteLine("Array without Sorting:");
            sortArrayClass.printArray(sortArray);
            Console.WriteLine();

            Console.WriteLine("Bubble Sort:");
            sortArrayClass = new BubbleSort();
            sortArrayClass.bubbleSort(sortArray);
            sortArrayClass.printArray(sortArray);
            Console.WriteLine();

            Console.WriteLine("Selection Sort:");
            int[] SelectionsortArray = { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };
            sortArrayClass = new SelectionSort();
            sortArrayClass.selectionSort(SelectionsortArray);
            sortArrayClass.printArray(SelectionsortArray);
            Console.WriteLine();

            Console.WriteLine("Merge Sort:");
            int[] MergesortArray = { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };
            sortArrayClass = new MergeSort();
            sortArrayClass.mergeSort(MergesortArray, 0, MergesortArray.Length-1);
            sortArrayClass.printArray(MergesortArray);
            Console.WriteLine();


            Console.WriteLine("Insertion Sort:");
            int[] InsertionArray = { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };
            sortArrayClass = new InsertionSort();
            sortArrayClass.insertionSort(InsertionArray);
            sortArrayClass.printArray(InsertionArray);
            Console.WriteLine();



            Console.WriteLine("Quick Sort:");
            int[] QuickArray = { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };
            sortArrayClass = new QuickSort();
            sortArrayClass.quickSort(QuickArray,0,QuickArray.Length-1);
            sortArrayClass.printArray(QuickArray);
            Console.WriteLine();


            Console.WriteLine("Heap Sort:");
            int[] HeapArray = { 30, 40, 10, 87, 90, 5, 25, 67, 100, 3, 15 };
            sortArrayClass = new HeapSort();
            sortArrayClass.heapSort(HeapArray);
            sortArrayClass.printArray(HeapArray);
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
