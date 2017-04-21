using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Enter_numbers
{
    class Program
    {
        static bool IsSorted(int [] numbers)
        {
           
            for (int i = 1; i < 10; i++)
            {
                if(numbers[i-1].CompareTo(numbers[i])!=-1)
                {
                    return false;
                }
                
            }
            return true;
        }
        static void ReadNumber(int start, int end,int [] numbers)
        {
            try
            {
                if (!IsSorted(numbers) || numbers.Any(x=> x<start) || numbers.Any(x=> x>end))
                {
                    throw new ArgumentException();
                }
                else
                {
                    Console.WriteLine("1 < " + string.Join(" < ", numbers) + " < 100");
                }
               
            }
            catch (Exception)
            {

                Console.WriteLine("Exception");
            }
            

        }
        static void Main(string[] args)
        {

            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

            }
            ReadNumber(0, 100,numbers);
        }
    }
}
