using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Square_root
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;
            double result;
            try
            {
                n = double.Parse(Console.ReadLine());
                if (n<0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    result = Math.Sqrt(n);
                    Console.WriteLine("{0:0.000}", result);
                }
                
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number"); ;
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
       
        }
    }
}
