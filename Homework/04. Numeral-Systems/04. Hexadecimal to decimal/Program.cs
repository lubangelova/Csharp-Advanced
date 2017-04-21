using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hexadecimal_to_decimal
{
    class Program
    {
        static BigInteger HexToDecimal(string hex)
        {
            BigInteger dec = 0;
            BigInteger power = 1;
            for (int i = hex.Length - 1; i >= 0; i--)
            {
                switch(hex[i])
                {
                    case 'A':dec += 10 * power;break;
                    case 'B': dec += 11 * power; break;
                    case 'C': dec += 12 * power; break;
                    case 'D': dec += 13 * power; break;
                    case 'E': dec += 14 * power; break;
                    case 'F': dec += 15 * power; break;
                    default: dec += (hex[i] - '0') * power;break;
                }
               
                power *= 16;
            }
            return dec;
        }
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            Console.WriteLine(HexToDecimal(hex));
        }
    }
}
