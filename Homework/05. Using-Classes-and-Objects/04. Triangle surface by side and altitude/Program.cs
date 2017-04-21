using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_surface_by_side_and_altitude
{
    class Program
    {
        static void Main(string[] args)
        {

            double side = double.Parse(Console.ReadLine());
            double atitude = double.Parse(Console.ReadLine());
            double surface = side * atitude / 2;

            Console.WriteLine("{0:0.00}",surface);
        }
    }
}
