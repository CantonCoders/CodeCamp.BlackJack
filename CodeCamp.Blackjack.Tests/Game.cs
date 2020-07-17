using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    public enum GameState {
        New,
        Finished,
       
    }
    public class Game
    {
        private List<Player> playerList;

        public Game()
        {
            playerList = new List<Player>();
            Dealer = new Player("Dealer");

        }

        public GameState State { get; internal set; }
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

        public Player Winner { get; internal set; }

        internal void Stay()
        {
            State = GameState.Finished;
            Winner = playerList[0];
        }

        internal void Hit()
        {
            State = GameState.Finished;
            Winner = Dealer;
        }
    }
}