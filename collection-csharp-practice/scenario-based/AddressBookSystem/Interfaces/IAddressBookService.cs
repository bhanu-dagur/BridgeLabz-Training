interface IAddressBookService
{
    void CreateAddressBook(string name);
    void AddContact(string bookName);
    void EditContact(string bookName);
    void DeleteContact(string bookName);
    void DisplayContacts(string bookName);
    void SearchByCityOrState(string search);
    void ViewByCityOrState();
    void CountByCityOrState(string search);
    void SortByName(string bookName);
    void SortByCityStateOrZip(string bookName, string field);
    
}