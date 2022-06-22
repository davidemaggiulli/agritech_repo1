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

        public Point2D(int coordX, int coordY)
        {
            x = coordX;
            y = coordY;
        }

        //Stato Interno
        private int x;
        private int y;
        public static int Status;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        
        

    }
}
