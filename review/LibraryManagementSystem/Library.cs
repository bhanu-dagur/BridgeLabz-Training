using System.ComponentModel.Design;
using LibraryManagementSystem;

namespace LibraryMangementSystem;

class Library
{
    public static void Main()
    {
        LibraryMenu menu=new LibraryMenu();
        menu.Menu();
    }
}