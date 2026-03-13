using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise13
    {
        static int largestOfThreeNumbers(int first, int second, int third)
        {
            if (first > second)
            {
                if (first > third)
                {
                    return first;
                }
                else
                {
                    return third;
                }
            }
            else
            {
                if (second > third)
                {
                    return second;
                }
                else
                {
                    return third;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Largest of the given 3 numbers");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            int result = largestOfThreeNumbers(first, second, third);
            Console.WriteLine($"Largest of {first}, {second}, {third} is : {result}");
        }
    }
}
