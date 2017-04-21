using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Binary_to_decimal
{
    class Program
    {
        static BigInteger BinaryToDecimal(string binary)
        {
            BigInteger dec = 0;
            BigInteger power = 1;
            for (int i = binary.Length-1; i>=0; i--)
            {
  
                dec += (binary[i] - '0')*power;
                power *= 2;
            }
            return dec;
        }
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(binary));
        }
    }
}
