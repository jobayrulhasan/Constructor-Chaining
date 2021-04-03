using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorChaining
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string middleName, string lastName):this(middleName,lastName) //this is constructor chaining
        {
            FirstName = firstName;
        }

        public Person(string middleName, string lastName):this()
        {
            MiddleName = middleName;
            LastName = lastName;
        }

        public Person()
        {
           
        }

        public string getFullName()
        {
            string myName = FirstName + " " + MiddleName + " " + LastName;
            return myName;
        }
    }
}
