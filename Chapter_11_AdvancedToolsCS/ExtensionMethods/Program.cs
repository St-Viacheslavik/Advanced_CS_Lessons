using System;
using System.Diagnostics.CodeAnalysis;
using System.Media;

namespace ExtensionMethods
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Понятие расширяемых методов";
            Console.ForegroundColor = ConsoleColor.Green;
            /*
             * Методы, созданные в классе MyExtensions.cs,
             * теперь могут применяться в других типах
             * Примеры рассмотрены ниже
             */
            var myInt = 123456789;
            Console.WriteLine($"Начальное значение переменной {myInt}");
            // Изначально тип Int не имел методов DisplayDefinitionAssembly() и ReverseDigits()
            myInt.DisplayDefinitionAssembly();
            myInt = myInt.ReverseDigits();
            Console.WriteLine($"Измененное значение переменной {myInt}");
            /* Также метод DisplayDefinitionAssembly() доступен и для других типов
             * Поскольку его входный параметр имеет тип object
             * Рассмотрим данный пример на типе SoundPlayer
             */
            var soundPlayer = new SoundPlayer();
            soundPlayer.DisplayDefinitionAssembly();
            Console.ReadLine();
        }
    }
}
