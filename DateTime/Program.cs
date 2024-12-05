Home:

Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("C# DateTime\n");
Console.BackgroundColor = ConsoleColor.Black;

Console.WriteLine("Enter command to execute function...!! Enter 0 to RESET & -1 to EXIT : ");
Console.WriteLine("    1 - Date Time Details");
Console.WriteLine("    2 - Date Time Operations");

int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case -1:
        return;
    case 0:
        goto Home;
    case 1:
        DateTimeDetails();
        goto case 0;
    case 2:
        DateTimeOperations();
        goto case 0;
    default:
        Console.WriteLine("Not a VALID Command...Try Again!");
        goto case 0;
}

void DateTimeOperations()
{
    var todaysDate = DateTime.Now;
    var randomDate = new DateTime(1969,10,19,15,36,23);

    TimeSpan span = new TimeSpan(1, 0, 0);

    Console.WriteLine("Todays Date : " + todaysDate.ToLongDateString());
    Console.WriteLine("Date and Day after 10 days : " + todaysDate.AddDays(10).ToString("dd:MM:yyyy - dddd"));
    Console.WriteLine("Date and Day befor 20 days : " + todaysDate.AddDays(-20).ToString("dd:MM:yyyy - dddd"));
    Console.WriteLine("Date and Day after 10 days : " + todaysDate.AddDays(10).ToString("dd:MM:yyyy - dddd"));
    Console.WriteLine("Date and Day befor 20 days : " + todaysDate.AddDays(-20).ToString("dd:MM:yyyy - dddd"));
    Console.WriteLine("A specific Date : " + randomDate.ToString("dd:MM:yyyy - dddd"));
    Console.WriteLine("Different between this and todays date : " + (todaysDate-randomDate).Days);
    Console.WriteLine("Different Hours : " + (todaysDate-randomDate).Hours);
    Console.WriteLine("Different Total Hours : " + (todaysDate-randomDate).TotalHours);
    Console.WriteLine("Date and Day after 1 days : " + todaysDate.Add(span));
    Console.WriteLine("Date and Day before 1 days : " + (todaysDate).Subtract(span));
    Console.WriteLine("Compare between 2 days : " + (todaysDate).CompareTo(randomDate));
    Console.WriteLine("\n****END****\n");
}

static void DateTimeDetails()
{
    Console.WriteLine("Showing Date Times Details");
    DateTime currentDateTime = DateTime.Now;
    DateTime currentUtcDateTime = DateTime.UtcNow;

    Console.WriteLine("Date Time : " + currentDateTime);
    Console.WriteLine("UTC Date Time : " + currentUtcDateTime);
    Console.WriteLine("Date : " + currentDateTime.ToString("dd/MMM/yyyy"));
    Console.WriteLine("Date of month : " + currentDateTime.ToString("dd"));
    Console.WriteLine("Day: " + currentDateTime.ToString("dddd"));
    Console.WriteLine("Month : " + currentDateTime.ToString("MM"));
    Console.WriteLine("Month : " + currentDateTime.ToString("MMMM"));
    Console.WriteLine("Year : " + currentDateTime.ToString("yyyy"));
    Console.WriteLine("Time : " + currentDateTime.ToString("HH : mm : ss : ") + currentDateTime.Millisecond) ;
    Console.WriteLine("AM or PM : " + currentDateTime.ToString("tt")) ;
    Console.WriteLine("Short Date : " + currentDateTime.ToShortDateString()) ;
    Console.WriteLine("Long Date : " + currentDateTime.ToLongDateString()) ;
    Console.WriteLine("Time of Day : " + currentDateTime.TimeOfDay) ;
    Console.WriteLine("Day of Week : " + currentDateTime.DayOfWeek) ;
    Console.WriteLine("Day of Year : " + currentDateTime.DayOfYear) ;
    Console.WriteLine("Is Leap Year : " + DateTime.IsLeapYear(currentDateTime.Year)) ;
    Console.WriteLine("Time Kind : " + (currentUtcDateTime.Kind)) ;
    Console.WriteLine("Unix Epoch : " + DateTime.UnixEpoch.ToString("dd-MMMM-yyyy hh:mm:ss tt" )) ;
    Console.WriteLine("\n****END****\n");
}