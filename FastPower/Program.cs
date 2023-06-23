using System;

namespace FastPower
{
    class Program
    {
        static void Main(string[] args)
        {
            long _base = 888;
            long _exp = 77;

            var sds = Math.Pow(_base, _exp);
            long _fastPower = GetFastPower(_base, _exp);

            Console.WriteLine($"{_base} power of {_exp}= {_fastPower}");

            int x = 888;
            int y = 77;
            int p = 1000000007;
            var sdsd = fastPower(888,77, 1000000007);


            
            Console.ReadKey();
        }

        private static long fastPower(long a, long b, int n)
        {

            long res = 1;

            while (b > 0)
            {

                if ((b & 1) != 0)
                {
                    res = (res * a % n) % n;
                }

                a = (a % n * a % n) % n;
                b = b >> 1;
            }

            return res;

        }
        private static long GetFastPower(long _base, long exp)
        {
            long result = 1;
            while (_base > 0)
            {
                if ((exp & 1) != 0)
                {
                    result = result * _base;
                }
                _base = _base * _base;
                exp = exp >> 1;
            }
            return result;
        }
    }
}
