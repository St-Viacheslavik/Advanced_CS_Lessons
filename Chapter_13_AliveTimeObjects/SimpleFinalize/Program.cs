using System;
using System.Diagnostics.CodeAnalysis;

namespace SimpleFinalize
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использования метода Finalize";
            Console.ForegroundColor = ConsoleColor.Green;
            var res = new MyResource("John", 25);
            Console.WriteLine(res.ToString());
            res.ChangeAll("Mark", 45);
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }
    }
}
