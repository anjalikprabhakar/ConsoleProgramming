

class Deck
{
    public static Card[] deck = new Card[52];
    public static List<string> newCard = new List<string>();

    public static List<string> CreateDeck()
    {
        int index = 0;
        string rank = "";
        foreach (string suit in Card.SuitsArray)
        {
            for (int value = 1; value <= 13; value++)
            {
                string newValue = Convert.ToString(value);
                Card card = new Card(newValue, suit);
                deck[index] = card;
                index++;

            }
        }
        for (int i = 0; i < 52; i++)
        {
            rank = Card.Cards(deck[i].Value);
            newCard.Add($"{rank}-{deck[i].Suit}");
        }
        return newCard;

    }



    public static void ChooseRandom()
    {
        var random = new Random();
        int index = random.Next(52);
        Console.WriteLine($"Your Random Card is {newCard[index]}");

    }


    public static void PrintDeck()
    {
        foreach (string card in newCard)
        {
            Console.WriteLine(card);
        }
    }

    public static void SortDeck()
    {
        List<string> spadeCard = new List<string>();
        List<string> heartCard = new List<string>();
        List<string> diamondCard = new List<string>();
        List<string> clubCard = new List<string>();
        List<string> newLis = new List<string>();

        foreach (string card in newCard)
        {
            if (card.Contains("spade"))
            {

                spadeCard.Add(card);
            }
            if (card.Contains("heart"))
            {

                heartCard.Add(card);
            }
            if (card.Contains("diamond"))
            {

                diamondCard.Add(card);
            }
            if (card.Contains("club"))
            {

                clubCard.Add(card);
            }
        }

    }

}