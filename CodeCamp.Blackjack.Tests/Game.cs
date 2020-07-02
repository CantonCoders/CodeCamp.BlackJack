using System;

namespace CodeCamp.Blackjack.Tests
{
    public class Game
    {
        public Game()
        {
        }

        public int NumberOfPlayers { get; internal set; }

        internal void AddPlayer(Player player)
        {
            NumberOfPlayers += 1;
        }
    }
}