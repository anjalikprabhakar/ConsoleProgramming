

Console.WriteLine("enter the number of Apples : ");
int Apples = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of Oranges : ");
int oranges = Convert.ToInt32(Console.ReadLine());


if (Apples > oranges)
{
    Console.WriteLine("more Apples than oranges");
}
else if (Apples < oranges)
{
    Console.WriteLine("more oranges than Apples");
}
else if (Apples == oranges)
{
    Console.WriteLine(" oranges and Apples are equal");
}
else
{
    Console.WriteLine("Invalid");
}


//switch


Console.WriteLine("Enter your mark (0-100) ");
int marks=Convert.ToInt32(Console.ReadLine());

switch(marks)
{

    case int n when (n < 50):
        Console.WriteLine("you are failed");
        break;
    case int n when (n>= 50 && n <= 100):
        Console.WriteLine("you are passed");
        break;
    default:
        Console.WriteLine("invalid marks entered");
        break;


}



string message = oranges > Apples ? "More Oranges" : "More Apples";

Console.WriteLine(message);