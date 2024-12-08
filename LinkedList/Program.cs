LinkedList<int> llist = new LinkedList<int>();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# Linked List\n");

Console.BackgroundColor = ConsoleColor.Black;
Home:


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - Show LinkedList");
Console.WriteLine("    2 - Add First");
Console.WriteLine("    3 - Add Last");
Console.WriteLine("    4 - Add in Index ");
Console.WriteLine("    5 - Remove First");
Console.WriteLine("    6 - Remove Last");
Console.WriteLine("    7 - Remove from Index");
Console.WriteLine("    8 - Remove by Value");
Console.WriteLine("    9 - Clear Linked List");

int input = Convert.ToInt32(Console.ReadLine());


switch (input)
{
    case -1:
        return;
    case 0:
        goto Home;
    case 1:
        ShowLinkedList();
        goto case 0;
    case 2:
        AddFirstt();
        goto case 1;
    case 3:
        AddLastt();
        goto case 1;
    case 4:
        AddInIndex();
        goto case 1;
    case 5:
        RemoveFirstt();
        goto case 1;
    case 6:
        RemoveLastt();
        goto case 1;
    case 7:
        RemoveIndex();
        goto case 1;
    case 8:
        RemoveByValue();
        goto case 1;
    case 9:
        ClearLinkedList();
        goto case 1;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void ClearLinkedList()
{
    llist.Clear();
    Console.WriteLine("LinkedList Cleared...!!");
}

void RemoveByValue()
{

    Console.Write("Enter an integer : ");
    int input = Convert.ToInt32(Console.ReadLine());
    llist.Remove(input);
    Console.WriteLine("Removed..!");
}

void AddInIndex()
{
    Console.Write("Enter an index : ");
    int index = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter an input : ");
    int input = Convert.ToInt32(Console.ReadLine());

    LinkedListNode<int> node = llist.First;
    

    if(node != null)
        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }
    if (node == null) llist.AddLast(input);
    else llist.AddBefore(node, input);
    
}

void AddFirstt()
{
    Console.Write("Enter an integer : ");
    int input = Convert.ToInt32( Console.ReadLine());
    llist.AddFirst(input);
}
void AddLastt()
{
    Console.Write("Enter an integer : ");
    int input = Convert.ToInt32( Console.ReadLine());
    llist.AddLast(input);
}
void RemoveIndex()
{
    Console.Write("Enter an index : ");
    int index = Convert.ToInt32(Console.ReadLine());

    LinkedListNode<int> node = llist.First;
    

    if(node != null)
        for (int i = 0; i < index; i++)
        {
            node = node.Next;
        }
    if (node == null)
        llist.RemoveLast();
    else
        llist.Remove(node);

    Console.WriteLine("Removed..!");
}

void RemoveFirstt()
{
    llist.RemoveFirst();
    Console.WriteLine("Removed..!");

}
void RemoveLastt()
{
    llist.RemoveLast();
    Console.WriteLine("Removed..!");
}

void ShowLinkedList()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Your Linked List is : ");
    foreach(int i in llist)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("\n");    Console.ForegroundColor = ConsoleColor.Green;

}