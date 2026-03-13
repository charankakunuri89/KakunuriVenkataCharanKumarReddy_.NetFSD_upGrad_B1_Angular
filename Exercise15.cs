using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment2
{
    internal class Exercise15
    {
        static int TotalOfNumbersInArray(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers to find average , total, Minimum marks, Maximum marks, arrange them in both ascending and descending order also");
            int[] marks = new int[10];
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Total of ten numbers is : " + TotalOfNumbersInArray(marks));
            Console.WriteLine("Average of ten numbers is : " + TotalOfNumbersInArray(marks) / marks.Length);

            int min = marks[0];
            int max = marks[0];

            foreach (int number in marks)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine("Minimun number in the array: " + min);
            Console.WriteLine("Maximum number in the array: " + max);
            Console.WriteLine("Display marks in ascending order is: ");
            Array.Sort(marks);
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Display marks in Descending order is: ");
            for (int i = marks.Length - 1; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }

        }
    }
}
