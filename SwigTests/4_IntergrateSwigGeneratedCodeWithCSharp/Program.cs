using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_IntergrateSwigGeneratedCodeWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = CS2CppAPI.fact(10);

            Console.WriteLine("Result of Factorial 10 in csharp program: " + res);
        }
    }
}
