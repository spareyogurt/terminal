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
                if (output != "clear")
                {
                    Console.WriteLine();
                }
                if (output == "help")
                {
                    Console.WriteLine("write - Prints the input.");
                    Console.WriteLine("clear - Clears all the text onscreen.");
                }
                else if (output == "print")
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
                else if (output == "directory list")
                {
                    Console.WriteLine("Directory of " + dir + "\n");
                    foreach (string folder in Directory.EnumerateFiles(dir, "*.*", SearchOption.TopDirectoryOnly))
                    {
                        Console.WriteLine(folder);
                    }
                }
                else if (output == "directory make")
                {
                    temp = Console.ReadLine();
                    Directory.CreateDirectory(dir + "/" + temp);
                }
                else if (output == "directory delete")
                {
                    temp = Console.ReadLine();
                    Directory.Delete(dir + "/" + temp);
                }
                else
                {
                    Console.WriteLine("This command is invalid.");
                    Console.Title = "Terminal";
                }
            }
        }
    }
}
