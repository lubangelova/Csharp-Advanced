using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Adding_polynomials
{
    class Program

    {
        static int[] SumPolynomials(int[] first,int[] second)
        {
            int length = first.Length;
            int[] sum = new int[length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = first[i] + second[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sum = SumPolynomials(first, second);
            foreach (var item in sum)
            {
                Console.Write(item+" ");
            }
        }
    }
}
