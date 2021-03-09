using System;
using System.Diagnostics.CodeAnalysis;

namespace LazyObjectInitialization
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class AllTracks
    {
        private Song[] _allSongs = new Song[10_000];

        public AllTracks()
        {
            Console.WriteLine("Прдеполагается заполнение массива");
        }

    }
}
