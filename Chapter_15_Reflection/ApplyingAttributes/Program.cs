using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Xml.Serialization;

namespace ApplyingAttributes
{
    [Obsolete]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Применение атрибутов";
            Console.ForegroundColor = ConsoleColor.Green;
            var motorcycle = new Motorcycle(){HasBar = true, HasHeadSet = false, HasRadioSystem = true, WeightPassenger = 65.5F};
            using (var writer = new FileStream("log.xml", FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(Motorcycle));
                xml.Serialize(writer, motorcycle);
            }
            var horse = new Horse();
            Console.WriteLine(horse.ToString());
            Console.ReadLine();
        }
    }
}
