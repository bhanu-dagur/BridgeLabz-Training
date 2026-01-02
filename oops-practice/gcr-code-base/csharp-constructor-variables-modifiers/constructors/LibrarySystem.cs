using System;
class Library{
    string title, author, price, availability;
    public Library(string title, string author, string price, string availability){
        this.title=title;
        this.author=author;
        this.price=price;
        this.availability=availability;
    }
    public void borrowBook(){
        if(availability=="yes"){
            Console.WriteLine("You have successfully borrowed the book: "+title);
            availability="no";
        }
        else{
            Console.WriteLine("Sorry, the book: "+title+" is currently not available.");
        }
    }
}
public class LibrarySystem{
    public static void Main(){
        Library book1=new Library("C# Programming","John Doe","250","yes");
        book1.borrowBook();
        book1.borrowBook();
    }
}