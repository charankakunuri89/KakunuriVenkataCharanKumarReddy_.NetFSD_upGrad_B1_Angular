using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Excercise4
    {
        static String evenOrOdd(int input)
        {
            return (input % 2 == 0) ? "Even" : "Odd";
        }
        static void Main(string[] args) {
            Console.WriteLine("Enter a number to check given number is an even or odd");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(evenOrOdd(input));
        }
    }
}
