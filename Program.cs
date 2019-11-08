using System;
using DeckOfCards.Classes;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********Deck of Cards*******");
            Deck myDeck = new Deck();
            Player nibbles = new Player("Mr. Nibbles");
            myDeck.Shuffle();
            CreateHand(nibbles, myDeck);    
            ShowHand(nibbles);  
            Console.WriteLine("Which card would you like to discard?");
            nibbles.Discard(3);
            

        }
        static void CreateHand(Player current, Deck deck)
        {
            for(var i = 0; i<4; i++)
            {
                current.Draw(deck);
            }
        }

        static void ShowHand(Player current)
        {
            foreach(var x in current.Hand)
            {
                Console.WriteLine($"{x.StringVal} of {x.Suit}");
            }
        }
    }
}
