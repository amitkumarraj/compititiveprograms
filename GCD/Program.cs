using System;

namespace GCD
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 24,60 };
            int gcd = GetGCD(arr);
            Console.WriteLine($" {string.Join(",", arr)} GCD is = {gcd}");
            Console.ReadKey();
        }

        private static int GetGCD(int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result = findGCD(arr[i], result);

                if (result == 1) return 1;
            }
            return result;
        }

        private static int findGCD(int a, int b)
        {

            if (a == 0) return b;

            return findGCD(b % a, a);
        }
    }
}
