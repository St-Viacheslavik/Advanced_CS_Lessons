using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace CustomAppDomain
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Создание собственных доменов";
            Console.ForegroundColor = ConsoleColor.Green;
            var defaultAd = AppDomain.CurrentDomain;
            defaultAd.ProcessExit += (sender, args) => { Console.WriteLine("Базовый домен был выгружен"); };
            DisplayAssemblies(defaultAd);
            MakeNewAppDomain();
            Console.ReadLine();
        }

        private static void MakeNewAppDomain()
        {
            var domain = AppDomain.CreateDomain("My New Domain");
            domain.DomainUnload += (o, s) => { Console.WriteLine("Домен был выгружен"); };
            try
            {
                domain.Load("CarLibrary");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            DisplayAssemblies(domain);
            AppDomain.Unload(domain);
        }

        private static void DisplayAssemblies(AppDomain defaultAd)
        {
            Console.WriteLine("*************************************************************************");
            var assemblies = defaultAd.GetAssemblies().OrderBy(name => name.FullName);
            Console.WriteLine($"Все сборки внутри домена {defaultAd.FriendlyName}");
            foreach (var assembly in assemblies)
            {
                Console.WriteLine($"-> {assembly.GetName().Name}");
                Console.WriteLine($"-> {assembly.GetName().Version}\n");
            }
            Console.WriteLine("*************************************************************************");
        }
    }
}
