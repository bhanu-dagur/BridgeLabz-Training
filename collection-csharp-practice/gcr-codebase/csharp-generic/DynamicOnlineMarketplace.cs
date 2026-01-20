using System;
using System.Collections.Generic;

class BookCategory
{
    public string Genre { get; set; }
}

class ClothingCategory
{
    public string Size { get; set; }
}

abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    protected Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public virtual void Display()
    {
        Console.WriteLine("Name: {0}, Price: {1}", Name, Price);
    }
}

class Product<TCategory> : Product
{
    public TCategory Category { get; set; }

    public Product(string name, double price, TCategory category)
        : base(name, price)
    {
        Category = category;
    }

    public override void Display()
    {
        Console.WriteLine(
            "Name: {0}, Price: {1}, Category: {2}",
            Name, Price, Category
        );
    }
}

class DiscountService
{
    public static void ApplyDiscount<T>(T product, double percentage)
        where T : Product
    {
        product.Price -= product.Price * (percentage / 100);
    }
}


class ProductCatalog
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void DisplayAllProducts()
    {
        foreach (var product in products)
        {
            product.Display();
        }
    }
}



class DynamicOnlineMarketPlace
{
    static void Main()
    {
        // Categories
        BookCategory bookCategory = new BookCategory { Genre = "Programming" };
        ClothingCategory clothingCategory = new ClothingCategory { Size = "L" };

        // Products
        Product<BookCategory> book =
            new Product<BookCategory>("C# in Depth", 800, bookCategory);

        Product<ClothingCategory> shirt =
            new Product<ClothingCategory>("T-Shirt", 1200, clothingCategory);

        // Apply Discount (Generic Method)
        DiscountService.ApplyDiscount(book, 10);
        DiscountService.ApplyDiscount(shirt, 20);

        // Catalog
        ProductCatalog catalog = new ProductCatalog();
        catalog.AddProduct(book);
        catalog.AddProduct(shirt);

        Console.WriteLine("=== Online Marketplace Products ===");
        catalog.DisplayAllProducts();
    }
}

