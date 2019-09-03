using System;
using MyDotNetLib;

namespace ConsumingApp  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current pointer size is : '{MyNugetPointerHelper.GetPointSize()}'!");
        }
    }
}
