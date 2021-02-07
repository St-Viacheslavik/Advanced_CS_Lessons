using System.Diagnostics.CodeAnalysis;

namespace LinqExpressions
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    public class ProductInfo
    {
        public string Name { get; set; } 
        public string Description { get; set; }
        public int NumberInStock { get; set; } 

        public ProductInfo(string name, string description, int numberInStock)
        {
            Name = name;
            Description = description;
            NumberInStock = numberInStock;
        }

        public override string ToString() =>
            $"Название продукта = {Name}, описание продукта = {Description}, оставшееся количество = {NumberInStock}";
    }
}
