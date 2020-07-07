namespace CodeCamp.Blackjack.ConsoleApp
{
    public class Card
    {
        public Card()
        {
        }
        public Suit Suit { get; }
        public CardName Name { get; }
        public int PointValue { get; }

        public Card(Suit suit, CardName cardName, int point)
        {
            this.Suit = suit;
            this.Name = cardName;
            this.PointValue = point;
        }

    }
}