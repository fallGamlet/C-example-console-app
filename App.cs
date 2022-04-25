
using DataSource;
using Model;
using Newtonsoft.Json;

namespace Application
{
    class App 
    {
        private IDataSource dataSource;
        public App(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Run() {
            Console.WriteLine("App started...");
            dataSource.AddBook(new Book("123", "book1", "author1"), 10);
            dataSource.AddBook(new Book("234", "book2", "author1"), 5);
            dataSource.AddBook(new Book("123", "book1", "author1"), 1);
            dataSource.AddBook(new Book("345", "book3", "author4"), 15);

            var books = dataSource.GetAllBooks();
            var booksJson = JsonConvert.SerializeObject(books, Formatting.Indented);
            Console.WriteLine($"All books: {booksJson}");
        }
    }
}