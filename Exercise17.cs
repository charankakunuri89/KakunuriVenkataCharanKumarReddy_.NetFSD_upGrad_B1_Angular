using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word to reverse that word");
            string input = Console.ReadLine();
            string rev = "";
            for (int i = 0; i < input.Length; i++)
            {
                rev = input[i] + rev;
            }
            Console.WriteLine(rev);
        }
    }
}
