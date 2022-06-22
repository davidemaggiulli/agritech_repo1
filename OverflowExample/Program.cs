using System;

namespace OverflowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.MaxValue - 10;
            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine(num);
                num = num + 1;
            }
        }
    }
}
