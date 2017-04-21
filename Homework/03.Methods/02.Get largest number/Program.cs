using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Get_largest_number
{
    class Program
    {
        static int GetMax(int a,int b)
        {
            int max = 0;
            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToArray();
            int max = 0;
            int a = input[0];
            int b = input[1];
            int c = input[2];
            max = GetMax(a, b);
            max = GetMax(max, c);
            Console.WriteLine(max);
        }
    }
}
