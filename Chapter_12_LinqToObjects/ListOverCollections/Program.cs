using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ListOverCollections
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "LINQ к классам";
            Console.ForegroundColor = ConsoleColor.Red;
            var rnd = new Random();
            var cars = new List<Cars>
            {
                new Cars(){Name = "Bob", Mark = "BMW", Speed = rnd.Next(25,100)},
                new Cars(){Name = "Mark", Mark = "Ford", Speed = rnd.Next(25,100)},
                new Cars(){Name = "Ted", Mark = "Nissan", Speed = rnd.Next(25,100)},
                new Cars(){Name = "John", Mark = "Suzuki", Speed = rnd.Next(25,100)},
                new Cars(){Name = "James", Mark = "Lada", Speed = rnd.Next(25,100)}
            };
            GetFasterCar(cars);
            Console.WriteLine();
            var carsArrayList = new ArrayList()
            {
                new Cars(){Name = "Bob", Mark = "BMW", Speed = rnd.Next(25,100)},
                new Cars(){Name = "Mark", Mark = "Ford", Speed = rnd.Next(25,100)},
                new Cars(){Name = "Ted", Mark = "Nissan", Speed = rnd.Next(25,100)},
                new Cars(){Name = "John", Mark = "Suzuki", Speed = rnd.Next(25,100)},
                new Cars(){Name = "James", Mark = "Lada", Speed = rnd.Next(25,100)}
            };
            /*
             * Чтобы использовать LINQ зарпос к такой коллекции
             * необходимо задействовать метод ofType<T>
             */
            var enumerator = carsArrayList.OfType<Cars>();
            var fasterCars = enumerator.Where(car => car.Speed > 50).OrderByDescending(car => car.Mark);
            foreach (var car in fasterCars)
            {
                Console.WriteLine($"Car Name: {car.Name}\t car mark: {car.Mark}");
            }
            Console.ReadLine();
        }

        private static void GetFasterCar(List<Cars> cars)
        {
            if (cars == null) throw new ArgumentNullException(nameof(cars));
            var fasterCars = cars.Where(car => car.Speed > 50).OrderBy(car => car.Name);
            foreach (var car in fasterCars)
            {
                Console.WriteLine($"Car Name: {car.Name}\t car mark: {car.Mark}");
            }
        }
    }
}
