using System;
using System.Diagnostics.CodeAnalysis;

using CarLibrary;

namespace SimpleReflection
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Понятие рефлексии";
            Console.ForegroundColor = ConsoleColor.Green;
            var sportCar = new SportCar("Mazda", 175, 210);
            var type = sportCar.GetType();
            Console.WriteLine($"Sport car type: {type}");
            var type2 = typeof(SportCar);
            Console.WriteLine($"Sport car type: {type2}");
            try
            {
                var type3 = Type.GetType("CarLibrary.SportCar, CarLibrary", true, false);
                Console.WriteLine($"Sport car type: {type3}");
                var type4 = Type.GetType("CarLibrary.car, CarLibrary", true, true);
                Console.WriteLine($"Sport car type: {type4}");
                var type5 = Type.GetType("CarLibrary.car, CarLibrary", true, false);
                Console.WriteLine($"Sport car type: {type5}");
            }
            catch (TypeLoadException e)
            {
                Console.WriteLine($"Тип исключения {e.TypeName}, сообщение исключения: {e.Message}");
            }
            
            Console.ReadLine();
        }
    }
}
