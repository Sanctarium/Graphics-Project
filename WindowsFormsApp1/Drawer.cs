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
    }
}
