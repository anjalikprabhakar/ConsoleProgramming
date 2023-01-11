
class AddressBook
{
    public void AddDetails()
    {
        Contact contact = new Contact();
        Dictionary<string, string> person1 = new Dictionary<string, string>();
        person1.Add("name", "Annie");
        person1.Add("phone", "999999999");
        person1.Add("email", "annie@gmail.com");


        Dictionary<string, string> person2 = new Dictionary<string, string>();
        person2.Add("name", "Xavy");
        person2.Add("phone", "12334567678");
        person2.Add("email", "xavi@gmail.com");

        List<Dictionary<string, string>> contactList = new List<Dictionary<string, string>>();
        contactList.Add(person1);
        contactList.Add(person2);
        Dictionary<string, string> contactDetails = new Dictionary<string, string>();
        contact.ContactDetails();
        contactDetails.Add("name", contact.firstName + "" + contact.lastName);
        contactDetails.Add("phone", contact.phone);
        contactDetails.Add("email", contact.email);
    }
}