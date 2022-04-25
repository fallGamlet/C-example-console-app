using Model;

namespace DataSource
{
    interface IDataSource
    {
        List<Book> GetAllBooks();

        BookBalance GetBook(string bookId);

        bool AddBook(Book book, int total);

        List<Customer> GetAllCustomers();

        CustomerBook GetCustomer(string customerId);

        bool AddCustomer(Customer customer);

        bool PushBook(Customer customer, Book book);
        bool PopBook(Customer customer, Book book);
    }
}