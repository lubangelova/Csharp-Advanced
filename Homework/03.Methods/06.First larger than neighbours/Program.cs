using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.First_larger_than_neighbours
{
    class Program


    {
        static int FirstLargerThanNeighbours(int[]numbers)
        {
            int index = 0;
            for (int i = 1; i < numbers.Length-1; i++)
            {
                if(numbers[i-1]<numbers[i]&& numbers[i]>numbers[i+1])
                {
                    index = i;
                    break;

                }
            }

            return index;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(FirstLargerThanNeighbours(numbers));
        }
    }
}
