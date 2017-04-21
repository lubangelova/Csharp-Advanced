using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Leap_year
{
    class LeapYear
    {
        static void Main(string[] args)
        {

            int year = int.Parse(Console.ReadLine());
            bool output = DateTime.IsLeapYear(year);

            Console.WriteLine(output? "Leap":"Common");
        }
    }
}
