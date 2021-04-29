using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Xml.Serialization;

//Аттрибут для соответствия сборки спецификации CLS
[assembly: CLSCompliant(true)]

namespace AttributeCarLibrary
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Построение собственных аттрибутов";
            Console.ForegroundColor = ConsoleColor.Green;
            var motorcycle = new Motorcycle();
            using (var writer = new FileStream("log.xml", FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(Motorcycle));
                xml.Serialize(writer, motorcycle);
            }
            Console.ReadLine();
        }
    }
}
