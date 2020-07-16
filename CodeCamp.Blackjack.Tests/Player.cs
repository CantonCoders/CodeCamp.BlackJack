﻿using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    public class Player
    {
        public Player()
        {
            Hand = new List<Card>();
        }
      

        
        public string Name { get; internal set; }
        public int NumberOfCards { get { return Hand.Count; } }

        public List<Card> Hand { get; internal set; }

        internal void HandCard(Card card)
        {
            Hand.Add(card);
        }
    }
}