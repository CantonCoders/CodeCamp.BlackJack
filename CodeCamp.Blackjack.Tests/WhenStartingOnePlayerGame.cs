using CodeCamp.Blackjack.ConsoleApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp.Blackjack.Tests
{
    public class WhenStartingOnePlayerGame
    {
        private Game game;
        private Player player;

        [SetUp]
        public void Setup()
        {
            game = new Game();
            game.AssignDealerDeck(new CardDeckFixture().BuildOnePlayerWinDeck());
            player = new Player();
            player.Name = "Insiya";
        }

        [Test]
        public void PlayerReceivesTwoCards()
        {
            StartOnePlayerGame();
            Assert.AreEqual(2, player.NumberOfCards);
        }

        [Test]
        public void PlayerCanDrawACard()
        {
            StartOnePlayerGame();
            player.Hit();
            Assert.AreEqual(3, player.NumberOfCards);
        }

        [Test]
        public void DealerRecievesTwoCards()
        {
            StartOnePlayerGame();
            var dealer = game.Dealer;

            Assert.AreEqual(2, dealer.NumberOfCards);
        }

        private void StartOnePlayerGame()
        {
            game.AddPlayer(player);
            game.Start();
        }

        [Test]
        public void TwoCardsAreDeltStartingWithPlayer()
        {
            StartOnePlayerGame();
            var card = player.Hand.FindAll(i => i.Suit == Suit.Diamonds && i.Name == CardName.Five);
            Assert.AreEqual(1, card.Count);
            
            card = player.Hand.FindAll(i => i.Suit == Suit.Diamonds && i.Name == CardName.Six);
            Assert.AreEqual(1, card.Count);
            
            card = game.Dealer.Hand.FindAll(i => i.Suit == Suit.Clubs && i.Name == CardName.Ten);
            Assert.AreEqual(1, card.Count);

            card = game.Dealer.Hand.FindAll(i => i.Suit == Suit.Diamonds && i.Name == CardName.Nine);
            Assert.AreEqual(1, card.Count);
        }
    }
}
