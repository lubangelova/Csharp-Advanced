using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Appearance_count
{
    class Program
    {
        static int AppearanceCount(int[]numbers,int x)
        {
            int count = 0;
            
            for (int i = 1; i < numbers.Length; i++)
            {
                
                if(x==numbers[i])
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
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCount(numbers,x));
        }
    }
}
