namespace PracticalExercise.Entities;

public class Book
{
    public required string Title { get; init; }
    public required string Author { get; init; }
    public required int Pages { get; init; }

    public void DisplayInfo() => Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
}
