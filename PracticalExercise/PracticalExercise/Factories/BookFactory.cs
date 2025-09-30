using PracticalExercise.Entities;
using PracticalExercise.Handlers;

namespace PracticalExercise.Factories;

public static class BookFactory
{
    public static Book CreateBook()
    {

        Console.Write(">> Enter title: ");
        string title = InputReadHandler.Handle();

        Console.Write(">> Enter an author: ");
        string author = InputReadHandler.Handle();

        Console.Write(">> Enter nr. of pages: ");
        int pages = InputReadHandler.Handle<int>(int.TryParse);


        return new Book
        {
            Title = title,
            Author = author,
            Pages = pages
        };
    }
}
