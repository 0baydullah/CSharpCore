using System;

public class Stack<T>
{
    private T[] _items; // Array to store stack elements
    private int _count; // Number of elements in the stack
    private const int DefaultCapacity = 4; // Default capacity of the stack

    // Constructor
    public Stack()
    {
        _items = new T[DefaultCapacity];
        _count = 0;
    }

    // Push method to add an item to the stack
    public void Push(T item)
    {
        if (_count == _items.Length) // Resize array if needed
        {
            ResizeArray();
        }
        _items[_count++] = item;
    }

    // Pop method to remove and return the top item of the stack
    public T Pop()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T item = _items[--_count];
        _items[_count] = default; // Clear the reference for garbage collection
        return item;
    }

    // Peek method to view the top item without removing it
    public T Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return _items[_count - 1];
    }

    // Property to check the number of items in the stack
    public int Count => _count;

    // Method to check if the stack is empty
    public bool IsEmpty => _count == 0;

    // Method to resize the internal array
    private void ResizeArray()
    {
        int newCapacity = _items.Length * 2;
        T[] newArray = new T[newCapacity];
        Array.Copy(_items, newArray, _count);
        _items = newArray;
    }
}

// Example usage
class Program
{
    static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Top item: " + stack.Peek()); // Output: 30
        Console.WriteLine("Popped item: " + stack.Pop()); // Output: 30
        Console.WriteLine("Top item after pop: " + stack.Peek()); // Output: 20
    }
}
