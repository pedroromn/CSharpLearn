using System;

namespace CSharpLearn
{
    // page 252 - Deittel

    class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        private decimal monthlySalary; // class variable

        public Employee(string firstName, string lastName,
            decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        // propierty
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }

            set
            {
                if(value >= 0M)
                {
                    monthlySalary = value;
                }
            }
        }

        public override string ToString() =>
            $"{FirstName, -10} {LastName, -10} {MonthlySalary, 10:C}"; 
    }
}