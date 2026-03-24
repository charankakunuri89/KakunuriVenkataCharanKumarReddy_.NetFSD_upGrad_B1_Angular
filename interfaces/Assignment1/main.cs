using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Assignment.Assignment1
{
    internal class main
    {
        static void Main(string[] args)
        {
            TCS tcs = new TCS(101, "Charan", "IT", "Developer", 35000);

            Console.WriteLine($"ID: {tcs.EmpId}, Name: {tcs.Name}, Dept: {tcs.Dept}, Desig: {tcs.Desg}");

            double pf1 = tcs.EmployeePF(tcs.BasicSalary);
            Console.WriteLine("Employee PF Amount is: " + pf1);

            Console.WriteLine("Leave Details:\n" + tcs.LeaVeDetails());

            Console.WriteLine("Graduity: " + tcs.gratuityAmount(6, tcs.BasicSalary));

            Console.WriteLine();

            Accenture acc = new Accenture(131, "Varshitha", "HR", "Manager", 25000);
            Console.WriteLine($"ID: {acc.EmpId}, Name: {acc.Name}, Dept: {acc.Dept}, Desig: {acc.Desg}");

            double pf2 = acc.EmployeePF(acc.BasicSalary);

            Console.WriteLine("EMployee PF Amount: " + pf2);

            Console.WriteLine("Leave Details:\n" + acc.LeaVeDetails());

            Console.WriteLine("Graduity: " + acc.gratuityAmount(6, acc.BasicSalary));

        }
    }
}
