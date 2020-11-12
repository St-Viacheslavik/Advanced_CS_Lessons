using System;
using System.Diagnostics.CodeAnalysis;

namespace OverloadedOps
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Перегрузка операций";
            Console.ForegroundColor = ConsoleColor.Green;
            var p1 = new Point(15,35);
            var p2 = new Point(2, 2);
            Console.WriteLine($"Исходные данные Р1 = {p1} Р2 = {p2}");
            Console.WriteLine($"Результат сложения объектов класса {p1.GetType().Name}: {p1+p2}");
            Console.WriteLine($"Результат вычитания объектов класса {p1.GetType().Name}: {p1 - p2}");
            Console.WriteLine($"Результат умножения объектов класса {p1.GetType().Name}: {p1 * p2}");
            Console.WriteLine();
            Console.WriteLine("Операции += и -= перегружаются автоматически");
            p2 += p1;
            Console.WriteLine("Выполнив операцию p2 += p1 получим:");
            Console.WriteLine($"Р1 = {p1} Р2 = {p2}");
            Console.WriteLine();
            Console.WriteLine("Перегрузка унарных операций ++ и --");
            Console.WriteLine($"P1++ = {++p1}, P2++ = {--p2}");
            Console.WriteLine();
            Console.WriteLine("Перегрузка операций эквивалентности == и !=");
            Console.WriteLine($"P1 == P2?: {p1==p2}, P1 != P2?: {p1!=p2}");
            Console.WriteLine("Перегрузка операций сравнения >, <, >=, <=");
            Console.WriteLine($"P1 > P2?: {p1 > p2}, P1 < P2?: {p1 < p2}, P1 >= P2?: {p1 >= p2}, P1 <= P2?: {p1 <= p2}");
            Console.ReadLine();
        }
    }
}
