namespace CodeCamp.Blackjack.Tests
{
    public enum Rank { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King }
    public enum Suit { Hearts, Diamonds, Clubs, Spades }
    
    public class Card
    {

        public Card(Suit suit, Rank rank)
        {
            this.Rank = rank;     
            this.Suit = suit;
        }

        public Rank Rank { get; }
        public Suit Suit { get; }
    }
}