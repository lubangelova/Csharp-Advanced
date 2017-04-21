using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1.Functional_Numeral_System
{
    class Program

    {
        
        static BigInteger Encode(string text)

        {
            string[] numSys = {"ocaml","haskell","scala","f#", "lisp", "rust", "ml", "clojure", "erlang", "standardml", "racket",
                        "elm", "mercury", "commonlisp", "scheme", "curry"};
            string hex = string.Empty;
            int firstTextIndex = text.Length;
        
            for (int i = numSys.Length-1; i >= 0; i--)
            {
                int count = 0;
                if (text.Contains(numSys[i]))
                {
                    
                
                    int textIndex = text.IndexOf(numSys[i]);
                    textIndex = Math.Min(textIndex, firstTextIndex);
            
                    
                    if (textIndex==0)
                    {
                        hex = i.ToString()+" " + hex;
                    }
                    else
                    {
                       
                        hex += i.ToString()+" ";
                    }
                    count++;
                }
                if (count >2)
                {
                    break;
                }
              
            }
            string[] hexArray = hex.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            BigInteger dec = 0;
            BigInteger power = 1;
            for (int i=hexArray.Length-1; i >= 0; i--)
            {
                string currentNumber = hexArray[i];
                if (currentNumber.Length>1)
                {
                    dec += int.Parse(currentNumber)*power;
                }
           
                
                else if (currentNumber.Length==1)
                {
                    dec += (Convert.ToChar(currentNumber) - '0') * power;
                }
                power *= 16;
            }

            return dec;
        }


        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            BigInteger product = 1;
            for (int i = 0; i < input.Length; i++)
            {
              
                BigInteger decNumber = Encode(input[i]);
                product *= decNumber;
            }
            Console.WriteLine(product);

      




        }
    }
}
