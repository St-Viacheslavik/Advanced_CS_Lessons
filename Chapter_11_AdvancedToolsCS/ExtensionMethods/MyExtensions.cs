using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ExtensionMethods
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public static class MyExtensions
    {
        /*
         * Метод позволянт объекту любого типа
         * отобразить сборку, в которой он определен
         */
        public static void DisplayDefinitionAssembly(this object obj)
            => Console.WriteLine($"{obj.GetType().Name} lives here: => {Assembly.GetAssembly(obj.GetType()).GetName().Name}");
        /*
         * Метод иневертирующий число
         * загруженное в него
         * пример: 1234 => 4321
         */
        public static int ReverseDigits(this int valueToReverse)
        {
            var charArray = valueToReverse.ToString().ToCharArray();
            Array.Reverse(charArray);
            var newValue = new string(charArray);
            return int.Parse(newValue);
        }
    }
}
