using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqRetValues
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "LINQ как возвращаемое значение";
            Console.ForegroundColor = ConsoleColor.Green;
            var linqValue = GetStringSubset();
            Console.WriteLine("Возвращаем linq запрос как тип IEnumerable<string>");
            foreach (var car in linqValue)
            {
                Console.WriteLine("\t{0}", car);
            }

            Console.WriteLine("\nВозвращем linq запрос как массив строк");
            var linqValueArray = GetStringSubsetArray();
            foreach (var car in linqValueArray)
            {
                Console.WriteLine("\t{0}", car);
            }
            Console.ReadLine();
        }

        private static IEnumerable<string> GetStringSubset()
        {
            var cars = new[] {"Honda","Nissan", "Ford", "Suzuki", "Yamaha", "Saab", "Kia" };
            var linq = cars.OrderBy(car => car);
            return linq;
        }

        private static string[] GetStringSubsetArray()
        {
            var cars = new[] { "Honda", "Nissan", "Ford", "Suzuki", "Yamaha", "Saab", "Kia" };
            var linq = cars.OrderBy(car => car).ToArray();
            return linq;
        }
    }
}
