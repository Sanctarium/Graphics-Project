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

        public void Draw(int x, int y, string colorname)
        {
            Bitmap.SetPixel(x, y, Color.FromName(colorname));
        }
    }
}
