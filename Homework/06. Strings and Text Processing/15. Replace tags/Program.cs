using System;
using System.Text.RegularExpressions;


namespace _15.Replace_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string replaceTags = Regex.Replace(text, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");
            Console.WriteLine(replaceTags);
        }
    }
}
