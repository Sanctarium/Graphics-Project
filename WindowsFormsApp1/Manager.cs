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
            DDA, BrezenheimLine, BrezenheimCircle,FullFill
        }
        
        private Manager()
        {

        }
    }
}
