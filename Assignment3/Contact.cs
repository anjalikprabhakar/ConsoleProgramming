

class Contact
{
    public string firstName { get; set; }
    public string lastName { get; set; }

    public string email { get; set; }

    public string phone { get; set; }


    public void ContactDetails()
    {
        Console.WriteLine("Please Enter Your First Name");
        firstName = Console.ReadLine();
        Console.WriteLine("Please Enter Your Last Name");
        lastName = Console.ReadLine();
        Console.WriteLine("Please Enter Your Phone Number");
        phone = Console.ReadLine();
        Console.WriteLine("Please Enter Your Email");
        email = Console.ReadLine();
    }
}