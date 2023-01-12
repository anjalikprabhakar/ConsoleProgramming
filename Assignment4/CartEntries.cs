

public class CartEntries
{


    public string choice = "y";
    public int item1Qty { get; set; }
    public int item2Qty { get; set; }
    public int item3Qty { get; set; }
    public void Entries()
    {
        ShoppingCart shoppingCart = new ShoppingCart();
        while (choice == "y")
        {
            Console.WriteLine("what do u like to order");
            Console.WriteLine($"{shoppingCart.item1} - {shoppingCart.priceItem1} Rs/-  PRESS 1 TO ORDER");
            Console.WriteLine($"{shoppingCart.item2} - {shoppingCart.priceItem2} Rs/-  PRESS 2 TO ORDER");
            Console.WriteLine($"{shoppingCart.item3} - {shoppingCart.priceItem3} Rs/-  PRESS 3 TO ORDER");
            string item = Console.ReadLine();
            switch (item)
            {
                case "1":
                    Console.WriteLine("Please enter required quqntity");
                    int qty1 = Convert.ToInt32(Console.ReadLine());
                    item1Qty += qty1;
                    break;

                case "2":

                    Console.WriteLine("Please enter required quqntity");
                    int qty2 = Convert.ToInt32(Console.ReadLine());
                    item2Qty += qty2;
                    break;


                case "3":
                    Console.WriteLine("Please enter required quqntity");
                    int qty3 = Convert.ToInt32(Console.ReadLine());
                    item3Qty += qty3;
                    break;
                default:
                    Console.WriteLine("please choose a valid item");
                    break;
            }
            Console.WriteLine("Do you like to add more(y/n)");
            choice = Convert.ToString(Console.ReadLine());

        }
    }
}