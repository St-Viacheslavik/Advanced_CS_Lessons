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
            Console.Write("Введите PID = ");
            var pid = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            GetSpecificProcess(pid);
            GetEnumThreads(pid);
            EnumModsByPid(pid);
            StartAndKillProcess();
            Console.ReadLine();
        }

        private static void StartAndKillProcess()
        {
            Console.WriteLine("Запустить процесс блокнот, а затем уничтожить его");
            try
            {
                var statInfo = new ProcessStartInfo("Notepad.exe") {WindowStyle = ProcessWindowStyle.Maximized};
                var stat = Process.Start(statInfo);
                Console.WriteLine($"Чтобы завершить процесс {stat?.ProcessName} нажмите Enter");
                Console.ReadLine();
                stat?.Kill();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void EnumModsByPid(int pid)
        {
            Console.WriteLine($"Вывести все модули, используемые процессом PID = {pid}");
            try
            {
                var proc = Process.GetProcessById(pid);
                Console.WriteLine($"Имя процесса: {proc.ProcessName}");
                var modules = proc.Modules;
                foreach (ProcessModule module in modules)
                {
                    Console.WriteLine($"\tModule name = {module.ModuleName},\tBase Address = {module.BaseAddress},\tModule Memory Size = {module.ModuleMemorySize}");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetEnumThreads(int pid)
        {
            Console.WriteLine($"Получить все потоки процесса по определенному PID: {pid}");
            
            try
            {
                var proc = Process.GetProcessById(pid);
                Console.WriteLine($"Потоки которые использует процесс: {proc.ProcessName}");
                var threads = proc.Threads;
                Console.WriteLine("*********************************************************************************************************************************************");
                foreach (ProcessThread thread in threads)
                {
                    Console.WriteLine($"\tID = {thread.Id},\t StartTime = {thread.StartTime.ToShortDateString()},\t State = {thread.ThreadState}, \t Priority = {thread.PriorityLevel}");
                }
                Console.WriteLine("*********************************************************************************************************************************************");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void GetSpecificProcess(int pid)
        {
            Console.WriteLine($"Получить процесс по оперделенному PID: {pid} или вывести ошибку");
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
