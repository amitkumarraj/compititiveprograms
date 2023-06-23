using System;

namespace BuySellStock
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] price = { 5, 2, 6, 1, 4, 7, 3, 6 };
            int n = price.Length;

            // buy and sell only one stocks
            Console.WriteLine(maxProfit(price, n));

            // buy and sell more then one stocks
            Console.WriteLine(maxProfit2(price, n));
        }

        private static int maxProfit2(int[] arr, int n)
        {
            int maxProfit = 0;
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    maxProfit += arr[i] - arr[i - 1];
                }
            }
            return maxProfit;

        }

        private static int maxProfit(int[] arr, int n)
        {
            int maxProfit = 0;
            int min = arr[0];

            for (int i = 0; i < n; i++)
            {
                min = Math.Min(min, arr[i]);
                int max = arr[i] - min;
                maxProfit = Math.Max(max, maxProfit);

            }

            return maxProfit;

        }
    }
}
