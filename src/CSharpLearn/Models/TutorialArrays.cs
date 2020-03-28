using System;

// pag 220 Deittel
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
    }
}