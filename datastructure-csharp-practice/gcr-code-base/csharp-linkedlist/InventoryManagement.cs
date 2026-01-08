using System;
class InventoryNode
{
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public InventoryNode Next { get; set; }

    public InventoryNode(int id, string name, int quantity, double price)
    {
        ItemId = id;
        ItemName = name;
        Quantity = quantity;
        Price = price;
    }

}
// Singly Linked List
class InventoryList
{
    public InventoryNode head=null;
    public void DisplayInventory()
    {
        InventoryNode temp=head;
        while (temp != null)
        {
            Console.WriteLine("Item ID: " + temp.ItemId + ", Item Name: " + temp.ItemName + ", Quantity: " + temp.Quantity + ", Price: " + temp.Price);
            temp=temp.Next;
        }
    }

    public void AddAtstart(InventoryNode node)
    {
        if(head == null)
        {
            head=node;
        }
        else
        {
            node.Next=head;
            head=node;
        }
    }
    public void AddAtEnd(InventoryNode node)
    {
        if(head == null)
        {
            head=node;
        }
        else
        {
            InventoryNode temp=head;
            while (temp.Next != null)
            {
                temp=temp.Next;
            }
            temp.Next=node;
        }
    }
    public void AddAtSpecificPosition(InventoryNode node, int position)
    {
        if (position == 1)
        {
            AddAtstart(node);
            return;
        }

        InventoryNode temp = head;

        for (int i = 1; i < position - 1 && temp != null; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Invalid Position");
            return;
        } 

        node.Next = temp.Next;
        temp.Next = node;
    }

    public void RemovedItem(int id)
    {
        if (head.ItemId == id)
        {
            head=head.Next;
            Console.WriteLine("Item removed");
        }
        InventoryNode temp=head;
        while (temp.Next!= null && temp.Next.ItemId != id)
        {
            temp=temp.Next;
        }
        if (temp.Next == null)
        {
            Console.WriteLine("Intem not found");
        }
        temp.Next=temp.Next.Next;
        Console.WriteLine("Intem is removed");
    }
    public void UpdateItem(int id, int quantity)
    {
        if (head.ItemId == id)
        {
            head.Quantity=quantity;
            Console.WriteLine("Quantity updated");
        }
        InventoryNode temp=head;
        while (temp.Next!= null && temp.Next.ItemId != id)
        {
            temp=temp.Next;
        }
        if (temp.Next == null)
        {
            Console.WriteLine("Intem not found");
        }
        temp.Next.Quantity=quantity;
        Console.WriteLine("Quantity updated");
    }
    public void SearchItem(int id)
    {
        if (head.ItemId == id)
        {
            Console.WriteLine("Item found");
        }
        InventoryNode temp=head;
        while (temp.Next!= null && temp.Next.ItemId != id)
        {
            temp=temp.Next;
        }
        if (temp.Next == null)
        {
            Console.WriteLine("Intem not found");
        }
        Console.WriteLine("Item found");
    }
    public void CalculateTotalValue()
    {
        double totalValue = 0;
        InventoryNode temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("Total value of inventory: " + totalValue);
    }
    public void SortInventoryByName()
    {
        InventoryNode temp = head;
        InventoryNode prev = null;
        while (temp != null)
        {
            InventoryNode minNode = temp;
            InventoryNode minPrev = prev;
            InventoryNode curr = temp.Next;
            while (curr != null)
            {
                if (curr.ItemName.CompareTo(minNode.ItemName) < 0)
                {
                    minNode = curr;
                    minPrev = prev;
                }
                curr = curr.Next;
            }
            if (minNode != temp)
            {
                if (minPrev == null)
                {
                    head = minNode;
                }
                else
                {
                    minPrev.Next = minNode;
                }
                temp.Next = minNode.Next;
                minNode.Next = temp;
            }
            prev = temp;
            temp = temp.Next;
        }
    }
}
class InventoryManagement
{
    static void Main()
    {
        InventoryList list = new InventoryList();
        InventoryNode node1 = new InventoryNode(1, "Item 1", 10, 100.0);
        InventoryNode node2 = new InventoryNode(2, "Item 2", 5, 50.0);
        InventoryNode node3 = new InventoryNode(3, "Item 3", 15, 150.0);
        InventoryNode node4 = new InventoryNode(4, "Item 4", 20, 200.0);
        InventoryNode node5 = new InventoryNode(5, "Item 5", 8, 80.0);
        list.AddAtstart(node1);
        list.AddAtEnd(node2);
        list.AddAtSpecificPosition(node3, 3);
        list.AddAtSpecificPosition(node4, 2);
        list.AddAtSpecificPosition(node5, 1);
        list.DisplayInventory();
        list.RemovedItem(2);
        list.DisplayInventory();
        list.UpdateItem(3, 18);
        list.DisplayInventory();
        list.SearchItem(4);
        list.CalculateTotalValue();
        list.SortInventoryByName();
    }
}