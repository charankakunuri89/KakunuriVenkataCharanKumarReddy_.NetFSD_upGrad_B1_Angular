using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment1
{
    internal class TCS: GovtRules
    {
        private int empid;
        private string name;
        private string dept;
        private string desg;
        private double basic_salary;

        public TCS(int empId, string Name, String Dept, String Desg, double basicSalary) 
        {
            empid = empId;
            name = Name;
            dept = Dept;
            desg = Desg;
            basic_salary = basicSalary;
        }

        public int EmpId => empid;
        public string Name => name;
        public string Dept => dept;
        public double BasicSalary => basic_salary;
        public string Desg => desg;



        public double EmployeePF(double basicSalary)
        {
            double employeePF = basic_salary * 0.12;
            double employerPF = basic_salary * 0.833;
            double pensionFund = basic_salary * 0.367;
            Console.WriteLine("Employer PF: " + employerPF);
            Console.WriteLine("Pension Fund: " + pensionFund);
            return employeePF;
        }

        public string LeaVeDetails()
        {
            return "1 day of Casual Leave per Month \n12 days of Sick Leave per year\n10 days of Previlage Leave per year";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted > 20)
            {
                return 3 * basicSalary;
            }
            else if (serviceCompleted > 10)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted > 5)
            {
                return 1 * basicSalary;
            }
            return 0;
        }

    }
}
