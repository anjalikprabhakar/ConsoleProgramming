
Console.WriteLine("Welcome");

int cardNumber = 12345;
int pinNumber = 1234;
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
        Console.WriteLine("Thank you! your Transaction is Cancelled");
        return false;
    }
    else
    {
        return true;
    }
}

bool validation = InputValidation(inputCardNumber, inputPinNumber);

int AtmFunctionMenu(bool valid)
{
    int choice = 0;
    if (valid is true)
    {
        while (choice != 4)
        {
            Console.WriteLine("Helllo!");
            Console.WriteLine("To check balance Press 1");
            Console.WriteLine("To withdraw money Press 2");
            Console.WriteLine("To deposite Money  Press 3");
            Console.WriteLine("To Cancel Press 4");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1 || choice == 2 || choice == 3)
            {
                return choice;
            }

        }
        Console.WriteLine("Thank you! your Transaction is Cancelled");
    }
    return choice;
}

int choice = AtmFunctionMenu(validation);
void Withdraw()
{

    {
        try
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
        catch (Exception e)
        {

            Console.WriteLine($"Illegal operation");
            Console.WriteLine("Thank you! your Transaction is Cancelled");
        }
    }
}

void Deposit()
{
    {
        try
        {
            Console.WriteLine("Enter the Amount To deposit");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Available Balance is {balance + amount}");

        }
        catch (Exception ex)
        {

            Console.WriteLine("Invalid Input");
            Console.WriteLine("Thank you! your Transaction is Cancelled");
        }
    }
}
void AtmOperations(int choice)
{
    switch (choice)
    {
        case 1:
            Console.WriteLine($"Your Balance is  {balance}");
            break;
        case 2:
            Withdraw();
            break;
        case 3:
            Deposit();
            break;
    }
}

AtmOperations(choice);