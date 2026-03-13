using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise5
    {
        static int highestBetweenThem(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

         static void Main(string[] args)
         {
               Console.WriteLine("Enter 2 numbers to find highest between them");
               int first = Convert.ToInt32(Console.ReadLine());
               int second = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Highest between two numbers is :" +highestBetweenThem(first, second));
          }
    }
}