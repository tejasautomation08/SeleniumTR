using CSharpConcept2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.Formulae
{
    public class Area
    {
        public static double AreaOfCirle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            return length * width;
        }
        

        //AreaOfTriangle
        public static double AreaOfTriangle(double height, double baselength)
        {
            return height * baselength / 2;
        }

        public static string AuthorName()
        {
            return "Tejas Kadam";
                 
        }
        
    }
}
