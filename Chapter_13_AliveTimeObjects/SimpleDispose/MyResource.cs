using System;

namespace SimpleDispose
{
    public class MyResource : IDisposable
    {
        private string Name { get; set; }

        private int Age { get; set; }

        public MyResource(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ChangeAll(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString() => $"My name is {Name}, i'm {Age} years old";

        public void Dispose()
        {
            Console.WriteLine("******In Dispose Method********");
        }
    }
}
