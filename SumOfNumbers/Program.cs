using System;

namespace SumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, i will sum two numbers.");
            Console.WriteLine("Put the first number");
            string s1 = Console.ReadLine();
            int n1 = int.Parse(s1);
            Console.WriteLine("Put the 2nd number");
            string s2 = Console.ReadLine();
            int n2 = int.Parse(s2);
            float avg = (float)(n1 + n2) / 2;   //Cast esplicito (da intero a float)
            float sum = n1 + n2;        //Cast implicito (da intero a float)
            //int a = 2.0f;       //Cast implicito NON CONSENTITO
            int b = (int)2.0f;  //Cast esplicito CONSENTITO
            float avg1 = sum / 2;
            Console.WriteLine("Average: " + avg);

            double d1 = 2.12312121;
            float f1 = 2.12121f;
            decimal m1 = 2.0000211m;
        }
    }
}
