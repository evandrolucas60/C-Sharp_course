using System;
using ExtensionMethodsCsharp.Extensions;

namespace ExtensionMethodsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 3, 31, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
