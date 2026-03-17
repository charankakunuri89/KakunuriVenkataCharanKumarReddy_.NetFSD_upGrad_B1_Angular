using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Education_System
{
    internal class SchoolStudent : Student
    {
        public SchoolStudent(int studentId, string name, double marks) : base(studentId, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            if (Marks > 40) 
                Console.WriteLine(Name + "(School Student): Pass");

            else
                Console.WriteLine(Name + "(School Student) : Fail");
        }
    }
}
