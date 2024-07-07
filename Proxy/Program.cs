namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ebook ebook1 = new LoggingEbookProxy("Ebook1");
            Ebook ebook2 = new LoggingEbookProxy("Ebook2");
            Library library = new Library();
            library.AddBook(ebook1);
            library.AddBook(ebook2);

            library.OpenBook("Ebook1");
            library.OpenBook("Ebook2");

            Console.ReadLine();
        }
    }
}
