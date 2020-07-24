using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    public class Player
    {
        public Player()
        {
            Hand = new List<Card>();
        }

        public Player(string name)
        {
            this.Name = name;
            Hand = new List<Card>();
        }

        public string Name { get; internal set; }
        public int NumberOfCards { get { return Hand.Count; } }

        public List<Card> Hand { get; internal set; }
        public bool Stayed { get; internal set; }

        public override string ToString()
        {
            return "Player: "+ Name;
        }

        internal void HandCard(Card card)
        {
            Hand.Add(card);
            if (Score() > 21)
                Stayed = true;
        }

        internal int Score()
        {
            int total = 0;

            foreach(Card card in Hand)
            {
                total += card.PointValue;
            }
            return total;
        }

        internal void Stay()
        {
            Stayed = true;
        }
    }
}