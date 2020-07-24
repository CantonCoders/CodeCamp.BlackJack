using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    class StartingOnePlayerGame
    {
        private Game game;
        private Player player;

        [SetUp]
        public void Setup()
        {
            var deck = new List<Card>()
            {
                new Card(Suit.Spades, Rank.King),
                new Card(Suit.Hearts, Rank.Eight),
                new Card(Suit.Clubs, Rank.Queen),
                new Card(Suit.Diamonds, Rank.Nine),
                new Card(Suit.Clubs, Rank.Four),
            };

            game = new Game();
            player = new Player();
            player.Name = "Insiya";
            game.AddPlayer(player);
            game.Start(deck);
        }
        [Test]
        public void HandTwoCardsWhenGameStarts()
        {
            Assert.AreEqual(2, player.NumberOfCards);
            Assert.AreEqual(new Card(Suit.Spades, Rank.King), player.Hand[0]);
            Assert.AreEqual(new Card(Suit.Clubs, Rank.Queen), player.Hand[1]);
            Assert.AreEqual(new Card(Suit.Hearts, Rank.Eight), game.Dealer.Hand[0]);
            Assert.AreEqual(new Card(Suit.Diamonds, Rank.Nine), game.Dealer.Hand[1]);
        }
        [Test]
        public void PlayerDecidesToStay()
        {
            game.Stay();
            Assert.AreEqual(player, game.Winner);
            Assert.AreEqual(GameState.Finished, game.State);
        }

        [Test]
        public void PlayerDecidesToTakeACard()
        {
            game.Hit();
            Assert.AreEqual(GameState.Finished, game.State);
            Assert.AreEqual(game.Dealer, game.Winner);
        }
    }
}
