using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    internal class Player
    {
        private List<Card> hand;
        public Player()
        {
            hand = new List<Card>();
        }
      
        
        public string Name { get; internal set; }
        public int NumberOfCards { get { return hand.Count; } }

        internal void HandCard(Card card)
        {
            hand.Add(card);
        }

        internal void Hit()
        {
          hand.Add(new Card());
        }
  }
}