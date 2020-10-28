using System;

namespace Traning_CSharp9_Records
{
    public record Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string first, string last) => (FirstName, LastName) = (first, last);

        /*
        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }
        */
    }

    public record Teacher : Person
    {
        public string Subject { get; }

        public Teacher(string first, string last, string sub) : base(first, last)
        {
            Subject = sub;
        }
    }

    public record ShotPerson(string FirstName, string LastName);

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new("Paul", "McCartney");
            Person p2 = new("Paul", "McCartney");
            Console.WriteLine(p1 == p2);
            //p1.FirstName = "Brown";

            Person p3 = p2 with { FirstName = "Brown" };
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            Person p = new("Paul", "McCartney");
            Teacher t = new("Paul", "McCartney", "Programming");
            Console.WriteLine(p == t);

            ShotPerson sp = new("Paul", "McCartney");
            var (first, last) = sp;
            Console.WriteLine(first);
            Console.WriteLine(last);
        }
    }
}
