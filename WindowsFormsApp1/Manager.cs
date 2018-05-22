using System.Drawing;

namespace WindowsFormsApp1
{
    class Manager
    {
        static public Bitmap Bitmap { get; set; }
        static public Bitmap CleanBitmap { get; set; }
        static public void ClearBitmap()
        {
            Bitmap = (Bitmap)CleanBitmap.Clone();
        }

        static public void SetStartXY(int x, int y)
        {
            if (DrawAccessible)
            {
                GlobalX = x;
                GlobalY = y;
                DrawAccessible = false;
            }
        }
        static bool _check;
        static public bool DrawAccessible { get => _check; set => _check = value; }
        static public int GlobalX { get; set; }
        static public int GlobalY { get; set; }

        static public PaintType PaintMode { get; set; }
        public enum PaintType
        {
            DDA, BrezenheimLine, BrezenheimCircle, FullFill, StringFill
        }
        static public AffineType AffineMode { get; set; }
        public enum AffineType
        {
            Idential, LocalM, OXSymm, OYSymm, OOSym, ShiftX, ShiftY, Turn, BissTurn, MinusBissTurn, ParPer, Proec, Scale
        }
        static public int CanvasWidth { get; set; }
        static public int CanvasHeight { get; set; }
        static public void SetCanvasSize(int width, int height)
        {
            CanvasWidth = width;
            CanvasHeight = height;
        }
        public static Point LabelPoint(string s)
        {
            string[] buf = s.Split(' ');
            Point p = new Point(int.Parse(buf[0]), int.Parse(buf[1]));
            return p;



        }
        private Manager()
        {

        }
    }
}
