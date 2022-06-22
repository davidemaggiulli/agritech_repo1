using GeomExample.Uility;
using GeomLib;
using System;


namespace GeomExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point2D a;
            Point2D b;
            Point2D o;

            a = new Point2D(100,13);
            b = new Point2D(-5, 19);
            
            //Point2D.Status = 20;

            Console.WriteLine($"Punta A: ({a.GetX()},{a.GetY()})");

            //PointLib pl = new PointLib();
            double dab = PointLib.GetDistance(a, b);

            Console.WriteLine($"Distanza tra due punti: {dab}");
            

            Point2D c = new Point2D(-5, 1);
            Point2D n1 = PointLib.GetNearestPointFromRef(a, b, c);
            Console.WriteLine($"Punto più vicino a ({c.GetX()} ; {c.GetY()}):  ({n1.GetX()} ; {n1.GetY()})");

            Point2D d = new Point2D(100, 100);
            Point2D n2 = PointLib.GetNearestPointFromRef(a, b, d );


            Console.ReadLine();

            
        }
    }
}
