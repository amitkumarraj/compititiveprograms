using System;
using System.Linq;

namespace RmoveDuplicateValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int n = ar.Length;
            Console.Write("Element occurring once is " +
                                findSingle(ar, n) + " ");
            float sdd = float.Parse(Console.ReadLine());

            char ss = Convert.ToChar(98);
        }

        static int findSingle(int[] ar, int ar_size)
        {
            // Do XOR of all elements and return
            int res = ar[0];
            for (int i = 1; i < ar_size; i++)
                res = res ^ ar[i];

            return res;
        }
    }
}
