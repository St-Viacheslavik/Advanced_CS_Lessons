using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace LinqExpressions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    internal class Program
    {
        private static void Main()
        {
            Console.Title = "Использование различных LINQ выражений";
            Console.ForegroundColor = ConsoleColor.Green;
            var products = new[]
            {
                new ProductInfo("Coffee", "Coffee with TEETH", 24),
                new ProductInfo("Milk Shake", "Milk cow's love", 100), 
                new ProductInfo("Tofu", "Bland as possible", 120),
                new ProductInfo("Water", "from the tap to your wallet", 80),
                new ProductInfo("Pizza", "Everyone loves pizza", 200)
            };
            SelectEverything(products);
            Console.WriteLine();
            GetOverstock(products);
            Console.WriteLine();
            GetNameAndDescription(products);
            Console.WriteLine();
            GetOdrerby(products);
            Console.ReadLine();
        }

        private static void GetOdrerby(ProductInfo[] products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            var orderbyExp = products.OrderBy(product => products);
            foreach (var info in orderbyExp)
            {
                Console.WriteLine(info.ToString());
            }
        }

        private static void GetNameAndDescription(ProductInfo[] products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            var nameDesc = products.Select(product => new {product.Name, product.Description});
            foreach (var info in nameDesc)
            {
                Console.WriteLine(info);
            }
        }

        private static void GetOverstock(ProductInfo[] products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            var whereExpression = products.Where(product => product.Description.EndsWith("e"));
            foreach (var info in whereExpression)
            {
                Console.WriteLine(info.ToString());
            }
        }

        private static void SelectEverything(ProductInfo[] products)
        {
            if (products == null) throw new ArgumentNullException(nameof(products));
            var simpleExpression = products.Select(product => product);
            foreach (var info in simpleExpression)
            {
                Console.WriteLine(info.ToString());
            }
        }
    }
}
