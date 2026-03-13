using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class Doctor
    {
        int DoctorId;
        string DoctorName;
        string Specialization;
        short ConsultationFee;

        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor();
            doctor1.DoctorId = 101;
            doctor1.DoctorName = "Charan";
            doctor1.Specialization = "Cardiology";
            doctor1.ConsultationFee = 1000;


            Doctor doctor2 = new Doctor();
            doctor2.DoctorId = 143;
            doctor2.DoctorName = "Ganesh";
            doctor2.Specialization = "Neuralogy";
            doctor2.ConsultationFee = 800;

            Console.WriteLine("Doctor1 Details are: ");
            Console.WriteLine("Doctor ID is: " + doctor1.DoctorId) ;
            Console.WriteLine("Doctor Name: " + doctor1.DoctorName);
            Console.WriteLine("Specialized in the field of : " + doctor1.Specialization);
            Console.WriteLine("Consultation Fee Charges Per Patient is: " + doctor1.ConsultationFee);

            Console.WriteLine();
            Console.WriteLine("Doctor2 Details are: ");
            Console.WriteLine("Doctor ID is: " + doctor2.DoctorId);
            Console.WriteLine("Doctor Name: " + doctor2.DoctorName);
            Console.WriteLine("Specialized in the field of : " + doctor2.Specialization);
            Console.WriteLine("Consultation Fee Charges Per Patient is: " + doctor2.ConsultationFee);


            
         }
    }
}
