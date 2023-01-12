
public class AddressBook
{
    public readonly List<Contact> _contact;
    public AddressBook()
    {
        _contact = new List<Contact>();
    }
    public void AddContact(Contact contact)
    {
        _contact.Add(contact);
    }
    public void RemoveContact(Contact contact)
    {
        _contact.Remove(contact);
    }
    public void SortContacts()
    {



        IEnumerable<Contact> sortedContacts = _contact.OrderByDescending(name => name.firstName).ToList();
        foreach (Contact contact in sortedContacts)



        {
            Console.WriteLine(contact);
        }
    }
    public void PrintContacts()
    {
        foreach (var item in _contact)
        {
            Console.WriteLine(item);
        }
    }




}
