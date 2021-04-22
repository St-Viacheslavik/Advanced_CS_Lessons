using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace TypeViewer
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование рефлексии";
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Console.WriteLine("Введите желаемый тип для изучения, для выхода введите Q(q)");
                var typeName = Console.ReadLine();
                if (typeName != null && (typeName.Equals("Q", comparisonType: StringComparison.Ordinal) ||
                                         (typeName.Equals("q", StringComparison.Ordinal)))) break;
                try
                {
                    if (typeName != null)
                    {
                        var t = Type.GetType(typeName, true, true);
                        ListMethods(t);
                        ListFields(t);
                        ListInterfaces(t);
                        ListVariousStats(t);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private static void ListMethods(Type type)
        {
            var methodList = type.GetMethods().Select(method => method);
            Console.WriteLine($"Тип {type} имеет следующие открыте методы");
            foreach (var methodInfo in methodList)
            {
                Console.WriteLine($"\t метод: {methodInfo}");
            }

            Console.WriteLine();
        }

        private static void ListInterfaces(Type type)
        {
            var methodList = type.GetInterfaces().Select(method => method);
            Console.WriteLine($"Тип {type} имеет следующие интерфейсы");
            foreach (var methodInfo in methodList)
            {
                Console.WriteLine($"\t интерфейс: {methodInfo}");
            }

            Console.WriteLine();
        }

        private static void ListFields(Type type)
        {
            var methodList = type.GetFields().Select(method => method);
            Console.WriteLine($"Тип {type} имеет следующие открыте поля");
            foreach (var methodInfo in methodList)
            {
                Console.WriteLine($"\t поле: {methodInfo}");
            }

            Console.WriteLine();
        }

        private static void ListVariousStats(Type type)
        {
            Console.WriteLine($"Другие параметры исследуемого типа {type}");
            Console.WriteLine();
            Console.WriteLine($"Базовый класс объекта {type.BaseType}");
            Console.WriteLine($"Класс является запечатанным? {type.IsSealed}");
            Console.WriteLine($"Класс является абстрактным? {type.IsAbstract}");
            Console.WriteLine($"Класс является обобщенным? {type.IsGenericTypeDefinition}");
            Console.WriteLine($"Класс является классом? {type.IsClass}");
            Console.WriteLine();
        }
    }
}
