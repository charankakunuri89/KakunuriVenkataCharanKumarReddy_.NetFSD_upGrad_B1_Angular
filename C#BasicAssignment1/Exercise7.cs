using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance and speed to calculate the time taken");
            Console.WriteLine("Enter the distance in kms only");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the speed in kms per hr");
            double speed = Convert.ToDouble(Console.ReadLine());
            double time = distance / speed;
            Console.WriteLine($"{ time} hours of time is taken to travel" );
        }
    }
}
