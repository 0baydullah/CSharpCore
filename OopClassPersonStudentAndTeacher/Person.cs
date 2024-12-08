using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClassPersonStudentAndTeacher
{
    internal class Person
    {
        public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine("Hello....");
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
