using System;

namespace sdf
{
    class Program
    {
        static int Factorial(int n)
        {
            int ret = 1;

            for (int m = 1; m <= n; m++)

            {
                ret *= m;
            }

            return ret;

        }

        static void Main(string[] args)
        {
            int n = 5;
            int ret = Factorial(n);
            Console.WriteLine(ret);

        }
    }
}
