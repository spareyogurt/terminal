using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Terminal";
            string ver = "1.0.0";
            string dir = Directory.GetCurrentDirectory();
            string pcName = Dns.GetHostName();
            string username = Environment.UserName;
            string input;
            string output;
            string temp;
            Console.WriteLine("Terminal v" + ver);
            while (true)
            {
                Console.WriteLine();
                Console.Write(username + "@" + pcName + " / " + dir + " > ");
                input = Console.ReadLine();
                output = input.ToLower();
                if (output == "help")
                {
                    Console.WriteLine("This command isn't finished yet. Sorry!\n:(");
                }
                else
                {
                    Console.WriteLine("This command is invalid.");
                }
            }
        }
    }
}
