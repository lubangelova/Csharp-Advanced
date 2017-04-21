using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Decimal_to_hexadecimal
{
    class Program
    {
        static string DecimalToHex(ulong n)
        {
            string hexNumbers = "0123456789ABCDEF";
            string hexValue = "";
            int hex;
            while (n > 0)
            {

                hex =Convert.ToInt32(n % 16);
                hexValue = hexNumbers[hex] + hexValue; 
                n = n / 16;
            }

            return hexValue;
        }
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(n));
        }
    }
}
