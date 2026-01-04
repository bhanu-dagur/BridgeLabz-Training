using System;
class Product
{
    static double Discount = 0.1; // 10% discount
    public readonly string ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(string productID, string productName, double price, int quantity)
    {
        this.ProductID = productID;
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;
    }

    public double CalculateTotalPrice()
    {
        double total = Price * Quantity;
        return total - (total * Discount);
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount updated to: " + (Discount * 100) + "%");
    }
}
class ShoppingCartSystem
{
    public static void Main()
    {
        Product product1 = new Product("1", "Laptop", 1000.0, 2);
        Product product2 = new Product("2", "Smartphone", 500.0, 3);

        if (product1 is Product)
        {
            Console.WriteLine("Product 1 Total Price after discount: " + product1.CalculateTotalPrice());
        }

        if (product2 is Product)
        {
            Console.WriteLine("Product 2 Total Price after discount: " + product2.CalculateTotalPrice());
        }

        Product.UpdateDiscount(0.15); // Update discount to 15%

        if (product1 is Product)
        {
            Console.WriteLine("Product 1 Total Price after updated discount: " + product1.CalculateTotalPrice());
        }

        if (product2 is Product)
        {
            Console.WriteLine("Product 2 Total Price after updated discount: " + product2.CalculateTotalPrice());
        }
    }
}