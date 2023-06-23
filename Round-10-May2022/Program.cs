using System;
using System.Linq;

namespace Round_10_May2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int itreation = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < itreation; i++)
            {
                int nosBought = Convert.ToInt32(Console.ReadLine());
                int giftCount = Convert.ToInt32(Console.ReadLine());
                string giftItem = Console.ReadLine();
                var rangeItem = giftItem.Split(' ').Take(giftCount).Select(x => Convert.ToInt32(x)).OrderBy(x => x).Take(nosBought).Sum();
                Console.WriteLine(rangeItem);
            }
        }
    }
}
