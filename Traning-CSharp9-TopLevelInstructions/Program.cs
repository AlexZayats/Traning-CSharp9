using System;
using System.Runtime.InteropServices;

Console.WriteLine("Hello World!");
FromWhom();

void FromWhom()
{
    Console.WriteLine($"From {RuntimeInformation.FrameworkDescription}");
}