using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment1
{
    internal class Accenture : GovtRules
    {
        private int empId;
        private string name;
        private string dept;
        private string desg;
        private double basicSalary;

        public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EmpId => empId;
        public string Name => name;
        public string Dept => dept;
        public string Desg => desg;
        public double BasicSalary => basicSalary;

        public double EmployeePF(double basicSalary)
        {
            double employeePF = basicSalary * 0.12;
            double employerPF = basicSalary * 0.12;

            Console.WriteLine("Employer PF: " + employeePF);

            return employeePF;
        }

        public string LeaVeDetails()
        {
            return "2 day of Casual Leave per months\n5 days of sick Leave per year \n5 days of Sick Leave per year";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }
    }
}
