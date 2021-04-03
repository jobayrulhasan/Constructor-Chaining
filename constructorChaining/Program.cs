using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person3 = new Person();
            Person person1 = new Person("Md.", "Hamidur", "Rahman");
            Person person2 = new Person("Sohel", "Khan");
            string fullName = person1.getFullName();
            string fullName2 = person2.getFullName();
            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);
            Console.ReadKey();
        }
    }
}
