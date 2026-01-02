using System;
class BookDetails{
    string title;
    string author;
    int price;
    //default constructor
    public BookDetails(){
        title="java"    ;
        author="devansh";
        price=150;
    }
    //parameterized constructor
    public BookDetails(string title,string author,int price){
        this.title=title;
        this.author=author;
        this.price=price;
    }

    public void Display(){
        Console.WriteLine("Details of the BookDetails ");
        Console.WriteLine("Title of the BookDetails is : "+ title);
        Console.WriteLine("Author of the BookDetails is : "+ author);
        Console.WriteLine("Price of the BookDetails is : "+ price);
    }
}
class s{
    public static void Main(){
        BookDetails ob1=new BookDetails();
        BookDetails obj2=new BookDetails("C# Programming","John Doe",250);
        Console.WriteLine("Displaying default constructor values:");
        ob1.Display();
        Console.WriteLine("===================================");
        Console.WriteLine("Displaying parameterized constructor values:");
        obj2.Display();
    }
}