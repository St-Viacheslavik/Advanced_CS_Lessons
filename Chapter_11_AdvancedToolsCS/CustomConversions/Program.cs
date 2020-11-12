using System;
using System.Diagnostics.CodeAnalysis;

namespace CustomConversions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Собственное приведение типов";
            var rect = new Rectangle(5, 10);
            Console.WriteLine($"Параметры прямоугольника {rect}");
            rect.Draw();
            var square = (Square) rect;
            Console.WriteLine($"Параметры квадрата {square}");
            square.Draw();
            rect = square;
            Console.WriteLine($"Параметры прямоугольника {rect}");
            rect.Draw();
            Console.WriteLine();
            var integer = 25;
            square = (Square) integer;
            Console.WriteLine($"Параметры квадрата {square}");
            square.Draw();
            integer = (int) square;
            Console.WriteLine($"Обратное приведение в int = {integer}");
            Console.ReadLine();
        }

        #region Struct

        private struct Rectangle
        {
            public int Width { get; private set; }
            private int Height { get; set; }
            
            public Rectangle(int w, int h) 
            {
                Width = w;
                Height = h;
            }

            public void Draw()
            {
                for (var i = 0; i < Height; i++)
                {
                    for (var j = 0; j < Width; j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
            }

            public override string ToString() => $"[Width, Height] = [{Width},{Height}]";

            public static implicit operator Rectangle(Square square)
            {
                var rectangle = new Rectangle()
                {
                    Width = square.Length,
                    Height = square.Length * 2
                };
                return rectangle;
            }
        }

        [SuppressMessage("ReSharper", "CommentTypo")]
        private struct Square
        {
            public int Length { get; }

            private Square(int length)
            {
                Length = length;
            }

            public void Draw()
            {
                for (var i = 0; i < Length; i++)
                {
                    for (var j = 0; j < Length; j++)
                    {
                        Console.Write("* ");
                    }

                    Console.WriteLine();
                }
            }

            public override string ToString() => $"[Width, Height] = [{Length},{Length}]";

            #region Converion Types

            public static explicit operator Square(Rectangle rectangle) => new Square(rectangle.Width);

            public static explicit operator Square(int length) => new Square(length);

            //Обратное преобразование из структуры в int
            public static explicit operator int(Square square) => square.Length;

            #endregion

        }

        #endregion


    }
}
