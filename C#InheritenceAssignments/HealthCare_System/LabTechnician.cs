using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment.HealthCare_System
{
    internal class LabTechnician : Staff
    {
        public double  EquipmentAllowance;

        public LabTechnician(int staffId, string name, double baseSalary, double equipmentAllowance) : base(staffId, name, baseSalary)
        {
            EquipmentAllowance = equipmentAllowance;
        }

        public override double CalculateSalary()
        {
            return BaseSalary + EquipmentAllowance;
        }

    }
}
