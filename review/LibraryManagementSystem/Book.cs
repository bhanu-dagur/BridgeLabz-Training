namespace LibraryManagementSystem;

class Book
{
    private string title;
    private string author;
    private bool status;

    public Book(string title,string author,bool status)
    {
        this.title=title;
        this.author=author;
        this.status=status;
    }

    public string Title
    {
        get{ return title;}
    }

    public string Author
    {
        get{return author;}
    }

    public bool Status
    {
        get{return status;}
        set{status=value;}
    }

    public override string ToString()
    {
        return "Title: "+title+"\tAuthor: "+author+"\tStatus: "+status;
    }
}