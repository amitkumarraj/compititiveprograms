using System;

namespace PalindromString
{
    class Program
    {
        static void Main(string[] args)
        {

            string obj = "racecar";
            if (IsPalindrom(obj))
                Console.WriteLine($"{obj} is Palindrome");
            else
                Console.WriteLine($"{obj} is not Palindrome");

            Console.WriteLine("Hello World!");
        }

        private static bool IsPalindrom(string obj)
        {
            int i = 0;
            int j = obj.Length-1;
            while (i != j)
            {
                if (obj[i] == obj[j])
                {
                    i++;
                    j--;
                }
                else
                {
                    return false;

                }
            }
            return true;
        }
    }
}
