using System.Collections.Generic;
using System.Linq;
using System;

// Deittel: pag 261 

namespace CSharpLearn
{
    class TutorialLists
    {

        public static void CreateLists()
        {
            var names = new List<string>{"<name>", "Anny", "Teo"};
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
        }

        public static void ModifyLists()
        {
            var names = new List<string>{"<name>", "Anny", "Teo"};
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Gaby");
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.WriteLine();
            names.Remove("Maria");
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.WriteLine($"The list has {names.Count} elements");
        }

        public static void SearchSortLists()
        {
            var names = new List<string> {"<name>", "Pedro", "Teo", "Anny", "Miguel", "Simón"};
            foreach(var name in names)
            {
                Console.WriteLine($">> {name.ToUpper()}");
            }
            var index = names.IndexOf("Teo");
            if(index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");
            
            var notFound = names.IndexOf("Felipe");
                Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            
            Console.WriteLine("\nSorts Lists\n");
            names.Sort();
            foreach(var name in names)
            {
                Console.WriteLine($">> {name.ToUpper()}");
            }
            
        }

        public static void ListsOtherTypes()
        {
            var fibonnaciNumbers = new List<int>{1,1};
            /*
            var previous = fibonnaciNumbers[fibonnaciNumbers.Count - 1];
            var previous2 = fibonnaciNumbers[fibonnaciNumbers.Count - 2];
            for(int i = 3; i <= 20; i++)
            {
                fibonnaciNumbers.Add(previous + previous2);
                previous = fibonnaciNumbers[fibonnaciNumbers.Count - 1];
                previous2 = fibonnaciNumbers[fibonnaciNumbers.Count - 2];
            }
            Console.WriteLine($"20th Fibonnaci number is : {fibonnaciNumbers[fibonnaciNumbers.Count - 1]}");
            */
            while(fibonnaciNumbers.Count < 20)
            {
                var previous = fibonnaciNumbers[fibonnaciNumbers.Count - 1];
                var previous2 = fibonnaciNumbers[fibonnaciNumbers.Count - 2];
                fibonnaciNumbers.Add(previous + previous2);
            }
            Console.WriteLine($"20th Fibonnaci number is : {fibonnaciNumbers[fibonnaciNumbers.Count - 1]}");
            /*foreach(var item in fibonnaciNumbers)
            {
                Console.WriteLine(item);
            }*/
        }

        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);
            List<T> ret = new List<T> (actualCount);
            for(int i = 0; i < actualCount; i++)
            {
                ret.Add(input[i]);
            }
            return ret;
        }

        public static void CopyAtMostTest()
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(20);

            List<int> firstTwo = CopyAtMost(numbers, 2);
            Console.WriteLine(firstTwo.Count);
            /* for(int i = 0; i < firstTwo.Count; i++)
            {
                Console.WriteLine(firstTwo[i]);
            } */
            foreach(var item in firstTwo)
            {
                string value = $">> {item}";
                Console.WriteLine(value: value);
            }
        }

        public static void LinqWithSimpleTypeArray()
        {
            // create an integer array
            var values = new[] {2,9,5,0,3,7,1,4,8,5};

            // display original values
            Console.Write("Original array: ");
            foreach(var element in values)
            {
                Console.Write($" {element}");
            }

            var filtered = 
                from value in values
                where value > 4
                //orderby value descending
                select value;

            Console.Write("\nArray values grather than 4: ");
            foreach(var value in filtered)
            {
                Console.Write($" {value}");
            }
        }

        public static void LinqWithArrayOfObjects()
        {
            var employees = new [] {
                new Employee("Jason","Red",5000M),
                new Employee("Ashley","Green",7600M),
                new Employee("Matthew","Indigo",3587.5M),
                new Employee("James","Indigo",4700.77M),
                new Employee("Luke","Indigo",6200M),
                new Employee("Jason","Blue",3200M),
                new Employee("Wendy","Brown",4236.4M)
            };

            // display all employees
            Console.WriteLine("Original array: ");
            foreach(var employee in employees)
            {
                Console.WriteLine(employee);
            }

            // filter a range of salaries using && in a Linq query
            var between4K6K =
                from e in employees
                where (e.MonthlySalary >= 4000M) && (e.MonthlySalary <= 6000M)
                select e;    

            // display employee making between 4000 and 6000 per month
            Console.WriteLine("\nEmployees earning in the range " +
                $"{4000:C}-{6000:C} per month: ");

            foreach(var employee in between4K6K)
            {
                Console.WriteLine(employee);
            }

        }
    }
}