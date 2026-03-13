using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class Billing
    {
        string PatientName;
        int ConsultationFee;
        int TestCharges;

        public Billing(string patientName, int consultationFee, int testCharges)
        {
            PatientName = patientName;
            ConsultationFee = consultationFee;
            TestCharges = testCharges;
        }

        public int CalculateTotalBill()
        {
            int totalBill = ConsultationFee + TestCharges;
            return totalBill;
        }

        public void display()
        {
            Console.WriteLine("Patient Name:" + PatientName);
            Console.WriteLine("Total Bill: " + CalculateTotalBill());
        }

        static void Main(string[] args)
        {
            Billing billing = new Billing("Ramesh", 1400, 100);
            billing.display();
        }
    }
}
