Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# String\n");

Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - String Basics");
Console.WriteLine("    2 - Missing Numbers");
Console.WriteLine("    3 - Space Remover");

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
        MissingNumbers();
        goto case 0;
    case 3:
        SpaceRemover();
        goto case 0;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void StringBasics()
{
    string str1 = "                 HeLLo       ";
    string str2;

    str2 = str1.Trim() ;

    string str3 = str2.ToLower();
    Console.WriteLine(str3+ "\n"+ str3.ToUpper());


    Console.WriteLine("\n****END****\n");
}

void MissingNumbers()
{
    string numbers = "1,2,3 4 6 7 8,9,11,13";
    char[] separators = { ',', ' ' };

    string[] singleNumbers = numbers.Split(separators);

    List<int> intNumbers = new List<int>();
    foreach(var number in singleNumbers)
    {
        intNumbers.Add(Convert.ToInt32(number));
    }

    int maxValue = intNumbers.Max();
    int minValue = intNumbers.Min();
    List<int> missingNumbers = new List<int>();

    for(int i = minValue; i <= maxValue; i++)
    {
        if (!intNumbers.Contains(i))
        {
            missingNumbers.Add(i);
        }
    }

    Console.Write("Missing Numbers Are : ");

    string output = string.Join(", ", missingNumbers);

    Console.WriteLine(output);
    Console.WriteLine("\n****END****\n");
}

void SpaceRemover()
{
    string message = "Enter a Text with extra spaces among words : ";
    Console.WriteLine(message);
    String text = Console.ReadLine();

    var words = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);

    string result = string.Join(' ', words);
    Console.WriteLine(result);

    Console.WriteLine("\n====END====\n");
}