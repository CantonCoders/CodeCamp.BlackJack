using NUnit.Framework;
using System;

namespace CodeCamp.Blackjack.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetNumberOfPlayers()
        {
            var game = new Game();
            Player player = new Player();
            player.Name = "Insiya";
            game.AddPlayer(player);
            Assert.AreEqual(1, game.NumberOfPlayers);
        }

        [Test]
        public void AddingSecondPlayer()
        {
            var game = new Game();
            Player player = new Player();
            player.Name = "Insiya";
            Player player2 = new Player();
            player2.Name = "James";
            game.AddPlayer(player);
            game.AddPlayer(player2);
            Assert.AreEqual(2, game.NumberOfPlayers);
        }
        [Test]
        public void AddingSamePlayerTwice()
        {
            var game = new Game();
            Player player = new Player();
            player.Name = "Insiya";
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