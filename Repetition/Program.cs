

for (int i = 0; i < 10; i++) 
{
    Console.WriteLine(i);
}

Console.WriteLine();
Console.WriteLine("for loop exit");

int n = 5;
while(n <= 5)
{ 
    Console.WriteLine("Enter value for n");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Inside loop {n}");
}
Console.WriteLine();
Console.WriteLine("while loop exit");



int j= 10;
do
{
    Console.WriteLine("Enter value for j");
    j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Inside loop {j}");

}while(j < 5);
Console.WriteLine();
Console.WriteLine(" do while loop exit");
