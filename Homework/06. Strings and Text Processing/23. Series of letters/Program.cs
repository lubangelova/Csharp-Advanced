using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char letter = input[0];
            StringBuilder result = new StringBuilder();
            result.Append(letter);
            for (int i = 1; i < input.Length; i++)
            {
                if(letter!=input[i])
                {
                    letter = input[i];
                    result.Append(letter);
                }
            }
            Console.WriteLine(result);
        }
    }
}
