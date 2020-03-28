using System.Collections.Generic;
using System;

namespace CSharpLearn
{
    class TutorialStrings
    {
        public static void IncludeDifferentDataTypes()
        {
            var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            var date = DateTime.Now;
            string value = $"On {date:d}, the price of {item.Name} was " +
            $"{item.Price:F3} per {item.perPackage} items";
            Console.WriteLine(value);
        }

        public static void WidthAlignmentStrings()
        {
            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 5,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine("");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach(var item in inventory)
            {
                Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");
            }
        }

        public static void FormatStrings()
        {
            var date = new DateTime(1731, 11, 25);
            Console.WriteLine($"On {date:dddd, MMMM dd, yyyy} Leonhard Euler introduced "
            +"the letter e to denote {Math.E:F5} in a letter to Christian Goldbach");

            const int NameAlignment = -15;
            const int ValueAlignment = 7;
            double a = 3;
            double b = 4;
            Console.WriteLine($"Three classical Pythagorean means of {a} and {b}:");
            Console.WriteLine($"|{"Arithmetic", NameAlignment}|{0.5*(a+b), ValueAlignment:F3}|");
            //Console.WriteLine($"");

        }

        public static void EscapeSequencesInterpolatedStrings()
        {
            var xs = new int[] {1, 2, 7, 9};
            var ys = new int[] {7, 9, 12};
            //Console.WriteLine($"{{{string.Join(",", xs)}}}");
            Console.WriteLine($"Find the intersection of the {{{string.Join(", ", xs)}}}" 
            +$" and {{{string.Join(", ", ys)}}} sets");
            Console.WriteLine();

            var userName = "Jane";
            var stringWithEscapes = $"C:\\Users\\{userName}\\Documents";
            var verbatimInterpolated = $@"C:\Users\{userName}\Documents";
            Console.WriteLine(stringWithEscapes);
            Console.WriteLine(verbatimInterpolated);
        }

        public static void IndicesRangesSequences()
        {
            string[] words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            Console.WriteLine($"The last word is \"{words[^1]}\"");
            string[] quickBrownFox = words[0..^0];
            foreach(var word in quickBrownFox)
            {
                Console.Write($"< {word} >");
            }
            Console.WriteLine();

            
            string[] reverseWords = words; 
            Array.Reverse(reverseWords);
            foreach(var word in reverseWords)
            {
                Console.Write($"< {word} >");
            }
            Console.WriteLine();
        }
    }
}