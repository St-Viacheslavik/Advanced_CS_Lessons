using System;
using System.Diagnostics.CodeAnalysis;

namespace LazyObjectInitialization
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Ленивое создание объектов";
            Console.ForegroundColor = ConsoleColor.Green;
            var mPlayer = new MediaPlayer();
            mPlayer.Play();

            var nPlayer = new MediaPlayer();
            var music = nPlayer.GerAllTracks();
            Console.ReadLine();
        }
    }
}
