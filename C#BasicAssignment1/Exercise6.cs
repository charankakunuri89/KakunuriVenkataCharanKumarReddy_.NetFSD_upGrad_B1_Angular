using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise6
    {
        static int areaOfRectangle(int length, int breadth)
        {
            return length * breadth;
        }

        static int areaOfSquare(int side)
        {
            return side * side; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length and breadth to find area of rectangle");
            Console.WriteLine("Enter length");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int areaofrectangle = areaOfRectangle(length, breadth);
            Console.WriteLine($"Area of Rectangle with {length} and {breadth } is : {areaofrectangle}");
            Console.WriteLine("Enter the side to find area of square");
            int side = Convert.ToInt32(Console.ReadLine());
            int areaofsquare = areaOfSquare(side);
            Console.WriteLine($"Area of the Square with {side} is : {areaofsquare}");
        }
    }
}
