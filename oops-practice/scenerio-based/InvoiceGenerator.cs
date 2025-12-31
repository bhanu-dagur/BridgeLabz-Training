using System;

class InvoiceGenerator
{
    static void Main()
    {
        InvoiceGenerator ig = new InvoiceGenerator();
        ig.Generate();
    }

    public void Generate()
    {
        Console.WriteLine("ENTER THE INPUTS TO GENERATE INVOICE:");
        string input = Console.ReadLine();
        ParseInvoice(input);
    }

    public void ParseInvoice(string input)
    {
        string[] items = input.Split(',');
        GetTotalAmount(items);
    }

    public void GetTotalAmount(string[] items)
    {
        int total = 0;

        foreach (string item in items)
        {
            // Split by -
            string[] parts = item.Split('-');

            if (parts.Length != 2)
            {
                Console.WriteLine("Invalid format: " + item);
                continue;
            }

            string itemName = parts[0].Trim();
            string pricePart = parts[1].Trim(); // "3000 INR"

            // Split price and currency
            string[] priceDetails = pricePart.Split(' ');

            int price;
            //TryParse safely converts a string to an integer without throwing an exception and return true 
            // and value insert into price variable.
            if (!int.TryParse(priceDetails[0], out price))
            {
                Console.WriteLine("Invalid price for item: " + itemName);
                continue;
            }

            Console.WriteLine(itemName + " : " + price);
            total = total + price;
        }

        Console.WriteLine("TOTAL AMOUNT: " + total);
    }
}
