using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    class StartingTwoPlayerGame
    {
        private Game game;
        private Player player;
        private Player player2;

        [SetUp]
        public void Setup()
        {
            var deck = new List<Card>()
            {
                new Card(Suit.Spades, Rank.Five),
                new Card(Suit.Spades, Rank.Seven),
                new Card(Suit.Hearts, Rank.Eight),
                new Card(Suit.Clubs, Rank.Four),
                new Card(Suit.Clubs, Rank.Eight),
                new Card(Suit.Diamonds, Rank.Nine)
            };


            game = new Game();
            player = new Player();
            player.Name = "Insiya";
            player2 = new Player("Nate");
            game.AddPlayer(player);
            game.AddPlayer(player2);

            game.Start(deck);
        }
        [Test]
        public void AllPlayersDealtTwoCards()
        {
            Assert.AreEqual(new Card(Suit.Spades, Rank.Five), player.Hand[0]);
            Assert.AreEqual(new Card(Suit.Clubs, Rank.Four), player.Hand[1]);

            Assert.AreEqual(new Card(Suit.Spades, Rank.Seven), player2.Hand[0]);
            Assert.AreEqual(new Card(Suit.Clubs, Rank.Eight), player2.Hand[1]);

            Assert.AreEqual(new Card(Suit.Hearts, Rank.Eight), game.Dealer.Hand[0]);
            Assert.AreEqual(new Card(Suit.Diamonds, Rank.Nine), game.Dealer.Hand[1]);
        }
    }
}
