using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Larger_than_neighbours
{
    class Program
    {
        static int LargerThanNeighbours(int[] numbers)
        {
            int count = 0;
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if (numbers[i-1] < numbers[i]&& numbers[i]>numbers[i+1])
                {
                    count++;
                }
            }

            return count;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(LargerThanNeighbours(numbers));
        }
    }
}
