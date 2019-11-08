using System;
using System.Collections.Generic;

namespace DeckOfCards.Classes
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck()
        {
            Reset();
        }
        public void Reset()
        {
            string[] strVal = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] suit = new string[] {"Spades", "Hearts", "Clubs", "Diamonds"};

            for(var i = 0; i<suit.Length; i++)
            {
                for(var j = 0; j <strVal.Length; j++)
                {
                    Card newCard = new Card(strVal[j],suit[i], j+1);
                    Cards.Add(newCard);
                }
            }
        }

        public Card Deal()
        {
            Card dealt = Cards[0];
            Cards.RemoveAt(0);
            Console.WriteLine($"{dealt.StringVal} of {dealt.Suit} was dealt");
            return dealt;
        }

        public void Shuffle()
        {
            for(var i = 0; i < Cards.Count; i++)
            {
                Random rand = new Random();
                int idx1 = rand.Next(Cards.Count);
                int idx2 = rand.Next(Cards.Count);

                Card temp = Cards[idx1];
                Cards[idx1] = Cards[idx2];
                Cards[idx2] = temp;
            }
        }
    }
}