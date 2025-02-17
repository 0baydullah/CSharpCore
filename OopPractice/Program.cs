using System.Net;
using System.Security.Cryptography.X509Certificates;
using Dumpify;
using OopPractice;


namespace OopPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                    new Student{Id = 1001 , Name = "S" , Sub = "phy" , Mark = 10},
                    new Student{Id = 1001 , Name = "S" , Sub = "chem" , Mark = 15.5},
                    new Student{Id = 1001 , Name = "S" , Sub = "math" , Mark = 5},

                    new Student{Id = 1002 , Name = "R" , Sub = "phy" , Mark = 30},
                    new Student{Id = 1002 , Name = "R" , Sub = "chem" , Mark = 2},

                    new Student{Id = 1003 , Name = "T" , Sub = "phy" , Mark = 20},
                    new Student{Id = 1003 , Name = "T" , Sub = "chem" , Mark = 25},
                    new Student{Id = 1003 , Name = "T" , Sub = "math" , Mark = 15},
                    new Student{Id = 1003 , Name = "T" , Sub = "eng" , Mark = 18},

                    new Student{Id = 1004 , Name = "U" , Sub = "phy" , Mark = 12},
                    new Student{Id = 1004 , Name = "U" , Sub = "chem" , Mark = 22},
                    new Student{Id = 1004 , Name = "U" , Sub = "math" , Mark = 17},
                    new Student{Id = 1004 , Name = "U" , Sub = "eng" , Mark = 19},

                    new Student{Id = 1005 , Name = "V" , Sub = "phy" , Mark = 14},
                    new Student{Id = 1005 , Name = "V" , Sub = "chem" , Mark = 24},
                    new Student{Id = 1005 , Name = "V" , Sub = "math" , Mark = 16},
                    new Student{Id = 1005 , Name = "V" , Sub = "eng" , Mark = 20},

                };

            students.Dump("students");

            students
                .GroupBy(x => x.Name)
                .Select(x => new { Name = x.Key, Mark = x.Sum(x => x.Mark), Subs = x.Select(x => string.Join(", ", x.Sub)) })
                .ToList()
                .Dump("name marks subs");

            var maxMarkStudent = students.MaxBy(x => x.Mark);
            new { Name = maxMarkStudent.Name, Sub = maxMarkStudent.Sub, Marks = maxMarkStudent.Mark }.Dump("Highest Mark Student sub mar");

            students.Where(x => x.Mark >= 10).Select(x => new { name = x.Name, sub = x.Sub, mark = x.Mark }).ToList().Dump("name sub mark");

            Color pen = new Pen();


        }
    }

}