using System;

namespace LargestSumContiguousSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kadane’s Algorithm 
            int[] a = {-2, -3, 4, -1,
                   -2, 1, 5, -3};
            int n = a.Length;
            maxSubArraySum(a, n);
            Console.ReadKey();
        }

        private static void maxSubArraySum(int[] arr, int size)
        {
            int MaxSumSoFar = 0;
            int currentSum = 0;
            int startIndex = 0, s = 0;
            int endIndex = 0;

            for (int i = 0; i < size; i++)
            {
                currentSum += arr[i];

                if (currentSum > MaxSumSoFar)
                {
                    MaxSumSoFar = currentSum;
                    startIndex = s;
                    endIndex = i;
                }
                if (currentSum < 0)
                {
                    s = i + 1;
                    currentSum = 0;
                }
            }
            Console.WriteLine($"Maximum contiguous sum is {MaxSumSoFar}");
            Console.WriteLine($"Starting index {startIndex}");
            Console.WriteLine($"Ending index {endIndex}");
        }
    }
}
