
using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        private string name;
        private int studentId;
        private int numberOfCredits;
        private double gpa;



        
public string Name { 

             get{ return name; }
            set { name = value; } 

                   }
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public int NumberOfCredits
        {
            get { return numberOfCredits; }
            set { numberOfCredits = value; }
        }
        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

    }
    

}
