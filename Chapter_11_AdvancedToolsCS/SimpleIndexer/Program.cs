using System;
using System.Data;
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
            var people = new PersonCollection
            {
                [0] = new Person("Artem", "Muratov", 30),
                [1] = new Person("Gena", "Acrabatov", 27),
                [2] = new Person("Leonid", "Filatov", 50),
                [3] = new Person("Oleg", "Penetratov", 18)
            };
            for (var i = 0; i < people.Count; i++)
            {
                Console.Write($"Номер лица: {i} ");
                Console.WriteLine($"Фамилия: {people[i].LastName}, Имя: {people[i].FirstName}, Возраст: {people[i].Age}");
            }
            MultiIndexer();
            Console.ReadLine();
        }

        private static void MultiIndexer()
        {
            var myTable = new DataTable();
            myTable.Columns.Add(new DataColumn("Имя"));
            myTable.Columns.Add(new DataColumn("Фамилия"));
            myTable.Columns.Add(new DataColumn("Возраст"));
            myTable.Rows.Add("Олег", "Газманов", 50);
            for (var i = 0; i < myTable.Rows.Count; i++)
            {
                for (var j = 0; j < myTable.Columns.Count; j++)
                {
                    Console.Write(myTable.Rows[i][j]+"\t");
                }

                Console.WriteLine();
            }
        }
    }
}
