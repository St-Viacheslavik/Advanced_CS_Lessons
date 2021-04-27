using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;

namespace LateBinding
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Пример позднего связывания";
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                var assembly = Assembly.Load("CarLibrary");
                CreateUsingLateBinding(assembly);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        private static void CreateUsingLateBinding(Assembly assembly)
        {
            try
            {
                var sportCar = assembly.GetType("CarLibrary.SportCar");
                //create SportCar without reference
                var car = Activator.CreateInstance(sportCar);
                var method = sportCar.GetMethod("TurboBoost");
                method?.Invoke(car, null);
                method = sportCar.GetMethod("TurnOnRadio");
                method?.Invoke(car, new object[] {true, 2});
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
