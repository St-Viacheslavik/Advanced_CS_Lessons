using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ExtendableApp
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        [STAThread]
        private static void Main()
        {
            Console.Title = "Расширяемое приложение";
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.WriteLine("\nWould you like to load a snapin? [Y,N]");

                // Get name of type.
                var answer = Console.ReadLine();

                // Does user want to quit?
                if (answer != null && !answer.Equals("Y", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                // Try to display type.
                try
                {
                    LoadSnapIn();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Sorry, can't find snapin, message {ex.Message}");
                }
            } while (true);
        }

        private static void LoadSnapIn()
        {
            var dialog = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Filter = "assemblies (*.dll)|*.dll|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                Console.WriteLine("Пользователь не выбрал сборку");
            }

            if (dialog.FileName.Contains("CommonSnappableTypes"))
                Console.WriteLine("CommonSnappableTypes has no snap-ins!");
            else if (!LoadExternalModule(dialog.FileName))
                Console.WriteLine("Nothing implements IAppFunctionality!");
        }

        private static bool LoadExternalModule(string path)
        {
            var foundSnapIn = false;
            Assembly theSnapInAsm;

            try
            {
                // Dynamically load the selected assembly.
                theSnapInAsm = Assembly.LoadFrom(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred loading the snapin: {ex.Message}");
                return false;
            }

            // Get all IAppFunctionality compatible classes in assembly.
            var theClassTypes = from t in theSnapInAsm.GetTypes()
                where t.IsClass && (t.GetInterface("IAppFunctionality") != null)
                select t;

            // Now, create the object and call DoIt() method.
            foreach (Type t in theClassTypes)
            {
                foundSnapIn = true;
                // Use late binding to create the type.
                var itfApp = (CommonSnappableTypes.CommonSnappableTypes.IAppFunctionality)theSnapInAsm.CreateInstance(t.FullName, true);
                itfApp?.DoIt();
                //lstLoadedSnapIns.Items.Add(t.FullName);

                // Show company info.
                DisplayCompanyData(t);
            }
            return foundSnapIn;
        }

        private static void DisplayCompanyData(Type t)
        {
            // Get [CompanyInfo] data.
            var compInfo = from ci in t.GetCustomAttributes(false)
                where (ci is CommonSnappableTypes.CommonSnappableTypes.CompanyInfoAttribute)
                select ci;

            // Show data.
            foreach (CommonSnappableTypes.CommonSnappableTypes.CompanyInfoAttribute c in compInfo)
            {
                Console.WriteLine($"More info about {c.CompanyName} can be found at {c.CompanyUrl}");
            }
        }
    }
}
