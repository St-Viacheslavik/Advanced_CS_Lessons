using System;
using System.Configuration;

namespace AppConfigReaderApp
{
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование файла конфигурации";
            var appReader = new AppSettingsReader();
            var repeatNumber = (int)appReader.GetValue("RepeatCount", typeof(int));
            var textColor = (string) appReader.GetValue("TextColor", typeof(string));

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), textColor);
            for (var i = 0; i < repeatNumber; i++)
            {
                Console.WriteLine($"Текущее значение {i}, значение взятое из файла конфигурации {repeatNumber}, Выбранный цвет {textColor}");
            }
            Console.ReadLine();
        }
    }
}
