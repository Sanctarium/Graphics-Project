using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Manager.Bitmap = new Bitmap(pictureBox1.BackgroundImage);
            Manager.CleanBitmap = (Bitmap)pictureBox1.BackgroundImage.Clone();
            Manager.Check = true;
            Manager.SetPaintMode(Manager.PaintMode.DDA);
        }

        private int toInteger(double num)
        {
            if (Math.Abs(num - (int)num) < 0.5) return (int)num;
            else
                return (int)num + 1;
        }
        private int getSign(double num)
        {
            if (num > 0) return 1;
            if (num == 0) return 0;
            else return -1;
        }
        private int GetPicX(int x) => x / 3;
        private int GetPicY(int y) => y / 4;
        private void DDA(int x1, int y1, int x2, int y2, string colorname, Bitmap bitmap)
        {
            double length;
            double x, y;
            if (Math.Abs(x2 - x1) >= Math.Abs(y2 - y1))
                length = Math.Abs(x2 - x1);
            else
                length = Math.Abs(y2 - y1);
            double dx = (x2 - x1) / length, dy = (y2 - y1) / length*1.0;
            x = x1 + 0.5 * getSign(dx);
            y = y1 + 0.5 * getSign(dy);
            for (int i = 0; i < length; i++)
            {
                bitmap.SetPixel(toInteger(x), toInteger(y), Color.FromName(colorname));
                x += dx;
                y += dy;
            }
            pictureBox1.BackgroundImage = bitmap;
        }
        private void BrezenheimLine(int x1, int y1, int x2, int y2, string colorname, Bitmap bitmap)
        {
            int x=x1, y=y1;
            int dx = Math.Abs(x2 - x1), dy = Math.Abs(y2 - y1),
                s1=getSign(x2-x1), s2=getSign(y2-y1);
            int temp, trade, e=2*dy-dx;
            if (dy > dx)
            {
                temp = dx;
                dx = dy;
                dy = temp;
                trade = 1;
            }
            else
                trade = 0;
            for(int i=1; i<dx; i++)
            {
                bitmap.SetPixel(x, y, Color.FromName(colorname));
                while(e>=0)
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
            pictureBox1.BackgroundImage = bitmap;
        }
        private void Plot(int x1, int y1, int x2, int y2, string color)
        {
            switch(Manager.GetPaintMode())
            {
                case Manager.PaintMode.DDA:
                    DDA(x1, y1, x2, y2, color, Manager.Bitmap);
                    break;
                case Manager.PaintMode.BrezenheimLine:
                    BrezenheimLine(x1, y1, x2, y2, color, Manager.Bitmap);
                    break;
                case Manager.PaintMode.BrezenheimCircle:
                    //call BrezenheimCircle method
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) => Manager.SetGlobalXY(e.X, e.Y);

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            int x1 = GetPicX(Manager.GlobalX), y1 = GetPicY(Manager.GlobalY), x2 = GetPicX(e.X), y2 = GetPicY(e.Y);
            Plot(x1, y1, x2, y2, "black");
            Manager.Check = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager.ClearBitmap();
            pictureBox1.BackgroundImage = Manager.Bitmap;
        }

        private void button1_Click(object sender, EventArgs e) => Manager.SetPaintMode(Manager.PaintMode.DDA);

        private void button2_Click(object sender, EventArgs e) => Manager.SetPaintMode(Manager.PaintMode.BrezenheimLine);

        private void button5_Click(object sender, EventArgs e)
        {
            DDA(15, 31, 150, 66, "red", Manager.Bitmap);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DDA(31, 15, 100, 56, "blue", Manager.Bitmap);
        }
    }
    public class Point
    {
        int x, y;
        
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        
    }
    public class Manager
    {
        static private Bitmap _bitmap;
        static private Bitmap _cleanBitmap;
        static public Bitmap Bitmap { get => _bitmap; set => _bitmap = value; }
        static public Bitmap CleanBitmap { get => _cleanBitmap; set => _cleanBitmap = value; }
        static public void ClearBitmap()
        {
            Bitmap = (Bitmap)CleanBitmap.Clone();
        }

        static public void SetGlobalXY(int x, int y)
        {
            if (Check)
            {
                GlobalX = x;
                GlobalY = y;
                Check = false;
            }
        }
        static bool _check;
        static public bool Check { get => _check; set => _check = value; }

        static int _globalX, _globalY;
        static public int GlobalX { get => _globalX; set => _globalX = value; }
        static public int GlobalY { get => _globalY; set => _globalY = value; }

        static private PaintMode paintMode;
        public enum PaintMode
        {
            DDA, BrezenheimLine, BrezenheimCircle
        }
        private Manager()
        {

        }
        static public void SetPaintMode(PaintMode Mode) => paintMode = Mode;
        static public PaintMode GetPaintMode() => paintMode;
    }
}
