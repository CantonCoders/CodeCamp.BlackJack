using NUnit.Framework;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    public class Dealer
    {
        public int NumberOfCards { get { return hand.Count; }  }

        private List<Card> hand; 

        public Dealer()
        {
            hand = new List<Card>();
        }

        internal void HandCard(Card card)
        {
            hand.Add(card);
        }
    }
}