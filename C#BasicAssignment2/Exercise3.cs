using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise3
    {
        static void Main(string[] args)
        {
           
            int first = Convert.ToInt32(args[0]);
            int second = Convert.ToInt32(args[1]);
            Console.WriteLine("Numbers between " + first + " and " + second + " are : ");
            for (int i = first + 1; i < second; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
