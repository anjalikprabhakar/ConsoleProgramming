var addressBook = new AddressBook();




List<Contact> catchedContacts = new List<Contact>();

for (int i = 0; i < 3; i++)
{
    string firstName = string.Empty;
    string lastName = string.Empty;
    string email = string.Empty;
    string phone = string.Empty;



    Console.Write("please enter your Firstname:");
    firstName = Console.ReadLine();
    Console.Write("please enter your Lastname:");
    lastName = Console.ReadLine();
    Console.Write("please enter your email:");
    email = Console.ReadLine();
    Console.Write("please enter your phone number:");
    phone = Console.ReadLine();




    var contact = new Contact(firstName, lastName, email, phone);
    addressBook.AddContact(contact);
    catchedContacts.Add(contact);



}
Console.WriteLine("Printing Contacts");
addressBook.PrintContacts();



Console.WriteLine("Sorting Contacts");
addressBook.SortContacts();




for (int i = 0; i < 3; i++)
{
    Console.WriteLine("removing contacts" + catchedContacts[i]);
    addressBook.RemoveContact(catchedContacts[i]);
    addressBook.PrintContacts();
}
