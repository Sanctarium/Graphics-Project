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
            }
        }
        private Point AffineWork(Point point, double a, double b, double c, double d)
        {
            Point newPoint;
            switch (Manager.AffineMode)
            {
                case Manager.AffineType.BissTurn:
                    return newPoint = Affine.affine(point, 0, 1, 1, 0);

                case Manager.AffineType.Idential:
                    return newPoint = Affine.affine(point, 1, 0, 1, 0);

                case Manager.AffineType.LocalM:
                    return newPoint = Affine.affine(point, a, 0, 0, d);

                case Manager.AffineType.MinusBissTurn:
                    return newPoint = Affine.affine(point, 0, -1, -1, 0);

                case Manager.AffineType.OOSym:
                    return newPoint = Affine.affine(point, -1, 0, 0, -1);

                case Manager.AffineType.OXSymm:
                    return newPoint = Affine.affine(point, 1, 0, 0, -1);

                case Manager.AffineType.OYSymm:
                    return newPoint = Affine.affine(point, -1, 0, 0, -1);

                case Manager.AffineType.ParPer:
                    return newPoint = Affine.affine(point, 0, 1, 1, 0);

                case Manager.AffineType.Proec:
                    return newPoint = Affine.affine(point, 0, 1, 1, 0);

                case Manager.AffineType.Scale:
                    return newPoint = Affine.affine(point, 0, 1, 1, 0);

                case Manager.AffineType.ShiftX:
                    return newPoint = Affine.affine(point, 1, b, 0, 1);

                case Manager.AffineType.ShiftY:
                    return newPoint = Affine.affine(point, 1, 0, c, 1);

                case Manager.AffineType.Turn:
                    return newPoint = Affine.affine(point,Math.Cos(a), Math.Sin(a),Math.Sin(a),Math.Cos(a));
            }
            return point = new Point(-1, -1);
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

        private void тождественноеПреобразованиеToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.Idential;


        private void локальноеМаштабированиеToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.LocalM;


        private void симметрияОтносХToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.OXSymm;


        private void симметрияОтносYToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.OYSymm;


        private void симметрияОтносительноНКToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.OOSym;


        private void сдвигВдольОХToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.ShiftX;


        private void сдвигВдольOYToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.ShiftY;


        private void поворотНаЗаданныйУголToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.Turn;


        private void симметрияОтносYxToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.BissTurn;


        private void симметрияОтносYxToolStripMenuItem1_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.MinusBissTurn;


        private void переносНаЗаданныйВекторToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.Proec;


        private void общееМаштабированиеToolStripMenuItem_Click(object sender, EventArgs e) => Manager.AffineMode = Manager.AffineType.Scale;

    }
}
