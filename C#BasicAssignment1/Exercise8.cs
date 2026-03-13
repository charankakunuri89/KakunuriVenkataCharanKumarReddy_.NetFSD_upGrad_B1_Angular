using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String: ");
            String input = Console.ReadLine();

            char ch = input[2];

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Third Character is a Vowel");
            }else
            {
                Console.WriteLine("Third Character is a Consonant");
            }
        }

    }
}
