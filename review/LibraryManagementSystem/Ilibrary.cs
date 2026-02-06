namespace LibraryManagementSystem;

interface ILibrary
{
    public void AddBook();
    public void DisplayBook();

    public void SearchBook(string title);

    public void UpdateBook(string title);
}