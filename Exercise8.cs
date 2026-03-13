using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print square series upto the number");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= number; i++)
            {
                Console.Write(i * i );
                if (i < number)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
