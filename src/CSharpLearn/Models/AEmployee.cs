using System;

namespace CSharpLearn
{
    abstract class AEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }

        public AEmployee(string firstName, string lastName, string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}\n" +
                $"social security number: {SocialSecurityNumber}";
        }

        public abstract decimal Earnings();
    }
}