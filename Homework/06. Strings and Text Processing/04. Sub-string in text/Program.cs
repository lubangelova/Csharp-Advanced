﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = Console.ReadLine().ToLower();
            string text= Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(pattern);
            while(index>0)
            {
                index = text.IndexOf(pattern,index+1);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
