using System;

namespace CSharpLearn
{
    class Student
    {
        public string Name {get; set;} // property
        private int average; // instance variable

        // constructor initializes Name and Average properties
        public Student(string studentName, int studentAverage)
        {
            Name = studentName;
            average = studentAverage; // sets average instance variable
        }

        public int Average
        {
            get
            {
                return average;
            }

            set
            {
                // validate that value is > 0 and <= 100; otherwise
                // keep instance variable average's current value
                if(value > 0)
                {
                    if(value <= 100)
                    {
                        average = value; // assing to instance variable
                    }
                }
            }
        }

        // returns the Student's letter grade. based on the average
        public string LetterGrade
        {
            get
            {
                string letterGrade = string.Empty; // string.Empty is ""
                if (average >= 90)
                {
                    letterGrade = "A";
                }
                else if (average >= 80)
                {
                    letterGrade = "B";
                }
                else if (average >= 70)
                {
                    letterGrade = "C";
                }
                else if (average >= 60)
                {
                    letterGrade = "D";
                }
                else
                {
                    letterGrade = "F";
                }

                return letterGrade;                
            }
        }        

    }
}