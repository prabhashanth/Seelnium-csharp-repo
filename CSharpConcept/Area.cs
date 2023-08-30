// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.MathConcept
{
    public class Area
    {
        public static double Areaofcircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaofRectangle(double length, double width)
        {
            return length * width;
        }

        //create a method for AreaOfSquare
      

        public static double AreaOfSquare(double a)
        {
            //double square = a * a;
            //return square;
            return a * a;
        }
        //create a method for AreaofTriangle
        public  double AreaOfTriangle(double length, double height)
        {
            //double triangle = length * height / 2;
            //return triangle;
            return length * height / 2;
        }

        public String GetAuthorName()
        {
            return "Prabhavathy";
         }

        public void Quit()
        {

        }
    }
}
