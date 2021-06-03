using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DefaultAppDomain
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование класса AppDomain";
            Console.ForegroundColor = ConsoleColor.Green;
            InitDad();
            DisplayStat();
            DisplayAssemblies();
            Console.ReadLine();
        }

        private static void InitDad()
        {
            var defaultAd = AppDomain.CurrentDomain;
            defaultAd.AssemblyLoad += DefaultAd_AssemblyLoad;
        }

        private static void DefaultAd_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine($"Сборка {args.LoadedAssembly.GetName().Name} была загружена");
        }

        private static void DisplayAssemblies()
        {
            Console.WriteLine("*************************************************************************");
            var defaultAd = AppDomain.CurrentDomain;
            var assemblies = defaultAd.GetAssemblies().OrderBy(name => name.FullName);
            Console.WriteLine($"Все сборки внутри домена {defaultAd.FriendlyName}");
            foreach (var assembly in assemblies)
            {
                Console.WriteLine($"-> {assembly.GetName().Name}");
                Console.WriteLine($"-> {assembly.GetName().Version}\n");
            }
            Console.WriteLine("*************************************************************************");
        }

        private static void DisplayStat()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Base Display");
            var defaultAd = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {defaultAd.FriendlyName},\tID = {defaultAd.Id},\tIdBaseDomain = {defaultAd.IsDefaultAppDomain()}");
            Console.WriteLine($"LocalPath {defaultAd.BaseDirectory}");
            Console.WriteLine("*************************************************************************");
        }
    }
}
