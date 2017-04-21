using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximal_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[nm[0], nm[1]];
            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int rows = 0; rows < nm[0]; rows++)

            {
                int [] submatrix= Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
                for (int cols = 0; cols < nm[1]; cols++)
                {
                    matrix[rows, cols] = submatrix[cols];
                        
                }
            }
            for (int rows = 0; rows < nm[0]-2; rows++)
            {
                for (int cols = 0; cols < nm[1]-2; cols++)
                {
                    currentSum = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2]
                        + matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2]
                        + matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
