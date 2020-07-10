using System;
using System.Collections.Generic;

namespace CodeCamp.Blackjack.Tests
{
    internal class CardShuffler
    {
        public CardShuffler()
        {
        }

        public List<Card> BuildDeck()
        {
            var cards= new List<Card>();
            //HDCS
            //cards[0] = "AH";
            //"AH","2H","3H","4H","5H","6H","7H","8H","9H","10H","JH","QH","KH","AD","2D","3D","4D","5D","6D","7D","8D","9D","10D","JD","QD","KD","AH","2H","3H","4H","5H","6H","7H","8H","9H","10H","JH","QH","KH","AH","2H","3H","4H","5H","6H","7H","8H","9H","10H","JH","QH","KH",
            foreach(Suit currentSuit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank currentRank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(currentSuit, currentRank));
                }
            }
            
            return cards;



        }
    }
}