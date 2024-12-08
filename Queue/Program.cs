Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# Queue\n");

Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - Queue Basics");
Console.WriteLine("    2 - ");
//Console.WriteLine("    3 - Most Frequent Character(s)");

int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case -1:
        return;
    case 0:
        goto Home;
    case 1:
        QueueBasics();
        goto case 0;
    case 2:
       // HashTagCalculator();
        goto case 0;
    //case 3:
    //    MostFrequentCharacters();
    //    goto case 0;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void QueueBasics()
{
    int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
    Queue<int> queue = new Queue<int>();

    foreach (int i in integers)
    {
        queue.Enqueue(i);
    }
    Console.Write("Your Queue is : ");

    while (queue.Count > 0)
    {
        Console.Write(queue.Dequeue() + " ");
    }
}