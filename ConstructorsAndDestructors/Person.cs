using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopConstructorsAndDestructors
{
    internal class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return "hi !! im " + Name;
        }

        ~Person()
        {
            this.Name = string.Empty;
        }
    }
}
