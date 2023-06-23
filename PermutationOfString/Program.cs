using System;

namespace PermutationOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "ABC";
            int n = str.Length;
            permute(str, 0, n - 1);
            Console.ReadKey();
        }

        private static void permute(String str, int l, int r)
        {
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        private static string swap(string str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
