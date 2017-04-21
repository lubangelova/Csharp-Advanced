using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {

                if (input[i]=='(')
                {
                    counter++;
                }
                if (input[i] == ')')
                {
                    counter--;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
