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
            Dealer = new Player();

        }

        public int NumberOfPlayers { get { return playerList.Count;}}

        public Player Dealer { get; internal set; }

        internal void AddPlayer(Player player)
        {
            if (playerList.Contains(player))
                throw new Exception("Player already exists.");
            
            playerList.Add(player);                
        }

        internal void Start()
        {
       
            playerList[0].HandCard(new Card(Suit.Spades, Rank.Ace));
            playerList[0].HandCard(new Card(Suit.Clubs, Rank.Queen));
            Dealer.HandCard(new Card(Suit.Hearts, Rank.Eight));
            Dealer.HandCard(new Card(Suit.Diamonds, Rank.Nine));

        }
    }
}