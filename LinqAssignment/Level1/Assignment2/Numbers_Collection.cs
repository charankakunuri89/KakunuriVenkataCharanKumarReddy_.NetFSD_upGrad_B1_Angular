using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment.Level1.Assignment2
{
    internal class Numbers_Collection
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            //1.Get even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            //2.Get numbers greater than 15
            var numbersGreaterThan15 = numbers.Where(n => n > 15).ToList();

            foreach(var n in numbersGreaterThan15)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            //3.find square of each number
            var squareOfEachNumber = numbers.Select(n =>  n * n).ToList();

            foreach(var n in squareOfEachNumber)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();
            //4.Count no.of numbers divisible by 5
            var countOfNumbersDivisibleBy5 = numbers.Where(n => n % 5 == 0).Count();
            Console.WriteLine(countOfNumbersDivisibleBy5);
        }
    }
}
