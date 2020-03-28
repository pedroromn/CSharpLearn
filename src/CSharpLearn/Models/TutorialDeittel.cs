using System;
using System.Text.RegularExpressions;

// pag 220

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

            string answer = $"{number1} + {number2} = {number1+number2}";
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
    }
}