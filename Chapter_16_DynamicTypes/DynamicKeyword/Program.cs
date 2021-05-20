using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CSharp.RuntimeBinder;

namespace DynamicKeyword
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование ключевого слова dynamic";
            Console.ForegroundColor = ConsoleColor.Green;
            ImplicitlyTypedVariable();
            PrintThreeStrings();
            ChangeDynamicType();
            InvokeMemberDynamicData();
            Console.ReadLine();
        }

        private static void InvokeMemberDynamicData()
        {
            dynamic str = "Строка";
            try
            {
                Console.WriteLine(str);
                //Вызвать можно но указывать метод придется самостоятельно
                Console.WriteLine(str.ToUpper());
                //Генерируется исключение
                Console.WriteLine(str.toupper);
            }
            catch (RuntimeBinderException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ChangeDynamicType()
        {
            dynamic dynamicVar = "string";
            Console.WriteLine($"Тип переменной dynamicVar: {dynamicVar.GetType()}, значение переменной: {dynamicVar}");
            dynamicVar = false;
            Console.WriteLine($"Тип переменной dynamicVar: {dynamicVar.GetType()}, значение переменной: {dynamicVar}");
            dynamicVar = new Exception("new exception");
            Console.WriteLine($"Тип переменной dynamicVar: {dynamicVar.GetType()}, значение переменной: {dynamicVar.Message}");
        }

        private static void PrintThreeStrings()
        {
            const string s1 = "Это строка";
            object s2 = "Это тоже строка";
            dynamic s3 = "И это тоже строка";
            Console.WriteLine($"Тип переменной s1: {s1.GetType()}");
            Console.WriteLine($"Тип переменной s2: {s2.GetType()}");
            Console.WriteLine($"Тип переменной s3: {s3.GetType()}");
        }

        private static void ImplicitlyTypedVariable()
        {
            var list = new List<int> {90, 45, 99, 46, 54};
            Console.WriteLine($"Вместимость {list.Capacity}, количество {list.Count}, {list}");
        }
    }
}
