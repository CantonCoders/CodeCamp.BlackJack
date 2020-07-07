using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Game
    {
        private List<Player> playerList;
        private List<Card> GameDeck;

        public Game()
        {
            playerList = new List<Player>();
            Dealer = new Player();
        }

        public int NumberOfPlayers { get { return playerList.Count;} }

        public Player Dealer { get; internal set; }

        public void AssignDealerDeck(List<Card> cards)
        {
            GameDeck = cards;
        }

        public void AddPlayer(Player player)
        {
            if (playerList.Contains(player))
                throw new Exception("Player already exists.");
            
            playerList.Add(player);            
        }

        public void Start()
        {
            for(var i = 0; i < 2; i++)
            {
                DealCard(playerList[0]);
                DealCard(Dealer);
            }
        }

        public void Hit()
        {
            DealCard(playerList[0]);
        }

        public void DealCard(Player player)
        {
            player.Deal(GameDeck[0]);
            GameDeck.RemoveAt(0);
        }
    }
}