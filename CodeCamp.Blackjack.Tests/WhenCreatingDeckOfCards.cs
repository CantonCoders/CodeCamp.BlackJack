using CodeCamp.Blackjack.ConsoleApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    class WhenCreatingDeckOfCards
    {
        private List<Card> deck;

        [SetUp]
        public void Setup()
        {
             deck = CardFactory.BuildDeck();
        }

        [Test]
        public void DeckShouldContain52Cards()
        {
            Assert.AreEqual(52, deck.Count);
        }

        [Test]
        public void DeckShouldContain4SuitsOf13Cards()
        {
            var clubs = deck.FindAll(i => i.Suit == Suit.Clubs);
            Assert.AreEqual(13, clubs.Count);

            var diamonds = deck.FindAll(i => i.Suit == Suit.Diamonds);
            Assert.AreEqual(13, diamonds.Count); 

            var hearts = deck.FindAll(i => i.Suit == Suit.Hearts);
            Assert.AreEqual(13, hearts.Count); 

            var spades = deck.FindAll(i => i.Suit == Suit.Spades);
            Assert.AreEqual(13, spades.Count);
        }
    }
}
