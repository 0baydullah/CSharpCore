Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# String\n");

Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - String Basics");
//Console.WriteLine("    2 - Date Time Operations");

int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case -1:
        return;

    case 0:
        goto Home;

    case 1:
        StringBasics();
        goto case 0;

    case 2:
        goto case 0;

    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void StringBasics()
{
    string str1 = "Hello";
    string str2 = str1;
    // str1 += str2;
     
    str2 = "hello";

    str1 += str2;

    var val = str1.Contains(str2,StringComparison.InvariantCultureIgnoreCase);
    System.Console.WriteLine(val);




    Console.WriteLine("\n****END****\n");
}