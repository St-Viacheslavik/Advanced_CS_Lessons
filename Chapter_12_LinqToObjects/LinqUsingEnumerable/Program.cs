using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqUsingEnumerable
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Построение выражений запросов с применением операций запросов";
            Console.ForegroundColor = ConsoleColor.Green;
            QueryStringWithOperators();
            Console.ReadLine();
        }

        private static void QueryStringWithOperators()
        {
            Console.WriteLine("**************Simple Query******************");
            var games = new[] {"Morrowind", "Ghost Reacon", "Tomb Rider", "Fallout", "Read Dead Redemption", "Daxter"};
            var query = games.Where(game => game.Contains(" ")).OrderBy(game => game).Select(game => game);
            foreach (var game in query)
            {
                Console.WriteLine($"New Game: {game}");
            }
            Console.WriteLine("**************End Simple Query******************");
        }
    }
}
