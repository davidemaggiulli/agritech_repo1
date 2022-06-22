using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hi, what's your name?");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hi " + name);
            Console.ReadLine();
			
        }
    }
}
