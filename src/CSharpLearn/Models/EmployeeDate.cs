using System;

namespace CSharpLearn
{
    class EmployeeDate
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Date BirthDate { get; }

        public Date HireDate { get; }

        public EmployeeDate(string firstName, string lastName,
            Date birthDate, Date hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"{LastName}, {FirstName} " + 
            $"Hired: {HireDate}  Birthday: {BirthDate}";
        }
    }
}