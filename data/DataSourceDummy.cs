
using DataSource;
using Model;

namespace Dummy
{
    class DataSourceDummy : IDataSource
    {
        private List<Book> books = new List<Book>();
        private Dictionary<string, BookBalance> bookBalances = new Dictionary<string, BookBalance>();
        private List<Customer> customers = new List<Customer>();
        private Dictionary<string, CustomerBook> customerBooks = new Dictionary<string, CustomerBook>();


        public bool AddBook(Book book, int total)
        {
            bool exists = false;
            // foreach (Book item in books) {
            //     if (item.Id == book.Id) {
            //         exists = true;
            //         break;
            //     }
            // }
            exists = books.Any(item => item.Id == book.Id); // Linq
            if (exists) return false;

            books.Add(book);
            bookBalances[book.Id] = new BookBalance(book, total, total);
            return true;
        }

        public List<Book> GetAllBooks()
        {
            return books.ToList();
        }

        public List<Customer> GetAllCustomers()
        {
            return customers.ToList();
        }

        public BookBalance GetBook(string bookId)
        {
            return bookBalances[bookId];
        }

        public CustomerBook GetCustomer(string customerId)
        {
            return customerBooks[customerId];
        }

        public bool AddCustomer(Customer customer) 
        {
            bool exists = false;
            exists = customers.Any(item => item.Id == customer.Id); // Linq
            if (exists) return false;

            customers.Add(customer);
            customerBooks[customer.Id] = new CustomerBook(customer, new Book[] {});
            return true;
        }

        public bool PushBook(Customer customer, Book book) 
        {
            var customerBook = customerBooks[customer.Id];
            bool exists = customerBook.Books.Any(item => item.Id == book.Id);
            if (exists) return false;

            var books = customerBook.Books.ToList();
            books.Add(book);

            customerBooks[customer.Id] = new CustomerBook(
                customerBook.Customer,
                books.ToArray()
            );

            return true;
        }

        public bool PopBook(Customer customer, Book book) 
        {
            var customerBook = customerBooks[customer.Id];
            bool exists = customerBook.Books.Any(item => item.Id == book.Id);
            if (!exists) return false;

            var books = customerBook.Books.ToList();
            books.Remove(book);

            customerBooks[customer.Id] = new CustomerBook(
                customerBook.Customer,
                books.ToArray()
            );

            return true;
        }
    }
}