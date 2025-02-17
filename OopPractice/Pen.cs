using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OopPractice
{
    internal class Pen : Color
    {
        private string _type;
        private string _brand;
        public Pen(string name, int code, string type, string brand) : base(name, code)
        {
            _type = type;
            _brand = brand;
        }
        public Pen() 
        {

        }
        public void SetType(string type)
        {
            _type = type;
        }
        public void SetBrand(string brand)
        {
            _brand = brand;
        }
        public string GetType()
        {
            return _type;
        }
        public string GetBrand()
        {
            return _brand;
        }
        public new void Info2(string message)
        {
            Console.WriteLine($"{message} Name: {Name}, Code: {Code}, Type: {_type}, Brand: {_brand}");
        }

        public override void Info()
        {
            throw new NotImplementedException();
        }
    }
}
