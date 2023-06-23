using System;
using System.Linq;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Before sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            quickSort(arr, 0, arr.Length - 1);
            //SelectionSort(arr);
            //InsertionSort(arr);
            // bubbleSort(arr);

            Console.WriteLine("After sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

        }

        #region Quick Sort
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[p] is now
                at right place */
                int pi = partition(arr, low, high);

                // Separately sort elements before
                // partition and after partition
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
            
        }
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // pivot
            int i = (low - 1); // Index of smaller element and indicates the right position of pivot found so far

            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {
                    i++; // increment index of smaller element
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }


        #endregion

        #region Selection Sort

        private static void SelectionSort(int[] arr)
        {

            Console.WriteLine("Before sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();


            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                swap(arr, i, min);
            }

            Console.WriteLine("after sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();

        }

        #endregion

        #region Insertion Sort
        private static void InsertionSort(int[] arr)
        {
            Console.WriteLine("Before sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();


            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }

            Console.WriteLine("After sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
        }
        #endregion

        #region Bubble sort 
        private static void bubbleSort(int[] arr)
        {
            bool swapped;
            Console.WriteLine("Before sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < (arr.Length - i) - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swap(arr, j, j + 1);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }

            Console.WriteLine("After sort"); ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.Write(" " + arr[i]);
            }

        }

        #endregion

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
