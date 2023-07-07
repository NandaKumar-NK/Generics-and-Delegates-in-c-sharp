using System;
using System.Collections.Generic;

class Stack<T>
{
    private List<T> items;

    public Stack()
    {
        items = new List<T>();
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        int lastIndex = items.Count - 1;
        T lastItem = items[lastIndex];
        items.RemoveAt(lastIndex);
        return lastItem;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return items[items.Count - 1];
    }

    public int Size()
    {
        return items.Count;
    }

    public override string ToString()
    {
        return string.Join(", ", items);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();

        Console.Write("Enter the number of elements to insert: ");
        int numElements;

        while (!int.TryParse(Console.ReadLine(), out numElements) || numElements <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Enter the number of elements to insert: ");
        }

        for (int i = 0; i < numElements; i++)
        {
            Console.Write($"Enter element #{i + 1}: ");
            int element;

            while (!int.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write($"Enter element #{i + 1}: ");
            }

            stack.Push(element);
        }

        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. List");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice;

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Enter your choice: ");
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the element to insert: ");


                    int element;

                    while (!int.TryParse(Console.ReadLine(), out element))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.Write("Enter the element to insert: ");
                    }

                    stack.Push(element);
                    Console.WriteLine("Element inserted.");
                    break;

                case 2:
                    try
                    {
                        int deletedItem = stack.Pop();
                        Console.WriteLine("Deleted item: " + deletedItem);
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case 3:
                    if (stack.IsEmpty())
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Stack elements: " + stack);
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting the program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
