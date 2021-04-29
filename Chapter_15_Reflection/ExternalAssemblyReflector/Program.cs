using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ExternalAssemblyReflector
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        [STAThread]
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
            Console.WriteLine($"Сборка загружена из GAC? {assembly.GlobalAssemblyCache}");
            var types = assembly.GetTypes();

            var classes = types.Where(m => m.IsClass);
            Console.WriteLine("***********Classes***********");
            foreach (var classType in classes) Console.WriteLine("\t{0}", classType);

            var methods = types.SelectMany(f => f.GetMethods());
            Console.WriteLine("***********Methods***********");
            foreach (var method in methods) Console.WriteLine("\t{0}", method);
            Console.WriteLine();

            var enums = types.Where(m => m.IsEnum);
            Console.WriteLine("***********Enums***********");
            foreach (var enumType in enums) Console.WriteLine("\t{0}", enumType);

            Console.WriteLine();

            var interfaces = types.Where(i => i.IsInterface);
            Console.WriteLine("***********Interfaces***********");
            foreach (var iInterface in interfaces) Console.WriteLine("\t{0}", iInterface);
            Console.WriteLine();
            
            var fields = types.SelectMany(f => f.GetFields());
            Console.WriteLine("***********Fileds***********");
            foreach (var field in fields) Console.WriteLine("\t{0}", field);
            Console.WriteLine();
        }

        private static bool Repeat()
        {
            Console.WriteLine("Желаете продолжить? Y/y - Да, для выхода введите любой другой символ");
            var chose = Console.ReadLine();
            #if DEBUG
                Debug.Assert(chose != null, nameof(chose) + " != null");
                return (chose.Equals("Y", StringComparison.Ordinal) ||
                                     chose.Equals("y", StringComparison.Ordinal));
            #endif
            #if !DEBUG
                return chose != null && (chose.Equals("Y", StringComparison.Ordinal) ||
                                                 chose.Equals("y", StringComparison.Ordinal));
            #endif
        }
    }
}
