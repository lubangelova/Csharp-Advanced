using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1__Messages
{
    class Program
    {
        static string NumberToGeorgeTheGreat(int number)
        {
            string str = number.ToString();
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case '0': str = str.Replace("0", "cad"); break;
                    case '1': str = str.Replace("1", "xoz"); break;
                    case '2': str = str.Replace("2", "nop"); break;
                    case '3': str = str.Replace("3", "cyk"); break;
                    case '4': str = str.Replace("4", "min"); break;
                    case '5': str = str.Replace("5", "mar"); break;
                    case '6': str = str.Replace("6", "kon"); break;
                    case '7': str = str.Replace("7", "iva"); break;
                    case '8': str = str.Replace("8", "ogi"); break;
                    case '9': str = str.Replace("9", "yan"); break;
                }
            }
            return str;
        }

        static int GeorgeTheGreatToNumber(string str)
        {
            List<string> words = new List<string>();
            string result = string.Empty;
            int resultToNumber = 0;
            for (int i = 0; i < str.Length; i+=3)
            {
                words.Add(str.Substring(i,3));
            }
            for (int i = 0; i < words.Count; i++)
            {
                switch(words[i])
                {
                    case "cad": words[i] = "0";break;
                    case "xoz": words[i] = "1"; break;
                    case "nop": words[i] = "2"; break;
                    case "cyk": words[i] = "3"; break;
                    case "min": words[i] = "4"; break;
                    case "mar": words[i] = "5"; break;
                    case "kon": words[i] = "6"; break;
                    case "iva": words[i] = "7"; break;
                    case "ogi": words[i] = "8"; break;
                    case "yan": words[i] = "9"; break;
                    default: Console.WriteLine("Wrong input!");break;

                }
                result += words[i];
            }
            resultToNumber = int.Parse(result);
            return resultToNumber;
        }
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string sign = Console.ReadLine();
            string second = Console.ReadLine();
            int result = 0;
            string resultToString = string.Empty;

            int firstNumber = GeorgeTheGreatToNumber(first);
            int secondNumber = GeorgeTheGreatToNumber(second);

            if (sign == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (sign == "-")
            {
                result = firstNumber - secondNumber;
            }
            else
            {
                Console.WriteLine("Wrong sign!");
            }

            resultToString = NumberToGeorgeTheGreat(result);
            Console.WriteLine(resultToString);
        }
    }
}
