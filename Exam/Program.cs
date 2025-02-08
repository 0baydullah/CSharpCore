using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

public class Program
{
    public static void Main()
    {
        // Date: Jan 05, 2021

        //       ----------      Question 1      ----------

        Console.Write("Odd Numbers: ");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 1)
            {
                Console.Write($" {i}");
            }
        }
        Console.Write("\nEven Numbers: ");
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($" {i}");
            }
        }

        Console.WriteLine();
        //       ----------      Question 2      ----------

        static string DayAfterNDays(int n)
        {
            return DateTime.Now.AddDays(n).ToString("dddd");
        }

        Console.WriteLine(DayAfterNDays(17));

        //       ----------      Question 3      ----------

        var Employees = new List<Employee>
        {
            new Employee {Name = "John", Department = "HR" },
            new Employee {Name = "Jane", Department = "IT" },
            new Employee {Name = "Jack", Department = "HR" },
            new Employee {Name = "Jill", Department = "IT" },
            new Employee {Name = "Joe", Department = "HR" },
            new Employee {Name = "Jenny", Department = "IT" },
            new Employee {Name = "Jim", Department = "HR" },
            new Employee {Name = "Jill", Department = "IT" },
            new Employee {Name = "Joe", Department = "HR" },
            new Employee {Name = "Jenny", Department = "IT" }
        };

        var dept = Employees.Select(e => e.Department).Distinct().ToList();
        foreach (var d in dept)
        {
            Console.Write($"{d} : ");

            var emp = Employees.Where(e => e.Department == d).Select(e => e.Name).ToList();
            var emps = string.Join(',', emp);
            Console.WriteLine(emps);
        }

        //       ----------      Question 4      ----------

        MyLogger logger = new();
        logger.Logg("This is my log");


        //       ----------      Question 5      ----------

        var nums1 = new int[] { 8, 4, 5, 6, 1, 7, 2, 3, 8, 1 };
        var nums2 = new int[] { 3, 8, 1, 9, 2, 3, 8, 4, 5, 6};

        var sortedArray = nums1.Concat(nums2).ToArray();
        Array.Sort(sortedArray);
        foreach (var i in sortedArray)
        {
            Console.Write($"{i} ");
        }
    }
}

internal class Employee
{
    public string? Name { get; set; }
    public string? Department { get; set; }
}

public interface IConsoleLogger
{
    void Log(string message);
}

public interface IFileLogger
{
    void Log(string message);
}

public class MyLogger : IConsoleLogger, IFileLogger
{
    public void Logg(string message)
    {
        ((IConsoleLogger)this).Log(message);
        ((IFileLogger)this).Log(message);
    }

    void IConsoleLogger.Log(string message)
    {
        Console.WriteLine($"LOG #{DateTime.Now.ToString("dd,MM,yyyy-HH:mm:ss")} : {message}");
    }

    void IFileLogger.Log(string message)
    {
        string filePath = "C:\\Users\\OPL\\Desktop\\MyLoggersLog.txt";
        string logMessage = $"LOG #{DateTime.Now.ToString("dd,MM,yyyy-HH:mm:ss")} : {message}";
        File.AppendAllText(filePath, logMessage + Environment.NewLine);
    }
}
