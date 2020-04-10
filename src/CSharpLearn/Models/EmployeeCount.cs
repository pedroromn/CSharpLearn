using System;

namespace CSharpLearn
{
    class EmployeeCount
    {
        public static int Count { get; private set; }
        public int IdEmployee { get; private set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public EmployeeCount(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            ++Count;
            IdEmployee = Count;

            Console.WriteLine("Employee constructor: " + 
                $"{FirstName} {LastName}; Count: {Count}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - Id: {IdEmployee}";
        }
    }
}