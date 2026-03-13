using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise9
    {
        static int factorial(int number)
        {
            int f = 1;
            while (number > 0)
            {
                f = f * number;
                number--;
            }
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to find factorial of that number: ");
            int number = Convert.ToInt32 (Console.ReadLine());
            int fact = factorial(number);
            Console.WriteLine($"Factorial of {number} is {fact}");
        }
    }
}
