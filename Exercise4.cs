using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check even or odd");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is an even number");
            }
            else
            {
                Console.WriteLine($"{number} is an odd number");
            }
        }
    }
}
