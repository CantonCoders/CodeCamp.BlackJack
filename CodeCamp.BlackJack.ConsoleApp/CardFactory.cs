using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class CardFactory
    {
        public static List<Card> BuildDeck()
        {
            var deck = new List<Card>();

            foreach(Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for(var i = 0; i < 13; i++)
                {
                    deck.Add(new Card(suit));         
                }
            }


            return deck;
        }
    }
}