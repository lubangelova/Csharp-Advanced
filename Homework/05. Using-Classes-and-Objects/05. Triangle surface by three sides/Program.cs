using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Triangle_surface_by_three_sides
{
    class Program
    {
        static double TriangleSurface(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double Surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return Surface;
        }
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F2}",TriangleSurface(a, b, c));
        }
    }
}
