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

        public int NumberOfPlayers { get; internal set; }

        internal void AddPlayer(Player player)
        {
            if (!playerList.Contains(player))
            {
                playerList.Add(player);
                NumberOfPlayers += 1;
            }
            else
            {
                throw new Exception("Player already exists.");
            }
               
        }
    }
}