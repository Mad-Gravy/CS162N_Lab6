using System;
using BlackJackClasses;

namespace Lab_6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand h = new Hand(); // Creates a hand object
            Card c = new Card(1, 1); // Creates an Ace of Clubs

            h.AddCard(c); // Adds the card to the hand
            h.AddCard(new Card(13, 4)); // Adds a King of Spades
            h.AddCard(new Card(7, 2)); // Adds a 7 of Diamonds

            Console.WriteLine("Showing hand. Expecting 3 cards. " + h); // Displays the hand, which should show 3 cards

            Console.WriteLine("Testing NumCards(), number of cards in hand. Expecting 3: " + h.NumCards); // Displays the count of cards

            Console.WriteLine("Testing HasCard(), checking for card with value 1. Expecting True: " + h.HasCard(1)); // Tests if the hand has a card with value 1 (Ace).

            Card removed = h.Discard(0); //Removes and returns the first card (Ace of Clubs) from the hand and stores it in 'removed'

            Console.WriteLine("Testing Discard(), discard and return card. Expecting Ace of Clubs: " + removed); // Displays discarded card

            Console.ReadLine();
        }
    }
}