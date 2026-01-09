using System;
using System.Collections.Generic;

class SortStackRecursion
{
    // Function to sort stack
    public static void SortStack(Stack<int> stack)
    {
        // Base case
        if (stack.Count == 0)
            return;

        // Step 1: Pop top element
        int top = stack.Pop();

        // Step 2: Sort remaining stack
        SortStack(stack);

        // Step 3: Insert element at correct position
        InsertSorted(stack, top);
    }

    // Helper function to insert element in sorted order
    private static void InsertSorted(Stack<int> stack, int element)
    {
        // Base case: correct position found
        if (stack.Count == 0 || stack.Peek() <= element)
        {
            stack.Push(element);
            return;
        }

        // Pop top element
        int top = stack.Pop();

        // Recursive call
        InsertSorted(stack, element);

        // Push back the popped element
        stack.Push(top);
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        while (stack.Count > 0)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}
