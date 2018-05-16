using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public double DX { get; set; }
        public double DY { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(double x, double y)
        {
            DX = x;
            DY = y;
        }
        public Point GetAffinePoint(double x, double y)
        {
            return new Point(x, y);
        }//обратное направление у?
        public void AffineToCanvasPoint()
        {
            X = (int)(Manager.CanvasWidth / 2 + DX);
            Y = (int)(Manager.CanvasHeight / 2 + DY);
        }

    }
}