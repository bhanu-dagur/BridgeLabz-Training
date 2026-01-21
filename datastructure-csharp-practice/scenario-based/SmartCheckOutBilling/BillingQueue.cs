using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Customer
{
    private string name;
    private List<string> items;

    public string Name
    {
        get{return name;}
        set{name = value;}
    }
    public List<string> Items
    {
        set{items=value;}
        get{return items;}
    }

}

class SmartCheckout
{
    Queue<Customer> queue=new Queue<Customer>();
    Dictionary<String,int> prices=new Dictionary<string,int>();
    Dictionary<String,int> stocks=new Dictionary<string,int>();

    public SmartCheckout()
    {
        prices.Add("milk",70);
        prices.Add("sugar",40);
        prices.Add("biscuits",10);
        prices.Add("chocalate",30);
        prices.Add("tea",20);
        prices.Add("coffee",30);

        stocks.Add("milk",2);
        stocks.Add("sugar",1);
        stocks.Add("biscuits",3);
        stocks.Add("chocalate",4);
        stocks.Add("tea",2);
        stocks.Add("coffee",1);
    }

    public void AddCustomer(Customer customer)
    {
        queue.Enqueue(customer);
        Console.WriteLine(customer.Name +" added to queue");
    }

    public void ProcessCustomer()
    {
        Console.WriteLine("-----------------------------------");
        if(queue.Count==0)
        {
            Console.WriteLine("Queue is empty, No customer is to billing");
            return;
        }
        Customer customer=queue.Dequeue();

        Console.WriteLine(customer.Name +" process for billing");

        double total=0;
        for(int i = 0; i < customer.Items.Count; i++)
        {
            string item=customer.Items[i];
            if (!prices.ContainsKey(item))
            {
                Console.WriteLine(item +" : Not available");
                continue;
            }
            if (stocks[item] <= 0)
            {
               Console.WriteLine(item +" : Out of stock"); 
               continue;
            }
            total+=prices[item];
            stocks[item]-=1;

            Console.WriteLine(item+" : "+prices[item]);
        }
        Console.WriteLine("Total bill is  "+total);
        
    }

}

class BillingQueue
{
    public static void Main()
    {
        SmartCheckout checkout=new SmartCheckout();
        Customer c1=new Customer();
        c1.Name="Bhanu";
        c1.Items=new List<string>(){"milk","sugar","biscuits","chocalate"};

        Customer c2=new Customer();
        c2.Name="Devesh";
        c2.Items=new List<string>(){"sugar","tea","coffee","namkeen"};

        checkout.AddCustomer(c1);
        checkout.AddCustomer(c2);
        Console.WriteLine("\nBills are processing");
        checkout.ProcessCustomer();
        checkout.ProcessCustomer();
    }
}