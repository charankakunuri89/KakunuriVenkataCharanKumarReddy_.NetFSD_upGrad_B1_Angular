using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.HealthCare_System
{
    internal class Staff
    {
        public int StaffId;
        public string Name;
        public double BaseSalary;

        public Staff(int staffId, string name, double baseSalary)
        {
            StaffId = staffId;
            Name = name;
            BaseSalary = baseSalary;
        }

        public virtual double CalculateSalary()
        {
            return BaseSalary;
        }
    }
}
