using System;

namespace BlackJackClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();

        private int value;
        private int suit;


        // Getters and Setters with rules!! (Property Procedures)
        public int Value
        {
            get { return value; }
            set
            {
                if (value >= 1 && value <= 13)
                    this.value = value;
                else
                    throw new ArgumentException("Value must be between 1 and 13.");
            }
        }

        public int Suit
        {
            get { return suit; }
            set
            {
                if (value >= 1 && value <= 4)
                    this.suit = value;
                else
                    throw new ArgumentException("Suit must be between 1 and 4.");
            }
        }

        // Default Constructor that generates a random card! 
        public Card()
        {
            value = generator.Next(1, 14);
            suit = generator.Next(1, 5);
        }

        // Full constructor!
        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }


        // All the Matchy things!
        public bool HasMatchingSuit(Card other)
        {
            return this.suit == other.suit;
        }

        public bool HasMatchingValue(Card other)
        {
            return this.value == other.value;
        }

        public bool IsAce()
        {
            return value == 1;
        }

        public bool IsBlack()
        {
            return suit == 1 || suit == 4;
        }

        public bool IsClub()
        {
            return suit == 1;
        }

        public bool IsDiamond()
        {
            return suit == 2;
        }

        public bool IsFaceCard()
        {
            return value == 11 || value == 12 || value == 13;
        }

        public bool IsHeart()
        {
            return suit == 3;
        }

        public bool IsRed()
        {
            return suit == 2 || suit == 3;
        }

        public bool IsSpade()
        {
            return suit == 4;
        }


        // ToString method!
        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
    }
}
