using System;

namespace CSharpLearn
{
    class GradeBook
    {
        private int[] grades; // array of student grades

        public string CourseName {get;}

        public GradeBook(string name, int[] gradesArray)
        {
            CourseName = name;
            grades = gradesArray;
        }

        public void displayMessage()
        {
            Console.WriteLine($"Welcome to the grade book for \n{CourseName}!\n");
        }

        public void processGrades()
        {
            // output grades array
            OutputGrades();

            Console.WriteLine($"\nClass average is {GetAverage():F}");

            Console.WriteLine($"Lowest grade is {GetMinimum()}");
            Console.WriteLine($"Highest grade is {GetMaximum()}\n");

            OutputBarChart();  
        }

        public int GetMinimum()
        {
            var lowGrade = grades[0];
            foreach(var grade in grades)
            {
                if(grade < lowGrade)
                {
                    lowGrade = grade;
                }
            }

            return lowGrade;
        }

        public int GetMaximum()
        {
            var highGrade = grades[0];
            foreach(var grade in grades)
            {
                if(grade > highGrade)
                {
                    highGrade = grade;
                }
            }

            return highGrade;
        }

        public double GetAverage()
        {
            var total = 0.0;

            // sum student's grades
            foreach(var grade in grades)
            {
                total += grade;
            }

            return total / grades.Length;
        }

        public void OutputBarChart()
        {
            //TODO 
        }

        public void OutputGrades()
        {
            // TODO
        }

        
    }
}