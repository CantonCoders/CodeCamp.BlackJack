namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Card
    {
        public Card()
        {
        }
        public Suit Suit { get; }
        public CardName Name { get; }
        public Card(Suit suit, CardName cardName)
        {
            this.Suit = suit;
            this.Name = cardName;
        }

    }
}