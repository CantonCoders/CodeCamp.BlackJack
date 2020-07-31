using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    class DealerWinsGame
    {
        private Game game;
        private Player player;
        private Player player2;

        [SetUp]
        public void Setup()
        {
            var deck = new List<Card>()
            {
                new Card(Suit.Spades, Rank.Six),   // player 1
                new Card(Suit.Spades, Rank.Seven),  // player 2
                new Card(Suit.Hearts, Rank.Nine),  // dealer
                new Card(Suit.Clubs, Rank.Seven),    // player 1
                new Card(Suit.Clubs, Rank.King),   // player 2
                new Card(Suit.Diamonds, Rank.Ace), // dealer
                new Card(Suit.Clubs, Rank.Nine),
                new Card(Suit.Hearts, Rank.Five),
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
        public void GameFinishedDealerWins()
        {
            Assert.AreEqual(game.State, GameState.Playing);
            Assert.AreEqual(player, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(game.State, GameState.Playing);
            Assert.IsNull(game.Winner);

            Assert.AreEqual(player2, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(22, player2.Score());
            Assert.AreEqual(22, player.Score());

            Assert.AreEqual(game.State, GameState.Finished);
            Assert.AreEqual(game.Winner,game.Dealer);

        }
    }
}
