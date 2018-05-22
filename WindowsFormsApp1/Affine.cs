using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    public class Affine
    {
       static public Point affine (Point point, double a, double b,double c,double d)
       {
            return (new Point(a * point.X + c * point.Y, b * point.X + d * point.Y));
        }
        public static void AffineWorks(string t1,string t2,string t3,double a,double b,double c,double d)
        {


            Point AffinePoint1 = Manager.LabelPoint(t1);
            AffinePoint1.GetAffinePoint();
            Point AffinePoint2 = Manager.LabelPoint(t2);
            AffinePoint2.GetAffinePoint();
            Point AffinePoint3 = Manager.LabelPoint(t3);
            AffinePoint3.GetAffinePoint();
            AffinePoint1 = affine(AffinePoint1, a, b, c, d);
            AffinePoint2 = affine(AffinePoint2, a, b, c, d);
            AffinePoint2 = affine(AffinePoint2, a, b, c, d);

            AffinePoint1.AffineToCanvasPoint();
            AffinePoint2.AffineToCanvasPoint();
            AffinePoint2.AffineToCanvasPoint();
            Drawer.DrawAffineTriangle(AffinePoint1,AffinePoint2,AffinePoint3, Manager.Bitmap);

        }
    }
}
