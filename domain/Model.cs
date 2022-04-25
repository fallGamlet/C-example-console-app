
namespace Model
{
    class Book
    {
        public readonly string Id;
        public readonly string Title;
        public readonly string Author;

        public Book(string id, string title, string author) 
        {
            this.Id = id;
            this.Title = title;
            this.Author = author;
        }
    }

    class BookBalance
    {
        public readonly Book Book;
        public readonly int Total;
        public readonly int Amount;

        public BookBalance(Book book, int total, int amount) {
            this.Book = book;
            this.Total = total;
            this.Amount = amount;
        }
    }

    class Customer
    {
        public readonly string Id;
        public readonly string FullName;

        public Customer(string id, string fullName) 
        {
            this.Id = id;
            this.FullName = fullName;
        }
    }

    class CustomerBook
    {
        public readonly Customer Customer;
        public readonly Book[] Books;

        public CustomerBook(Customer customer, Book[] books)
        {
            this.Customer = customer;
            this.Books = books;
        }
    }
}