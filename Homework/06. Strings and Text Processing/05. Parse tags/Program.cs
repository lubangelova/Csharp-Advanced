using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string result =String.Empty;
            string temp = string.Empty;
            char[] CharArray=input.ToCharArray();
            string startValue = "<upcase>";
            string endValue = "</upcase>";
            int startInd = -1;
            int endInd =-1;
            for (int i = 0; i < input.Length; i++)
            {
                startInd = input.IndexOf(startValue,startInd+1);
                if (startInd!=-1)
                {
                    endInd=input.IndexOf(endValue, endInd + 1);
                    for (int j = startInd + startValue.Length; j < endInd; j++)
                    {
                        temp = input[j].ToString().ToUpper();
                        CharArray[j] = Convert.ToChar(temp);

                    }
                }
                
                else
                 {
                    break;
                }
               
              
            }
            result = new string(CharArray);
            result=result.Replace(startValue, "");
            result=result.Replace(endValue, "");
            Console.WriteLine(result);
        }
    }
}
