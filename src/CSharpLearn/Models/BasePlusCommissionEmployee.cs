using System;

namespace CSharpLearn
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // base salary per week

         // six parameter constructor
         public BasePlusCommissionEmployee(string firstName, string lastName,
            string socialSecurityNumber, decimal grossSales,
            decimal commissionRate, decimal baseSalary)
            : base(firstName, lastName, socialSecurityNumber,
                grossSales, commissionRate)
         {
             BaseSalary = baseSalary;
         }

         public decimal BaseSalary
         {
             get
             {
                 return baseSalary;
             }

             set
             {
                 if(value < 0)
                 {
                     throw new ArgumentOutOfRangeException(nameof(value),
                        value,$"{nameof(BaseSalary)} must be >= 0");
                 }

                 baseSalary = value;
             }
         }

         // calculate earnings
         public override decimal Earnings()
         {
             return BaseSalary + base.Earnings();
         }

         // return string representation
         public override string ToString()
         {
             return $"base-salaried {base.ToString()}\nbase salary: {BaseSalary:C}";
         }
    }
}