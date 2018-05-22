using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Drawer
    {
        private Bitmap Bitmap;
        public Drawer(Bitmap bitmap)
        {
            Bitmap = bitmap;
        }

        public void Draw(int x, int y, Color colorname)
        {
            try { Bitmap.SetPixel(x, y, colorname); }
            catch (ArgumentOutOfRangeException)
            { Bitmap.SetPixel(Bitmap.Width, Bitmap.Height, colorname); }

        }
      static  public void DrawAffineTriangle(Point p1, Point p2, Point p3, Bitmap bitmap)
        {
            Algorithms.DDA((int)p1.X, (int)p1.Y, (int)p2.X, (int)p2.Y, Color.Black, bitmap);
            Algorithms.DDA((int)p2.X, (int)p2.Y, (int)p3.X, (int)p3.Y, Color.Black, bitmap);
            Algorithms.DDA((int)p3.X, (int)p3.Y, (int)p1.X, (int)p1.Y, Color.Black, bitmap);
            
        }
    }
}
