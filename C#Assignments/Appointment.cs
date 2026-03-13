using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP_Concepts_using_HealthCare_Domain
{
    internal class Appointment
    {
        int AppointmentID ;
        string PatientName;
        string DoctorName ;
        string AppointmentDate;

        public Appointment()
        {
            AppointmentID = 101;
            PatientName = "Sravanthi";
            DoctorName = "General Physician";
            AppointmentDate = "2026-03-12";
        }

        public void display()
        {
            Console.WriteLine("AppointmentID: " + AppointmentID);
            Console.WriteLine("PatientName: " + PatientName);
            Console.WriteLine("DoctorName: " + DoctorName);
            Console.WriteLine("AppointmentDate: " + AppointmentDate);
        }

        static void Main(string[] args)
        {
            Appointment appointment = new Appointment();
            appointment.display();
        }


    }
}
