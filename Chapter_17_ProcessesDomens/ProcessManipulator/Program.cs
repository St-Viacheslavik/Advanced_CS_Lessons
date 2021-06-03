using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ProcessManipulator
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Работа с процессами";
            Console.ForegroundColor = ConsoleColor.Green;
            ListAllRunningProcess();
            GetSpecificProcess();
            Console.ReadLine();
        }

        private static void GetSpecificProcess()
        {
            Console.WriteLine("Получить процесс по оперделенному PID или вывести ошибку");
            Console.Write("Введите PID = ");
            var pid = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            try
            {
                var proc = Process.GetProcessById(pid);
                Console.WriteLine($"Process name: {proc.ProcessName}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ListAllRunningProcess()
        {
            Console.WriteLine("Список всех процессов на локальном компьютере");
            var processes = Process.GetProcesses(".").OrderBy(proc => proc.Id).Select(proc => proc);
            Console.WriteLine("***********************************************");
            foreach (var process in processes)
            {
                Console.WriteLine($"\tPID = {process.Id},\t Name = {process.ProcessName}");
            }
            Console.WriteLine("***********************************************");
        }
    }
}
