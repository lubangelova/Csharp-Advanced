using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Integer_calculations
{
    class Program
    {
        static int Minimum(int[] numbers)
        {
            int minElement = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]<minElement)
                {
                    minElement = numbers[i];
                }
            }
            return minElement;
        }
        static int Maximum(int[] numbers)
        {
            int maxElement = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }
            return maxElement;
        }
        static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static double Average(int[] numbers)
        {
            double average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average = (double)Sum(numbers) /numbers.Length;
            }
            return average;
        }
        static BigInteger Product(int[] numbers)
        {
            BigInteger product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Minimum(numbers));
            Console.WriteLine(Maximum(numbers));
            Console.WriteLine("{0:0.00}",Average(numbers));
            Console.WriteLine(Sum(numbers));
            Console.WriteLine(Product(numbers));
            
        }
    }
}
