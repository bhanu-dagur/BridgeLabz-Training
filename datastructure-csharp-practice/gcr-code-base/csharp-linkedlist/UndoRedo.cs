using System;

// Doubly Linked List Node
class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    TextState head;      // Oldest state
    TextState tail;      // Latest state
    TextState current;   // Current cursor
    int size = 0;
    const int MAX_HISTORY = 10;

    // Add new text state
    public void AddState(string content)
    {
        TextState newState = new TextState(content);

        // If undo was used, clear redo history
        if (current != tail && current != null)
        {
            current.Next = null;
            tail = current;
        }

        if (head == null)
        {
            head = tail = current = newState;
            size = 1;
            return;
        }

        tail.Next = newState;
        newState.Prev = tail;
        tail = newState;
        current = newState;
        size++;

        // Maintain history limit
        if (size > MAX_HISTORY)
        {
            head = head.Next;
            head.Prev = null;
            size--;
        }
    }

    // Undo operation
    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Undo successful");
        }
        else
        {
            Console.WriteLine("No more undo available");
        }
    }

    // Redo operation
    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Redo successful");
        }
        else
        {
            Console.WriteLine("No more redo available");
        }
    }

    // Display current text
    public void DisplayCurrentState()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Content);
        else
            Console.WriteLine("Editor empty");
    }
}

class UndoRedo
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("H");
        editor.AddState("He");
        editor.AddState("Hel");
        editor.AddState("Hell");
        editor.AddState("Hello");

        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        editor.Undo();
        editor.DisplayCurrentState();

        editor.Redo();
        editor.DisplayCurrentState();

        editor.AddState("Hello World");
        editor.DisplayCurrentState();

        editor.Redo(); // Should not work
    }
}
