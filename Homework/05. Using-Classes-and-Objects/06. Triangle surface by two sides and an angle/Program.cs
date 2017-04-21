using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triangle_surface_by_two_sides_and_an_angle
{
    class Program
    {
        static double TriangleSurfaceByTwoSidesAnAngle(double a,double b, double angle)
        {
            double surface = (a * b * Math.Sin(angle)) / 2;
            return surface;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine())*Math.PI/180;
            Console.WriteLine("{0:F2}", TriangleSurfaceByTwoSidesAnAngle(a,b,angle));

        }
    }
}
