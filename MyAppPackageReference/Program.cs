using MyDotNetLib;
using System;

namespace MyAppPackageReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current pointer size is : '{PointerHelper.GetPointSize()}'!");
        }
    }
}
