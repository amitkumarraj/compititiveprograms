using System;
using System.Collections.Generic;
using System.Linq;

namespace RateGain
{


    public abstract class abc
    {
        public string Name { get; }
        protected abc()
        {
            this.Name = "amit";
        }
    }
    public class test : abc
    {

        public test()
        {
            Console.WriteLine(Name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int chance = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < chance; i++)
            {
                string str = Console.ReadLine();
                findDuplicatiValue(str, chance);
            }
        }

        private static void findDuplicatiValue(string str, int ch)
        {
            Dictionary<char, int> item = new Dictionary<char, int>();
            Char[] chr = new char[str.Length];
            for (int i = 0; i < chr.Length; i++)
            {
                if (item.Any(x => x.Key == Convert.ToChar(str[i])))
                {
                    item[str[i]] = item.Count(x => x.Key == str[i]) + 1;
                }
                else
                {
                    item.Add(str[i], 1);
                }
            }
            Console.WriteLine(item.Where(x => x.Value >= ch).OrderBy(x => x.Key).FirstOrDefault().Key);
        }
    }
}
