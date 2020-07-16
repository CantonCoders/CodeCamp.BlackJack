using NUnit.Framework;
using System;

namespace CodeCamp.Blackjack.Tests
{
    public class InitializingGameTest
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
        public void GameStateIsNewGame()
        {
            
            Assert.AreEqual(GameState.New, game.State);
        }


        [Test]
        public void GetNumberOfPlayers()
        {
            game.AddPlayer(player);
            Assert.AreEqual(1, game.NumberOfPlayers);
        }

        [Test]
        public void AddingSecondPlayer()
        {
            
            game.AddPlayer(player);
            game.AddPlayer(player2);
            Assert.AreEqual(2, game.NumberOfPlayers);
        }
        [Test]
        public void AddingSamePlayerTwice()
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