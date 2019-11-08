using System.Collections.Generic;
using System;
namespace DeckOfCards.Classes
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>(5);
        }

        public Card Draw(Deck playing)
        {
            Card myCard = playing.Deal();
            Hand.Add(myCard);
            return myCard;
        }

        public Card Discard(int idx)
        {
            Card discard = Hand[idx];
            Console.WriteLine($"Discarding {discard.StringVal} of {discard.Suit}");
            Hand.RemoveAt(idx);
            return discard;
        }
   }
}