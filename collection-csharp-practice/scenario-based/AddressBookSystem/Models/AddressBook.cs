using System.Dynamic;

class AddressBook{
    public string Name;
    public List<Contact> Contacts;
    public AddressBook(string name){
        this.Name = name;
        this.Contacts = new List<Contact>();
    }

    
}