using System;
using System.Diagnostics.CodeAnalysis;

using CarLibrary;

namespace ConsoleClient
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Пример консольного клиента для сторонней библиотеки";
            Console.ForegroundColor = ConsoleColor.Cyan;
            var sportCar = new SportCar("Audi", 210, 270);
            sportCar.TurboBoost();

            var miniVan = new MiniVan();
            miniVan.TurboBoost();
            Console.ReadLine();
        }
    }
}
