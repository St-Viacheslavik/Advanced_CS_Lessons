using System;

namespace SimpleFinalize
{
    public class MyResource
    {
        private string Name { get; set; }

        private int Age { get; set; }

        public MyResource(string name, int age)
        {
            Name = name;
            Age = age;
        }

        ~MyResource() => Console.Beep(7000, 500);

        public void ChangeAll(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public override string ToString() => $"My name is {Name}, i'm {Age} years old";
    }
}
