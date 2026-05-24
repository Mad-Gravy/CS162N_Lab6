using System;
using System.Collections.Generic;

namespace BlackJackClasses
{
    public class Hand
    {

        protected List<Card> cards;

        public Hand() // Constructor
        {
            cards = new List<Card>();
        }

        public Hand(Deck d, int numCards) // Overloaded Constructor
        {
            cards = new List<Card>();

            for (int i = 0; i < numCards; i++)
            {
                cards.Add(d.Draw());
            }
        }

        public int NumCards // Card Counter (lol)
        {
            get { return cards.Count; }
        }

        public void AddCard(Card c) // Method to add a card to the hand
        {
            cards.Add(c);
        }

        public Card GetCard(int index) // Retuns a card at a specific index in the hand
        {
            return cards[index];
        }

        public Card Discard(int index) // Method to remove and display a card at a specific index in the hand
        {
            Card removed = cards[index];

            cards.RemoveAt(index);

            return removed;
        }

        public int IndexOf(Card c) // Returns the index of a certain card.
        {
            return cards.IndexOf(c);
        }

        public bool HasCard(Card c) // Boolean check for card.
        {
            return IndexOf(c) != -1;
        }

        public int IndexOf(int value) // Indexer, returns the index of a certain card value.
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool HasCard(int value) // Boolean check for card value.
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(int value, int suit) // Indexer, returns the index of a certain card value and suit.
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == value &&
                    cards[i].Suit == suit)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool HasCard(int value, int suit) // Boolean check for card value and suit.
        {
            return IndexOf(value, suit) != -1;
        }

        public override string ToString() // ToString method to display the hand's cards.
        {
            string handString = "Hand: ";

            foreach (Card c in cards)
            {
                handString += c + ", ";
            }

            return handString;
        }
    }
}