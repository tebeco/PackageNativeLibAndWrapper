using MyDotNetLib;
using System;

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
