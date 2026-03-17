using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Education_System
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public double Marks { get; set; }


        public Student(int  studentId, string name, double marks)
        {
            StudentId = studentId;
            Name = name;
            Marks = marks;
        }

        public virtual void CalculateGrade()
        {
            if (Marks > 50) Console.WriteLine(Name + " : Pass");
            else Console.WriteLine(Name + ": Fail");
        }
    }
}
