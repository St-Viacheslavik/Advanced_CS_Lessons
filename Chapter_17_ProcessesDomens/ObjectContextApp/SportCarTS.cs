using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp
{
    public class SportCar
    {
        public SportCar()
        {
            var context = Thread.CurrentContext;
            Console.WriteLine($"{this} object in context {context.ContextID}");
            if (context.ContextProperties == null) return;
            foreach (var contextContextProperty in context.ContextProperties)
            {
                Console.WriteLine($"context prop {contextContextProperty.Name}");
            }
        }
    }

    [Synchronization]
    public class SportCarTs : ContextBoundObject
    {
        public SportCarTs()
        {
            var context = Thread.CurrentContext;
            Console.WriteLine($"{this} object in context {context.ContextID}");
            if (context.ContextProperties == null) return;
            foreach (var contextContextProperty in context.ContextProperties)
            {
                Console.WriteLine($"context prop {contextContextProperty.Name}");
            }
        }
    }
}
