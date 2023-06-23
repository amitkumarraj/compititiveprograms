using System;

namespace FineOccuringOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };
            int oddOccuring = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] & 1) == 1)
                    oddOccuring++;
            }
            Console.WriteLine($"Odd occuring is {oddOccuring}");
            Console.WriteLine("Hello World!");
        }
    }
}
