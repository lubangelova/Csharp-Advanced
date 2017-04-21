using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fill_the_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int counter = 1;
            if (c == 'a')
            {
                for (int cols = 0; cols < n; cols++)
                {
                    for (int rows = 0; rows < n; rows++)
                    {
                        matrix[rows, cols] = counter;
                        counter++;
                    }
                }
            }
            else if (c == 'b')
            {
                for (int cols = 0; cols < n; cols++)
                {
                    for (int rows = 0; rows < n; rows++)
                    {
                        if (cols % 2 == 0)
                        {
                            matrix[rows, cols] = counter;
                            counter++;
                        }
                        else
                        {
                            matrix[rows, cols] = counter + n - rows * 2 - 1;
                            counter++;
                        }
                    }
                }
            }
            else if (c == 'c')
            {
                for (int reversedRow = n - 1; reversedRow >= 0; reversedRow--)
                {
                    for (int col = 0; col < (n - reversedRow); col++, counter++)
                    {
                        if (col == 0)
                        {
                            matrix[reversedRow, col] = counter;
                        }
                        else
                        {
                            matrix[(reversedRow + col), col] = counter;
                        }
                    }
                }
                for (int col = 1; col <= n - 1; col++)
                {
                    for (int row = 0; row < (n - col); row++, counter++)
                    {
                        if (row == 0)
                        {
                            matrix[row, col] = counter;
                        }
                        else
                        {
                            matrix[row, (col + row)] = counter;
                        }
                    }
                }
            }
            else if(c=='d')
            {
                for (int depth = 0; depth <= (n / 2); depth++)
                {
                    for (int down = depth; down <= n - depth - 1; down++, counter++)
                    {
                        matrix[down, depth] = counter;
                    }
                    for (int right = depth + 1; right <= n - depth - 1; right++, counter++)
                    {
                        matrix[(n - depth - 1), right] = counter;
                    }
                    for (int up = n - depth - 2; up > depth; up--, counter++)
                    {
                        matrix[up, (n - depth - 1)] = counter;
                    }
                    for (int left = n - depth - 1; left > depth; left--, counter++)
                    {
                        if (matrix[depth, left] == 0)
                        {
                            matrix[depth, left] = counter;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (cols == n - 1)
                    {
                        Console.Write(matrix[rows, cols]);
                    }
                    else
                    {
                        Console.Write(matrix[rows, cols] + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
