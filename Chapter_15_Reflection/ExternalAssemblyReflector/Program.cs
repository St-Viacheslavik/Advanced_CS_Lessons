using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Windows.Forms;

namespace ExternalAssemblyReflector
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        [STAThreadAttribute]
        private static void Main()
        {
            Console.Title = "Загрузка внешних сборок";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Выберете сборку в диалоговом окне");
            while (true)
            {
                var fileDialog = new OpenFileDialog {Filter = "Библиотеки dll|*.dll"};
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine($"Путь к сборке: {fileDialog.FileName}");
                    try
                    {
                        AssemblyViewer(Assembly.LoadFrom(fileDialog.FileName));
                        if (!Repeat()) break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        if (!Repeat()) break;
                    }
                }
                else
                {
                    if (!Repeat()) break;
                }

            }
        }

        private static void AssemblyViewer(Assembly assembly)
        {
            Console.WriteLine($"Название сборки: {assembly.FullName}");
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine($"\tType: {type}");
            }

            Console.WriteLine();
            var attributes = assembly.GetCustomAttributes();
            foreach (var attribute in attributes)
            {
                Console.WriteLine($"\tAttribute: {attribute}");
            }
        }

        private static bool Repeat()
        {
            Console.WriteLine("Желаете продолжить? Y/y - Да, для выхода введите любой другой символ");
            var chose = Console.ReadLine();
            Debug.Assert(chose != null, nameof(chose) + " != null");
            return (chose.Equals("Y", StringComparison.Ordinal) ||
                    chose.Equals("y", StringComparison.Ordinal));
        }
    }
}
