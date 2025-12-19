using System;

class TotalPrice
{
    public static void Main(String []args)
    {
        double unitPrice;
        int quantity;
        double totalPrice;

        Console.Write("Enter unit price: ");
        unitPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter quantity: ");
        quantity = Convert.ToInt32(Console.ReadLine());

        totalPrice = unitPrice * quantity;

        Console.WriteLine("The total purchase price is " + totalPrice +
                          " if the quantity " + quantity +
                          " and unit price is " + unitPrice);
    }
}
