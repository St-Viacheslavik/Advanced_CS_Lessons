using System;
using System.Diagnostics.CodeAnalysis;

using CarLibrary;

namespace ClientWithGAC
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование библиотеки, размещенной в GAC";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            var sportCar = new SportCar("Audi", 210, 270);
            sportCar.TurboBoost();
            Console.ReadLine();
        }
    }
}
