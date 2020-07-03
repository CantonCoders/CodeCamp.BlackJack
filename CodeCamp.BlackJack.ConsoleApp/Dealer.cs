using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Dealer
    {
        public int NumberOfCards { get { return hand.Count; }  }

        private List<Card> hand; 

        public Dealer()
        {
            hand = new List<Card>();
        }

        public void HandCard(Card card)
        {
            hand.Add(card);
        }
    }
}