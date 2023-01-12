class Program
{
    static void Main(string[] args)
    {

        Deck.CreateDeck();
        Console.WriteLine("Duck Created");
        Deck.PrintDeck();
        Deck.ChooseRandom();
        Deck.SortDeck();
    }
}