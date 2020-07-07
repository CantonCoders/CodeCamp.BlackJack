using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Player
    {
        public List<Card> Hand;
        public Player()
        {
            Hand = new List<Card>();
        }

        public string Name { get; set; }
        public int NumberOfCards { get { return Hand.Count; } }

        public void Deal(Card card)
        {
            Hand.Add(card);
        }
  }
}