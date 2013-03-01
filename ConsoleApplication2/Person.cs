using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Person CreateNew(string firstName, string lastName)
        {
            return new Person { FirstName = firstName, LastName = lastName };
        }

        /// <summary>
        /// Get the full name
        /// </summary>
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
