using System;
using System.Collections.Generic;

namespace Traning_CSharp9_GetEnumerator
{
    static class Program
    {
        public static IEnumerator<T> GetEnumerator<T>(this ValueTuple<T, T, T, T, T> source)
        {
            yield return source.Item1;
            yield return source.Item2;
            yield return source.Item3;
            yield return source.Item4;
            yield return source.Item5;
        }

        static void Main(string[] args)
        {
            foreach (var item in (1, 2, 3, 4, 5))
            {
                Console.WriteLine(item);
            }
        }
    }
}
