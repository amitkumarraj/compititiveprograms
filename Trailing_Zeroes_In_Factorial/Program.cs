using System;

namespace Trailing_Zeroes_In_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int no = 500;
            int count = 0;

            for (int i = 5; no / i >= 1; i *= 5)
            {
                count += no / i;
            }

            Console.WriteLine($"Count of trailing 0s in {no}! is {count}");
            Console.ReadKey();

        }
    }
}
