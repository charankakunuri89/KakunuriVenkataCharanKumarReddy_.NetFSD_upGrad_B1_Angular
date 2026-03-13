using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two words to find same or not");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            //if (first.Equals(second))
            if (first==second)
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("Not same");
            }
        }
    }
}
