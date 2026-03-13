using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to print multiplication table till 20");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }
    }
}
