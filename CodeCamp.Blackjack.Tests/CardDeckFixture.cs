using CodeCamp.Blackjack.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    class CardDeckFixture
    {
        public List<Card> BuildOnePlayerWinDeck()
        {
            var deck = new List<Card>();

            deck.Add(new Card(Suit.Diamonds, CardName.Five));
            deck.Add(new Card(Suit.Clubs, CardName.Ten));
            deck.Add(new Card(Suit.Diamonds, CardName.Six));
            deck.Add(new Card(Suit.Diamonds, CardName.Nine));
            deck.Add(new Card(Suit.Hearts, CardName.Six));
            deck.Add(new Card(Suit.Spades, CardName.Six));
            deck.Add(new Card(Suit.Clubs, CardName.Six));

            return deck;
        }
    }
}
