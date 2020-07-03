namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Card
    {
        public Card()
        {
        }
        public Suit Suit { get; internal set; }

        public Card(Suit suit)
        {
            this.Suit = suit;
        }

    }
}