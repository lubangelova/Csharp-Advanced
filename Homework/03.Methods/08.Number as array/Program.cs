using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_as_array
{
    class Program
    {

        static int[] ArrayOfDigit(int[] array1,int[] array2)
        {
          
            int sum = 0;
            int firstNum = 0;
            int secondNum = 0;
            int increaseWithOne = 0;
            
            int[] arrayOfDigit=new int[Math.Max(array1.Length,array2.Length)];
            for (int i = 0; i < arrayOfDigit.Length; i++)
            {
                if (i < array1.Length)
                {
                    firstNum = array1[i];
                }
                else
                {
                    firstNum = 0;
                }
                if(i < array2.Length)
                {
                    secondNum = array2[i];
                }
                else
                {
                    secondNum = 0;
                }
                sum = (firstNum + secondNum+increaseWithOne)%10;
                arrayOfDigit[i] += sum;

                if (firstNum + secondNum + increaseWithOne > 9)
                {
                    increaseWithOne = 1;
                }
                else
                {
                    increaseWithOne = 0;
                }
            }
            return arrayOfDigit;
           
        }

        static void Main(string[] args)
        {

            int[] nm = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];
            int[] array1 = new int[n];
            int[] array2 = new int[m];
            array1=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            array2= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int [] arrayOfDigit=ArrayOfDigit(array1, array2);
            foreach (var item in arrayOfDigit)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

        }
    }
}
