using System.Drawing;

namespace WindowsFormsApp1
{
    class Manager
    {
        static private Bitmap _bitmap;
        static private Bitmap _cleanBitmap;
        static public Bitmap Bitmap { get => _bitmap; set => _bitmap = value; }
        static public Bitmap CleanBitmap { get => _cleanBitmap; set => _cleanBitmap = value; }
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
