using System;

namespace RainWaterTrap
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.Write(maxWater(arr));
            Console.ReadKey();
        }

        private static int maxWater(int[] arr)
        {
            int n = arr.Length;
            int[] leftArr = new int[arr.Length];
            int[] rightArr = new int[arr.Length];
            int sum = 0;

            leftArr[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                leftArr[i] = Math.Max(arr[i], leftArr[i - 1]);
            }

            rightArr[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                rightArr[i] = Math.Max(arr[i], rightArr[i + 1]);
            }


            for (int i = 0; i < n; i++)
            {

                sum += Math.Min(leftArr[i], rightArr[i]) - arr[i];
            }
            return sum;
        }

    }
}
