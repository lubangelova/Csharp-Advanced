﻿using System;


namespace _08.Binary_short
{
    class Program
    {        
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2).PadLeft(16, '0');

            Console.WriteLine(binary);
        }
    }
}
