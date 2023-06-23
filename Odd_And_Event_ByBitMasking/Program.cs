using System;

namespace Odd_And_Event_ByBitMasking
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10] { 5, 3, 1, 18, 4, 8, 9, 10, 43, 45 };
            foreach (var item in arr)
            {

                if ((item & 1) == 0) Console.WriteLine($"{item} is  even");
                else Console.WriteLine($"{item} is odd");
            }
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
