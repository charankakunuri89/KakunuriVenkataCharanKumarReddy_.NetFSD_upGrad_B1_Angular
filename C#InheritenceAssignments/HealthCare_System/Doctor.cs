using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.HealthCare_System
{
    internal class Doctor : Staff
    {
        public double ConsulationFee;

        public Doctor(int staffId, string name, double baseSalary, double consulationFee) : base(staffId, name, baseSalary)
        {
            ConsulationFee = consulationFee;
        }

        public override double CalculateSalary()
        {
                return BaseSalary + ConsulationFee;
        }
    }
}
