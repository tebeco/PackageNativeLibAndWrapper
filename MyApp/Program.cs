using MyDotNetLib;
using System;

namespace MyApp_AnyCPU
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current pointer size is : '{PointerHelper.GetPointSize()}'!");
        }
    }
}
