using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Binary_to_hexadecimal
{
    class Program
    {
        static ulong BinaryToDecimal(string binary)
        {
            ulong dec = 0;
            ulong power = 1;
            for (int i = binary.Length - 1; i >= 0; i--)
            {

                dec += (ulong)(binary[i] - '0') * power;
                power *= 2;
            }
            return dec;
        }

        static string DecimalToHex(ulong n)
        {
            string hexNumbers = "0123456789ABCDEF";
            string hexValue = "";
            int hex;
            while (n > 0)
            {

                hex = Convert.ToInt32(n % 16);
                hexValue = hexNumbers[hex] + hexValue;
                n = n / 16;
            }

            return hexValue;
        }

        static string BinaryToHex(string binary)
        {

            ulong dec = BinaryToDecimal(binary);
            string hex = DecimalToHex(dec);
            return hex;
        }
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            Console.WriteLine(BinaryToHex(binary));
        }
    }
}
