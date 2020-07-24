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
                new Card(Suit.Diamonds, Rank.Nine),
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
        public void AllPlayersDealtTwoCards()
        {
            Assert.AreEqual(new Card(Suit.Spades, Rank.Five), player.Hand[0]);
            Assert.AreEqual(new Card(Suit.Clubs, Rank.Four), player.Hand[1]);

            Assert.AreEqual(new Card(Suit.Spades, Rank.Seven), player2.Hand[0]);
            Assert.AreEqual(new Card(Suit.Clubs, Rank.Eight), player2.Hand[1]);

            Assert.AreEqual(new Card(Suit.Hearts, Rank.Eight), game.Dealer.Hand[0]);
            Assert.AreEqual(new Card(Suit.Diamonds, Rank.Nine), game.Dealer.Hand[1]);
        }

        [Test]
        public void PlayerOneTurn()
        {
            Assert.AreEqual(player.Score(), 9);
            Assert.AreEqual(player, game.CurrentPlayer);
        }

        [Test]
        public void PlayerOneTakesCard()
        {
            game.Hit();
            Assert.AreEqual(player.NumberOfCards, 3);
            Assert.AreEqual(new Card(Suit.Clubs, Rank.Nine), player.Hand[2]);
            Assert.AreEqual(player.Score(), 18);
        }

        [Test]
        public void PlayerTwoTakesCard()
        {
            Assert.AreEqual(player2.Score(), 15);
            Assert.AreEqual(player, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(player2, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(new Card(Suit.Hearts, Rank.Five), player2.Hand[2]);
            Assert.AreEqual(player2.Score(), 20);
        }
        [Test]
        public void PlayerOneStays()
        {
           
            Assert.AreEqual(player, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(player2, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(player, game.CurrentPlayer);
            game.Stay();
            Assert.AreEqual(player2, game.CurrentPlayer);

        }

        [Test]
        public void GameFinishedWhenAllPlayersStay()
        {
            Assert.AreEqual(game.State, GameState.Playing);
            Assert.AreEqual(player, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(game.State, GameState.Playing);

            Assert.AreEqual(player2, game.CurrentPlayer);
            game.Hit();
            Assert.AreEqual(game.State, GameState.Playing);

            Assert.AreEqual(player, game.CurrentPlayer);
            game.Stay();
            Assert.AreEqual(game.State, GameState.Playing);

            Assert.AreEqual(player2, game.CurrentPlayer);
            game.Stay();
            Assert.AreEqual(game.State, GameState.Finished);
            Assert.AreEqual(game.Winner, player2);

        }
    }
}
