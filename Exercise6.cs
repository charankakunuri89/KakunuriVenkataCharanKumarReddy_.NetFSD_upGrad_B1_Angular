using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature to convert Celsis from Fahrenheit");
            double temperature = Convert.ToDouble(Console.ReadLine());
            double celsius = ((temperature - 32) * 5) / 9;
            Console.WriteLine($"Fahrenheit { temperature} in celsius is : {celsius}" );
        }
    }
}
