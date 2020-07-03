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
                foreach(CardName cardName in Enum.GetValues(typeof(CardName)))
                {
                    deck.Add(new Card(suit, cardName));         
                }
            }


            return deck;
        }
    }
}