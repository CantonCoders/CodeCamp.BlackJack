using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    public class Game
    {
        private List<Player> playerList;

        public Game()
        {
            playerList = new List<Player>();
            Dealer = new Dealer();
        }

        public int NumberOfPlayers { get { return playerList.Count;}}

        public Dealer Dealer { get; internal set; }

        internal void AddPlayer(Player player)
        {
            if (playerList.Contains(player))
                throw new Exception("Player already exists.");
            
            playerList.Add(player);
            
                           
        }

        internal void Start()
        {
       
            playerList[0].HandCard(new Card());
            playerList[0].HandCard(new Card());

            Dealer.HandCard(new Card());
            Dealer.HandCard(new Card());
        }
    }
}