using PracticalExercise.Entities;
using PracticalExercise.Enums;
using PracticalExercise.Handlers;

namespace PracticalExercise.Factories;

public static class ProductFactory
{
    public static Product CreateProduct()
    {

        Console.Write(">> Enter product name: ");
        var name = InputReadHandler.Handle();

        Console.Write(">> Enter product price: ");
        var price = InputReadHandler.Handle<decimal>(decimal.TryParse);

        Console.Write(">> Enter stock quantity: ");
        var stock = InputReadHandler.Handle<int>(int.TryParse);

        Console.WriteLine("Categories");
        foreach (var c in Enum.GetValues(typeof(ProductCategory)))
        {
            Console.WriteLine($" {c}");
        }

        Console.Write(">> Enter product category: ");
        var category = InputReadHandler.Handle<ProductCategory>(Enum.TryParse);

        Console.Write(">> Enter manufacture date: ");
        var date = InputReadHandler.Handle<DateTime>(DateTime.TryParse);

        return new Product
        {
            Name = name,
            Price = price,
            StockQuantity = stock,
            Category = category,
            ManufactureDate = date
        };
    }
}
