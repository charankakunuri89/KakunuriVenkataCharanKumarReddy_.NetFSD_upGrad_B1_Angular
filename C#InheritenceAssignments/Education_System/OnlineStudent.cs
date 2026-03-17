using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.Education_System
{
    internal class OnlineStudent : Student
    {
        public OnlineStudent(int studentId, string name, double marks) : base(studentId, name, marks) { 
        
        }

        public override void CalculateGrade()
        {
            if (Marks > 60)
            {
                Console.WriteLine(Name + " (Online Student): Pass");
            }
            else
            {
                Console.WriteLine(Name + " (Online Student): Fail");
            }
        }
    }
}
