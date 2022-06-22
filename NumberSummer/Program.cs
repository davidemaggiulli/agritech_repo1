using System;

namespace NumberSummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'll sum the first 10 integer numbers");

            int sum = 0;
            for(int i = 1; i < 11; i++)
            {
                sum = sum + i;
            }

            int sum1 = 0;
            int num = 1;
            while(num < 11)
            {
                sum1 = sum1 + num;
                num = num + 1;
            }
        }
    }
}
