using System;
using BlackJackClasses;

namespace Lab_6_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHand();
            TestBJHand();

            Console.ReadLine();
        }

        static void TestHand()
        {
            Hand h = new Hand();

            h.AddCard(new Card(1, 1)); // Ace of Clubs
            h.AddCard(new Card(13, 4)); // King of Spades
            h.AddCard(new Card(7, 2)); // 7 of Diamonds

            Console.WriteLine("TESTING HAND CLASS");
            Console.WriteLine("------------------");

            Console.WriteLine("Showing hand. Expecting 3 cards:");
            Console.WriteLine(h);

            Console.WriteLine("Testing NumCards. Expecting 3: " + h.NumCards);

            Console.WriteLine("Testing GetCard(0). Expecting Ace of Clubs: " + h.GetCard(0));

            Console.WriteLine("Testing HasCard(1). Expecting True: " + h.HasCard(1));
            Console.WriteLine("Testing HasCard(5). Expecting False: " + h.HasCard(5));

            Console.WriteLine("Testing HasCard(13, 4). Expecting True: " + h.HasCard(13, 4));
            Console.WriteLine("Testing HasCard(13, 1). Expecting False: " + h.HasCard(13, 1));

            Console.WriteLine("Testing IndexOf(7). Expecting 2: " + h.IndexOf(7));
            Console.WriteLine("Testing IndexOf(10). Expecting -1: " + h.IndexOf(10));

            Console.WriteLine("Testing IndexOf(13, 4). Expecting 1: " + h.IndexOf(13, 4));
            Console.WriteLine("Testing IndexOf(13, 1). Expecting -1: " + h.IndexOf(13, 1));

            Card removed = h.Discard(0);

            Console.WriteLine("Testing Discard(0). Expecting Ace of Clubs: " + removed);
            Console.WriteLine("Testing NumCards after discard. Expecting 2: " + h.NumCards);

            Console.WriteLine();
        }

        static void TestBJHand()
        {
            Console.WriteLine("TESTING BJHAND CLASS");
            Console.WriteLine("--------------------");

            BJHand hand1 = new BJHand(); // Tetsting Ace + King. Expecting score 21.
            hand1.AddCard(new Card(1, 1)); // Ace of Clubs
            hand1.AddCard(new Card(13, 4)); // King of Spades

            Console.WriteLine("Testing Ace + King. Expecting score 21.");
            Console.WriteLine(hand1);
            Console.WriteLine("Testing HasAce. Expecting True: " + hand1.HasAce);
            Console.WriteLine("Testing Score. Expecting 21: " + hand1.Score);
            Console.WriteLine("Testing IsBusted. Expecting False: " + hand1.IsBusted);
            Console.WriteLine();

            BJHand hand2 = new BJHand(); // Testing Ace + 5. Expecting score 16.
            hand2.AddCard(new Card(1, 2)); // Ace of Diamonds
            hand2.AddCard(new Card(5, 1)); // 5 of Clubs

            Console.WriteLine("Testing Ace + 5. Expecting score 16.");
            Console.WriteLine(hand2);
            Console.WriteLine("Testing HasAce. Expecting True: " + hand2.HasAce);
            Console.WriteLine("Testing Score. Expecting 16: " + hand2.Score);
            Console.WriteLine("Testing IsBusted. Expecting False: " + hand2.IsBusted);
            Console.WriteLine();

            BJHand hand3 = new BJHand(); // Testing King + Queen + 5. Expecting Bust of 25.
            hand3.AddCard(new Card(13, 1)); // King of Clubs
            hand3.AddCard(new Card(12, 2)); // Queen of Diamonds
            hand3.AddCard(new Card(5, 3)); // 5 of Hearts

            Console.WriteLine("Testing King + Queen + 5. Expecting score 25.");
            Console.WriteLine(hand3);
            Console.WriteLine("Testing HasAce. Expecting False: " + hand3.HasAce);
            Console.WriteLine("Testing Score. Expecting 25: " + hand3.Score);
            Console.WriteLine("Testing IsBusted. Expecting True: " + hand3.IsBusted);
            Console.WriteLine();

        }
    }
}