using System;

namespace _07.LargestAreaInMatrix
{
    class Program
    {
        static short[,] matrix;
        static bool[,] visitedElements;
        static int counter;
        static short h;  
        static short w;  

        static void Main(string[] args)
        { 
            string[] input = Console.ReadLine().Split(' ');
            h = short.Parse(input[0]);  
            w = short.Parse(input[1]);  

            matrix = new short[h, w]; 
            for (int row = 0; row < h; row++)
            {
                string[] tempStr = Console.ReadLine().Split(' ');
                for (int col = 0; col < w; col++)
                {
                    matrix[row, col] = short.Parse(tempStr[col]);
                }
            }

            visitedElements = new bool[h, w]; 
            for (int row = 0; row < h; row++) 
            {
                for (int col = 0; col < w; col++)
                {
                    visitedElements[row, col] = false;
                }
            }

      
            MatrixCalculation();
            Console.WriteLine(counter);
        }

        static void MatrixCalculation()
        {
            int currentCounter = 0;
            short element = 0;
            for (int row = 0; row < h; row++)
            {
                for (int col = 0; col < w; col++)
                {
                    element = matrix[row, col];
                    DFS(element, row, col, ref currentCounter);
                    counter = MaxCounter(ref currentCounter);
                }
            }
        }

        static void DFS(short element, int row, int col, ref int currentCounter)
        {
            if (row < 0 || col < 0 || row >= h || col >= w || visitedElements[row, col] == true)
            {
                return;
            }
            if (matrix[row, col] == element)
            {
                currentCounter++;
                visitedElements[row, col] = true;
       
                DFS(element, (row + 1), col, ref currentCounter);  
                DFS(element, row, (col + 1), ref currentCounter);  
                DFS(element, row, (col - 1), ref currentCounter); 
                DFS(element, (row - 1), col, ref currentCounter);  
            }
        }

        static int MaxCounter(ref int currentCounter)
        {
            if (currentCounter > counter)
            {
                counter = currentCounter;
            }
            currentCounter = 0;
            return counter;
        }
    }
}
