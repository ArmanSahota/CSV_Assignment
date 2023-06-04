using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Assignment
{
    internal class Person
    {
        string _firstName;
        string _lastName;
        string _job;

        public Person() { } // Default constructor for loading CSV files

        public Person(string firstName, string lastName, string job)
        {
            _firstName = firstName;
            _lastName = lastName;
            _job = job;
        }

        // Public properties for each field I plan to load
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Job { get => _job; set => _job = value; }
    }
}
