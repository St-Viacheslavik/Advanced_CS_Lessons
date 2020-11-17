using System;
using System.Diagnostics.CodeAnalysis;

namespace AnonymousTypes
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Анонимные типы";
            Console.ForegroundColor = ConsoleColor.Green;
            BuildAnonType("Skoda", "Желтая", 80);
            Console.WriteLine();
            //Анонимный тип содержащий в себе другой анонимный тип
            var purchaseItem = new
                {Time = DateTime.Now, Item = new {Color = "Red", Mark = "Saab", MaxSpeed = 190}, Price = 5_500_000};
            ReflectionOverAnonymousTypes(purchaseItem);
            Console.ReadLine();
        }

        private static void BuildAnonType(string carName, string carColor, int carSpeed)
        {
            var myCar = new {CarName = carName, CarColor = carColor, CarSpeed = carSpeed};
            var newCar = new { CarName = carName, CarColor = carColor, CarSpeed = carSpeed };
            Console.WriteLine($"Машина: {myCar.CarColor} {myCar.CarName}, едет со скоростью: {myCar.CarSpeed}км/ч");
            Console.WriteLine("Method: ToString => {0}", myCar);
            Console.WriteLine();
            Console.WriteLine($"Машина: {newCar.CarColor} {newCar.CarName}, едет со скоростью: {newCar.CarSpeed}км/ч");
            Console.WriteLine("Method: ToString => {0}", newCar);
            Console.WriteLine();
            Console.WriteLine();
            ReflectionOverAnonymousTypes(myCar);
            Console.WriteLine();
            ReflectionOverAnonymousTypes(newCar);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Проверки на сравнения двух анонимных типов");
            // Выведется что объекты одинаковые
            Console.WriteLine(myCar.Equals(newCar) ? "Два объекта одинаковы" : "Объекты различны");
            /*
             * Здесь будет выведено объекты ралзичны
             * так как оператор == сравнивает по ссылке
             * поэтому объекты будут различны
             */
            Console.WriteLine(myCar == newCar ? "Два объекта одинаковы" : "Объекты различны");
        }

        private static void ReflectionOverAnonymousTypes(object obj)
        {
            Console.WriteLine($"Onj is an instance of: {obj.GetType().Name}");
            Console.WriteLine($"Base class of: {obj.GetType().Name} is {obj.GetType().BaseType}");
            Console.WriteLine($"obj.ToString() => {obj}");
            Console.WriteLine($"obj.GetHashCode() => {obj.GetHashCode()}");
        }
    }
}
