using System;
using System.Collections.Generic;
using System.Text;

namespace C_Assignment1
{
    internal class Exercise3
    {
        static int sumOfNumbers(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(String[] args )
        {
            Console.Write("Enter the five numbers to find sum and average of the numbers");
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int length = arr.Length;
            int sum = sumOfNumbers((int[])arr);
            double  average = (sumOfNumbers((int[])arr) / length);
            Console.WriteLine($"sum of 5 numbers is : {sum}");
            Console.WriteLine($"average of 5 numbers is : {average}");
        }
    }
}
