using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceExtensions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Пример использования расширенных методов, реализующих интерфейс";
            Console.ForegroundColor = ConsoleColor.Yellow;
            /*
             * Применим расширяемые методы на классы,
             * реализующие интерфейс IEnumerable
             */
            var myList = new List<int> { 5, 10, 15, 20, 26, 248, 12, 5, 10, 5, 1 };
            myList.PrintDataAndBeep();
            Console.WriteLine();
            var stringList = new List<string>{"Johny", "Margo", "Someone"};
            stringList.PrintDataAndBeep();
            Console.ReadLine();
        }
    }
}
