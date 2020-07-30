using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace CSharpLearn
{
    class TutorialDeittel
    {
        public static void AddingIntegers()
        {
            int number1;
            int number2;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            string answer = $"{number1} + {number2} = {number1 + number2}";
            Console.WriteLine(answer);
        }

        public static void AccountTest()
        {
            Account account1 = new Account("Pedro Romero", 50.00m);
            Account account2 = new Account("Anny Perez", -7.53m);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C2}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C2}");
            Console.Write("Enter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance");
            account1.Deposit(depositAmount);
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C2}");
            /* -------------------------------------------------------*/
            /* Console.WriteLine($"Inital name is: {account.Name}");
            while(true)
            {
                Console.Write("Please enter the name: ");
                string name = Console.ReadLine();
                if ( Regex.Match( name, "[a-zA-Z][a-zA-Z ]+[a-zA-Z]$" ).Success ) { 
                    // Expresión regular que permite escribir nombre de cuenta
                    // con letras y espacios, sin caracteres especiales ni números.
                    account.Name = name;
                    break;
                }
                else
                {
                    Console.WriteLine("Error account name!!");
                }
            }
            //Console.WriteLine($"{account.Name.All(char.IsLetter)}");
            Console.WriteLine($"Inital name is: {account.Name}"); */
        }

        public static void StudentTest()
        {
            Student student1 = new Student("Jane Green", 93);
            Student student2 = new Student("John Blue", 72);
            Console.Write($"{student1.Name}'s letter grade equivalent of ");
            Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
            Console.Write($"{student2.Name}'s letter grade equivalent of ");
            Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
        }

        public static void Time1Test()
        {
            var time = new Time1();

            Console.WriteLine(
                $"The initial universal time is: {time.ToUniversalString()}");

            Console.WriteLine(
                $"The initial standar time is: {time.ToString()}");

            Console.WriteLine();

            time.SetTime(13, 27, 6);

            Console.WriteLine(
                $"The universal time is: {time.ToUniversalString()}");

            Console.WriteLine(
                $"The standar time is: {time.ToString()}");

            Console.WriteLine();

            try
            {
                time.SetTime(99, 99, 99);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message + "\n");
            }

            Console.WriteLine("After attempting invalid settings:");
            Console.WriteLine($"Universal time: {time.ToUniversalString()}");
            Console.WriteLine($"Standard time: {time.ToString()}");
        }

        public static void EmployeeDateTest()
        {
            var birthday = new Date(7, 24, 1949);
            var hireDate = new Date(3, 12, 1988);
            var employee = new EmployeeDate("Bob", "Blue", birthday, hireDate);

            Console.WriteLine(employee);
        }

        public static void EmployeeCountTest()
        {
            Console.WriteLine($"\nEmployees before instantiation: {EmployeeCount.Count}");

            // creato two Employees; Count should become 2
            var e1 = new EmployeeCount("Susan", "Baker");
            var e2 = new EmployeeCount("Bob", "Blue");

            Console.WriteLine($"\nEmployees after instantiation: {EmployeeCount.Count}");

            Console.WriteLine($"\nEmployee 1: {e1}");
            Console.WriteLine($"Employee 2: {e2}");

            // Employee object as being eligible for garbage collection
            e1 = null;
            e2 = null;
        }

        public static void ComplexNumberTest()
        {
            Console.Write("Enter de real part of complex number x: ");
            double realPart = double.Parse(Console.ReadLine());
            Console.Write("Enter de Imaginary part of complex number x: ");
            double imaginaryPart = double.Parse(Console.ReadLine());
            var x = new ComplexNumber(realPart, imaginaryPart);

            Console.Write("Enter de real part of complex number y: ");
            realPart = double.Parse(Console.ReadLine());
            Console.Write("Enter de Imaginary part of complex number y: ");
            imaginaryPart = double.Parse(Console.ReadLine());
            var y = new ComplexNumber(realPart, imaginaryPart);

            Console.WriteLine();
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public static void PayrollSystemTest()
        {
            // create derived-class objects
            var salariedEmployee = new SalariedEmployee("John", "Smith",
                "111-11-1111", 800.00M);

            var hourlyEmployee = new HourlyEmployee("Karen", "Price",
                "222-22-2222", 16.75M, 40.0M);

            var commissionEmployee = new CommissionEmployee("Sue", "Jones",
                "333-33-3333", 10000.0M, .06M);

            var basePlusCommissionEmployee =
                new BasePlusCommissionEmployee("Bob", "Lewis",
                    "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine($"{salariedEmployee}\nearned: " +
                $"{salariedEmployee.Earnings():C}\n");
            Console.WriteLine(
                $"{hourlyEmployee}\nearned: {hourlyEmployee.Earnings():C}\n");
            Console.WriteLine(
                $"{commissionEmployee}\nearned: {commissionEmployee.Earnings():C}\n");
            Console.WriteLine($"{basePlusCommissionEmployee}\nearned: " +
                $"{basePlusCommissionEmployee.Earnings():C}\n");

            // create List<AEmployee> and initialize with employeeobjects
            var employees = new List<AEmployee>(){salariedEmployee,
                hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

            Console.WriteLine("Employees processed polymorphically:\n");

            // generically process each element in employees
            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);

                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    //var employee = (BasePlusCommissionEmployee)currentEmployee;
                    var employee = currentEmployee as BasePlusCommissionEmployee;
                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine("new base salary with 10% increase is: " +
                    $"{employee.BaseSalary:C}");
                }

                Console.WriteLine($"earned: {currentEmployee.Earnings():C}\n");
            }

            // get type name of each object in employees
            for (int j = 0; j < employees.Count; j++)
            {
                Console.WriteLine(
                    $"Employee {j} is a {employees[j].GetType()}");
            }

        }

        public static void DivideByZeroNoExceptionHandling()
        {
            // Deitel page 364
            // get numerator
            Console.Write("Please enter an integer numerator: ");
            var numerator = int.Parse(Console.ReadLine());

            // get denominator
            Console.Write("Please enter an integer denominator: ");
            var denominator = int.Parse(Console.ReadLine());

            // divide the two integers, then display the result
            var result = numerator / denominator;

            Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}");
        }

        public static void DivideByZeroExceptionHandling()
        {
            var continueLoop = true;

            do
            {

                try
                {
                    // get numerator
                    Console.Write("Please enter an integer numerator: ");
                    var numerator = int.Parse(Console.ReadLine());

                    // get denominator
                    Console.Write("Please enter an integer denominator: ");
                    var denominator = int.Parse(Console.ReadLine());

                    // divide the two integers, then display the result
                    var result = numerator / denominator;

                    Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    
                    Console.WriteLine($"\n{formatException.Message}");
                    Console.WriteLine("You must enter two integers. Please try again. \n");
                }
                catch (DivideByZeroException divideByZeroException)
                {
                    Console.WriteLine($"\n{divideByZeroException.Message}");
                    Console.WriteLine("Zero is an invalid denominator. Please try again. \n");
                }
                
            } while (continueLoop);
        }
    }
}