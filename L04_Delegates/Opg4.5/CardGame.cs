namespace L04.Delegates.Opg4._5;

public class CardGame
{
    private List<Card> cards = [];

    public CardGame()
    {
        for (var i = 0; i < 4; i++)
        {
            for (var j = 0; j < 13; j++)
            {
                cards.Add(new Card((Suit) i, (Number) j));
            }
        }
    }

    public List<Card> Cards => cards;

    public void AddCard(Suit suit, Number number)
    {
        cards.Add(new Card(suit, number));
    }

    public List<Card> filterCardGame(FilterCardDelegate filter)
    {
        var result = new List<Card>();
        
        foreach (var card in cards)
        {
            if (!filter(card)) continue;
            result.Add(card);
        }

        return result;
    }

}

public delegate bool FilterCardDelegate(Card card);