using System;
using System.Diagnostics.CodeAnalysis;

namespace SimpleGC
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Простой пример сборщика мусора";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Оценочное количество байт зарезервированых в куче: {GC.GetTotalMemory(false)},\n" +
                              $"в килобайтах {GC.GetTotalMemory(false)/1024},\n" +
                              $"в мегабайтах {GC.GetTotalMemory(false) / 1024/1024}");
            Console.WriteLine($"Максимальное количество поколений: {GC.MaxGeneration + 1}");
            var car = new Car("Honda", 175);
            Console.WriteLine(car.ToString());
            Console.WriteLine();
            Console.WriteLine($"Поколоение этого объекта: {GC.GetGeneration(car)}");
            var moreCars = new Car [50000];
            for (var i = 0; i < moreCars.Length; i++)
            {
                moreCars[i] = new Car();
            }
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            Console.WriteLine(moreCars[2000] != null
                ? $"Поколоение объекта moreCars[2000]: {GC.GetGeneration(car)}"
                : $"Объект moreCars[2000] больше не существует");
            Console.WriteLine($"Поколоение 0 изменилось {GC.CollectionCount(0)} раз");
            Console.WriteLine($"Поколоение 1 изменилось {GC.CollectionCount(1)} раз");
            Console.WriteLine($"Поколоение 2 изменилось {GC.CollectionCount(2)} раз");
            Console.ReadLine();
        }
    }
}
