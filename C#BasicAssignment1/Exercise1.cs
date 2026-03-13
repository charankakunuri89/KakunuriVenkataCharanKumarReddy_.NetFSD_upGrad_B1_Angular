using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise1
    {
        static int Divide(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());

            if (second_number == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            else
            {
                int result = Divide(first_number, second_number);
                Console.WriteLine("Quotient = " + result);
            }
        }
    }
}
