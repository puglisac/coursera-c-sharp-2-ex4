using System;
using System.Collections.Generic;
using ConsoleCards;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lower = 3;
            int upper = 9;

            for(int i = lower; i <= upper; i++)
            {
                Console.WriteLine(i);
            }

            Deck deck = new Deck();

            List<Card> hand = new List<Card>();

            deck.Shuffle();

            for(int i = 0; i<=4; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            for(int i = 0; i<hand.Count; i++)
            {
                hand[i].FlipOver();
            }

            foreach(Card card in hand)
            {
                card.Print();
            }
        }
    }
}
