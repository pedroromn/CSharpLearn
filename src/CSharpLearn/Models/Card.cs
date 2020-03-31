using System;

namespace CSharpLearn
{
    class Card
    {
        private string Face {get;} // Card's face {"Ace", "Deuce", ....}
        private string Suit {get;} // Card's suit {"Hearts", "Diamonds", ....}

        // two parameter constructor
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString() => $"{Face} of {Suit}";
    }
}