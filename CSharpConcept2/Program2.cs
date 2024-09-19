using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThomsonReuters.Formulae;

namespace CSharpConcept2
{
    public class Program2
    { 
        /*public static double AreaOfCirle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }


        public static double PAreaOfRectangle(double length, double width)
        {
            return length * width;
        }*/

        //AreaOfTriangle
        public static double AreaOfTriangle(double height, double baselength)
        {
            return height * baselength / 2;
        }

        static void Main(string[] args)
        {
            


            //Area of triangle prog
            double baseblength = 5;
            double height = 10;
            double area = Program2.AreaOfTriangle(baseblength, height);
            Console.WriteLine(area);

            //load all non static fields in memory
            Area obj = new Area();

            string name = Area.AuthorName();
            Console.WriteLine(name);


        }
    }
}