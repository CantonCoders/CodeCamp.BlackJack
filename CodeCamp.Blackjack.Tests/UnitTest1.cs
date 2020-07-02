using NUnit.Framework;

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
        public void Test()
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
    }
}