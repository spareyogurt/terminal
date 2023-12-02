using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Terminal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Terminal";
            string ver = "1.0";
            string dir = Directory.GetCurrentDirectory();
            string pcName = Dns.GetHostName();
            string username = Environment.UserName;
            string input;
            string output;
            string temp;
            Console.WriteLine("Terminal v" + ver);
            while (true)
            {
                temp = null;
                Console.WriteLine();
                Console.Write(username + "@" + pcName + " | " + dir + "\n   > ");
                input = Console.ReadLine();
                output = input.ToLower();
                Console.Title = output + " - Terminal";
                if (output == "help")
                {
                    Console.WriteLine("This command isn't finished yet. Sorry!\n:(");
                }
                else if (output == "write")
                {
                    temp = Console.ReadLine();
                    Console.WriteLine("\n" + temp);
                }
                else if (output == "clear")
                {
                    Console.Clear();
                }
                else if (output == "directory change")
                {
                    temp = Console.ReadLine();
                    if (Directory.Exists(temp))
                    {
                        dir = temp;
                    }
                    else
                    {
                        Console.WriteLine("\nThis directory is invalid.");
                    }
                }
                else
                {
                    Console.WriteLine("\nThis command is invalid.");
                    Console.Title = "Terminal";
                }
            }
        }
    }
}
