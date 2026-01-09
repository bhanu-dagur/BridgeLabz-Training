using System;

// Node for Linked List
class HashNode
{
    public int Key;
    public int Value;
    public HashNode Next;

    public HashNode(int key, int value)
    {
        Key = key;
        Value = value;
        Next = null;
    }
}

// Custom Hash Map
class MyHashMap
{
    private int SIZE = 10;          // bucket size
    private HashNode[] buckets;     // array of linked lists

    public MyHashMap()
    {
        buckets = new HashNode[SIZE];
    }

    // Hash Function
    private int GetIndex(int key)
    {
        return key % SIZE;
    }

    // INSERT / PUT
    public void Put(int key, int value)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];

        // If key already exists, update value
        while (head != null)
        {
            if (head.Key == key)
            {
                head.Value = value;
                return;
            }
            head = head.Next;
        }

        // Insert new node at beginning
        HashNode newNode = new HashNode(key, value);
        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }

    // GET / RETRIEVE
    public int Get(int key)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];

        while (head != null)
        {
            if (head.Key == key)
                return head.Value;

            head = head.Next;
        }

        return -1; 
    }

    // REMOVE / DELETE
    public void Remove(int key)
    {
        int index = GetIndex(key);
        HashNode head = buckets[index];
        HashNode prev = null;

        while (head != null)
        {
            if (head.Key == key)
            {
                if (prev == null)
                    buckets[index] = head.Next;
                else
                    prev.Next = head.Next;

                return;
            }
            prev = head;
            head = head.Next;
        }
    }
}


class CustomHashMap
{
    static void Main()
    {
        MyHashMap map = new MyHashMap();

        map.Put(1, 10);
        map.Put(2, 20);
        map.Put(12, 120); 

        Console.WriteLine(map.Get(1));   
        Console.WriteLine(map.Get(2));   
        Console.WriteLine(map.Get(12));  

        map.Remove(2);
        Console.WriteLine(map.Get(2));   
    }
}
