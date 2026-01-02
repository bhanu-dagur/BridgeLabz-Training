using System;
class Book{
    string title="java";
    string author="bhanu";
    int price=150;

    public void Display(){
        Console.WriteLine("Details of the book ");
        Console.WriteLine("Title of the book is : "+ title);
        Console.WriteLine("Author of the book is : "+ author);
        Console.WriteLine("Price of the book is : "+ price);
    }
}
class BookDetails{
    public static void Main(){
        Book obj=new Book();
        obj.Display();
    }
}