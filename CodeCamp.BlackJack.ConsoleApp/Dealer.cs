using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Dealer
    {
        public int NumberOfCards { get { return Hand.Count; }  }

        public List<Card> Hand { get; }

        public Dealer()
        {
            Hand = new List<Card>();
        }

        public void HandCard(Card card)
        {
            Hand.Add(card);
        }
    }
}