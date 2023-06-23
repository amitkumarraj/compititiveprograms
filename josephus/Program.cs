using System;

namespace josephus
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 47;
            int k = 5;

            int joesphusCount = FindJoesphus(n, k);

            Console.WriteLine("Hello World!");
        }

        private static int FindJoesphus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (FindJoesphus(n - 1, k) + k - 1) % n + 1;
        }
    }
}
