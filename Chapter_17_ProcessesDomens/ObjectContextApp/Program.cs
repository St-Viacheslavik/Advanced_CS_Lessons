using System;
using System.Diagnostics.CodeAnalysis;

namespace ObjectContextApp
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Исследование контекста объекта";
            Console.ForegroundColor = ConsoleColor.Green;
            var sportCar = new SportCar();
            Console.WriteLine();
            var sportCar2 = new SportCar();
            Console.WriteLine();
            var sportCarTs = new SportCarTs();
            Console.ReadLine();
        }
    }
}
