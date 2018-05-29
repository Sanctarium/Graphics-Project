using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Point
    {
        private double x;
        private double y;
        public double X { get { return (int)x; } set { x = value; } }
        public double Y { get { return (int)y; } set { y=value; } }
        static public int x0 { get; set; }
        static public int y0 { get; set; }
        public double DX { get; set; }
        public double DY { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void GetAffinePoint()
        {
            X = X - x0;
            Y = y0 - Y;
        }
        //public Point GetAffinePoint(double x, double y)
        //{
        //    return new Point(x, y);
        //}


        public void AffineToCanvasPoint()
        {
            X = X+x0;
            Y = y0 - Y;
        }

    }
}