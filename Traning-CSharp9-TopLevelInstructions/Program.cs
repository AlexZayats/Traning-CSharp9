using System;
using System.Runtime.InteropServices;

Console.WriteLine("Hello World!");
Console.WriteLine(args.Length);
FromWhom();

void FromWhom()
{
    Console.WriteLine($"From {RuntimeInformation.FrameworkDescription}");
}