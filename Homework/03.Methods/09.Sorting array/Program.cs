using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sorting_array
{
    class Program
    {
        static int MaxElementInArray(int[] numbers)
        {
            int maxElement = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]>maxElement)
                {
                    maxElement = numbers[i];
                }
            }
            return maxElement;
        }

        static int[] SortingArray(int[] numbers)
        {
            int[] sortedArray = new int[numbers.Length];
            int index = sortedArray.Length - 1;
            for (int i = 0; i <numbers.Length; i++)
            {
               int maxElement = MaxElementInArray(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[j]==maxElement)
                    {
                        sortedArray[index] = numbers[j];
                        numbers[j] = int.MinValue;
                        index--;
                        break;

                    }
                }
                
            }
            return sortedArray;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int []sortedArray = SortingArray(numbers);

            foreach (var item in sortedArray)
            {
                Console.Write(item + " ");
            }

        }
    }
}
