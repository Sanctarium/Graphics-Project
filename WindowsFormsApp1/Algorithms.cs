using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
        static public void DDA(int x1, int y1, int x2, int y2, Color colorname, Bitmap bitmap)
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
        static public void BrezenheimLine(int x1, int y1, int x2, int y2, Color colorname, Bitmap bitmap)
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
        static public void BrezenheimCirle(int x, int y, int r, Color colourname, Bitmap bitmap)
        {
            Drawer drawer = new Drawer(bitmap);
            int x1 = 0;
            int y1 = r;
            int delta = 1 - 2 * r;
            int error = 0;
            while (y1 >= 0)
            {
                drawer.Draw(toInteger(x + x1), toInteger(y + y1), colourname);
                drawer.Draw(toInteger(x + x1), toInteger(y - y1), colourname);
                drawer.Draw(toInteger(x - x1), toInteger(y + y1), colourname);
                drawer.Draw(toInteger(x - x1), toInteger(y - y1), colourname);
                error = 2 * (delta + y1) - 1;
                if (delta < 0 && error <= 0)
                {
                    x1++;
                    delta += 2 * x1 + 1;
                    continue;
                }
                if (delta > 0 && error > 0)
                {
                    y1--;
                    delta -= 2 * y1 + 1;
                    continue;
                }
                x1++;
                delta += 2 * (x1 - y1);
                y1--;
            }
        }
        static public void FullFill(int x, int y, Color pixelcolour, Color newcolour, Bitmap bitmap)
        {
            Drawer drawer = new Drawer(bitmap);
            Point p = new Point();
            Stack<Point> pointStack = new Stack<Point>();
            pointStack.Push(new Point(-1, 3));
            if (bitmap.GetPixel(x, y).ToArgb() != newcolour.ToArgb())
            {
                pointStack.Push(new Point(x, y));
                while (pointStack.Peek().x != -1)
                {
                    p = pointStack.Pop();
                    if (bitmap.GetPixel(p.x, p.y) == pixelcolour) drawer.Draw(p.x, p.y, newcolour);
                    if (p.x + 1 < bitmap.Width && bitmap.GetPixel(p.x + 1, p.y) == pixelcolour) pointStack.Push(new Point(p.x + 1, p.y));
                    if (p.x - 1 > 0 && bitmap.GetPixel(p.x - 1, p.y) == pixelcolour) pointStack.Push(new Point(p.x - 1, p.y));
                    if (p.y + 1 < bitmap.Height && bitmap.GetPixel(p.x, p.y + 1) == pixelcolour) pointStack.Push(new Point(p.x, p.y + 1));
                    if (p.y - 1 > 0 && bitmap.GetPixel(p.x, p.y - 1) == pixelcolour) pointStack.Push(new Point(p.x, p.y - 1));
                }
            }
        }
        static public void StringFill(int x, int y, Color pixelcolour, Color newcolour, Bitmap bitmap)
        {


            Drawer drawer = new Drawer(bitmap);
            Point pt = new Point(x, y);
            Stack<Point> pixels = new Stack<Point>();
            
            if (bitmap.GetPixel(x, y).ToArgb() != newcolour.ToArgb())
            {
                pixels.Push(pt);
                while (pixels.Count != 0)
                {
                    Point temp = pixels.Pop();
                    int y1 = temp.y;
                    while (y1 >= 0 && Manager.Bitmap.GetPixel(temp.x, y1) == pixelcolour)
                    {
                        y1--;
                    }
                    y1++;
                    bool spanLeft = false;
                    bool spanRight = false;
                    while (y1 < Manager.Bitmap.Height && Manager.Bitmap.GetPixel(temp.x, y1) == pixelcolour)
                    {
                        drawer.Draw(temp.x, y1, newcolour);
                        if (!spanLeft && temp.x > 0 && Manager.Bitmap.GetPixel(temp.x - 1, y1) == pixelcolour)
                        {
                            pixels.Push(new Point(temp.x - 1, y1));
                            spanLeft = true;
                        }
                        else if (spanLeft && temp.x - 1 == 0 && Manager.Bitmap.GetPixel(temp.x - 1, y1) != pixelcolour)
                        {
                            spanLeft = false;
                        }
                        if (!spanRight && temp.x < Manager.Bitmap.Width - 1 && Manager.Bitmap.GetPixel(temp.x + 1, y1) == pixelcolour)
                        {
                            pixels.Push(new Point(temp.x + 1, y1));
                            spanRight = true;
                        }
                        else if (spanRight && temp.x < Manager.Bitmap.Width - 1 && Manager.Bitmap.GetPixel(temp.x + 1, y1) != pixelcolour)
                        {
                            spanRight = false;
                        }
                        y1++;
                    }
                }
            }
        }


        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
