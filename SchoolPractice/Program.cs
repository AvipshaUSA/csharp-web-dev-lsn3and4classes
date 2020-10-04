using System;
using System.Dynamic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student obj = new Student();
            obj.Name = "Avipsha Das";
             obj.StudentId = 5;
            obj.NumberOfCredits = 1;
            obj.Gpa = 4;


            Console.WriteLine($"new student :{obj.Name}");
            Console.WriteLine($"Id :{obj.StudentId}");
            Console.WriteLine($"Number Of credits :{obj.NumberOfCredits}");
            Console.WriteLine($"GPA :{obj.Gpa}");


        }
    }
}