using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task_3__Bit_Shift_Matrix
{
    class Program
    {

        static void FillMatrix(BigInteger [,] matrix)
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    matrix[r, c] = (BigInteger)Math.Pow(2, (matrix.GetLength(0)-1-r + c));
                }
            }
        }

        static void PrintMatrix(BigInteger[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,4}",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] codes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            BigInteger[,] field = new BigInteger[rows, cols];
            FillMatrix(field); 
            int coeff = Math.Max(rows, cols);
            int[] pos = { rows-1, 0 };
            BigInteger sum = 0;
            sum += field[pos[0], pos[1]];
            field[pos[0], pos[1]] = 0;
            foreach (var code in codes)
            {
                int[] tarPos = { code / coeff, code % coeff };
                int stepRow = Math.Sign(tarPos[0]- pos[0]);
                int stepCol = Math.Sign(tarPos[1]- pos[1]);

                do
                {
                    pos[1] += stepCol;
                    sum += field[pos[0], pos[1]];
                    field[pos[0], pos[1]] = 0;

                } while (pos[1] != tarPos[1] && pos[1] >= 0 && pos[1] < cols);

                   do
                {
                    pos[0] += stepRow;
                    sum += field[pos[0], pos[1]];
                    field[pos[0], pos[1]] = 0;

                } while (pos[0] != tarPos[0] && pos[0] >= 0 && pos[0] < rows) ;

            }
            Console.WriteLine(sum);
           
           
           
        }
    }
}
