using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sequence_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int n = nm[0];
            int m = nm[1];
            int[,] matrix = new int[n, m];
            int counter = 1;
            int rowsmaxCounter = 0;
            int colsmaxCounter = 0;
            int maxCounter = 0;
            for (int rows = 0; rows <n; rows++)

            {
                int[] submatrix = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
                for (int cols = 0; cols <m; cols++)
                {
                    matrix[rows, cols] = submatrix[cols];

                }
            }
            for (int rows = 0; rows < n; rows++)
            {
                counter = 1;
                for (int cols = 0; cols < m-1; cols++)
                {
                    if(matrix[rows,cols]==matrix[rows,cols+1])
                    {
                        counter++;
                        if (counter >= rowsmaxCounter)
                        {
                            rowsmaxCounter = counter;
                        }
                    }  
                }
            }
            
                for (int cols = 0; cols < m; cols++)
                {
                counter = 1;
               
                    for (int rows = 0; rows < n-1; rows++)
                    {
                    if (matrix[rows, cols] == matrix[rows+1, cols])
                    {
                        counter++;
                        if (counter >= colsmaxCounter)
                        {
                            colsmaxCounter = counter;
                        }
                    }
                }
            }
            maxCounter = Math.Max(rowsmaxCounter, colsmaxCounter);
            Console.WriteLine(maxCounter);
        }
    }
}
