using System.Collections.Generic;
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
    }
}