using System;

namespace PowerSetOfString
{
    class Program
    {
        static void Main(string[] args)
        {

            string obj = "ab";

            PrintPowerSet(obj, 0, " ");

            Console.WriteLine("Hello World!");
        }

        private static void PrintPowerSet(string obj, int i, string currentStr)
        {
            if (i >= obj.Length)
            {
                Console.WriteLine(currentStr); return;
            }
            PrintPowerSet(obj, i + 1, currentStr + obj[i]);
            PrintPowerSet(obj, i + 1, currentStr);


        }
    }
}
