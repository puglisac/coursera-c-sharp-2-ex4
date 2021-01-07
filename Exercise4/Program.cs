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
            //print integers from 3 to 9 (inclusive)
            for(int i = lower; i <= upper; i++)
            {
                Console.WriteLine(i);
            }

            Deck deck = new Deck();

            List<Card> hand = new List<Card>();

            deck.Shuffle();

            //add 5 cards to the deck
            for(int i = 0; i<=4; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            //flip over each card
            for(int i = 0; i<hand.Count; i++)
            {
                hand[i].FlipOver();
            }

            //print each card
            foreach(Card card in hand)
            {
                card.Print();
            }
        }
    }
}
