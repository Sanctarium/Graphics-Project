using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Algorithms
    {
        static private int toInteger(double num)
        {
            if (Math.Abs(num - (int)num) < 0.5) return (int)num;
            else
                return (int)num + 1;
        }
        static private int getSign(double num)
        {
            if (num > 0) return 1;
            if (num == 0) return 0;
            else return -1;
        }
        static public void DDA(int x1, int y1, int x2, int y2, string colorname, Bitmap bitmap)
        {
            Drawer drawer = new Drawer(bitmap);
            double length;
            double x, y;
            if (Math.Abs(x2 - x1) >= Math.Abs(y2 - y1))
                length = Math.Abs(x2 - x1);
            else
                length = Math.Abs(y2 - y1);
            double dx = (x2 - x1) / length, dy = (y2 - y1) / length * 1.0;
            x = x1 + 0.5 * getSign(dx);
            y = y1 + 0.5 * getSign(dy);
            for (int i = 0; i < length; i++)
            {
                drawer.Draw(toInteger(x), toInteger(y), colorname);
                x += dx;
                y += dy;
            }
        }
        static public void BrezenheimLine(int x1, int y1, int x2, int y2, string colorname, Bitmap bitmap)
        {
            Drawer drawer = new Drawer(bitmap);
            int x = x1, y = y1;
            int dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1),
                s1 = getSign(x2 - x1), s2 = getSign(y2 - y1);
            int temp, trade, e = 2 * dy - dx;
            if (dy > dx)
            {
                temp = dx;
                dx = dy;
                dy = temp;
                trade = 1;
            }
            else
                trade = 0;
            for (int i = 1; i < dx; i++)
            {
                drawer.Draw(x, y, colorname);
                while (e >= 0)
                {
                    if (trade == 1)
                        x = x + s1;
                    else
                        y = y + s2;
                    e -= 2 * dx;
                }
                if (trade == 1)
                    y += s2;
                else
                    x += s1;
                e += 2 * dy;
            }
        }
    }
}
