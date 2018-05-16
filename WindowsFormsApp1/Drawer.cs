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
        public void DrawAffineTriangle(Point p1, Point p2, Point p3)
        {
            Algorithms.DDA(p1.X, p1.Y, p2.X, p2.Y, Color.Black, Bitmap);
            Algorithms.DDA(p2.X, p2.Y, p3.X, p3.Y, Color.Black, Bitmap);
            Algorithms.DDA(p3.X, p3.Y, p1.X, p1.Y, Color.Black, Bitmap);
            Algorithms.FullFill(p1.X + p2.X + p3.X, p1.Y + p2.Y + p3.Y, Color.White, Color.Yellow, Bitmap);
        }
    }
}
