using System;
using System.Collections.Generic;
interface IDiscountable
{
    double ApplyDiscount();
    string GetDiscountDetails();
}

abstract class FoodItem
{
    // Encapsulation: protected fields
    protected string itemName;
    protected double price;
    protected int quantity;

    public FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }
    public abstract double CalculateTotalPrice();

    public void GetItemDetails()
    {
        Console.WriteLine("Item Name : " + itemName);
        Console.WriteLine("Price    : " + price);
        Console.WriteLine("Quantity : " + quantity);
    }
}

class VegItem : FoodItem, IDiscountable
{
    public VegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        return price * quantity;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.10; 
    }

    public string GetDiscountDetails()
    {
        return "10% discount on Veg items";
    }
}

class NonVegItem : FoodItem, IDiscountable
{
    public NonVegItem(string name, double price, int quantity)
        : base(name, price, quantity) { }

    public override double CalculateTotalPrice()
    {
        double basePrice = price * quantity;
        double extraCharge = basePrice * 0.05; 
        return basePrice + extraCharge;
    }

    public double ApplyDiscount()
    {
        return CalculateTotalPrice() * 0.05; 
    }

    public string GetDiscountDetails()
    {
        return "5% discount on Non-Veg items";
    }
}

class OnlineFoodDeliverySystem
{
    static void Main()
    {
        // Polymorphism: base class reference
        List<FoodItem> items = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 300, 1),
            new VegItem("Veg Burger", 120, 3)
        };

        foreach (FoodItem item in items)
        {
            item.GetItemDetails();

            double totalPrice = item.CalculateTotalPrice();
            double discount = 0;

            // Interface-based polymorphism
            if (item is IDiscountable)
            {
                IDiscountable discountable = (IDiscountable)item;
                discount = discountable.ApplyDiscount();
                Console.WriteLine(discountable.GetDiscountDetails());
            }

            double finalPrice = totalPrice - discount;

            Console.WriteLine("Total Price : " + totalPrice);
            Console.WriteLine("Discount    : " + discount);
            Console.WriteLine("Final Price : " + finalPrice);
            Console.WriteLine("----------------------------------");
        }
    }
}
