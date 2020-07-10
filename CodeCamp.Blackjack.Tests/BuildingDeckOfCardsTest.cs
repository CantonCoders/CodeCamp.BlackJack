using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    public class BuildingDeckOfCardsTest
    {
        private CardFactory cardShuffler;
        private List<Card> deck;

        [SetUp]
        public void SetUp()
        {
            cardShuffler = new CardFactory();
            deck = cardShuffler.BuildNonJokerDeck();
        }

        // array of cards
        // track cards that are dealt - no duplicates
        // assign number & suite
        [Test]
        public void BuildingDeckOf52Cards()
        {
            Assert.NotNull(deck);
            Assert.AreEqual(52, deck.Count);

            Assert.AreEqual(Suit.Hearts, deck[0].Suit);
            //Assert.AreEqual("4D", deck[16]);
        }

        [Test]
        public void GetAllSuitWith13Cards()
        {
            var hearts = deck.FindAll(card => card.Suit == Suit.Hearts);
            Assert.AreEqual(13, hearts.Count);
            //Assert.AreEqual("4D", deck[16]);
            var diamonds = deck.FindAll(card => card.Suit == Suit.Diamonds);
            Assert.AreEqual(13, diamonds.Count);

            var spades = deck.FindAll(card => card.Suit == Suit.Spades);
            Assert.AreEqual(13, spades.Count);

            var clubs = deck.FindAll(card => card.Suit == Suit.Clubs);
            Assert.AreEqual(13, clubs.Count);
        }
        [Test]
        public void FullDeckOfCardsEachSuitHas13UniqueCards()
        {
            var hearts = deck.FindAll(card => card.Suit == Suit.Hearts);
            AssertCardRanks(hearts);

            var diamonds = deck.FindAll(card => card.Suit == Suit.Diamonds);
            AssertCardRanks(diamonds);
        }

        private static void AssertCardRanks(List<Card> suit)
        {
            var i = 0;
            Assert.AreEqual(Rank.Ace, suit[i++].Rank);
            Assert.AreEqual(Rank.Two, suit[i++].Rank);
            Assert.AreEqual(Rank.Three, suit[i++].Rank);
            Assert.AreEqual(Rank.Four, suit[i++].Rank);
            Assert.AreEqual(Rank.Five, suit[i++].Rank);
            Assert.AreEqual(Rank.Six, suit[i++].Rank);
            Assert.AreEqual(Rank.Seven, suit[i++].Rank);
            Assert.AreEqual(Rank.Eight, suit[i++].Rank);
            Assert.AreEqual(Rank.Nine, suit[i++].Rank);
            Assert.AreEqual(Rank.Ten, suit[i++].Rank);
            Assert.AreEqual(Rank.Jack, suit[i++].Rank);
            Assert.AreEqual(Rank.Queen, suit[i++].Rank);
            Assert.AreEqual(Rank.King, suit[i++].Rank);
        }
    }
}
