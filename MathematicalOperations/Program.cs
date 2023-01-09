

int num1 = 11;
int num2 = 12;


Console.WriteLine($"Addition :{num2+num1}");
Console.WriteLine($"Substraction :{num2 - num1}");
Console.WriteLine($"Multiplication :{num2 * num1}");
Console.WriteLine($"Division :{num2/ num1}");
Console.WriteLine($"Modulus :{num2 % num1}");


num1=num1+ 4;

Console.WriteLine($"New Value of num1 is {num1}");
Console.WriteLine($"Addition :{num2 + num1}");
Console.WriteLine($"Substraction :{num2 - num1}");
Console.WriteLine($"Multiplication :{num2 * num1}");
Console.WriteLine($"Division :{num2 / num1}");
Console.WriteLine($"Modulus :{num2 % num1}");


num1 += 4;
Console.WriteLine($"New Value of num1 is {num1}");
num1 -= 4;
Console.WriteLine($"New Value of num1 is {num1}");
num1 *= 4;
Console.WriteLine($"New Value of num1 is {num1}");
num1 /= 4;
Console.WriteLine($"New Value of num1 is {num1}");
num1 %= 4;
Console.WriteLine($"New Value of num1 is {num1}");