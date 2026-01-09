using System;
using System.Collections.Generic;

class StockSpan
{
    static void CalculateSpan(int[] price)
    {
        int n = price.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        // First day
        span[0] = 1;
        stack.Push(0);

        for (int i = 1; i < n; i++)
        {
            // Pop until greater price found
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
            {
                stack.Pop();
            }

            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }

        Console.WriteLine("Stock Prices:");
        foreach (int p in price)
            Console.Write(p + " ");

        Console.WriteLine("\nStock Span:");
        foreach (int s in span)
            Console.Write(s + " ");
    }

    static void Main()
    {
        int[] price = { 100, 80, 60, 70, 60, 75, 85 };
        CalculateSpan(price);
    }
}
