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
            Point.x0 = pictureBox1.BackgroundImage.Width / 2;
            Point.y0 = pictureBox1.BackgroundImage.Height / 2;
            Algorithms.BrezenheimCirle(Point.x0, Point.y0, 3, Color.Black, Manager.Bitmap);
            pictureBox1.Refresh();
            
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

        private void тождественноеПреобразованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 1, 0, 0, 1);
            pictureBox1.Refresh();

        }
        private void локальноеМаштабированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text,double.Parse( textBox4.Text), 0, 0, 1);
            pictureBox1.Refresh();

        }

        private void симметрияОтносХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 1, 0, 0, -1);
            pictureBox1.Refresh();

        }

        private void симметрияОтносYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, -1, 0, 0, 1);
            pictureBox1.Refresh();

        }


        private void симметрияОтносительноНКToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, -1, 0, 0, -1);
            pictureBox1.Refresh();

        }


        private void сдвигВдольОХToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 1, double.Parse(textBox4.Text), 0, -1);
            pictureBox1.Refresh();

        }


        private void сдвигВдольOYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 1, 0, double.Parse(textBox5.Text), -1);
            pictureBox1.Refresh();

        }


        private void поворотНаЗаданныйУголToolStripMenuItem_Click(object sender, EventArgs e) 
   {
             Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, Math.Cos(double.Parse(textBox4.Text)*Math.PI/180), Math.Sin(double.Parse(textBox4.Text) * Math.PI / 180), -1*Math.Sin(double.Parse(textBox4.Text) * Math.PI / 180), Math.Cos(double.Parse(textBox4.Text) * Math.PI / 180));
         //   Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 0, 1, -1, 0);

            pictureBox1.Refresh();

        }

    private void симметрияОтносYxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 0, 1, 1, 0);
            pictureBox1.Refresh();

        }

        private void симметрияОтносYxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Affine.AffineWorks(textBox1.Text, textBox2.Text, textBox3.Text, 0,-1, -1, 0);
            pictureBox1.Refresh();

        }

        private void переносНаЗаданныйВекторToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.Proec;


        private void общееМаштабированиеToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.Scale;

        private void треугольникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drawer.DrawAffineTriangle(Manager.LabelPoint(textBox1.Text), Manager.LabelPoint(textBox2.Text), Manager.LabelPoint(textBox3.Text), Manager.Bitmap);
            pictureBox1.Refresh();
        }

private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void системаКоординатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Algorithms.BrezenheimLine(0,190,680,190, Color.Black, Manager.Bitmap);
            Algorithms.BrezenheimLine(340,0,340,380, Color.Black, Manager.Bitmap);
            pictureBox1.Refresh();
        }
    }
}
