using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace InterfaceExtensions
{
    [SuppressMessage("ReSharper", "CommentTypo")]
    public static class AnnoyingExtensions
    {
        /*
         * Струкутра написания класса расширяемых методов
         * остается неизменной
         */
        public static void PrintDataAndBeep(this IEnumerable iterator)
        {
            foreach (var variable in iterator)
            {
                Console.WriteLine(variable);
                Console.Beep(150, 500);
            }
        }
    }
}
