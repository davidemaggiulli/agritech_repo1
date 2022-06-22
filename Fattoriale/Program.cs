using System;

namespace Fattoriale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire n:");
            int n = int.Parse(Console.ReadLine());
            int f = Fact(n);
            int f1 = FactRic(n);
            Console.WriteLine("Fattoriale: " + f);
        }

        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            int f = 1;

            for (int i = n; i > 0; i--)
                f *= i;     //f = f * i;    //*= += -= /=
            

            //for(int i = 1;i <= n;i++)
            //{
            //    f = f * i;
            //}
            return f;
        }

        static int FactRic(int n)
        {
            if (n == 0)
                return 1;
            return n * FactRic(n - 1);
        }
    }
}
