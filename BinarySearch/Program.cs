using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40,45,67,75,89,98,122,156,166,178,189,190,210,255,290,315 };
            int n = arr.Length;
            int findingElement = 98;



            int result = findPostionwithOutGivenArryLength(arr, findingElement);
            //int result = binarySearch(arr, 0, n - 1, findingElement);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
        }

        private static int findPostionwithOutGivenArryLength(int[] arr, int findingElmenet)
        {
            int l = 0;
            int h = 1;
            while (arr[h] < findingElmenet)
            {
                
                    l = h;
                    h = h * 2;
            }
            return binarySearch(arr, l, h, findingElmenet);
        }

        private static int binarySearch(int[] arr, int l, int h, int findingElement)
        {
            if (l <= h)
            {
                int middle = l + (h - l) / 2;
                if (arr[middle] == findingElement)
                {
                    return middle;
                }
                if (arr[middle] > findingElement)
                {
                    return binarySearch(arr, l, middle - 1, findingElement);
                }
                else
                {
                    return binarySearch(arr, middle + 1, h, findingElement);
                }
            }
            return -1;
        }
    }
}
