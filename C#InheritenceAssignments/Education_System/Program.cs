using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Education_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[] {
                new SchoolStudent(121, "Charan", 75.65),
                new CollegeStudent(1432, "Ganesh", 65),
                new OnlineStudent(21, "Aditya", 55.45)
            };

            foreach (Student student in students)
            {
                Console.WriteLine("Student ID: " + student.StudentId);
                Console.WriteLine("Student Name: " + student.Name);
                Console.WriteLine("Student Marks: " + student.Marks);
                student.CalculateGrade();
                Console.WriteLine();
            }
        }
    }
}
