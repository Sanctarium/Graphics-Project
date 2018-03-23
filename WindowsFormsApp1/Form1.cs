﻿using System;
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
            pictureBox1.BackgroundImage = Manager.Bitmap;
            Manager.CleanBitmap = (Bitmap)pictureBox1.BackgroundImage.Clone();
            Manager.DrawAccessible = true;
            Manager.PaintMode = Manager.PaintType.DDA;
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
        private int GetPicX(int x)
        {
            if (x >= pictureBox1.ClientRectangle.Right)
                return pictureBox1.ClientRectangle.Right;
            else if (x <= pictureBox1.ClientRectangle.Left)
                return pictureBox1.ClientRectangle.Left;
            else return x;
        }
        private int GetPicY(int y)
        {
            if (y >= pictureBox1.ClientRectangle.Bottom)
                return pictureBox1.ClientRectangle.Bottom;
            else if (y <= pictureBox1.ClientRectangle.Top)
                return pictureBox1.ClientRectangle.Top;
            else return y;
        }

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
            pictureBox1.Refresh();
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
            pictureBox1.Refresh();
        }
        private void Plot(int x1, int y1, int x2, int y2, string color)
        {
            switch(Manager.PaintMode)
            {
                case Manager.PaintType.DDA:
                    DDA(x1, y1, x2, y2, color, Manager.Bitmap);
                    break;
                case Manager.PaintType.BrezenheimLine:
                    BrezenheimLine(x1, y1, x2, y2, color, Manager.Bitmap);
                    break;
                case Manager.PaintType.BrezenheimCircle:
                    //call BrezenheimCircle method
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) => Manager.SetStartXY(e.X, e.Y);

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int x1 = GetPicX(Manager.GlobalX), y1 = GetPicY(Manager.GlobalY), x2 = GetPicX(e.X), y2 = GetPicY(e.Y);
            Plot(x1, y1, x2, y2, "black");
            Manager.DrawAccessible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.DDA;

        private void toolStripMenuItem3_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.BrezenheimLine;

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Manager.ClearBitmap();
            pictureBox1.BackgroundImage = Manager.Bitmap;
        }
    }
}
