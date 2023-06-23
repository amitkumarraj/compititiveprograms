using System;

namespace FindingMajortyElementByMooresVoting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 3, 4, 2, 4, 4, 2, 4 };
            int size = a.Length;
            printMajority(a, size);

            Console.ReadKey();
            //timeComplexcity 0(n)
        }

        private static void printMajority(int[] a, int size)
        {
            int cand = FindingMajortyElement(a, size);
            if (ChechIsMajorty(a, size, cand))
            {
                Console.WriteLine("Majorty element is =" + cand);
            }
            else
            {
                Console.WriteLine("Majorty element not found");
            }
        }

        private static bool ChechIsMajorty(int[] a, int size, int cand)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (a[i] == cand)
                {
                    count++;
                }
            }
            if (count > (size / 2))
            {
                return true;
            }
            return false;
        }

        private static int FindingMajortyElement(int[] arr, int size)
        {
            int start_index = 0;
            int count = 1;


            for (int i = 1; i < size; i++)
            {
                if (arr[start_index] == arr[i])
                    count++;
                else
                    count--;

                if (count == 0)
                {
                    start_index++;
                    count = 1;
                }
            }

            return arr[start_index];
        }
    }
}
