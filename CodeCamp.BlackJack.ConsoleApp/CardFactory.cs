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
                    deck.Add(NewCard(suit, cardName));
                }
            }


            return deck;
        }

        public static Card NewCard(Suit suit, CardName cardName)
        {
            var point = (int)cardName + 1;

            if (cardName == CardName.Ace)
                point = 11;
            if ((int)cardName >= 10)
                point = 10;

            return new Card(suit, cardName, point);
        }
    }
}