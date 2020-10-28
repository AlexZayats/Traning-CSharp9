using System;
using System.Runtime.CompilerServices;

namespace Traning_CSharp9_ModuleInit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Module
    {
        [ModuleInitializer]
        internal static void Init()
        {
            Console.WriteLine("Init!");
        }
    }
}
