using System;
using System.Diagnostics.CodeAnalysis;

namespace AttributeCarLibrary
{
    [Obsolete ("Класс устарел, но это неточно")]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Horse
    {
        public Horse()
        {
            Console.WriteLine("Я лошадь и я уже не в почете");
        }
    }
}
