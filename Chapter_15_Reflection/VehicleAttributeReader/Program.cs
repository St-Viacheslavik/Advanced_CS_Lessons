using System;
using System.Diagnostics.CodeAnalysis;

using AttributeCarLibrary;

namespace VehicleAttributeReader
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование аттрибутов на этапе раннего связывания";
            Console.ForegroundColor = ConsoleColor.Green;
            ReflectOnAttributesUsingEarlyBuilding();
            Console.ReadLine();
        }

        private static void ReflectOnAttributesUsingEarlyBuilding()
        {
            var type = typeof(Motorcycle);
            var customAtt = type.GetCustomAttributesData();
            foreach (var attribute in customAtt)
            {
                Console.WriteLine($"\t-> {attribute}");
            }
        }
    }
}
