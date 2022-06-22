using GeomLib;
using System;
using System.Runtime;

namespace DataStructExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] v = new int[3];
            v[0] = 1;
            v[2] = 2;
            v[1] = 10;

            //v[3] = 10;

            IIntList list;
            IIntList list2;

            list = new IntList();
         

            for(int i = 0; i < 100; i++)
            {
                list.Add(i * 10);
            }
            list.Add(1000);
            int index = list.IndexOf(30);

            int item = list.ItemAt(50);
            //item = list.ItemAt(-2);
            try
            {
                item = list.ItemAt(102);
            } catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            list.RemoveAt(40);

            //IIntList list3 = new IntList();
            //list.Add("Sono");
            //list.Add("una");
            //list.Add("lista");
            IGenericList<string> list4 = new GenericList<string>();
            IGenericList<Point2D> list5 = new GenericList<Point2D>();
            IGenericList<float> list6 = new GenericList<float>();

            list4.Add("Sono");
            list4.Add("una");
            list4.Add("lista");
            list6.Add(12.4f);
            list5.Add(new Point2D(0, 0));
            list5.Add(new Point2D(10, 20));
            list5.Add(new Point2D(30, 20));

            Console.WriteLine($"La lista ha {list.Count()} elementi");
            Console.ReadLine();
        }
    }
}
