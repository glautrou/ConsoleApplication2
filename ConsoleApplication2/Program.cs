using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.CreateNew("John", "Smith");
            Console.WriteLine("Hi " + person.GetFullName());
        }
    }
}
