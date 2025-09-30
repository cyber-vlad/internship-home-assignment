using PracticalExercise.Enums;

namespace PracticalExercise.Entities;

public class Product
{
    public required string Name { get; init; }
    public required decimal Price { get; init; }
    public required int StockQuantity { get; init; }
    public required DateTime ManufactureDate { get; init; }
    public required ProductCategory Category { get; init; }

    public void DisplayInfo() => 
        Console.WriteLine($"Product: {Name}, Price: {Price}, Stock: {StockQuantity}, Category: {Category}, Manufacture Date: {ManufactureDate:dd-MM-yyyy}");
}
