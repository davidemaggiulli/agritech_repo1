using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Equation
    {
        public double[] ResolveSecondDegreeEquation(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
                return null;  //Equazione con zero soluzioni
            
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

            if (x1 == x2)
                return new double[] { x1 };   //Equazione con 1 soluzione

            return new double[] { x1, x2 }; //Equazione con 2 soluzioni distinte
        }
    }
}
