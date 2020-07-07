using CodeCamp.Blackjack.ConsoleApp;
using CodeCamp.BlackJack.ConsoleApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    class WhenPlayerOneWins
    {
        private Game game;
        private Player player;

        [SetUp]
        public void Setup()
        {
            game = new Game();
            game.AssignDealerDeck(new CardDeckFixture().BuildOnePlayerWinOnDeltCards());
            player = new Player();
            player.Name = "Insiya";
            game.AddPlayer(player);
        }

        [Test]
        public void PlayerIsDeltAScoreOf21()
        {
            game.Start();
            Assert.AreEqual(GameStatus.Finished, game.Status);
        }
    }
}
