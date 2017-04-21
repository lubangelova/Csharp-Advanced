using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.PeshoCode
{
    class Program
    {
        static void Main(string[] args)
        {

            string searchedWord = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            
            string result = string.Empty;
         
            string text = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                text += input;
            }
 
                int wordIndex = text.IndexOf(searchedWord);
                int commaIndex = text.IndexOf('.');
                int commaLastIndex = text.LastIndexOf('.');
                int questionIndex = text.IndexOf('?');
                 int questionLastIndex = text.LastIndexOf('?');

                if (wordIndex!=-1 && wordIndex < questionIndex && questionIndex<commaIndex)
                {
                    result = text.Substring(wordIndex + searchedWord.Length, questionIndex - (wordIndex + searchedWord.Length));

                }
                else if (wordIndex != -1 && wordIndex > questionIndex && wordIndex<questionLastIndex)
                {
                   result = text.Substring(wordIndex + searchedWord.Length, questionLastIndex - (wordIndex + searchedWord.Length));
                }
                else if (wordIndex != -1 && wordIndex > commaIndex && wordIndex < commaLastIndex)
                {
                    result = text.Substring(commaIndex + 1, wordIndex - (commaIndex + 1));
                }
                else if (wordIndex != -1 && wordIndex > questionIndex && wordIndex < commaLastIndex)
                {
                    result = text.Substring(questionIndex + 1, wordIndex - (questionIndex + 1));
                } 
                else if (wordIndex!=-1 && wordIndex<commaIndex && commaIndex<questionIndex)
                {
                    result = text.Substring(0, wordIndex - 1);
                }


            result = result.ToUpper();
            long finalResult = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != ' ')
                {
                    finalResult += result[i];
                }
            }
           //Console.WriteLine(result);
            Console.WriteLine(finalResult);
        }
    }
}

/*
 will
4
Software developers like to solve
problems? If they are no problems
handily available, they will create
their own problems.

will
4
Software developers like to solve
problems? If they are no problems
handily available, they will create
their own problems?

will
4
Software developers like to solve
problems. If they are no problems
handily available, they will create
their own problems?


will
4
Software developers will to solve
problems. If they are no problems
handily available, they no create
their own problems?


    */
