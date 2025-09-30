
using PracticalExercise.Factories;
using PracticalExercise.Handlers;

namespace PracticalExercise;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("__ Entity Creation Process __\n");

        int option;
        do
        {
            ShowMenu();
            option = InputReadHandler.Handle<int>(int.TryParse);
            ProcessOption(option);

        } while (option != 0);
    }

    private static void ShowMenu()
    {
        Console.WriteLine("<======================>");
        Console.WriteLine("|1| Create Book");
        Console.WriteLine("|2| Create Product");
        Console.WriteLine("|0| Exit");
        Console.WriteLine("<======================>");
    }

    private static void ProcessOption(int option)
    {
        switch (option)
        {
            case 1:
                CreateAndDisplayBook();
                break;
            case 2:
                CreateAndDisplayProduct();
                break;
            case 0:
                break;
            default:
                Console.WriteLine(">> Invalid option!");
                break;
        }
        Console.WriteLine();
    }

    private static void CreateAndDisplayBook()
    {
        var book = BookFactory.CreateBook();
        book.DisplayInfo();
    }

    private static void CreateAndDisplayProduct()
    {
        var product = ProductFactory.CreateProduct();
        product.DisplayInfo();
    }
}
