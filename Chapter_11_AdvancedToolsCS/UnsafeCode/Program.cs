using System;
using System.Diagnostics.CodeAnalysis;

namespace UnsafeCode
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.Title = "Работа с небезопасным кодом";
            Console.ForegroundColor = ConsoleColor.Green;
            unsafe
            {
                var i = 10;
                var j = 20;
                SquareIntPointer(&i);
                Console.WriteLine($"Value: {i}");
                Console.WriteLine();
                PrintValueAddress();
                Console.WriteLine();
                Console.WriteLine($"i = {i}, j = {j}");
                int* iPoint = &i, jPoint = &j;
                Console.WriteLine("UnSafe Swap");
                UnsafeSwap(iPoint, jPoint);
                Console.WriteLine($"i = {i}, j = {j}");
                Console.WriteLine("Safe Swap");
                SafeSwap(ref i, ref j);
                Console.WriteLine($"i = {i}, j = {j}");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Point point;
                var p = &point;
                p->X = 100;
                p->Y = 200;
                Console.WriteLine(p->ToString());
                Console.WriteLine();
                UnsafeStackAlloc();
                Console.WriteLine();
                UseAndPinPoint();
                Console.WriteLine();
                UseSizeOf();
            }
            Console.ReadLine();
        }

        #region Temp Resources

        private struct Point
        {
            public int X;
            public int Y;

            public override string ToString()
                => $"[X,Y] = [{X},{Y}]";
        }

        public class PointRef
        {
            public int X;
            private readonly int _y;

            public PointRef(int x, int y)
            {
                X = x;
                _y = y;
            }

            public override string ToString()
                => $"[X,Y] = [{X},{_y}]";
        }

        #endregion


        #region Unsafe Methods

        private static unsafe void SquareIntPointer(int* intPointer)
        {
            *intPointer *= *intPointer;
        }

        private static unsafe void PrintValueAddress()
        {
            int myInt;
            var myIntPointer = &myInt;
            *myIntPointer = 132;
            Console.WriteLine("Value of myInt: {0}", *myIntPointer);
            Console.WriteLine("Adress of myInt: 0x{0:X}", (int)&myIntPointer);
        }

        private static unsafe void UnsafeSwap(int* i, int* j)
        {
            var temp = *i;
            *i = *j;
            *j = temp;
        }

        private static void SafeSwap(ref int i, ref int j)
        {
            var temp = i;
            i = j;
            j = temp;
        }

        private static unsafe void UnsafeStackAlloc()
        {
            var p = stackalloc char[256];
            for (var i = 0; i < 256; i++)
            {
                p[i] = (char)i;
                Console.WriteLine((int)&p[i]);
            }
        }

        private static unsafe void UseAndPinPoint()
        {
            var pt = new PointRef(5, 10);
            fixed (int* p = &pt.X)
            {
                //Можем что то делать с этой переменной
                Console.WriteLine($"Адресс переменной класса {(int)p:X}");
            }
        }

        private static void UseSizeOf()
        {
            Console.WriteLine($"Size of short is {sizeof(short)}");
            Console.WriteLine($"Size of int is {sizeof(int)}");
            Console.WriteLine($"Size of decimal is {sizeof(decimal)}");
            Console.WriteLine($"Size of long is {sizeof(long)}");
        }

        #endregion

    }
}
