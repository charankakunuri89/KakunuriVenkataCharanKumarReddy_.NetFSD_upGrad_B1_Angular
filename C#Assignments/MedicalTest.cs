using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class MedicalTest
    {
        int TestId;
        string TestName;
        short TestCost;

        public MedicalTest(int testId, string testName, short testCost)
        {
            TestId = testId;
            TestName = testName;
            TestCost = testCost;
        }
        public void display()
        {
            Console.WriteLine("TestID: " + TestId);
            Console.WriteLine("TestName: " + TestName);
            Console.WriteLine("TestCost: " + TestCost);
        }

        static void Main(string[] args)
        {
            MedicalTest obj = new MedicalTest(1432, "Blood Test", 24000);
            MedicalTest obj1 = new MedicalTest(1234, "X-Ray", 12450);
            obj.display();
            Console.WriteLine();
            obj1.display();
        }
    }
}
