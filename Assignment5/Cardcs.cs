using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

public class Card
{
    public string Value;
    public static string[] SuitsArray = new string[] { "spades", "diamonds", "clubs", "hearts" };
    public string Suit { get; set; }

    public Card(string value, string suit)
    {
        Value = value;
        Suit = suit;

    }



    public static string Cards(string input)
    {
        switch (input)
        {
            case "1":
                input = "Ace";
                break;
            case "11":
                input = "Jack";
                break;
            case "12":
                input = "Queen";
                break;
            case "13":
                input = "King";
                break;
            default:
                input = input;
                break;

        }
        return input;

    }
}