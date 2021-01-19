using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqOverArray
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Применение Linq";
            Example();
            Ex();
            Console.ReadLine();
        }

        private static void Example()
        {
            var stringArray = new[] {"GTA 5", "Read dead redemption", "Portal", "Cyberpunk", "Serious Sam"};
            var linqQuery = from g in stringArray where g.Contains(" ") orderby g select g;
            var newLinqQuery = stringArray.Where(g => g.Contains(" ")).OrderBy(g => g);
            foreach (var element in linqQuery)
            {
                Console.WriteLine($"Выбранный элемент: {element}");
            }
            foreach (var element in newLinqQuery)
            {
                Console.WriteLine($"Выбранный элемент: {element}");
            }
        }

        private static void Ex()
        {
            var intArray = new[] {5,7,3,4,2,6,8,1,9 };
            var constLinqQuery = from item in intArray where item < 10 select item;
            Console.WriteLine("Исходный массив значений: ");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Использование запроса");
            foreach (var i in constLinqQuery)
            {
                Console.WriteLine($"{i} < 10");
            }

            Console.WriteLine("Измененный массив исходных значений");
            intArray[3] = 15;
            intArray[5] = 0;
            intArray[1] = 2;
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Повторное использование запроса");
            foreach (var i in constLinqQuery)
            {
                Console.WriteLine($"{i} < 10");
            }

            Console.WriteLine("Приведение LINQ запроса к какому-то массиву не позволяет использовать отложенное выполнение. Запрос выполняется один раз для текущего значения коллекции." +
                              "Изменяя коллекцию и выполнив запрос снова данные будут браться от запроса к первоначальной коллекции");
            var intQuery = (from item in intArray where item < 10 select item).ToArray();
            Console.WriteLine("Исходный массив значений: ");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Использование запроса");
            foreach (var i in intQuery)
            {
                Console.WriteLine($"{i} < 10");
            }
            intArray = new[] { 5, 7, 3, 4, 2, 6, 8, 1, 9 };
            Console.WriteLine("Массив значений: ");
            foreach (var i in intArray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Использование запроса");
            foreach (var i in intQuery)
            {
                Console.WriteLine($"{i} < 10");
            }
        }
    }
}
