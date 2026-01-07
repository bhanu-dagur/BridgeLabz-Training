using System;
abstract class Product
{
    private int productId;
    private string name;
    private double price;

    public Product(int productId, string name, double price)
    {
        this.productId = productId;
        this.name = name;
        this.price = price;
    }

    public int ProductId
    {
        get { return productId; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Product ID   : " + productId);
        Console.WriteLine("Product Name : " + name);
        Console.WriteLine("Product Price: " + price);
    }

    public abstract double CalculateDiscount();
}

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }

    public double CalculateTax()
    {
        return Price * 0.18;
    }

    public string GetTaxDetails()
    {
        return "18% tax on Electronics";
    }
}

class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.20;
    }

    public double CalculateTax()
    {
        return Price * 0.12;
    }

    public string GetTaxDetails()
    {
        return "12% tax on Clothing";
    }
}
class Groceries : Product
{
    public Groceries(int id, string name, double price)
        : base(id, name, price) { }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}

class EcommercePlatform
{
    static void Main()
    {
        Product[] products =
        {
            new Electronics(101, "Laptop", 50000),
            new Clothing(102, "Shirt", 1000),
            new Groceries(103, "Rice", 500)
        };

        foreach (Product product in products)
        {
            product.DisplayDetails();

            double discount = product.CalculateDiscount();
            double tax = 0;

            if (product is ITaxable)
            {
                ITaxable taxable = (ITaxable)product;
                tax = taxable.CalculateTax();
                Console.WriteLine(taxable.GetTaxDetails());
            }


            double finalPrice = product.Price - discount + tax;

            Console.WriteLine("Discount    : " + discount);
            Console.WriteLine("Tax         : " + tax);
            Console.WriteLine("Final Price : " + finalPrice);
            Console.WriteLine("----------------------------");
        }
    }
}
