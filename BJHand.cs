using System;

namespace BlackJackClasses
{
    public class BJHand:Hand
    {
        public BJHand():base() // Default Constructor, called from the parent class (Hand)
        {

        }

        public BJHand(Deck d, int numCards) : base(d, numCards) // Overloaded Constructor, called from the parent class
        {

        }

        public bool HasAce // Checks the hand for an Ace using HasCard() from the parent class
        {
            get
            {
                return HasCard(1);
            }
        }

        public int Score // Calculates the score of the hand according to Blackjack rules
        {
            get
            {
                int score = 0;

                foreach (Card c in cards)
                {
                    if (c.Value >= 11 && c.Value <= 13) // Face cards count as 10 points
                    {
                        score += 10;
                    }
                    else
                    {
                        score += c.Value; // Number cards count as their value, and Aces count as 1 point for now
                    }
                }

                if (HasAce && score <= 11) // Boost ace from 1 to 10 points if it doesn't cause a bust
                {
                    score += 10;
                }

                return score;
            }
        }

        public bool IsBusted // Sad...
        {
            get
            {
                return Score > 21; // You done goofed.
            } 
        }
    }
}