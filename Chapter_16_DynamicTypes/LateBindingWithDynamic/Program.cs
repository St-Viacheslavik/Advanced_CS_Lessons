using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Microsoft.CSharp.RuntimeBinder;

namespace LateBindingWithDynamic
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование позднего связывания на динамических типах";
            Console.ForegroundColor = ConsoleColor.Green;
            AddWithReflection();
            AddWithDynamic();
            Console.ReadLine();
        }

        private static void AddWithDynamic()
        {
            var assembly = Assembly.Load("DynamicMathLibrary");
            try
            {
                var mathClass = assembly.GetType("DynamicMathLibrary.DMathLib");
                //Автоматически создать класс не используя лишний код как во втором методе
                dynamic obj = Activator.CreateInstance(mathClass);
                Console.WriteLine($"Result is {obj.Add(45, 54)}");
            }
            catch (RuntimeBinderException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddWithReflection()
        {
            var assembly = Assembly.Load("DynamicMathLibrary");
            try
            {
                var mathClass = assembly.GetType("DynamicMathLibrary.DMathLib");
                var obj = Activator.CreateInstance(mathClass);
                var method = mathClass.GetMethod("Add");
                object[] args = { 45, 54 };
                Console.WriteLine($"Result of Sum {method?.Invoke(obj, args)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
