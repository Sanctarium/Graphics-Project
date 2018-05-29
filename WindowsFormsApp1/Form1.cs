using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

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

        private void Plot(int x1, int y1, int x2, int y2, Color color)
        {
            switch (Manager.PaintMode)
            {
                case Manager.PaintType.DDA:
                    Algorithms.DDA(x1, y1, x2, y2, color, Manager.Bitmap);
                    break;
                case Manager.PaintType.BrezenheimLine:
                    Algorithms.BrezenheimLine(x1, y1, x2, y2, color, Manager.Bitmap);
                    break;
                case Manager.PaintType.BrezenheimCircle:
                    int range = (int)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                    try
                    { Algorithms.BrezenheimCirle(x1, y1, range, color, Manager.Bitmap); }
                    catch (Exception)
                    { }
                    break;
                case Manager.PaintType.FullFill:                   
                    Color oldcolor = Manager.Bitmap.GetPixel(x1, y1);                  
                    Algorithms.FullFill(x1, y1, oldcolor, Color.Red, Manager.Bitmap);                 
                    break;
                case Manager.PaintType.StringFill:                   
                    Color oldcolor1 = Manager.Bitmap.GetPixel(x1, y1);
                    Algorithms.StringFill(x1, y1, oldcolor1, Color.Blue, Manager.Bitmap);                 
                    break;
                case Manager.PaintType.SazerlendCut:
                    Algorithms.SazerlendCut(x1, y1, x2, y2);
                    break;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Manager.SetStartXY(e.X, e.Y);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int x1 = GetPicX(Manager.GlobalX), y1 = GetPicY(Manager.GlobalY), x2 = GetPicX(e.X), y2 = GetPicY(e.Y);
            Plot(x1, y1, x2, y2, Color.Black);
            pictureBox1.Refresh();
            Manager.DrawAccessible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.DDA;

        private void toolStripMenuItem3_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.BrezenheimLine;

        private void ToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Manager.ClearBitmap();
            pictureBox1.BackgroundImage = Manager.Bitmap;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem6_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.BrezenheimCircle;

        private void обычнаяToolStripMenuItem_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.FullFill;

        private void построчнаяToolStripMenuItem_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.StringFill;

        private void toolStripMenuItem9_Click(object sender, EventArgs e) => Manager.PaintMode = Manager.PaintType.SazerlendCut;
    }
}
