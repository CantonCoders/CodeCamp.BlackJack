namespace CodeCamp.Blackjack.Tests
{
    public enum Rank : int { Ace = 11, Two = 2, Three = 3, Four = 4, 
        Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10,
        Jack = 10, Queen = 10, King = 10 }
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
        public int PointValue { get { return (int)Rank; } }

        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   Rank == card.Rank &&
                   Suit == card.Suit;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Rank + " of " + Suit;
        }
    }
}