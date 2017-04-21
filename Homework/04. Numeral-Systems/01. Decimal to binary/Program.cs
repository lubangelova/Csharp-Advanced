using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Decimal_to_binary
{
    class Program
    {
        static string DecimalToBinary(BigInteger n)
        {
            string binary = "";
            while(n>0)
            {
                binary = (n % 2)+binary;
                n = n / 2;
            }

            return binary;
        }
        static void Main(string[] args)
        {
             BigInteger n = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToBinary(n));
        }
    }
}
