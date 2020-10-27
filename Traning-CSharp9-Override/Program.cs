using System;

namespace Traning_CSharp9_Override
{
    class Food
    {
    }

    class Meat : Food
    {
    }

    abstract class Animal
    {
        public abstract Food GetFood();
    }

    class Tiger : Animal
    {
        public override Meat GetFood() => new Meat();
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
