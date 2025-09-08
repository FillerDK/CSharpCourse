namespace L04.Delegates.Opg4._5;

public class Card
{
    public Suit Suit { get; }
    public Number Number { get; }

    public Card(Suit suit, Number number)
    {
        Suit = suit;
        Number = number;
    }
    
    public override string ToString()
    {
        return string.Format($"{Suit} {Number}");
    }
}

public enum Suit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum Number
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}