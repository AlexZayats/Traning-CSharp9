using System;
using System.Drawing;

namespace Traning_CSharp9_PatternMatching
{
    class Vehicle
    {
        public int Weight;
        public int Year;
        public int Passengers;
    }
    class Car : Vehicle { }
    class Bike : Vehicle { }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car { Weight = 1200, Year = 2020, Passengers = 2 };
            if (vehicle is not Bike)
            {
                Console.WriteLine("vehicle is not Bike");
            }
            if (vehicle is { Weight: > 1000 and < 1500, Year: 2020 })
            {
                Console.WriteLine("vehicle weight > 1000 and < 1500 and year = 2020");
            }
            
            Console.WriteLine(CalculateToll1(vehicle));
            Console.WriteLine(CalculateToll2(vehicle));
            Console.WriteLine(CalculateToll3(vehicle));
            Console.WriteLine(CalculateToll4(vehicle));
        }

        public static decimal CalculateToll1(object vehicle) => vehicle switch
        {
            Car c when c.Weight >= 1500 => 3.0m,
            Car c when c.Weight > 1000 && c.Weight < 1500 => 2.0m,
            Car c when c.Weight <= 1000 => 1.5m,
            Bike t => 1.2m,
            { } => throw new ArgumentException("Unknown vehicle type", nameof(vehicle)),
            null => throw new ArgumentNullException(nameof(vehicle))
        };

        public static decimal CalculateToll2(object vehicle) => vehicle switch
        {
            Car { Passengers: 0 } => 2.0m,
            Car { Passengers: 1 } => 2.5m,
            Car { Passengers: 2 } => 3.0m,
            Car => 4.0m,
            _ => 5.0m,
        };

        public static decimal CalculateToll3(object vehicle) => vehicle switch
        {
            Car c => c.Passengers switch
            {
                0 => 2.0m,
                1 => 2.5m,
                2 => 3.0m,
                _ => 4.0m
            },
            _ => 5.0m,
        };

        public static decimal CalculateToll4(object vehicle) => vehicle switch
        {
            Car c => c.Passengers switch
            {
                0 => 2.0m,
                > 0 and <= 5 => 2.5m,
                > 5 => 3.0m,
                _ => 4.0m
            },
            _ => 5.0m,
        };
    }
}
