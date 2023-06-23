using System;

namespace BitWise
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 8;
            int b = 10;

            var ss = a >> 1; // divide by 2
            var ss1 = a >> 2;// divide by 4
            var ss2 = a >> 3; // divide by 8

            var sdd = b << 1; // multiply by 2
            var sdd1 = b << 2; // multiply by 4
            var sdd2 = b << 3; // multiply by 8
            Console.WriteLine("Hello World!");
        }
    }
}
