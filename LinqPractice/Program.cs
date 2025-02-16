using System;
using Dumpify;
using Spectre.Console;

public class Program
{
    public static void Main(string[] args)
    {
        // where

        IEnumerable<int> collection = [5,1, 2, 3, 4, 5 , 1];

        collection.Where(c => c > 2).Dump();

        // ofType

        IEnumerable<object> collection2 = [1, false, 3, 4, "6", '6'];

        collection2.OfType<int>().Dump();
        collection2.OfType<string>().Dump();

        // skip , take , skipLast , takeLast , skipWhile , takeWhile

        collection.Take(1).Dump("Take");
        collection.Skip(1).Dump("Skip");
        collection.TakeLast(2).Dump("TakeLast");
        collection.SkipLast(2).Dump("SkipLast");
        collection.SkipWhile(x => x < 2).Dump("SkipWhile");
        collection.TakeWhile(x => x < 2).Dump("TakeWhile");


        // select, selctMany

        collection.Select(x => x).Dump();
        var b = collection.Select((x,i) => $"{i} > {x}").Dump();

        IEnumerable<List<int>> collection3 = [[1,2,3], [4,5,6]];

        collection3.SelectMany(x => x).Dump();
        collection3.SelectMany((x,i) => x.Select(x => $"{i} > {x}")).Dump();

        // cast
        IEnumerable<object> collection4 = [1, 2, 3, 4, 5];

        collection4.Cast<int>().Dump("Object to int CAST");

        // chunk

        collection4.Chunk(3).Dump("Chunk");

        // any , all , contains 

        collection.Any(x => x > 4).Dump("Any");
        collection.All(x => x > 3).Dump("All");
        collection.Contains(3).Dump("Contains");


        // append , prepend 

        var a = collection.Append(4).Dump("Append");
        a.Prepend(7).Dump("Prepend");


        // count 


        IEnumerable<int> collection5 = [1,2,3,4,5];
        collection5.Count().Dump("Count");

        // max , maxBy , min , minBy

        a.Max().Dump("Max");

        IEnumerable<Person> People = [
            new(0,"P1",13),
            new(1,"P2",9),
            new(2,"P3",32),
            new(3,"P4",32)
        ];

        People.MaxBy(x => x.Age).Dump("MaxBy");

        a.Min().Dump("Min");
        People.MinBy(x => x.Age).Dump("MinBy");


        // sum , average , aggregate , LongCount

        a.Sum().Dump("sum");
        a.Average().Dump("Average");
        a.LongCount().Dump("LongCount");
        a.Aggregate((x,y) => x+y).Dump("Aggregate");
        a.Select(x=> x.ToString()).Aggregate((x,y) => $"{x},{y}").Dump("Aggregate");
        a.Aggregate(10,(x,y) => x+y).Dump("Aggregate");
        a.Aggregate(10,(x,y) => (x+y), x => x/2.0).Dump("Aggregate");


        // first , firstOrDefault

        List<string> s = new List<string>();
        s.FirstOrDefault("NotFound").Dump("FirstOrDefault");
        s.Prepend("FirstItem").First().Dump("First");

        // single , singleOrDefault

        s.SingleOrDefault("Not single").Dump("singleOrDefault");
        s.Append("Single Item").Single().Dump("Single");

        // last , lastOrDefault

        s.LastOrDefault("NotFound").Dump("LastOrDefault");
        s.Prepend("LastItem").Last().Dump("Last");

        // elementAt , elementAtOrDefault , DefaultIfEmpty

        a.ElementAt(3).Dump("ElementAt");
        a.ElementAtOrDefault(69).Dump("ElementAtOrDefault");
        s.DefaultIfEmpty("Empty").Dump("DefaultIfEmpty");
        s.Append("NotEmpty").Append("Another Item").DefaultIfEmpty().Dump("DefaultIfEmpty ");


        // ToArray , ToList , ToDictionary , ToHashSet , ToLookup

        People.ToArray().Dump("ToArray");
        People.ToList().Dump("ToList");
        People.ToDictionary(x=>x.Name , y=>y.Age).Dump("ToDictionary");
        People.ToHashSet().Dump("HashSet");
        People.ToLookup(x => x.Age)[32].Dump("ToLookup");


        // Repeat , Range , Empty

        IEnumerable<int> ints = Enumerable.Repeat(1, 10).Dump("Repeat");
        ints = Enumerable.Range(2, 10).Dump("Range");
        ints = Enumerable.Empty<int>().Dump("Empty");


        // Distinct , DistinctBy

        collection.Distinct().Dump("Distinct");
        People.DistinctBy(x => x.Age).Dump("DistinctBy");


        // union , intersect , except , exceptby , intersectby , unionby , sequenceEqual

        IEnumerable<int> col1 = [1, 2, 3, 4];
        IEnumerable<int> col2 = [3, 5, 7, 10];

        col1.Union(col2).Dump("Union");
        col1.Intersect(col2).Dump("Intersect");
        col1.Except(col2).Dump("except");
        col1.SequenceEqual(col2).Dump("SequenceEqual");


        // zip , join, groupJoin , concat , GroupBy

        IEnumerable<String> col3 = ["one", "two", "three"];

        col1.Zip(col2,col3).Dump("zip");

        IEnumerable<Product> product = [
            new (0,"mango"),
            new (1,"mango1"),
            new (2,"mango2"),
            new (3,"mango3"),
            new (4,"mango34"),
        ];

        People
            .Join(product, p => p.id, pr => pr.pid, (p, pr) 
            => $"{p.Name} bought {pr.Name}").Dump("Join");
        People
            .GroupJoin(product, p => p.id, pr => pr.pid, (p, pr) 
            => $"{p.Name} bought {string.Join(',',pr)}").Dump("GroupJoin");

        col1.Concat(col2).Dump("concat");

        People.GroupBy(x => x.Age).Dump("GroupBy");

    }
}

record Person(int id, string Name, int Age);
record Product(int pid, string Name);