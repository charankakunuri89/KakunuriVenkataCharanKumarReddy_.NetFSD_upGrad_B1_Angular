using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check whether the given word is palindrome or not");
            string input = Console.ReadLine();
            string rev = "";
            for (int i = 0; i < input.Length; i++)
            {
                rev = input[i] + rev;
            }
            if (input == rev)
            {
                Console.WriteLine("Given word is a Palindrome");

            }
            else
            {
                Console.WriteLine("Not a Palindrome");

            }
        }

    }
}
