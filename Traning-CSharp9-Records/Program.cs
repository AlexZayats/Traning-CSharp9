using System;

namespace Traning_CSharp9_Records
{
    /*
    public record Person
    {
        public string LastName { get; }
        public string FirstName { get; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);
    }
    */

    public record Person(string FirstName, string LastName);

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new("Paul", "McCartney");
            Person p2 = new("Paul", "McCartney");

            Console.WriteLine(p1 == p2);

            Person p3 = p2 with { FirstName = "Brown" };
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            var (first, last) = p1;
            Console.WriteLine(first);
            Console.WriteLine(last);
        }
    }
}
