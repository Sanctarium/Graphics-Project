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
            return (new Point(a * point.x + c * point.y, b * point.x + d * point.y));
        }
    }
}
