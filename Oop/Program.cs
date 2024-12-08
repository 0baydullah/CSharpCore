using System.Runtime.CompilerServices;
using Oop;

internal class Program
{
    private static void Main(string[] args)
    {
        int totalPerson = 3;
        Person[] persons = new Person[totalPerson];

        for(int i = 0; i < totalPerson; i++)
        {
            Console.Write("Enter a persons Name : ");

            persons[i] = new Person()
            {
                Name = Console.ReadLine()
            };
        }

        foreach(Person person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}