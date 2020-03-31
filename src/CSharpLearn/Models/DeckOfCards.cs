using System;

namespace CSharpLearn
{
    class DeckOfCards
    {
        private static Random randomNumbers = new Random();

        private const int NumberOfCards = 52; // number of cards in a deck
        private Card[] deck = new Card[NumberOfCards];
        private int currentCard = 0;

        public DeckOfCards()
        {
            string[] faces = {"Ace", "Deuce", "Three", "Four", "Five", "Six",
                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

            string[] suits = {"Hearts", "Diamonds", "Clubs", "Spades"};

            // populate deck with Card objects
            for(var count = 0; count < deck.Length; ++count)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }
        }

        public void shuffle()
        {
            currentCard = 0; // reinitialize  currentCard
            for (var first = 0; first < deck.Length ; ++first)
            {
                var second = randomNumbers.Next(NumberOfCards);

                // swap current Card with randomly selected Card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;    
            }      
        }

        // deal one Card
        public Card DealCard()
        {
            if(currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null; // indicate that all Cards were dealt
            }
        }
    }
}