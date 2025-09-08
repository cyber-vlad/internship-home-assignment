namespace BookManagement
{
    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required int Pages { get; set; }

        public static Book CreateBook()
        {
            Console.WriteLine("__ The process of creating the book __\n");

            Console.Write(">> Enter a title: ");
            string title = Console.ReadLine()!;

            Console.Write(">> Enter an author: ");
            string author = Console.ReadLine()!;

            Console.Write(">> Enter nr. of pages: ");
            int pages;

            while(!int.TryParse(Console.ReadLine(), out pages) || pages <= 0)
            {
                Console.WriteLine("Invalid number");
                Console.Write(">> Enter nr. of pages: ");
            }

            return new Book
            {
                Author = author,
                Title = title,
                Pages = pages
            };
        }

        public void DisplayInfo()
        {
            Console.WriteLine("\nBook info");
            Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}");
        }
    }
}
