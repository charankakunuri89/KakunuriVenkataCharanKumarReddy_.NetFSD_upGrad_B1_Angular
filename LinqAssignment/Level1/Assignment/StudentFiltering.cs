using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment.Level1.Assignment1
{
    //class Student
    //{
    //    public int Id { get; set; }

    //    public string Name { get; set; }

    //    public int Age { get; set; }

    //    public double Marks { get; set; }
    //};

    public record Student(int Id, string Name, int Age, double Marks);

    internal class StudentFiltering
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student (470, "Charan", 23, 74.16 ),
            new Student (488,  "Gignesh", 22, 67.34 ),
            new Student (479, "Vivek", 23, 79.46),
            new Student (478,  "Sekhar", 24, 81.45 ),
            new Student (491, "Mani", 22, 76.76),
            new Student (483, "Nagi", 24, 65.18)
        };


            //Tasks:
            //1.Get all students with marks > 75
            //var students_list_greaterThan_75_Marks = students.Where(s => s.Marks > 75).ToList();
            Console.WriteLine("Students Whose Marks Greater than 75: ");
            var students_list_greaterThan_75_Marks = (from s in students
                                                  where s.Marks > 75
                                                  select s).ToList();

            foreach(var s in students_list_greaterThan_75_Marks)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //2.Get Students whose age is between 18 and 25
            Console.WriteLine("Students Whose Age is Between 18 and 25: ");
            var students_Age_between_18_and_25 = (from s in students
                                                  where s.Age >= 18 && s.Age <= 25
                                                  select s).ToList();

            foreach(var s in students_Age_between_18_and_25)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //3.Sort Students by Marks(descending)
            Console.WriteLine("Sort students by Marks(descending:");
            var students_sort_by_marks_descending = students.OrderByDescending(stud => stud.Marks).ToList();
            foreach(var s in students_sort_by_marks_descending)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            //4.Select only Name and Marks
            Console.WriteLine("Select only Names and Marks: ");
            var result  = students.Select(s => (s.Name, s.Marks)).ToList();

            foreach(var item in result)
            {
                Console.WriteLine(item.Name + " - " +  item.Marks);
            }
        }
    }
}
