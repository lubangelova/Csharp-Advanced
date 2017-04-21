using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ProtocolInd = input.IndexOf(":");
            int serverInd = input.IndexOf("//");
            int resourceInd = input.IndexOf("/",serverInd+2);
            string protocol = input.Substring(0,ProtocolInd);
            string server = input.Substring(serverInd+2,resourceInd-serverInd-2);
            string resource = input.Substring(resourceInd);

            Console.WriteLine("[protocol] = {0}",protocol);
            Console.WriteLine("[server] = {0}",server);
            Console.WriteLine("[resource] = {0}",resource);
        }
    }
}
