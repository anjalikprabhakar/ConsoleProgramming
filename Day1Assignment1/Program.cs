

// user enter two numbers and print their sum and product on screen

int num1 = 0;
int num2 = 0;

Console.WriteLine("Enter the first Number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Second Number");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of given numbers is  {num1+num2} ");
Console.WriteLine($"Product of given numbers is  {num1 * num2} ");



// Implement the equation (((a + b) / c) * a)


int a = 0;
int b = 0;
int c = 0;
Console.WriteLine("Enter 3 numbers a,b,c");

Console.WriteLine("a =");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("b = ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("c = ");
c = Convert.ToInt32(Console.ReadLine());


if (c== 0)
{
    Console.WriteLine("c can not be zero");
}
else
{
    Console.WriteLine($"The Result is {(((a + b) / c) * a)}");
}



// Fortune- Guess the Number

int fortuneNumber = 10;
int guess = 0;
int maxguessess = 5;
for (int i =1; i <= maxguessess; i++)
{
    Console.Write(" Guess A Number between 0-100  ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (i == maxguessess)
    {
        Console.WriteLine($"Your Lost");
        break;
    }
    else if (guess == fortuneNumber)
    {
        Console.WriteLine("You Win");
        break;
    }
    else if (guess>100 || guess<0)
    {
        Console.WriteLine("Guess A Number between 0-100");
    }
    else if (guess < fortuneNumber)
    {
        Console.WriteLine("Guessed number is greater than Original Number");
    }
    else if (guess > fortuneNumber)
    {
        Console.WriteLine("Guessed number is lower than Original Number");
    }
    Console.WriteLine($"guesses remaining is {i}");
}


