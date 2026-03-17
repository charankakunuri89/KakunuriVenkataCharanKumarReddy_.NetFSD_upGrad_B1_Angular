using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Education_System
{
    internal class CollegeStudent : Student
    {
        public CollegeStudent(int studentId, string name, double marks) : base(studentId, name, marks)
        {
        }

        public override void CalculateGrade()
        {
            if (Marks > 50)
            {
                Console.WriteLine(Name + " (College Student): Pass");
            }
            else
            {
                Console.WriteLine(Name + " (College Studnet): Fail");
            }
        }
    }
}
