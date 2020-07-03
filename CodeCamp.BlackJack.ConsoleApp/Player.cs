using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Player
    {
        private List<Card> hand;
        public Player()
        {
            hand = new List<Card>();
        }
      
        
        public string Name { get; set; }
        public int NumberOfCards { get { return hand.Count; } }

        public void HandCard(Card card)
        {
            hand.Add(card);
        }

        public void Hit()
        {
          hand.Add(new Card());
        }
  }
}