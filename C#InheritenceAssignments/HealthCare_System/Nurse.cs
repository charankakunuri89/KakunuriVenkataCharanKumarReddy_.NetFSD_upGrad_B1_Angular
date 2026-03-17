using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.HealthCare_System
{
    internal class Nurse : Staff
    {
        public double NightShiftAllowance;

        public Nurse(int staffId, string name, double baseSalary, double nightShiftAllowance) : base(staffId, name, baseSalary)
        {
            NightShiftAllowance = nightShiftAllowance;
        }

        public override double CalculateSalary()
        {
                return BaseSalary + NightShiftAllowance;
        }
    }
}
