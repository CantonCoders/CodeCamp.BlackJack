using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Game
    {
        private List<Player> playerList;

        public Game()
        {
            playerList = new List<Player>();
            Dealer = new Dealer();
        }

        public int NumberOfPlayers { get { return playerList.Count;} }

        public Dealer Dealer { get; internal set; }

        public void AddPlayer(Player player)
        {
            if (playerList.Contains(player))
                throw new Exception("Player already exists.");
            
            playerList.Add(player);            
        }

        public void Start()
        {
            /*TODO REDUCE THESE LINES AND CREATE A OVERLOAD TO SAVE NUMBER OF OBJECTS WE GIVE.*/
            playerList[0].HandCard(new Card());
            playerList[0].HandCard(new Card());

            Dealer.HandCard(new Card());
            Dealer.HandCard(new Card());
        }
    }
}