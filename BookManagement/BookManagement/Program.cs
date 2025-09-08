namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = Book.CreateBook();
            book.DisplayInfo();
        }
    }
}
