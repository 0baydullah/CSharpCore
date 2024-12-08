Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# Stack\n");

Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - Reverse a String");
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
        StringReverser();
        goto case 0;
    /*case 2:
        HashTagCalculator();
        goto case 0;*/
    //case 3:
    //    MostFrequentCharacters();
    //    goto case 0;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void StringReverser()
{
    Console.WriteLine("Enter a String to Reverse : ");
    string data = Console.ReadLine();

    /**
       // With Build in method

       var x = data.Reverse().ToArray();
       Console.WriteLine(x);
*/

    String output = "";
    Stack<char> chars = new Stack<char>();

    foreach(var c in data)
    {
        chars.Push(c);
    }
    while(chars.Count() != 0)
    {
        output+=chars.Pop();
     //   Console.WriteLine(c);
    }

    Console.WriteLine($"Your reversed string : {output}");

    Console.WriteLine("\n+++ END +++\n");

}