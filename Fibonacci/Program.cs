using System;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci. Inserire n: ");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            Console.WriteLine("Fibonacci: " + Fibonacci(n));

            Console.ReadLine();
        }

        static long Fibonacci(int k)
        {
            long n1 = 1;
            long n2 = 1;

            if (k == 1 || k == 2)
            {
                return 1;
            }
            long c = 0;
            int i = 3;
            for (;i <= k; i++)
            {
                c = n1 + n2;
                n1 = n2;
                n2 = c;
                Console.WriteLine(c);
            }
            return c;
        }

        static long FibonacciRic(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
