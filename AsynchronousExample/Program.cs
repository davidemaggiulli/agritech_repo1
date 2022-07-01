using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Asynchronous example **");
            var watch = new Stopwatch();

            watch.Start();

            Task.WaitAll(Func1(), Func2(), Func3());
            
            watch.Stop();

            Console.WriteLine($"End all activities: {watch.ElapsedMilliseconds}");
        }

        static async Task Func1()
        {
            Console.WriteLine("Func1 >> Start");
            await Task.Delay(5000);
            Console.WriteLine("Func1 >> End");
        }

        static async Task Func2()
        {
            Console.WriteLine("Func2 >> Start");
            await Task.Delay(3000);
            Console.WriteLine("Func2 >> End");
        }

        static async Task Func3()
        {
            Console.WriteLine("Func3 >> Start");
            await Task.Delay(7000);
            Console.WriteLine("Func3 >> End");
        }
    }
}
