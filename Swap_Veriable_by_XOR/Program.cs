using System;

namespace Swap_Veriable_by_XOR
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 897;
            int b = 999;
            Console.WriteLine($"Before swap of A is {a}");
            Console.WriteLine($"Before swap of B is {b}");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("Hello World!");
            Console.WriteLine($"After swap of A is {a}");
            Console.WriteLine($"After swap of B is {b}");

            Console.ReadKey();
        }
    }
}
