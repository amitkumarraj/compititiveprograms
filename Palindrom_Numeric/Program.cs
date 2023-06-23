using System;

namespace Palindrom_Numeric
{
    class Program
    {
        static void Main(string[] args)
        {

            int pr = 45848504;
            int plindrop = pr;
            int pr1 = 0;

            while (pr > 0)
            {
                int mod = pr % 10;
                pr1 = (pr1 * 10) + mod;
                pr = pr / 10;
            }
            if(plindrop == pr1)
            {
                Console.WriteLine($"{plindrop} is palindrome");
            }
            else
            {
                Console.WriteLine($"{plindrop} is  not palindrome");
            }


            Console.WriteLine("Hello World!");
        }
    }
}
