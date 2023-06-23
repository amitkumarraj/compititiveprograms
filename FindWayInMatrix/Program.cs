using System;

namespace FindWayInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 3;
            int n = 3;

            int wayCounts = FindWays(m, n);

            Console.WriteLine("Hello World!");
        }

        private static int FindWays(int m, int n)
        {
            if (m == 1 || n == 1)
                return 1;

            return (FindWays(m - 1, n) + FindWays(m, n - 1));
        }
    }
}
