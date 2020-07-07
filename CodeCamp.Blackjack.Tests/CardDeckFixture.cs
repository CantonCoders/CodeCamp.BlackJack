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

            deck.Add(CardFactory.NewCard(Suit.Diamonds, CardName.Five));
            deck.Add(CardFactory.NewCard(Suit.Clubs, CardName.Ten));
            deck.Add(CardFactory.NewCard(Suit.Diamonds, CardName.Six));
            deck.Add(CardFactory.NewCard(Suit.Diamonds, CardName.Nine));
            deck.Add(CardFactory.NewCard(Suit.Hearts, CardName.Six));
            deck.Add(CardFactory.NewCard(Suit.Spades, CardName.Six));
            deck.Add(CardFactory.NewCard(Suit.Clubs, CardName.Six));

            return deck;
        }

        public List<Card> BuildOnePlayerWinOnDeltCards()
        {
            var deck = new List<Card>();

            deck.Add(CardFactory.NewCard(Suit.Diamonds, CardName.Ace));
            deck.Add(CardFactory.NewCard(Suit.Clubs, CardName.Ten));
            deck.Add(CardFactory.NewCard(Suit.Diamonds, CardName.Ten));
            deck.Add(CardFactory.NewCard(Suit.Diamonds, CardName.Seven));

            return deck;
        }
    }
}
