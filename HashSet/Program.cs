Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# HashSet+SortedSet\n");

Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - Available Letters");
//Console.WriteLine("    2 - Word Counter");
//Console.WriteLine("    3 - Most Frequent Character(s)");

int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case -1:
        return;
    case 0:
        goto Home;
    case 1:
        AvailableLetters();
        goto case 0;
    //case 2:
    //    WordCounter();
    //    goto case 0;
    //case 3:
    //    MostFrequentCharacters();
    //    goto case 0;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void AvailableLetters()
{
    Console.WriteLine("Enter a text : ");

    string text = Console.ReadLine().ToLower();
 //   var set = new HashSet<char>();
    var set = new SortedSet<char>();

    foreach (var c in text)
    {
        if(char.IsLetter(c))
        set.Add(c);
    }


    string output = string.Join(", ", set);
    Console.WriteLine($"Available Characters are : { output.ToString()}" );

    Console.WriteLine("----END----");
}