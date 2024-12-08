using OopConstructorsAndDestructors;

internal class Program
{
    private static void Main(string[] args)
    {
        int total = 3;

        Person[] persons = new Person[total];

        for(int i = 0;  i < total; i++)
        {
            Console.WriteLine("Enter a name  :  ");
            persons[i] = new Person(Console.ReadLine()); 
        }

        foreach(Person person in persons)
        {
            Console.WriteLine(person.ToString());
        }
    }
}