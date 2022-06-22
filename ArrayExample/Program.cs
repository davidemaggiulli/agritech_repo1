using System;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] v;
            int a = 2;


            v = new int[10];

            v[2] = 10;
            v[3] = 11;
            v[4] = v[3] + v[2] + v[1];

            Console.ReadLine();

        }
    }
}
