using System;

namespace Traning_CSharp9_Other
{
    class Person { }
    class Student : Person { }
    class Customer : Person { }

    class Program
    {
        static void SomeFunc(Func<int, int> f)
        {
            Console.WriteLine(f(5));
        }

        static void Main(string[] args)
        {
            int y1 = 10;
            const int y2 = 10;
            SomeFunc(i => i + y1);          // выведет 15
            //SomeFunc(static i => i + y1);   // ошибка компиляции: y1 не видна в лямбде
            SomeFunc(static i => i + y2);   // выведет 15


            Func<int, int, int> someFunc1 = (_, _) => { return 5; };
            Func<int, int, int> someFunc2 = (int _, int _) => { return 5; };
            Func<int, int, int> someFunc3 = delegate (int _, int _) { return 5; };

            int? result = DateTime.Now.DayOfWeek == DayOfWeek.Sunday ? 0 : null;

            Student student = new Student();
            Customer customer = new Customer();
            //Person p = student ?? customer;

            var t = new PartialClass();
            t.DoSomeWork(out var p);
        }
    }

    public partial class PartialClass
    {
        public partial int DoSomeWork(out string p);
    }
    public partial class PartialClass
    {
        public partial int DoSomeWork(out string p)
        {
            p = "test";
            Console.WriteLine("Partial method");
            return 5;
        }
    }
}
