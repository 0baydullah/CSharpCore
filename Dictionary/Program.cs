using System.Text.RegularExpressions;

Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("C# Dictionary\n");

Console.BackgroundColor = ConsoleColor.Black;


Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - Frequency Count");
Console.WriteLine("    2 - Word Counter");
Console.WriteLine("    3 - Most Frequent Character(s)");

int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case -1:
        return;
    case 0:
        goto Home;
    case 1:
        FrequencyCount();
        goto case 0;
    case 2:
        WordCounter();
        goto case 0;
    case 3:
        MostFrequentCharacters();
        goto case 0;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void MostFrequentCharacters()
{
    Console.WriteLine("Enter your text to see most frequent character(s) : ");
    string text = Console.ReadLine().ToLower();
    var characters = new Dictionary<char, int>();
    foreach(char c in text)
    {
        if (char.IsLetter(c))
        {
            if (characters.ContainsKey(c))
                characters[c]++;
            else characters[c] = 1;
        }
    }
    int maxFrequency = characters.Values.Max();

    var mostFrequentChar = characters.Where(x => x.Value == maxFrequency).Select(x=>x.Key);
    Console.WriteLine($"\nMost Frequent Character(s) : {string.Join(", ", mostFrequentChar)} and Max Frequency is {maxFrequency}");

    Console.WriteLine("\n___END___\n");
}

void WordCounter()
{
    Console.WriteLine("Enter Your Text : ");
    string text = Console.ReadLine().ToLower();
    text = RemovePunctuation(text);
    string[] words = text.Split(' ');

    int totalWordCount = words.Length;
    Dictionary<string, int> count = new Dictionary<String, int>();

    foreach(var word in words)
    {
        if (count.ContainsKey(word)) count[word]++;
        else count[word] = 1;
    }

    var sortedKeys = count.Keys.OrderBy(k => k);

    foreach (var item in sortedKeys)
    {
        Console.WriteLine($"{item} = {count[item]}");
    }

    Console.WriteLine($"Total Words count : {totalWordCount}");
    Console.WriteLine($"Total Unique Words count : {count.Keys.Count}");

    Console.WriteLine("\n___END___\n");
}
string RemovePunctuation(string input)
{
    // Use Regex to replace punctuation with an empty string
    return Regex.Replace(input, @"[^\w\s]", "");
}

void FrequencyCount()
{
    int[] integers = { 1, 2, 3, 1, 2, 3, 4, 2, 4, 3, 3, 3, 31, 2, 1, 23, 24, 24, 4, 2, 323, 232, 321, 21, 2, 1, 3, 23, 23, 1, 2, 4 };
    Dictionary<int, int> frequency = new Dictionary<int, int>();

    foreach (int i in integers)
    {
        if (frequency.ContainsKey(i)) frequency[i]++;
        else frequency[i] = 1;
    }

    foreach (KeyValuePair<int, int> i in frequency)
    {
        Console.WriteLine($"{i.Key} = {i.Value}");
    }
}