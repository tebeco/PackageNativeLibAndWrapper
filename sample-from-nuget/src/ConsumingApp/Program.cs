using System;
using ThirdPartDotNet;

namespace ConsumingApp  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current pointer size is : '{PointerHelper.GetPointSize()}'!");
        }
    }
}
