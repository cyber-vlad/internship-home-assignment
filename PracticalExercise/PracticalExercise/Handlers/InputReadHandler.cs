namespace PracticalExercise.Handlers;

public static class InputReadHandler
{
    public delegate bool TryParseHandler<T>(string input, out T value);

    public static T Handle<T>(TryParseHandler<T> tryParse)
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (tryParse(input, out T value))
                return value;

            Console.WriteLine(">> Invalid input!");
        }
    }

    public static string Handle()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
                return input;

            Console.WriteLine(">> Invalid input!");
        }
    }
}
