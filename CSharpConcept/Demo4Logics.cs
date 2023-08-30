using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Unisys.MathConcept;

namespace CSharpConcept
{

    public class Demo4Logics
    {
        

        //public static double Areaofcircle(int r)
        //{
        //    double area = 3.14 * r * r;
        //    return area;
        //}

        //public static double AreaofRectangle (double length, double width)
        //{
        //    return length * width;
        //}
            public static void Main(string[] args)
        {
            int radius = 10;
            double res = Area.Areaofcircle(10);
            //double res= Demo4Logics.Areaofcircle(radius);

            //double result = 3.14 * radius * radius;
            Console.WriteLine(res);
            //res = Demo4Logics.Areaofcircle(20);
            res = Area.Areaofcircle(20);
            Console.WriteLine(res);

            //double rect = Demo4Logics.AreaofRectangle(10, 20.5);
            double rect = Area.AreaofRectangle(10, 20.5);
            Console.WriteLine(rect);

            double sq = Area.AreaOfSquare(1.2);
            Console.WriteLine(sq);

            Area obj = new Area();
            double tri = obj.AreaOfTriangle(1.2,2.3);
            Console.WriteLine(tri);

            Console.WriteLine(obj.GetAuthorName());

            obj.Quit();

            //Console.WriteLine(25 / 2);
        }
            
     
    }
}
