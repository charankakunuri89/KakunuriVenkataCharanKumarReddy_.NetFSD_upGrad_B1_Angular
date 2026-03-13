using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise2
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string input = args[0];
                Console.WriteLine($"Hi! {input} ");
                Console.WriteLine($"Welcome to the world of C#");
            }
            else
            {
                Console.WriteLine("Please provide your name as a command line argument.");
            }
        }
    }
}
