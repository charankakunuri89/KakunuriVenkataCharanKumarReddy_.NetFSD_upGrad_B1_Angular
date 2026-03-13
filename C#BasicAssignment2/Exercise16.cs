using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word to find length of it");
            string input = Console.ReadLine();
            int length = input.Length;
            Console.WriteLine($"Length of the given {input } word is : {length}"); 

        }
    }
}
