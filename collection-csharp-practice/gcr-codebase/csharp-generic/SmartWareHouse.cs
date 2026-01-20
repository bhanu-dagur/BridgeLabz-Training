using System;
abstract class WarehouseItem
{
    private string name;
    private int quantity;

    public string Name
    {
        get{ return name;}
        set{name=value;}
    }
    // public int Quantity{get=>quantity; set=>quantity=value;}
    public int Quantity
    {
        get{ return quantity;}
        set{quantity=value;}
    }
}
class Electronics : WarehouseItem
{
    public Electronics(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
    
}
class Groceries: WarehouseItem
{
    public Groceries(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
    
}
class Furniture: WarehouseItem
{
    public Furniture(string name,int quantity)
    {
        Name = name;
        Quantity =quantity;
    }
    
}
class Storage<T> where T : WarehouseItem
{
    T [] store;
    public Storage(int size)
    {
        store = new T[size];
    }
    public void Add(T item)
    {
        for(int i=0;i<store.Length;i++)
        {
            if(store[i]==null)
            {
                store[i] = item;
                break;
            }
        }
    }
    public void Display()
    {
        foreach(T item in store)
        {
            if(item==null)
            {
                continue;
            }
            Console.WriteLine(item.Name);
        }
    }
}
class SmartWareHouse
{
    public static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>(5);
        electronicsStorage.Add(new Electronics("Laptop",1));
        electronicsStorage.Add(new Electronics("Mobile",2));
        electronicsStorage.Display();

        Storage<Groceries> groceriesStorage = new Storage<Groceries>(5);
        groceriesStorage.Add(new Groceries("Rice",1));
        groceriesStorage.Add(new Groceries("Sugar",2));
        groceriesStorage.Display();

        Storage<Furniture> furnitureStorage = new Storage<Furniture>(5);
        furnitureStorage.Add(new Furniture("Chair",1));
        furnitureStorage.Add(new Furniture("Table",2));
        furnitureStorage.Display();
    } 
}