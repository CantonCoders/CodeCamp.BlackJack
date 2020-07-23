using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    public enum GameState
    {
        New,
        Finished,

    }
    public class Game
    {
        private List<Player> playerList;
        private List<Card> deck;

        public Game()
        {
            playerList = new List<Player>();
            Dealer = new Player("Dealer");

        }

        public GameState State { get; internal set; }
        public int NumberOfPlayers { get { return playerList.Count; } }

        public Player Dealer { get; internal set; }

        internal void AddPlayer(Player player)
        {
            if (playerList.Contains(player))
                throw new Exception("Player already exists.");

            playerList.Add(player);
        }

        internal void Start()
        {
            for (var i = 0; i < 2; i++)
            {
                foreach (var player in playerList)
                {
                    player.HandCard(deck[0]);
                    deck.RemoveAt(0);
                }

                Dealer.HandCard(deck[0]);
                deck.RemoveAt(0);
            }
            CurrentPlayerIndex = 0;
        }

        internal void Start(List<Card> deck)
        {
            this.deck = deck;
            Start();
        }

        public Player Winner { get; internal set; }
        public Player PlayerTurn { get { return playerList[CurrentPlayerIndex]; } }

        internal void Stay()
        {
            State = GameState.Finished;
            Winner = playerList[0];
            NextPlayer();
        }

        private int CurrentPlayerIndex = 0;

        internal void Hit()
        {
            PlayerTurn.HandCard(deck[0]);
            deck.RemoveAt(0);
            State = GameState.Finished;
            Winner = Dealer;
            NextPlayer();

        }

        private void NextPlayer()
        {
            CurrentPlayerIndex++;
            if (CurrentPlayerIndex >= NumberOfPlayers)

                CurrentPlayerIndex = 0;
        }
    }
}