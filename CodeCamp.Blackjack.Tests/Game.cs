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

        }

        public int NumberOfPlayers { get { return playerList.Count;}}

        internal void AddPlayer(Player player)
        {
            if (playerList.Contains(player))
                throw new Exception("Player already exists.");
            
            playerList.Add(player);
            
                           
        }
    }
}