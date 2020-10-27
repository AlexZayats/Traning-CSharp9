using System;

namespace Traning_CSharp9_InitProperties
{
    class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Line1 { get; set; }
    }

    class Person
    {
        public string Name { get; init; }
        public string Company { get; set; }
        public Address CompanyAddress { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person employee = new()
            {
                Name = "Paul McCartney",
                Company = "High Technologies Center",
                CompanyAddress = new()
                {
                    Country = "Russia",
                    City = "Izhevsk",
                    Line1 = "246, Karl Marx St."
                }
            };
        }
    }
}
