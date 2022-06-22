using System;
using System.Collections.Generic;
using System.Text;

namespace GeomLib
{
    public class PointLib
    {
        public static double GetDistance(Point2D p1, Point2D p2)
        {
            return Math.Sqrt( Math.Pow(p1.GetX() - p2.GetX(),2) + Math.Pow(p1.GetY() - p2.GetY(),2) );
        }

        public static Point2D GetNearestPointFromRef(Point2D p1, Point2D p2, Point2D r)
        {
            double dar = GetDistance(p1, r);
            double dbr = GetDistance(p2, r);
            if (dar < dbr)
                return p1;
            else
                return p2;
        }
    }
}
