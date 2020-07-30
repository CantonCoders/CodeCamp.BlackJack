using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    public class ScoringPlayerHand
    {
        [Test]
        public void AceWorthElevenPoints()
        {
            var player = new Player();
            player.HandCard(new Card(Suit.Clubs, Rank.Ace));
            player.HandCard(new Card(Suit.Diamonds, Rank.King));

            Assert.AreEqual(21, player.Score());
        }

        [Test]
        public void AceWorthOnePointWhenLastCardDealt()
        {
            var player = new Player();
            player.HandCard(new Card(Suit.Diamonds, Rank.King));
            player.HandCard(new Card(Suit.Hearts, Rank.King));
            player.HandCard(new Card(Suit.Clubs, Rank.Ace));

            Assert.AreEqual(21, player.Score());
        }

        [Test]
        public void AceWorthOnePointWhenFirstCardDealt()
        {
            var player = new Player();
            player.HandCard(new Card(Suit.Clubs, Rank.Ace));
            player.HandCard(new Card(Suit.Diamonds, Rank.King));
            player.HandCard(new Card(Suit.Hearts, Rank.King));

            Assert.AreEqual(21, player.Score());
        }
    }
}
