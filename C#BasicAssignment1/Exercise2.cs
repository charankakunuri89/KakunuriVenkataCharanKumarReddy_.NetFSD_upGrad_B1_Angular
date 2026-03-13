using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise2
    {
        static int kilometers_to_meters(int a)
        {
            return (int)(a * 1000);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number convert to meters from kilometers: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int result = kilometers_to_meters(input);
            Console.WriteLine($"{input} kilometers is equals to {result} meters");
        }
    }
}
