using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClassPersonStudentAndTeacher
{
    internal class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm Studing...");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is : {Age} years old");
        }
    }
}
