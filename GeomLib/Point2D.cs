using System;
using System.Collections.Generic;
using System.Text;

namespace GeomLib
{
    public class Point2D
    {
        public Point2D() : this(0,0)
        {
            //x = 0;
            //y = 0;
        }

        public Point2D(float coordX, float coordY)
        {
            x = coordX;
            y = coordY;
        }

        //Stato Interno
        private float x;
        private float y;
        //public static int Status;

        public float GetX()
        {
            return x;
        }

        public float GetY()
        {
            return y;
        }

        public override string ToString()
        {
            return $"({x} : {y})";
        }


    }
}
