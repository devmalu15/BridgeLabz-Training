using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.Constructors
{
    public class Person
    {
        string name;
        int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(Person otherPerson)
        {
            this.name = otherPerson.name;
            this.age = otherPerson.age;
        }

        public static void Main(string[] args)
        {
            Person p1 = new Person("Alice", 25);
            Person p2 = new Person(p1);
            Console.WriteLine("Original: " + p1.name);
            Console.WriteLine("Copy: " + p2.name);
        }
    }
}
