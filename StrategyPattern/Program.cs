using StrategyPattern.Context;
using StrategyPattern.Model;
using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item() { Name = "iPhone", Price = 90000 };

            ItemContext dewaliContext = new ItemContext(new DiwaliStreagty());
            ItemContext newyearContext = new ItemContext(new NewyearStreagty());
            ItemContext noDiscountContext = new ItemContext(new NoDiscountStreagty());

            Console.WriteLine("iPhone Price at diwali = " + dewaliContext.GetItemNetPrice(item));
            Console.WriteLine("iPhone Price at New Year =" + newyearContext.GetItemNetPrice(item));
            Console.WriteLine("iPhone Price at regular " + noDiscountContext.GetItemNetPrice(item));
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
