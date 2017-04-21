using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Reverse_number
{
    class Program
    {

        static string ReverseNumber(double number)
        {
            string reversedNumber="";
            string numberToString = number.ToString();
            for (int i = numberToString.Length-1; i >=0; i--)
            {
                string digit = numberToString[i].ToString();
                reversedNumber+= digit;
            }

            return reversedNumber;
        }
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            
            Console.WriteLine(ReverseNumber(n));
        }
    }
}
