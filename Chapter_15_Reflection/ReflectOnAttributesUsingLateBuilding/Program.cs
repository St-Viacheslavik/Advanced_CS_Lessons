using System;
using System.Reflection;

namespace ReflectOnAttributesUsingLateBuilding
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование атрибутов на этапе позднего связывания";
            Console.ForegroundColor = ConsoleColor.Green;
            ReflectionOnAttributesUsingLateBuilding();
            Console.ReadLine();
        }

        private static void ReflectionOnAttributesUsingLateBuilding()
        {
            try
            {
                var asm = Assembly.Load("AttributeCarLibrary");
                var attribute = asm.GetType("AttributeCarLibrary.VehicleDescriptionAttribute");
                var propDesc = attribute.GetProperty("Description");
                var types = asm.GetTypes();
                foreach (var type in types)
                {
                    var obj = type.GetCustomAttributes(attribute, false);
                    foreach (var o in obj)
                    {
                        Console.WriteLine($"->\t{type.Name}\t{propDesc?.GetValue(o, null)}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
