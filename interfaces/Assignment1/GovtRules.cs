using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment1
{
    internal interface GovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaVeDetails();
        public double gratuityAmount(float serviceCompleted, double basicSalary);
    }
}
