using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            StringBuilder reversed = new StringBuilder();
            for (int i = input.Length-1; i >=0; i--)
            {
                reversed.Append(input[i]);
            }

            Console.WriteLine(reversed);
        }
    }
}
