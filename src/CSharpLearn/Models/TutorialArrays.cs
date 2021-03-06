using System;

// pag 227 Deittel
namespace CSharpLearn
{
    class TutorialArrays
    {
        public static void BarChart()
        {
            int[] array = {10,5,2,10,0,2,1,2,4,2,1}; // distribution
            Console.WriteLine("Grade distribution");

            //for_each array element, output a bar of the char
            for (var counter = 0; counter < array.Length; ++counter)
            {
                if(counter == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write($"{counter * 10:D2}-{counter * 10 + 9:D2}: ");
                }

                // display bar of asterisks
                for(var stars = 0; stars < array[counter]; ++stars)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void RollDie()
        {
            var randomNumbers = new Random(); // random-number generator
            var frequency = new int[7]; // array of frequency counters
            const long maxRoll = 60000000;

            // roll die 60000000 times; use die value as frequency index
            for(var roll = 1; roll <= maxRoll; ++roll)
            {
                ++frequency[randomNumbers.Next(1,7)];
            }

            Console.WriteLine($"{"Face"}{"Frequency",10}");

            // output each array element's value
            for(var face = 1; face < frequency.Length; ++face)
            {
                Console.WriteLine($"{face,4}{frequency[face],10}");
            }
        }

        public static void CardShufflingDealing()
        {
            var myDeackOfCards = new DeckOfCards();
            myDeackOfCards.shuffle();

            for(var i = 0; i < 52; ++i)
            {
                Console.Write($"{myDeackOfCards.DealCard(), -20}");

                if((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        public static void GradeBookTest()
        {
            int[] gradesArray = {87,68,94,100,83,78,85,91,76,87};

            var myGradeBook = new GradeBook(
                "CS101 Introduction to C# Programming",gradesArray);
            
            myGradeBook.displayMessage();
            myGradeBook.processGrades();
        }

        public static void InitRectJaggedArrays()
        {
            // with rectangular arrays
            int[,] rectangular = {{1,2,3},{4,5,6}};

            int[][] jagged = {new int[]{1,2},
                              new int[]{3},
                              new int[]{4,5,6}};

            OutputArray(rectangular);
            Console.WriteLine();
            OutputArray(jagged);
        }

        private static void OutputArray(int[,] array)
        {
            Console.WriteLine("values in the rectangular array by row are: ");

            for(var row = 0; row < array.GetLength(0); ++row)
            {
                for(var column = 0; column < array.GetLength(1); ++column)
                {
                    Console.Write($"{array[row,column]} ");
                }

                Console.WriteLine();
            }
        }

        private static void OutputArray(int[][] array)
        {
             Console.WriteLine("values in the jagged array by row are: ");

             foreach(var row in array)
             {
                 foreach(var element in row)
                 {
                     Console.Write($"{element} ");
                 }

                 Console.WriteLine();
             }
        }
    }
}