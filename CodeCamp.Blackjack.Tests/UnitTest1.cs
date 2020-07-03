using NUnit.Framework;
using System;

namespace CodeCamp.Blackjack.Tests
{
    public class Tests
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


        [Test]
        public void HandTwoCardsWhenGameStarts()
        {

            game.AddPlayer(player);
            game.Start();
            Assert.AreEqual(2, player.NumberOfCards);
           
        }

        [Test]
        public void GetPlayerDrawCard()
        {
            game.AddPlayer(player);
            game.Start();
            player.Hit();
            Assert.AreEqual(3, player.NumberOfCards);
        }

        [Test]
        public void GetDealerCards()
        {
            game.AddPlayer(player);
            var dealer = game.Dealer;
            game.Start();

            Assert.AreEqual(2, dealer.NumberOfCards);
        }
    }
}