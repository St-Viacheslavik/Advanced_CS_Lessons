using System;
using System.Diagnostics.CodeAnalysis;

namespace SimpleIndexer
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Пример создания индексатора";
            Console.ForegroundColor = ConsoleColor.Green;
            var people = new PersonCollection();
            people[0] = new Person("Artem", "Muratov", 30);
            people[1] = new Person("Gena", "Acrabatov", 27);
            people[2] = new Person("Leonid", "Filatov", 50);
            people[3] = new Person("Oleg", "Penetratov", 18);
            for (var i = 0; i < people.Count; i++)
            {
                Console.Write($"Номер лица: {i} ");
                Console.WriteLine($"Фамилия: {people[i].LastName}, Имя: {people[i].FirstName}, Возраст: {people[i].Age}");
            }
            Console.ReadLine();
        }
    }
}
