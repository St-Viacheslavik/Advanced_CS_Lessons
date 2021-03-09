using System;

namespace FinalazibleAndDisposibleClass
{
    internal class MyResource : IDisposable
    {
        private bool _disposed;

        private string Name { get; set; }

        private int Age { get; set; }

        public MyResource(string name, int age)
        {
            Name = name;
            Age = age;
        }

        ~MyResource()
        {
            CleanUp(false);
            Console.Beep();
        }

        public void ChangeAll(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString() => $"My name is {Name}, i'm {Age} years old";

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        private void CleanUp(bool disposing)
        {
            if (_disposed) return;
            /*
             * Если disposing true
             * то, освободить все управляемые ресурсы
             */
            if (disposing)
            {
                //Освободить управляемые ресурсы
            }

            _disposed = true;
        }
    }
}
