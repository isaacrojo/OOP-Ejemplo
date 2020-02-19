using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jack = new Person("Jack Sparrow");
            jack.SayHello();

            Person jimmy = new Person("Jimmy Neutron");
            jimmy.SayHello();

            Console.WriteLine(Person.bloodColor);            //se manda llamar desde clase Person
            Person.PrintRace();
            

        }
    }
}
