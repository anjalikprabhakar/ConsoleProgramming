
CartEntries cartEntries = new CartEntries();
ShoppingCart shoppingCart = new ShoppingCart();
class Order

{
    static void Main()
    {
        CartEntries cartEntries = new CartEntries();
        ShoppingCart shoppingCart = new ShoppingCart();
        cartEntries.Entries();
        double tax = 0.1;
        double totalAmount = 0;
        double totalTaxAmount = 0.0;
        if (cartEntries.item1Qty != 0)
        {
            Console.WriteLine($"{shoppingCart.item1} -  {shoppingCart.priceItem1}  * {cartEntries.item1Qty}  ");
            totalAmount += shoppingCart.priceItem1 * cartEntries.item1Qty;
            totalTaxAmount += (shoppingCart.priceItem1 * cartEntries.item2Qty * tax);

        }
        if (cartEntries.item2Qty != 0)
        {
            Console.WriteLine($"{shoppingCart.item2} -  {shoppingCart.priceItem2}  * {cartEntries.item2Qty}  ");
            totalAmount += shoppingCart.priceItem2 * cartEntries.item2Qty;
            totalTaxAmount += (shoppingCart.priceItem2 * cartEntries.item2Qty * tax);
        }
        if (cartEntries.item3Qty != 0)
        {
            Console.WriteLine($"{shoppingCart.item3}   {shoppingCart.priceItem1}  * {cartEntries.item3Qty}  ");
            totalAmount += shoppingCart.priceItem3 * cartEntries.item3Qty;
            totalTaxAmount += (shoppingCart.priceItem3 * cartEntries.item3Qty * tax);
        }
        else
            Console.WriteLine($"total amount     {totalAmount}  ");
        Console.WriteLine($"total payable    {totalAmount - totalTaxAmount}  ");
    }
}


