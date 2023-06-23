using System;

namespace FindingMajortyElement
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 3, 3, 4, 2, 4, 4, 2, 4 };
            PrintMajortyElement(arr);

            Console.ReadKey();


            //timeComplexcity 0(n*n)
        }

        private static void PrintMajortyElement(int[] arr)
        {
            int index = -1;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    index = i;
                }
            }

            if (maxCount > (arr.Length / 2))
            {
                Console.WriteLine("Majority Elements is " + arr[index]);
            }
            else
            {
                Console.WriteLine("No Majority Elements is found ");
            }
        }
    }
}
