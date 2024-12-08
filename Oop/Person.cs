using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Person
    {
        
        public string Name { get; set; }
        //public Person(string name)
        //{
        //    this.Name = name;
        //}
        public override string ToString()
        {
            return "Hello ! My name is " + Name;
        }

        //~Person()
        //{
        //    Name = string.Empty;
        //}
    }
}
