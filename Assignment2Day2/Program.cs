Console.WriteLine("Welcome");

int cardNumber = 12345;
int pinNumber = 1234;
string name = "name";
int balance = 10000;

Console.WriteLine("Enter Your 5 Digit ATM CARD Number");
int inputCardNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Enter Your 4 Digit PIN Number");
int inputPinNumber = Convert.ToInt32(Console.ReadLine());

bool InputValidation(int inputCardNumber, int inputPinNumber)
{
    if (inputPinNumber.ToString().Length != 4)
    {
        Console.WriteLine("User pin must be a 4 digit value");
        return false;
    }
    else if (inputCardNumber.ToString().Length != 5)
    {
        Console.WriteLine("ATM pin must be a 5 digit value");
        return false;
    }
    else if (inputCardNumber != cardNumber && pinNumber != inputPinNumber)
    {
        Console.WriteLine("Invalid credentials");
        return false;
    }
    else
    {
        return true;
    }
}

bool validation = InputValidation(inputCardNumber, inputPinNumber);
Console.WriteLine(validation);

int AtmFunction(bool valid)
{
    int choice = 0;
    if (valid is true)
    {
        Console.WriteLine($"Helllo {name} !");
        Console.WriteLine("To check balance Press 1");
        Console.WriteLine("To withdraw money Press 2");
        Console.WriteLine("To deposite Money  Press 3");
        Console.WriteLine("To Cancel Press 4");

        choice = Convert.ToInt32(Console.ReadLine());
    }
    return choice;
}
int choice = AtmFunction(validation);
void CheckBalaance(int choice)
{
    if (choice == 1)
    {

        Console.WriteLine($"Your Balance is{balance}");
    }
}
CheckBalaance(choice);
void Withdraw(int choice)
{ if (choice == 2)
    {
        Console.WriteLine("Enter the Amount To withdraw");
        int amount = Convert.ToInt32(Console.ReadLine());
        if (amount > balance)
        {
            Console.WriteLine("Insufficient Balance ");
        }
        else
        {
            Console.WriteLine("Please Collect the cash");
            Console.WriteLine($"Your Available Balance is {balance - amount}");
        }
    }
}
Withdraw(choice);

void Deposit(int choice){
    if (choice == 3)
    {
        Console.WriteLine("Enter the Amount To deposit");
        int amount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your Available Balance is {balance + amount}");

    }
}

Deposit(choice);    

void CancelTransaction(int choice, bool validation)
{
    if ((choice==4) ||(validation==false))
    {
        Console.WriteLine("Thank you! your Transaction is Cancelled");
    }
}

CancelTransaction(choice,validation);  