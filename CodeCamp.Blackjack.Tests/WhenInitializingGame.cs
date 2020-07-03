using NUnit.Framework;
using System;

namespace CodeCamp.Blackjack.Tests
{
    public class WhenInitializingGame
    {
        private Game game;
        private Player player;
        private Player player2;

        [SetUp]
        public void Setup()

        {
            game = new Game();
            player = new Player();
            player2 = new Player();
            player.Name = "Insiya";
            player2.Name = "James";
        }


        [Test]
        public void AddMultiplePlayers()
        {
            game.AddPlayer(player);
            game.AddPlayer(player2);
            Assert.AreEqual(2, game.NumberOfPlayers);
        }
        [Test]
        public void CannotAddPlayerTwice()
        {
            game.AddPlayer(player);
         
            try {
                game.AddPlayer(player);
                Assert.Fail("Should not add same player twice.");
            }
            catch (Exception e)
            {
                Assert.AreEqual("Player already exists.", e.Message);

            }
        }

    }
}